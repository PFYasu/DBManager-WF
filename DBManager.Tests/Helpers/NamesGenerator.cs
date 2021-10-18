using System;

namespace DBManager.Tests.Helpers
{
    public static class NamesGenerator
    {
        private const string Chars = "abcdefghijklmnopqrstuvwxyz";

        public static string Generate(uint length = 10)
        {
            var random = new Random();

            var generatedName = "";

            for (int i = 0; i < length; i++)
            {
                var selectedNumber = random.Next(0, Chars.Length);
                generatedName += Chars[selectedNumber];
            }

            return generatedName;
        }
    }
}
