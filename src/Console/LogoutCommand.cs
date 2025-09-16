using Cmf.CustomerPortal.Sdk.Common.Handlers;
using Cmf.CustomerPortal.Sdk.Console.Base;
using System.CommandLine.Invocation;
using System.Threading.Tasks;

namespace Cmf.CustomerPortal.Sdk.Console
{
    class LogoutCommand : BaseCommand
    {
        public LogoutCommand() : this("logout", "Log out of the CMF Portal")
        {
        }

        public LogoutCommand(string name, string description = null) : base(name, description)
        {
            Handler = CommandHandler.Create(typeof(LogoutCommand).GetMethod(nameof(LogoutCommand.LogoutHandler)), this);
        }

        public async Task LogoutHandler(bool verbose)
        {
            // use logout handler to remove login information
            CreateSession(verbose);
            LogoutHandler logoutHandler = ServiceLocator.Get<LogoutHandler>();
            await logoutHandler.Run();
        }
    }
}
