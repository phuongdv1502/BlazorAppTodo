using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Api.Entities
{
    public class User:IdentityUser<Guid>
    {
        public string FullName { get; set; }
    }
}
