using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.Application.Dto
{
    // DTO usado para leitura (GET)
    public class FuncionarioReadDto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public decimal Salario { get; set; }
    }

    // DTO usado para criação (POST)
    public class FuncionarioCreateDto
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"\d{11}", ErrorMessage = "CPF deve conter 11 dígitos.")]
        public string Cpf { get; set; } = string.Empty;

        [Required(ErrorMessage = "O cargo deve ser selecionado.")]
        public int CargoId { get; set; }

        [Required(ErrorMessage = "O salário é obrigatório.")]
        [Range(0, double.MaxValue, ErrorMessage = "O salário deve ser maior ou igual a zero.")]
        public decimal Salario { get; set; }
    }

    // DTO usado para atualização (PUT)
    public class FuncionarioUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100)]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [RegularExpression(@"\d{11}")]
        public string Cpf { get; set; } = string.Empty;

        [Required]
        public int CargoId { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Salario { get; set; }
    }

}
