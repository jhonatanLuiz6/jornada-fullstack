using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Request.Categories;

public class CreateCategoryRequest : Request
{
    [Required(ErrorMessage = "Título inválido")]
    [MaxLength(80, ErrorMessage = " O título deve conter at")]
    public string Title {get; set;} = string.Empty;

    [Required(ErrorMessage = "Descrição inválida")]
    public string Description {get; set;} = string.Empty;

}

