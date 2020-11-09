using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.ClassStudent
{
    public class ClassStudentDtoCreate
    {
        [Required(ErrorMessage = "Id da Turma é campo obrigatório",AllowEmptyStrings=false)]
        [Display(Name = "Informe o identificador da turma")]
        public string IdClass { get; set; }

        [Required(ErrorMessage = "Id do Aluno é campo obrigatório",AllowEmptyStrings=false)]
        [Display(Name = "Informe o identificador do aluno")]
        public string IdStudent { get; set; }
    }
}
