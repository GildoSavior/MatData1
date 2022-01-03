using System;
using System.Collections.Generic;

namespace MatData
{
    public static class Helpers
    {
        public static string[] StringToArray(string text)
        {
            if (!text.Contains(","))
            {
                return new string[] { text };
            }

            if (string.IsNullOrEmpty(text))
            {
                return new string[] { };
            }

            var parts = text.Split(",");

            var list = new List<string>();

            foreach (var parte in parts)
            {
                list.Add(parte.TrimStart());
            }

            return list.ToArray();
        }
    }
}
