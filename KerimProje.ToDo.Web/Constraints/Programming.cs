using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;

namespace KerimProje.ToDo.Web.Constraints
{
    public class Programming : IRouteConstraint
    {

        public List<string> ProgrammingLang = new List<string> { "csharp", "java", "php" };
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return ProgrammingLang.Contains(values[routeKey].ToString().ToLower());
        }
    }
}
