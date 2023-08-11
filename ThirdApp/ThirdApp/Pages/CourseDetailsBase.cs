using Microsoft.AspNetCore.Components;
using ThirdApp.Models;
using ThirdApp.Services.Infrastructure;

namespace ThirdApp.Pages;

public class CourseDetailsBase : ComponentBase
{
    [Inject]
    public ICourseService courseService { get; set; }
    
    public Course Course { get; set; }

    [Parameter]
    public string Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Id ??= "1";
        Console.WriteLine(int.Parse(Id));   
        Course = await courseService.GetById(int.Parse(Id));
    }
}
