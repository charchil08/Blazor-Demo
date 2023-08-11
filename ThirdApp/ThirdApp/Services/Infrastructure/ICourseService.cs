using ThirdApp.Models;

namespace ThirdApp.Services.Infrastructure;

public interface ICourseService
{
    Task<IEnumerable<Course>> GetList();
}
