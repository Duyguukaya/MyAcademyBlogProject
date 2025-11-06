using AutoMapper;
using Blogy.Business.DTOs.BlogDtos;
using Blogy.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.Business.Mappings
{
    public class BlogMappings:Profile
    {
        public BlogMappings()
        {
            CreateMap<Blog,ResultBlogDto>().ReverseMap();
            CreateMap<Blog,CreateBlogDto>().ReverseMap();
            CreateMap<Blog,UpdateBlogDto>().ReverseMap();
            CreateMap<UpdateBlogDto, ResultBlogDto>().ReverseMap();
        }
    }
}
