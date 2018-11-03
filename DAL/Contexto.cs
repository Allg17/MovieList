using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieList
{
    public class Contexto : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCar> Moviecar { get; set; }
        public DbSet<MovieCarDetalle> Detalle { get; set; }

        public Contexto() : base("ConStr")
        {
        }
    }
}