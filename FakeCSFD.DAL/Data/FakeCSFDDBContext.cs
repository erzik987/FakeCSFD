using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeCSFD.DAL.Data
{
    public class FakeCSFDDBContext : DbContext
    {
        public FakeCSFDDBContext()
        {

        }

        public FakeCSFDDBContext(DbContextOptions<FakeCSFDDBContext> options) : base(options)
        {

        }
    }
}
