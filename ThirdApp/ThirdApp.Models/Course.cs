using System.ComponentModel.DataAnnotations;

namespace ThirdApp.Models;
public class Course
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTimeOffset CreatedOn { get; set; }

    public DateTimeOffset ModifiedOn { get; set; }

    public bool IsDeleted { get; set; }
}
