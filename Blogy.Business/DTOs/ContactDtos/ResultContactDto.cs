using Blogy.Business.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.Business.DTOs.ContactDtos
{
    public class ResultContactDto : BaseDto
    {
        public string Location { get; set; }
        public string OpenHours { get; set; }
        public string Email { get; set; }
        public string Call { get; set; }
    }
}
