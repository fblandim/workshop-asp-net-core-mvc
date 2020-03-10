using Microsoft.AspNetCore.Localization;
using System.Globalization;

namespace SalesWebMvc
{
    internal class RequestCuture : RequestCulture
    {
        public RequestCuture(CultureInfo culture) : base(culture)
        {
        }
    }
}