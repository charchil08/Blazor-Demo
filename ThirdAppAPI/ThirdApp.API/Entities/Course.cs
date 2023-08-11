using System.ComponentModel.DataAnnotations;

namespace ThirdApp.API.Entities;

public sealed class Course
{
    [Key]
    public int Id { get; set; }

    [StringLength(20)]
    public string Name { get; set; } = null!;

    public DateTimeOffset CreatedOn { get; set; }
    
    public DateTimeOffset ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }
}
