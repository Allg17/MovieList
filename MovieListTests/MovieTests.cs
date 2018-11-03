using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieList.Tests
{
    [TestClass()]
    public class MovieTests
    {
        private Movie GetClass()
        {
            Movie movie = new Movie();
            movie.Nombre = "Uncle Drew";
            movie.IdMovie = 0;
            movie.Link = @"C:\Users\Usuario\source\repos\MovieList\MovieList\Photo\w.jpg";
            movie.Photo = @"C:\Users\Usuario\source\repos\MovieList\MovieList\Photo\w.jpg";

            return movie;

        }

        [TestMethod()]
        public void MovieTest()
        {
            BLL.RepositorioBase<Movie> movie = new BLL.RepositorioBase<Movie>();
            Assert.AreEqual(movie.Guardar(GetClass()),true);
        }

        [TestMethod()]
        public void MovieTest1()
        {
            Assert.Fail();
        }
    }
}