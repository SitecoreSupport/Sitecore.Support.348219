using Sitecore.Diagnostics;
using Sitecore.Modules.EmailCampaign.Core.HostnameMapping;
using System;
using System.Collections.Generic;

namespace Sitecore.Modules.EmailCampaign.Core.Pipelines.GenerateLink
{
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
