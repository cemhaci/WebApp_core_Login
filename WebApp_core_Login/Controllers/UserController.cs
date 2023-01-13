using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp_core_Login.Models;
using WebApp_core_Login.Models.viewModel;

namespace WebApp_core_Login.Controllers
{
    [Authorize(Roles ="admin")]  //sadece admin olan bu controllera ulaşabilecek
    public class UserController : Controller
    {
        private DatabaseContext db;
        private IMapper _mapper;
        public UserController(DatabaseContext context,IMapper mapper)
        {
            db=context;
            _mapper=mapper; 
        }
        public IActionResult Index()
        {
           List<User> userlist= db.Users.ToList();
            //authomapper

            List<userViewModel> model=userlist.Select(x=>_mapper.Map<userViewModel>(x)).ToList();  //userlistteki elemanları mapleyip userviewmodel e at
            //List<userViewModel> users=new List<userViewModel>();
            //foreach(User user in userlist)
            //{
            //    users.Add(new userViewModel
            //    {
            //        id=user.id,
            //        Name=user.Name
            //    });
            //}
            return View(model);
        }
        //public IActionResult Create()
        //{

        //}
    }
}
