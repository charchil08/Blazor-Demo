using System.ComponentModel.DataAnnotations;

namespace ThirdApp.Models.DTOs;

public class CourseDTO
{
    public string Id { get; set; }

    [Required]
    [MinLength(2)]
    public string Name { get; set; } = null!;
}