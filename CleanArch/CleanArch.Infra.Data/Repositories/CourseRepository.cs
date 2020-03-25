using CleanArch.Domain.Models;
using CleanArch.Domain.Models.Interfaces;
using CleanArch.Infra.Data.Context;
using System.Collections.Generic;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
