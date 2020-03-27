using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public IQueryable<Course> GetCourses()
        {
            return _context.Courses;
        }

        public void Add(Course course)
        {
            _context.Add(course);
            _context.SaveChanges();
        }
    }
}
