using AutoMapper;
using PrjVendas.Application.Dto;
using PrjVendas.Domain.Entities;

namespace PrjVendas.Application.Profiles
{
    public class DomainToDTOProfile: Profile
    {
        public DomainToDTOProfile()
        {
            // DTO → Entidade
            CreateMap<FuncionarioDTO, Funcionario>().ReverseMap();
        }
    }
}
