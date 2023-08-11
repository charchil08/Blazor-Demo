using System.Net.Http.Json;
using ThirdApp.Models;
using ThirdApp.Services.Infrastructure;

namespace ThirdApp.Services.Architecture;

public class CourseService : ICourseService
{
    private readonly HttpClient httpClient;

    public CourseService(HttpClient httpClient)
	{
        this.httpClient = httpClient;
    }

    public async Task<IEnumerable<Course>> GetList()
    {
        return await httpClient.GetFromJsonAsync<Course[]>("api/courses");
    }
}
