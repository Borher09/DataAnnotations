using System;
using System.ComponentModel.DataAnnotations;

namespace AtvDataAnnotations.Models
{
    public class ClientePremiumViewModel
    {
        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O nome completo é obrigatório.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O nome deve ter entre 5 e 100 caracteres.")]
        public string NomeCompleto { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime? DataNascimento { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$",
            ErrorMessage = "Informe um CPF no formato 000.000.000-00.")]
        public string Cpf { get; set; }

        [Display(Name = "Telefone Celular")]
        [Required(ErrorMessage = "O telefone celular é obrigatório.")]
        [Phone(ErrorMessage = "O número de telefone informado não é válido.")]
        public string TelefoneCelular { get; set; }

        [Display(Name = "Perfil do LinkedIn")]
        [Url(ErrorMessage = "A URL informada não é válida.")]
        public string UrlPerfilLinkedIn { get; set; }

        [Display(Name = "Renda Mensal")]
        [Required(ErrorMessage = "A renda mensal é obrigatória.")]
        [Range(3000, 1000000, ErrorMessage = "A renda deve estar entre R$ 3.000,00 e R$ 1.000.000,00.")]
        [DataType(DataType.Currency)]
        public decimal RendaMensal { get; set; }

        [Display(Name = "Número do Cartão de Crédito")]
        [Required(ErrorMessage = "O número do cartão de crédito é obrigatório.")]
        [CreditCard(ErrorMessage = "Informe um número de cartão de crédito válido.")]
        public string NumeroCartaoCredito { get; set; }

        [Display(Name = "Senha de Acesso")]
        [Required(ErrorMessage = "A senha é obrigatória.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$",
            ErrorMessage = "A senha deve ter no mínimo 8 caracteres, incluindo letra maiúscula, minúscula, número e caractere especial.")]
        public string SenhaAcesso { get; set; }

        [Display(Name = "Confirmar Senha")]
        [Required(ErrorMessage = "A confirmação de senha é obrigatória.")]
        [DataType(DataType.Password)]
        [Compare("SenhaAcesso", ErrorMessage = "As senhas digitadas não são iguais.")]
        public string ConfirmarSenhaAcesso { get; set; }
    }
}