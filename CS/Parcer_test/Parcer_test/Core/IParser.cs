using AngleSharp.Html.Dom;

namespace Parcer_test.Core
{
    internal interface IParser<T> where T : class
    {
        T Parce(IHtmlDocument document);
    }
}
