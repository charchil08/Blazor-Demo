using Microsoft.AspNetCore.Components;
using ThirdApp.Models;
using ThirdApp.Services.Infrastructure;

namespace ThirdApp.Pages;

public class CourseListBase : ComponentBase
{
    public IEnumerable<Course> Courses { get; set; }


    [Inject]
    public ICourseService courseService { get; set; }

    [Parameter]
    public bool ShowActions { get; set; } = true;

    protected override async Task OnInitializedAsync()
    {
        Courses = (await courseService.GetList()).ToList();
        //LoadCourses();
        //return base.OnInitializedAsync();
    }

    //private void LoadCourses()
    //{
    //    Courses = new List<Course>
    //    {
    //        new Course { Id = 1, Name = "Mathematics", CreatedOn = DateTimeOffset.UtcNow, ModifiedOn = DateTimeOffset.UtcNow, IsDeleted = false },
    //        new Course { Id = 2, Name = "Science", CreatedOn = DateTimeOffset.UtcNow, ModifiedOn = DateTimeOffset.UtcNow, IsDeleted = false },
    //        new Course { Id = 3, Name = "History", CreatedOn = DateTimeOffset.UtcNow, ModifiedOn = DateTimeOffset.UtcNow, IsDeleted = false },
    //        new Course { Id = 4, Name = "English", CreatedOn = DateTimeOffset.UtcNow, ModifiedOn = DateTimeOffset.UtcNow, IsDeleted = false },
    //        new Course { Id = 5, Name = "Physics", CreatedOn = DateTimeOffset.UtcNow, ModifiedOn = DateTimeOffset.UtcNow, IsDeleted = false },
    //        new Course { Id = 6, Name = "Chemistry", CreatedOn = DateTimeOffset.UtcNow, ModifiedOn = DateTimeOffset.UtcNow, IsDeleted = false },
    //        new Course { Id = 7, Name = "Biology", CreatedOn = DateTimeOffset.UtcNow, ModifiedOn = DateTimeOffset.UtcNow, IsDeleted = false },
    //        new Course { Id = 8, Name = "Geography", CreatedOn = DateTimeOffset.UtcNow, ModifiedOn = DateTimeOffset.UtcNow, IsDeleted = false },
    //        new Course { Id = 9, Name = "Computer Science", CreatedOn = DateTimeOffset.UtcNow, ModifiedOn = DateTimeOffset.UtcNow, IsDeleted = false },
    //        new Course { Id = 10, Name = "Music", CreatedOn = DateTimeOffset.UtcNow, ModifiedOn = DateTimeOffset.UtcNow, IsDeleted = false },
    //    };
    //}
}
