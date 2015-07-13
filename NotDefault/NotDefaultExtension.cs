namespace NotDefault
{
    using System.Collections.Generic;

    public static class NotDefaultExtension
    {
        /// <summary>
        /// Returns true if T is default(T), false otherwise.
        /// </summary>
        /// <typeparam name="T">Type to check</typeparam>
        /// <param name="o">Object to check</param>
        /// <returns>If T is default(T)</returns>
        public static bool NotDefault<T>(this T o)
        {
            return !EqualityComparer<T>.Default.Equals(o, default(T));
        }
    }
}
