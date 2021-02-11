using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413_Assignment4.Models
{
    public class TempStorage
    {
        private static List<Suggestion> suggestions = new List<Suggestion>();

        public static IEnumerable<Suggestion> Suggestions => suggestions;

        public static void AddApplication(Suggestion response)
        {
            suggestions.Add(response);
        }
    }
}
