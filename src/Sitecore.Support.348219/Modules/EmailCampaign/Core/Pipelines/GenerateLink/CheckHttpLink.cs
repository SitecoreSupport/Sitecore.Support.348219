namespace Sitecore.Support.Modules.EmailCampaign.Core.Pipelines.GenerateLink
{
    using Sitecore.Diagnostics;
    using Sitecore.Modules.EmailCampaign.Core.Pipelines.GenerateLink;
    using System.Collections.Generic;
    public class CheckHttpLink : GenerateLinkProcessor
    {
        public override void Process(GenerateLinkPipelineArgs args)
        {
            Assert.IsNotNull(args, "Arguments can't be null");
            if (restrictedValues.Contains(args.Url))
            {
                args.Url = "";
            }
        }

        private List<string> restrictedValues = new List<string>()
        {
            "http://",
            "https://",
            "http",
            "https",
            "http:",
            "https:",
            "http:/",
            "https:/"
        };
    }
}
