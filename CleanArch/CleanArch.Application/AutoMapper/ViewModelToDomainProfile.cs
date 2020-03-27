using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;

namespace CleanArch.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(course => new CreateCourseCommand(course.Name, course.Description, course.ImageUrl));
        }
    }
}
