using System;
namespace _19_CompositionDEMO
{
    public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            this._logger = logger;
        }

        public void Install()
        {
            this._logger.Log("We are installing the application");
        }
    }
}
