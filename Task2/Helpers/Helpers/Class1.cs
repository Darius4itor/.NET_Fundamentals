using System;

namespace Helpers
{
    public static class StringHelper
    {
        public static string GetGreatings(string username) => DateTime.Now.ToShortTimeString() + " Hello, " + username;
    }
}
