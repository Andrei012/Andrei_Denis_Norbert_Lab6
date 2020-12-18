using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Andrei_Denis_Norbert_Lab6.Models;

namespace Andrei_Denis_Norbert_Lab6.Data
{
    public class Andrei_Denis_Norbert_Lab6Context : DbContext
    {
        public Andrei_Denis_Norbert_Lab6Context (DbContextOptions<Andrei_Denis_Norbert_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Andrei_Denis_Norbert_Lab6.Models.Book> Book { get; set; }
    }
}
