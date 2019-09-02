using System;
using Xunit;
using FakeMovieTheatre;
using Microsoft.EntityFrameworkCore;
using FakeMovieTheatre.Models;
using System.Linq;

using System.Runtime.InteropServices.ComTypes;


namespace unitTesting

{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]

        public void CanGetRoom()

        {

            DbContextOptions<FakeMovieTheatreContext> options = new DbContextOptionsBuilder<FakeMovieTheatreContext>()
                U

            using (AsyncdbContext context = new AsyncdbContext(options))

            {

                Room room = new Room();
            }
        }
}
