using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JedMorrisBlog.Models;

public class Blog
{
  public int Id { get; set; }
  public string AuthorId { get; set; }

  [Required]
  [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long", MinimumLength = 2)]
  public string Name { get; set; }
  
  [Required]
  [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at most {1} characters long", MinimumLength = 2)]
  public string Description { get; set; }
 
  [DataType(DataType.Date)]
  [Display(Name = "Created Date")]
  public DateTime Created { get; set; }
  
  [DataType(DataType.Date)]
  [Display(Name = "Updated Date")]
  public DateTime? Updated { get; set; }
 
  [Display(Name = "Blog Image")]
  public byte[] ImageData { get; set; }
  
  [Display(Name = "Image Type")]
  public string ContentType { get; set; }
 
  [NotMapped]
  public IFormFile Image { get; set; }
  
}