using System.Net.Http;
using System.Threading.Tasks;

namespace Parcer_test.Core
{
    internal class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader (IParserSettings settings)
        {
            url = $"{settings.BaseUrl}/{settings.Prefix}";
        }


    }
}
