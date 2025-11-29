using Blogy.Business.DTOs.AboutDtos;
using Blogy.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.Business.Services.AboutServices
{
    public interface IAboutService: IGenericService<ResultAboutDto, UpdateAboutDto, CreateAboutDto>
    {
        Task<string> GenerateAboutTextWithAiAsync();
    }
}
