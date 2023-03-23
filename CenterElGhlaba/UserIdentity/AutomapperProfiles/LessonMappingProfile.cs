﻿using AutoMapper;
using Center_ElGhalaba.Models;
using Center_ElGhlaba.ViewModels;

namespace Center_ElGhlaba.AutomapperProfiles
{
    public class LessonMappingProfile : Profile
    {
        public LessonMappingProfile()
        {
            CreateMap<Lesson, LessonDetailsVM>()
                .ForMember(dest => dest.LessonID, src => src.MapFrom(src => src.ID))
                .ReverseMap();

            CreateMap<Student, LessonDetailsVM>()
                .ForMember(dest => dest.studentName, src => src
                .MapFrom(src => src.AppUser.FirstName + " " + src.AppUser.LastName))
                .ReverseMap();

            CreateMap<Teacher, LessonDetailsVM>().ReverseMap();

            CreateMap<LessonComment, LessonDetailsVM>().ReverseMap();
        }
    }
}
