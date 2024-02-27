using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BaltaTest.Models;

public class Premium
{
    [Key]
    [DisplayName("Id")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o titulo do Premium")]
    [StringLength(80, ErrorMessage = "O titulo deve conter até 80 caracteres")]
    [MinLength(5, ErrorMessage = "O titulo deve conter pelo menos 5 caracteres")]
    [DisplayName("Titulo")]
    public string Title { get; set; } = string.Empty;

    [DataType(DataType.DateTime)]
    //[GreaterThanToday]
    [DisplayName("Inicio")]
    public DateTime StartDate { get; set; }

    [DataType(DataType.DateTime)]
    [DisplayName("Término")]
    public DateTime EndDate { get; set; }

    [DisplayName("Aluno")]
    [Required(ErrorMessage = "Aluno invalido")]
    public int StundetId { get; set; }

    public Student? Stundent { get; set; }

}