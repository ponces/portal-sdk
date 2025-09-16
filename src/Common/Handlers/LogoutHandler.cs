using System.Threading.Tasks;

namespace Cmf.CustomerPortal.Sdk.Common.Handlers
{
    public class LogoutHandler : AbstractHandler
    {
        public LogoutHandler(ISession session) : base(session, false) { }

        public async override Task Run()
        {
            await EnsureLogin();

            Session.LogDebug("Logging out");

            Session.ClearSession();

            Session.LogInformation("User successfully logged out");
        }
    }
}
