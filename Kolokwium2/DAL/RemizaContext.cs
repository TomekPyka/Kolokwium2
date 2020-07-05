using Kolokwium2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2.DAL
{
    public class RemizaContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public RemizaContext() : base()
        {

        }

        public RemizaContext(DbContextOptions<RemizaContext> options) : base(options)
        {
        }

        public Microsoft.EntityFrameworkCore.DbSet<FireTruck_Action> FireTruck_Actions { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<FireTruck> FireTucks { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<Firefighter> Firefighters { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<FirefighterAction> FirefighterActions { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<Model.Action> Actions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<FireTruck_Action>((entity) =>
            {
                entity.HasKey(entity => new { entity.Action, entity.FireTruck });
            });
        }
    }
}

