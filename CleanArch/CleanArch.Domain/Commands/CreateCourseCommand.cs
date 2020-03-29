﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Domain.Commands
{
    public class CreateCourseCommand : CourseCommand
    {
        public CreateCourseCommand(string name, string description, string imageUrl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageUrl;
        }

        public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
        {
            private readonly ICourseRepository _courseRepository;

            public CourseCommandHandler(ICourseRepository courseRepository)
            {
                _courseRepository = courseRepository;
            }

            public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
            {
                var course = new Course
                {
                    Name = request.Name,
                    Description = request.Description,
                    ImageUrl = request.ImageUrl
                };

                _courseRepository.Add(course);

                return Task.FromResult(true);
            }
        }
    }
}
