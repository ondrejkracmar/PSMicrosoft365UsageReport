using System;
using System.Text.RegularExpressions;

namespace PSMicrosoft365UsageReport.Helper
{
    /// <summary>
    /// Utility class to handle the conversion of ISO 8601 duration strings to total seconds.
    /// </summary>
    public static class DurationToSecondsConverter
    {
        /// <summary>
        /// Converts an ISO 8601 duration string into the total number of seconds.
        /// Handles null or empty input gracefully by returning 0.
        /// Example valid inputs:
        /// - "P4DT45M50S" (4 days, 45 minutes, 50 seconds)
        /// - "PT45M50S" (45 minutes, 50 seconds)
        /// - "PT50S" (50 seconds)
        /// </summary>
        /// <param name="isoDuration">The ISO 8601 duration string to convert.</param>
        /// <returns>The total duration in seconds. Returns 0 if the input is null or empty.</returns>
        public static int ConvertIsoDurationToSeconds(string? isoDuration)
        {
            // Return 0 for null or empty input
            if (string.IsNullOrWhiteSpace(isoDuration))
            {
                return 0;
            }

            // Updated regular expression to parse ISO 8601 duration strings with optional components
            var regex = new Regex(@"P(?:(\d+)D)?T(?:(\d+)H)?(?:(\d+)M)?(?:(\d+)S)?");
            var match = regex.Match(isoDuration);

            // If the string doesn't match the expected format, throw an exception
            if (!match.Success)
            {
                throw new FormatException($"Invalid ISO 8601 duration format: '{isoDuration}'.");
            }

            // Extract values from the matched groups (days, hours, minutes, seconds)
            int days = string.IsNullOrEmpty(match.Groups[1].Value) ? 0 : int.Parse(match.Groups[1].Value);
            int hours = string.IsNullOrEmpty(match.Groups[2].Value) ? 0 : int.Parse(match.Groups[2].Value);
            int minutes = string.IsNullOrEmpty(match.Groups[3].Value) ? 0 : int.Parse(match.Groups[3].Value);
            int seconds = string.IsNullOrEmpty(match.Groups[4].Value) ? 0 : int.Parse(match.Groups[4].Value);

            // Calculate the total duration in seconds
            return (days * 86400) + (hours * 3600) + (minutes * 60) + seconds;
        }
    }
}