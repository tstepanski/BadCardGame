using System.Web.Mvc;

namespace BadCardGame.Web
{
    public sealed class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) => filters.Add(new HandleErrorAttribute());
    }
}