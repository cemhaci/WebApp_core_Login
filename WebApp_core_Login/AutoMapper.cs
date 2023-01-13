using AutoMapper;
using WebApp_core_Login.Models;
using WebApp_core_Login.Models.viewModel;

namespace WebApp_core_Login
{
    public class AutoMapper:Profile
    {
        public AutoMapper()
            { 
            CreateMap<User,userViewModel>().ReverseMap();    //userdan userview e girmek istediğimize dair bir map oluşturduk.reversemap ile birbirlerine dönüşürrebilriz
            }
    }
}
