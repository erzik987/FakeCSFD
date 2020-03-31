using FakeCSFD.DAL.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeCSFD.DAL.Factories
{
    public interface IDBContextFactory
    {
        FakeCSFDDBContext CreateDbContext();
    }
}
