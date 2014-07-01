using System.Web.Mvc;

namespace OndeComprar.MVC.Areas.Gerencial
{
    public class GerencialAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Gerencial";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Gerencial_default",
                "Gerencial/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
