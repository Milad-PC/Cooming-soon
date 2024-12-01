namespace CoomingSoonApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CoomingSoonApp.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CoomingSoonApp.MyContext context)
        {
            //  This method will be called after migrating to the latest version.
            Admins usr = new Admins();
            usr.AdminsId = 1;
            usr.UserName = "admin";
            usr.Password = "admin";
            context.Admins.AddOrUpdate(usr);
            context.SaveChanges();
        }
    }
}
