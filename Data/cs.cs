using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace ToDoContext
{
    public class cs : DbContext
    {
        public cs (DbContextOptions<cs> options)
            : base(options)
        {
        }

        public DbSet<ToDo.Models.TodoItem> TodoItem { get; set; } = default!;
    }
}
