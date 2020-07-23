using System;
using System.Collections.Generic;
using System.Text;
using AfectacionMedioAmbiente.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AfectacionMedioAmbiente.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet <Celular> Celulares { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
