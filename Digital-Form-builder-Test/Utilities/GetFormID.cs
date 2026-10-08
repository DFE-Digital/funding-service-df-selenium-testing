using System;
using System.Collections.Generic;
using System.Text;

namespace Digital_Form_builder_Test.Utilities
{
    public static class GetFormID
    {

        public static string GetFormIDFromUrl(string url)
        {
            return url.Substring(url.LastIndexOf('/') + 1);
        }
    }
}
