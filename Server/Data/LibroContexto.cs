﻿using Libreria.Shared.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Libreria.Server.Data
{
    public class LibroContexto:DbContext
    {
        public LibroContexto(DbContextOptions<LibroContexto> options) : base(options)
        {

        }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }

    }
}
