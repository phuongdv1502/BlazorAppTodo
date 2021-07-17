using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TodoList.Api.Entities;

namespace TodoList.Api.Data
{
    public class TodoDBContext : IdentityDbContext<User, Role, Guid>
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> option) : base(option)
        {

        }
        public DbSet<Task> Tasks { get; set; }
    }
}
