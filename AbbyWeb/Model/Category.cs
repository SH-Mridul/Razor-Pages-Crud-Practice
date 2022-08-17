using System.ComponentModel.DataAnnotations;

namespace AbbyWeb.Model
{
    public class Category
    {
       [Key]
       public int Id { get; set; }
       [Required(ErrorMessage = "Name is required!"),Display(Name ="Name")]
       public string Name { get; set; }
       [Required(ErrorMessage = "Order view is required!"), Range(1,int.MaxValue - 1, ErrorMessage = "you have to give a positive number!"),Display(Name = "Order view")]
       public int DisplayOrder { get; set; }
    }
}
