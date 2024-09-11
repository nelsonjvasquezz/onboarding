using System;

namespace onboarding.extensions
{
    public static class EnumParseExtensions
    {
        public static T EnumParse<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }
    }
}
