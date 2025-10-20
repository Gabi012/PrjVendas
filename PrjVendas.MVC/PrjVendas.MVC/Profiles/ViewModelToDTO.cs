using AutoMapper;
using PrjVendas.Application.Dto;
using PrjVendas.MVC.Models;

namespace PrjVendas.MVC.Profiles
{
    public class ViewModelToDTO : Profile
    {
        public ViewModelToDTO()
        {
            CreateMap<FuncionarioViewModel, FuncionarioDTO>().ReverseMap();
        }
    }
}
