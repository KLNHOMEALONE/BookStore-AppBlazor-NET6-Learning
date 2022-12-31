﻿using AutoMapper;
using BookStoreApp.API.Data;
using BookStoreApp.API.Models.Authors;

namespace BookStoreApp.API.Configurations
{
    public class MapperConfig: Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
        }
    
    }
}