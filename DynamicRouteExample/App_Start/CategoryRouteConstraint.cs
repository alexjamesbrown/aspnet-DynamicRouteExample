using System.Linq;
using System.Web;
using System.Web.Routing;

namespace DynamicRouteExample
{
    public class CategoryRouteConstraint : IRouteConstraint
    {
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            //these would usually come from a database, or cache.
            var categories = new[] { "restaurants", "cafes", "bistros" };

            if (values[parameterName] == null)
                return false;

            //get the category passed in to the route
            var category = values[parameterName].ToString();

            //now we check our categories, and see if it exists
            return categories.Any(x => x == category.ToLower());

            // url such as /category1/whatever will match
            // url such as /category4/whatever will not
        }
    }
}