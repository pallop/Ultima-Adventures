using System;

namespace Server
{
    public static class Translation
    {
        public static Func<string, string> TranslateToSpanish { get; set; }
        public static Func<string, string> TranslateToEnglish { get; set; }
        public static Func<int, string, string> TranslateCliloc { get; set; }
    }
}
