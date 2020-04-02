using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace GitHubProject.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }
    }
}
