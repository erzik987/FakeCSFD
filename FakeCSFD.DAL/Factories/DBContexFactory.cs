using FakeCSFD.DAL.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeCSFD.DAL.Factories
{
    class DBContexFactory : IDBContextFactory
    {
        public FakeCSFDDBContext CreateDbContext()
        {
            string dbServer = ConfigurationManager.AppSettings.Get("Server");
            string dbInitCatalog = ConfigurationManager.AppSettings.Get("InitCatalog");
            string dbUserID = ConfigurationManager.AppSettings.Get("UserID");
            string dbPassword= ConfigurationManager.AppSettings.Get("Password");

            var optionsBuilder = new DbContextOptionsBuilder<FakeCSFDDBContext>();
            optionsBuilder.UseSqlServer($"Server = {dbServer}, 1433; Initial Catalog = {dbInitCatalog}; Persist Security Info = False; User ID = {dbUserID}; Password ={dbPassword}; MultipleActiveResultSets = False; Encrypt = True;Database=EFProviders.InMemory; TrustServerCertificate = False; Connection Timeout = 30;");
            return new FakeCSFDDBContext(optionsBuilder.Options);
        }
    }
}
