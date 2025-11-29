using Blogy.Entity.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.Entity.Entities
{
    public class About:BaseEntity
    {
   
        public string Description { get; set; } // AI burayı dolduracak
        public string ImageUrl { get; set; }
    }
}
