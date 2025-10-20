using Microsoft.AspNetCore.Mvc.Rendering;
using PrjVendas.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace PrjVendas.MVC.Models
{
    public class FuncionarioViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"\d{11}", ErrorMessage = "CPF deve conter 11 dígitos.")]
        public string Cpf { get; set; } = string.Empty;

        [Required(ErrorMessage = "O cargo deve ser selecionado.")]
        [Display(Name = "Cargo")]
        public int CargoId { get; set; }

        [Required(ErrorMessage = "O salário é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O salário deve ser maior ou igual a zero.")]
        public decimal Salario { get; set; }

        public List<SelectListItem>? ListaCargos { get; set; }
    }
}
