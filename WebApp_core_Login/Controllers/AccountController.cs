using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Extensions.Configuration;
using NETCore.Encrypt.Extensions;
using System.Globalization;
using System.Security.Claims;
using WebApp_core_Login.Models;
using WebApp_core_Login.Models.viewModel;

namespace WebApp_core_Login.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private DatabaseContext db;
        private IConfiguration _configuration;
        public AccountController(DatabaseContext dbcontext,IConfiguration configuration)
        {
            db=dbcontext;
            _configuration=configuration;
        }
        //dependency injention == nesneyi bağımlılıktan kurtarıyor
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)  //girilen bilgiler boşsa
            {
                string sifre = _configuration.GetValue<string>("Appsettings:sifre");
                sifre = model.password + sifre;
                string md5sifre = sifre.MD5();
                User user=db.Users.SingleOrDefault(x=>x.Username.ToLower()==model.username.ToLower() && x.password==md5sifre);
                if (user != null)
                {
                    List<Claim> claims=new List<Claim>();  //normal user listesi olarak atılsaydı listeye hepsini atacaktık bir nesne oldıuğundan dollayı. ama claim listesinde tüm değerler parça parça bulunuyor.böylelikle coocie ye atabileceğiz bu bilgileri
                    claims.Add(new Claim(ClaimTypes.NameIdentifier, user.id.ToString()));
                    claims.Add(new Claim(ClaimTypes.Role, user.role));
                    claims.Add(new Claim("Name",user.Name??string.Empty));  //null olamaz diye hata veriyor. o yüzden nullsa boş string at dedik
                    claims.Add(new Claim("Username",user.Username));

                    ClaimsIdentity claimsIdentity=new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme); //ikinciyi cookie olarak kullanacağımızdan yazdık
                     HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal(claimsIdentity));
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ModelState.AddModelError("","kullanıcıadı yada şifre hatalı");
                }
            }
            return View(model);
        }
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Register(registerViewModel model)
        {
            if(ModelState.IsValid)
            {
                if(db.Users.Any(x=>x.Username.ToLower()==model.username.ToLower()))  //any hiç var mı kontrolü sağlar . bool tip de döner
                {
                    ModelState.AddModelError(nameof(model.username),"bu kullanıcıadı sistemde bulunmuyor");  //usernami alsın diye nameof dedik.nameof yerine tırnak içinde yazarsakda olurdu
                    return View(model);
                }
                string sifre=_configuration.GetValue<string>("Appsettings:sifre");
                sifre=model.password+sifre;
                string md5sifre=sifre.MD5();

                User user = new User()
                {
                    Username =model.username,
                    password=md5sifre
                };
                db.Users.Add(user);
                if (db.SaveChanges() == 0)
                {
                    ModelState.AddModelError("","kayıt eklenemedi");  //ilk tırnağa nerede hata ykalamayı istiyorsak onu yazıyoruz. örneğin username yazzılabilir 
                }
                else
                {
                    return RedirectToAction("Login");
                }
                    
            }
            return View(model);
        }
        public IActionResult profil()
        {
            Profileİnfo();
            return View();
        }

        private void Profileİnfo()
        {
            Guid id = new Guid(User.FindFirstValue(ClaimTypes.NameIdentifier));
            User user = db.Users.SingleOrDefault(x => x.id == id);
            ViewData["useName"] = user.Name;
            ViewData["userName"] = user.Username;
            ViewData["password"] = user.password;
            ViewData["mesaj"] = TempData["mesaj"];
        }

        [HttpPost]
        public IActionResult nameSurnameSave(string nameSurname)
        {
            if (ModelState.IsValid)
            {
                Guid id=new Guid(User.FindFirstValue(ClaimTypes.NameIdentifier));
                User user=db.Users.SingleOrDefault(x=>x.id==id);


                user.Name=nameSurname;
                db.SaveChanges();
                return RedirectToAction("profil");
            }
            return View("profil");
        }
        [HttpPost]
        public IActionResult userNameSave(string username)
        {
            if (ModelState.IsValid)
            {
                Guid id=new Guid(User.FindFirstValue(ClaimTypes.NameIdentifier));
                User user = db.Users.SingleOrDefault(x => x.id == id);

                if(db.Users.Any(x=>x.Username.ToLower()==username.ToLower() && x.id != id))
                {
                    ModelState.AddModelError("", "bu kullanıcı sistemde kayıtlı bulunuyor");
                    return View("profil");
                }
                user.Username = username;
                db.SaveChanges();

                TempData["mesaj"] = "kullanıcı adı değişti";

                Profileİnfo();
                return RedirectToAction("profile");

            }
            return View("profil");
        }
        public IActionResult passwordSave(string password)
        {
            if (ModelState.IsValid)
            {
                Guid id=new Guid(User.FindFirstValue(ClaimTypes.NameIdentifier));
                User user = db.Users.SingleOrDefault(x => x.id == id);

                string sifre = _configuration.GetValue<string>("Appsettings=sifre");
                sifre = password + sifre;
                string md5sifre = sifre.MD5();

                user.password=md5sifre;
                db.SaveChanges();

                TempData["mesaj"] = "nameData";
                Profileİnfo();
                return RedirectToAction("profil");
            }
            return View("profil");
        }
        public IActionResult logout()
        {

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}
