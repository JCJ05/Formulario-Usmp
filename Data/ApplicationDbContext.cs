using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Formulario_Usmp.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
          public DbSet<Formulario_Usmp.Models.Alumno> DataAlumnos { get; set; }

        
    }
}