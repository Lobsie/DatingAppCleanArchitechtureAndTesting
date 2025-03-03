using DatingApp.API.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.API.Core.Dtos
{
    public class AppUserDto : BaseDto
    {
        public required string UserName { get; set; }
    }
}
