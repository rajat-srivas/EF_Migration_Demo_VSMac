using System;
using Microsoft.EntityFrameworkCore;
using StackUpDemo.Model;

namespace StackUpDemo.Context
{
    public class StackUpDemoContext: DbContext
    { 
            public StackUpDemoContext(DbContextOptions<StackUpDemoContext> options)
               : base(options)
            {
            }
            public virtual DbSet<Status> Status { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Status>().HasData(
                    new Status
                    {
                        StatusId = 1,
                        EntityStatus = "Active"
                    },
                    new Status
                    {
                        StatusId = 2,
                        EntityStatus = "InActive"
                    },
                     new Status
                     {
                         StatusId = 3,
                         EntityStatus = "Pending"
                     }
                );
            }

        }
    }