﻿using System;

namespace Framework
{
    /// <summary>
    /// Utilities for doing common string operations.
    /// </summary>
    public static class StringUtils
    {
        /// <summary>
        /// Gets a byte count as a nicely formatted string.
        /// </summary>
        /// <param name="byteCount">The number of bytes.</param>
        /// <returns>The string representation.</returns>
        public static string BytesToString(long byteCount)
        {
            string[] suffix = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };

            if (byteCount == 0)
            {
                return $"0 {suffix[0]}";
            }

            var bytes = Math.Abs(byteCount);
            var place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1000.0)));
            var num = Math.Round(bytes / Math.Pow(1000.0, place), 1);
            return $"{Math.Sign(byteCount) * num} {suffix[place]}";
        }
    }
}
