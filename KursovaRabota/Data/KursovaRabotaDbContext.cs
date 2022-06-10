using KursovaRabota.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaRabota
{
    public class KursovaRabotaDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Server=.; DataBase=HotelDbs; Integrated Security=true ");
        }
        public DbSet<Client>Clients{ get; set; }
        public DbSet<Hotel>Hotels{ get; set; }
        
    }
}
