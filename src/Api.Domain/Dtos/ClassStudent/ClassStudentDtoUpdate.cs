using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.ClassStudent
{
    public class ClassStudentDtoUpdate
    {
        [Required(ErrorMessage = "Id é campo obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o identificador do vinculo entre Classe e Aluno")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Identificador da classe é campo obrigatório", AllowEmptyStrings = false)]
        [StringLength(36, MinimumLength = 5, ErrorMessage = "Identificador da classe deve ter no mínimo 5 e no máximo {1} caracteres.")]
        [Display(Name = "Informe o identificador da classe")]
        public string IdClass { get; set; }

        [Required(ErrorMessage = "Identificador do aluno é campo obrigatório", AllowEmptyStrings = false)]
        [StringLength(36, MinimumLength = 5, ErrorMessage = "Identificador do aluno deve ter no mínimo 5 e no máximo {1} caracteres.")]
        [Display(Name = "Informe o identificador do aluno")]
        public string IdStudent { get; set; }
    }
}
