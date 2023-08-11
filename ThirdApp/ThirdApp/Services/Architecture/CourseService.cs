using System.Net.Http.Json;
using ThirdApp.Models;
using ThirdApp.Models.DTOs;
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

    public async Task<Course> GetById(int id)
    {
        return await httpClient.GetFromJsonAsync<Course>($"api/courses/{id}") ?? new Course();
    }

    public async Task Edit(int id,CourseDTO dto)
    {
        await httpClient.PutAsJsonAsync<object>($"api/courses/{id}", dto);
    }

    public async Task<object> Add(CourseDTO dto)
    {
        return await httpClient.PostAsJsonAsync<CourseDTO>("/api/courses", dto);
    }

    public async Task Delete(int id)
    {
        await httpClient.DeleteAsync($"/api/courses/{id}");
    }

}
