using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Estudio.Models;
using Microsoft.EntityFrameworkCore;

namespace Estudio.Data
{
    public class EstudioDBContext: DbContext
    {
        public DbSet<Music> Songs { get; set; }
        public EstudioDBContext(DbContextOptions<EstudioDBContext>options):base(options)//enlaza base de datos con el Entity
        {
          
        }
    }
}
