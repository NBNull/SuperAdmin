using Microsoft.AspNetCore.Antiforgery;
using Super.Admin.Controllers;

namespace Super.Admin.Web.Host.Controllers
{
    public class AntiForgeryController : AdminControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
