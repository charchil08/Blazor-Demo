using Microsoft.AspNetCore.Components;
using ThirdApp.Models;

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

    protected async Task CheckboxChecked(ChangeEventArgs e)
    {
        IsSelected = (bool)e.Value!;
        await OnCourseSelection.InvokeAsync(IsSelected);
    }
}
