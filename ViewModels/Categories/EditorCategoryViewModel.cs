using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Categories;

public class EditorCategoryViewModel
{
    [Required(ErrorMessage = "O nome é obrigatório")]
    [StringLength(40, MinimumLength = 3, ErrorMessage = "Nome deve conter entre 3 e 40 caractéres")]
    public string Name { get; set; } = string.Empty;


    [Required(ErrorMessage = "O slug é obrigatório")]
    public string Slug { get; set; } = string.Empty; //está definido como único
}