using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trainning.Arch.Repository.Mappings;

namespace Trainning.Arch.Repository
{
    public class Context : DbContext
    {
        public DbSet<PessoaMap> Pessoas { get; set; }
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PessoaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
