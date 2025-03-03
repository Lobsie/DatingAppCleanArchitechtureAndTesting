using DatingApp.API.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Core.Entities
{
    public class AppUser : EntityBase
    {
        public required string UserName { get; set; }
    }
}
 