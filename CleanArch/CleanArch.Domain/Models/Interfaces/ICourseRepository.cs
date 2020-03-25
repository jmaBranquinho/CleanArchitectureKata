using System.Collections.Generic;

namespace CleanArch.Domain.Models.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
