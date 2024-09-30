using DBGestaoEmpresarial.Domain.Entities;
using DBGestaoEmpresarial.Infrastructure.ConfigurationEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBGestaoEmpresarial.Infrastructure.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<Employe> Employes {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EmployeConfiguration());
        }
    }
}
