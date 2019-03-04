namespace App.DAL.Context
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelApp : DbContext
    {
        public ModelApp() : base(GetConnectionString())
        {
            // @"data source=(LocalDb)\MSSQLLocalDB;initial catalog=TrainingIS;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"
        }

        public static string GetConnectionString()
        {

            string ConnectionString = @"data source=(LocalDb)\MSSQLLocalDB;initial catalog=Main_App;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";

            return ConnectionString;
        }

    }
}