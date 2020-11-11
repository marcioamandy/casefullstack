using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Student
{
    public class StudentDtoCreate
    {
        [Required(ErrorMessage = "Nome é campo obrigatório", AllowEmptyStrings = false)]
        [StringLength(60, MinimumLength = 4, ErrorMessage = "Nome deve ter no mínimo 4 e no máximo {1} caracteres.")]
        [Display(Name = "Informe o Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-mail é campo obrigatório", AllowEmptyStrings = false)]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        [StringLength(100, MinimumLength = 7, ErrorMessage = "E-mail deve ter no mínimo 7 e no máximo {1} caracteres.")]
        [Display(Name = "Informe o E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Data de Nascimento é campo obrigatório", AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        [Display(Name = "Informe a Data de Nascimento")]
        public string DateBirth { get; set; }

        [Required(ErrorMessage = "Status é campo obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o Status")]
        public bool Status { get; set; }
    }
}
