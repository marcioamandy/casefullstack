using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.ClassStudent
{
    public class ClassStudentDtoCreate
    {
        [Required(ErrorMessage = "Identificação da classe é campo obrigatório", AllowEmptyStrings = false)]
        [StringLength(36, MinimumLength = 4, ErrorMessage = "Identificação da classe deve ter no mínimo 4 e no máximo {1} caracteres.")]
        [Display(Name = "Informe a Identificação da Classe")]
        public string IdClass { get; set; }

        [Required(ErrorMessage = "Identificação do aluno é campo obrigatório", AllowEmptyStrings = false)]
        [StringLength(36, MinimumLength = 4, ErrorMessage = "Identificação do aluno deve ter no mínimo 4 e no máximo {1} caracteres.")]
        [Display(Name = "Informe a Identificação do Aluno")]
        public string IdStudent { get; set; }
    }
}
