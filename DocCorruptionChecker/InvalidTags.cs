﻿using System.Collections.Generic;

namespace DocCorruptionChecker
{
    class InvalidTags
    {
        /// <summary>
        /// This section contains the RegEx strings that are used to parse the document and find the invalid tags
        /// Invalid xml strings stored with their explicit values since the matches will be exact
        /// this happens with multiple namespaces; seems like wps, wpg, wpi and wpc are the most common
        /// <mc:AlternateContent><mc:Choice Requires="wps"><m:oMath>
        /// Escape character value
        /// <mc:AlternateContent><mc:Choice Requires=\"wps\"><m:oMath>
        /// There is also a corruption that happens with textboxes not getting closed out correctly
        /// </summary>
        public const string strInvalidOmathWps = "<mc:AlternateContent><mc:Choice Requires=\"wps\"><m:oMath>";
        public const string strInvalidOmathWpg = "<mc:AlternateContent><mc:Choice Requires=\"wpg\"><m:oMath>";
        public const string strInvalidOmathWpi = "<mc:AlternateContent><mc:Choice Requires=\"wpi\"><m:oMath>";
        public const string strInvalidOmathWpc = "<mc:AlternateContent><mc:Choice Requires=\"wpc\"><m:oMath>";
        public const string strInvalidVshape = "</w:txbxContent></w:pict></mc:Fallback></mc:AlternateContent>";

        /// <summary>
        /// This section contains the RegEx values to check for invalid tags that are not always the exact same sequence
        /// instead of using exact matches, the RegEx will look for patterns of incorrect xml tags that I've come across
        /// "strInvalidmcChoiceRegEx" checks for any tag after </mc:Choice> that isn't any of the 3 valid patterns
        /// "strInvalidFallbackRegEx" checks for the following:
        /// 1. <mc:Fallback><w:pict/> - sometimes there is no end tag so we can just omit the fallback
        /// 2. <mc:Fallback><w:pict/></mc:Fallback> - this case has an actual end tag for the fallback, but it's still invalid so we can omit the tag completely
        /// </summary>
        public const string strInvalidMcChoiceRegex = @"(</mc:Choice>)(<(.).*?(/>|>))";
        public const string strInvalidFallbackRegex = @"(<mc:Fallback><w:pict/>)(<(.).*?(/>|>))";

        public IEnumerable<string> invalidXmlTags()
        {
            yield return strInvalidOmathWps;
            yield return strInvalidOmathWpg;
            yield return strInvalidOmathWpi;
            yield return strInvalidOmathWpc;
            yield return strInvalidMcChoiceRegex;
            yield return strInvalidFallbackRegex;
            yield return strInvalidVshape;
        }
    }
}
