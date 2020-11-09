using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.School
{
    public class SchoolDtoCreate
    {
        [Required(ErrorMessage = "Nome é campo obrigatório",AllowEmptyStrings=false)]
        [StringLength(60, MinimumLength=4, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        [Display(Name = "Informe o Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address é campo obrigatório",AllowEmptyStrings=false)]
        [StringLength(100, MinimumLength=10, ErrorMessage = "Endereço deve ter no máximo {1} caracteres.")]
        [Display(Name = "Informe o Endereço")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Status é campo obrigatório",AllowEmptyStrings=false)]
        [Display(Name = "Informe o Status")]
        public Boolean Status { get; set; }
    }
}
