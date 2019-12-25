using System;

namespace _19_CompositionDEMO
{

    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DBMigrator(new Logger());

            var logger = new Logger();

            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
