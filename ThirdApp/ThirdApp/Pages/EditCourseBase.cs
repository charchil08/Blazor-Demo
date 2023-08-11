using Microsoft.AspNetCore.Components;
using ThirdApp.Models;
using ThirdApp.Models.DTOs;
using ThirdApp.Services.Infrastructure;

namespace ThirdApp.Pages;

public class EditCourseBase : ComponentBase
{
    [Parameter]
    public string Id { get; set; }

    [Inject]
    public ICourseService courseService { get; set; }

    [Inject] public NavigationManager NavigationManager { get; set; }

    public CourseDTO CourseDTO { get; set; }

    public Course Course { get; set; }

    protected override async Task OnInitializedAsync()
    {

        int.TryParse(Id, out int courseId);

        if(courseId != 0)
        {
            Course = await courseService.GetById(int.Parse(Id));
            CourseDTO = new CourseDTO()
            {
                Id = Course.Id.ToString(),
                Name = Course.Name,
            };
        }
        else
        {
            CourseDTO = new CourseDTO();
        }
    }

    protected async Task HandleValidSubmit()
    {

        int.TryParse(Id,out int courseId);

        if(courseId != 0)
        {
            await courseService.Edit(int.Parse(Id), CourseDTO);
        }
        else
        {
            CourseDTO.Id = "0";
            await courseService.Add(CourseDTO);
        }

        NavigationManager.NavigateTo("/course");
    }

    protected async Task Delete_Click()
    {
        await courseService.Delete(int.Parse(Id));
        NavigationManager.NavigateTo("/course");
    }
}
