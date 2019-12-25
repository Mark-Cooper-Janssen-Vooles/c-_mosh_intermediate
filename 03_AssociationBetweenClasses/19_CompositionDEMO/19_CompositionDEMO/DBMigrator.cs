using System;
namespace _19_CompositionDEMO
{
    public class DBMigrator
    {
        private readonly Logger _logger;

        public DBMigrator(Logger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            this._logger.Log("We are migrating. blah blah blah.");
        }
    }
}
