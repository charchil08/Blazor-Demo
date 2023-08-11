using System.ComponentModel.DataAnnotations;

namespace ThirdApp.API.Entities.DTOs;

public class CourseDTO
{    
    public int Id { get; set; }

    [Required]
    [MinLength(2)]
    public string Name { get; set; } = null!;
}
