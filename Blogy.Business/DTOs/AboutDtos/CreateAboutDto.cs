using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.Business.DTOs.AboutDtos
{
    public class CreateAboutDto
    {
        public string Description { get; set; } // AI burayı dolduracak
        public string ImageUrl { get; set; }
    }
}
