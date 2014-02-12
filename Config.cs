using Latino;

namespace Latino.Workflows
{
    public static class Config
    {
        public static readonly string RssFeedComponent_DefaultRssXmlEncoding
            = Utils.GetConfigValue("RssFeedComponent_DefaultRssXmlEncoding", "ISO-8859-1");
        public static readonly string RssFeedComponent_DefaultHtmlEncoding
            = Utils.GetConfigValue("RssFeedComponent_DefaultHtmlEncoding", "ISO-8859-1");
    }
}
