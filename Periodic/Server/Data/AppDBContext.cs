using Periodic.Shared.Models;
using Microsoft.EntityFrameworkCore;
using CsvHelper;
using System;

namespace Periodic.Server.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Element>? Elements { get; set; }
    }
}
