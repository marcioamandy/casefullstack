using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Class
{
    public class ClassDtoUpdate
    {
        [Required(ErrorMessage = "Id é campo obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o identificador da escola")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome é campo obrigatório", AllowEmptyStrings = false)]
        [StringLength(60, MinimumLength = 4, ErrorMessage = "Nome deve ter no mínimo 4 e no máximo {1} caracteres.")]
        [Display(Name = "Informe o Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Dias da semana que ocorrerá as aulas é campo obrigatório", AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Dias da semana deve ter no mínimo 5 e no mínimo 5 e no máximo {1} caracteres.")]
        [Display(Name = "Informe os dias da semana das aulas")]
        public string DaysWeek { get; set; }

        [Required(ErrorMessage = "Data inicial é campo obrigatório", AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        [Display(Name = "Informe a data inicial da turma")]
        public string DateStart { get; set; }

        [Required(ErrorMessage = "Data final é campo obrigatório", AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]
        [Display(Name = "Informe a data final da turma")]
        public string DateEnd { get; set; }

        [Required(ErrorMessage = "Identificador da escola é campo obrigatório", AllowEmptyStrings = false)]
        [StringLength(36, MinimumLength = 5, ErrorMessage = "Identificador da escola deve ter no mínimo 5 e no máximo {1} caracteres.")]
        [Display(Name = "Informe o identificador da escola associada a turma")]
        public string IdSchool { get; set; }

        [Required(ErrorMessage = "Status é campo obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Informe o status da turma")]
        public bool Status { get; set; }
    }
}
