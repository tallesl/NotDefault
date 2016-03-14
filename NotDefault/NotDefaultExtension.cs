namespace NotDefaultLibrary
{
    using System.Collections.Generic;

    public static class NotDefaultExtension
    {
        /// <summary>
        /// Returns true if T is default(T), false otherwise.
        /// </summary>
        /// <typeparam name="T">Type to check</typeparam>
        /// <param name="obj">Object to check</param>
        /// <returns>If T is default(T)</returns>
        public static bool NotDefault<T>(this T obj)
        {
            return !EqualityComparer<T>.Default.Equals(obj, default(T));
        }
    }
}
