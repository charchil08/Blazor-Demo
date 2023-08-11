using Microsoft.AspNetCore.Components;
using ThirdApp.Models;
using ThirdApp.Services.Infrastructure;

namespace ThirdApp.Shared;

public class DisplayCourseBase : ComponentBase
{
    [Parameter]
    public Course Course { get; set; }

    [Parameter]
    public bool ShowActions { get; set; }

    protected bool IsSelected { get; set; }

    [Parameter]
    public EventCallback<bool> OnCourseSelection { get; set; }

    [Parameter]
    public EventCallback<int> OnCourseDeletion { get; set; }

    [Inject]
    private ICourseService courseService { get; set; }

    protected async Task CheckboxChecked(ChangeEventArgs e)
    {
        IsSelected = (bool)e.Value!;
        await OnCourseSelection.InvokeAsync(IsSelected);
    }

    protected async Task Delete_Click()
    {
        await courseService.Delete(Course.Id);
        await OnCourseDeletion.InvokeAsync(Course.Id);
    }
}
