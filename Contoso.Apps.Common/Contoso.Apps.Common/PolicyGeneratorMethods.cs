using System;
using System.Linq;

namespace Contoso.Apps.Common
{
    public class PolicyGeneratorMethods
    {
        private static readonly Random Random = new Random();

        /// <summary>
        /// Generates a Policy Number value based on the passed in last name and policy holder Id.
        /// </summary>
        /// <param name="lastName"></param>
        /// <param name="policyHolderId"></param>
        /// <returns></returns>
        public static string PolicyNumberGenerator(string lastName, int policyHolderId)
        {
            if (string.IsNullOrWhiteSpace(lastName))
                throw new ArgumentOutOfRangeException(nameof(lastName));

            const int randomStringLength = 8;
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var truncatedLName = lastName.ToUpperInvariant();

            if (truncatedLName.Length >= 3)
            {
                truncatedLName = truncatedLName.Substring(0, 3);
            }

            var rando = new string(Enumerable.Repeat(chars, randomStringLength)
                .Select(s => s[Random.Next(s.Length)]).ToArray());

            return $"{truncatedLName}{policyHolderId}{rando}";
        }

        public static string PdfFilenameGenerator(string lastName, string policyNumber)
        {
            return $"{lastName}-{policyNumber}.pdf";
        }
    }
}