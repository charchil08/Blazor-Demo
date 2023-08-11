using Microsoft.AspNetCore.Components;
using ThirdApp.Models;

namespace ThirdApp.Shared;

public class DisplayCourseBase : ComponentBase
{
    [Parameter]
    public Course Course { get; set; }

    [Parameter]
    public bool ShowActions { get; set; }
}
