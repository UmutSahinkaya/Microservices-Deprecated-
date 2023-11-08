﻿using AutoMapper;
using Services.Catalog.Models;
using Services.Catalog.Models.Dtos;

namespace Services.Catalog.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Feature, FeatureDto>().ReverseMap();

            CreateMap<Course,CourseCreateDto>().ReverseMap();
            CreateMap<Course,CourseUpdateDto>().ReverseMap();
        }
    }
}
