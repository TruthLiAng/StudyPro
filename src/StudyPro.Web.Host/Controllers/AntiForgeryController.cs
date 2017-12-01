using Microsoft.AspNetCore.Antiforgery;
using StudyPro.Controllers;

namespace StudyPro.Web.Host.Controllers
{
    public class AntiForgeryController : StudyProControllerBase
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
