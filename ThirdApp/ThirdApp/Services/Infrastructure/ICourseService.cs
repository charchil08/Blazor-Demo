using ThirdApp.Models;
using ThirdApp.Models.DTOs;

namespace ThirdApp.Services.Infrastructure;

public interface ICourseService
{
    Task<IEnumerable<Course>> GetList();

    Task<Course> GetById(int id);

    Task Edit(int id, CourseDTO dto);

    Task<object> Add(CourseDTO dto);

    Task Delete(int id);
}
