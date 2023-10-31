using System.Text.RegularExpressions;

namespace DevsPark.Utilities
{
    public static class Utils
    {
        public static string GetName(this ContentPage page)
        {
            return Regex.Replace(page.GetType().Name, "([a-z])([A-Z])", "$1 $2");
        }
    }
}
