using AutoMapper;
using Vendas.Application.Dto;
using Vendas.Domain.Entities;
using Vendas.Domain.Entities;

namespace Vendas.Application.Profiles
{
    public class DomainToDTOProfile: Profile
    {
        public DomainToDTOProfile()
        {
            // DTO → Entidade
            CreateMap<FuncionarioCreateDto, Funcionario>().ReverseMap();
            CreateMap<FuncionarioReadDto, Funcionario>().ReverseMap();
            CreateMap<FuncionarioReadDto, FuncionarioCreateDto>().ReverseMap();
            CreateMap<FuncionarioUpdateDto, Funcionario>().ReverseMap();
        }
    }
}
