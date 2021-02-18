using System;

namespace Hnpwa.Shared
{
    public static class Helpers
    {
        public static string GetDomainName(string? url, bool withParenthesis = false)
        {
            if(url == null)
                return "";
            Uri uri = new Uri(url);
            string[] domainNameSplit = uri.Host.Split('.', 2);

            string result;
            if(domainNameSplit[0] == "www")
                result = domainNameSplit[1];
            else
                result = uri.Host;
            if(withParenthesis)
                return '(' + result + ')';
            return result;
        }

        public static string TimeAgo(DateTimeOffset? dtOffset)
        {
            if(dtOffset == null)
                return string.Empty;

            if (dtOffset > DateTimeOffset.Now)
                return "about sometime from now";
            
            TimeSpan span = (DateTimeOffset.Now - dtOffset).GetValueOrDefault();

            if (span.Days > 365)
            {
                int years = (span.Days / 365);
                if (span.Days % 365 != 0)
                    years += 1;
                return String.Format("about {0} {1} ago", years, years == 1 ? "year" : "years");
            }

            if (span.Days > 30)
            {
                int months = (span.Days / 30);
                if (span.Days % 31 != 0)
                    months += 1;
                return String.Format("about {0} {1} ago", months, months == 1 ? "month" : "months");
            }

            if (span.Days > 0)
                return String.Format("about {0} {1} ago", span.Days, span.Days == 1 ? "day" : "days");

            if (span.Hours > 0)
                return String.Format("about {0} {1} ago", span.Hours, span.Hours == 1 ? "hour" : "hours");

            if (span.Minutes > 0)
                return String.Format("about {0} {1} ago", span.Minutes, span.Minutes == 1 ? "minute" : "minutes");

            return "just now";
        }
    }
}