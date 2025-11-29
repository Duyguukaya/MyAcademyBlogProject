using Blogy.Business.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.Business.DTOs.AboutDtos
{
    public class UpdateAboutDto:BaseDto
    {
        public string Description { get; set; } // AI burayı dolduracak
        public string ImageUrl { get; set; }
    }
}
