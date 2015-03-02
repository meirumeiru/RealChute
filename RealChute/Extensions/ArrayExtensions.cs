﻿using System;

/* RealChute was made by Christophe Savard (stupid_chris). You are free to copy, fork, and modify RealChute as you see
 * fit. However, redistribution is only permitted for unmodified versions of RealChute, and under attribution clause.
 * If you want to distribute a modified version of RealChute, be it code, textures, configs, or any other asset and
 * piece of work, you must get my explicit permission on the matter through a private channel, and must also distribute
 * it through the attribution clause, and must make it clear to anyone using your modification of my work that they
 * must report any problem related to this usage to you, and not to me. This clause expires if I happen to be
 * inactive (no connection) for a period of 90 days on the official KSP forums. In that case, the license reverts
 * back to CC-BY-NC-SA 4.0 INTL.*/

namespace RealChute.Extensions
{
    public static class ArrayExtensions
    {
        #region Methods
        /// <summary>
        /// Finds the index of the first given element. Returns -1 if it fails
        /// </summary>
        /// <typeparam name="T">IEnumerable type</typeparam>
        /// <param name="value">Element to search for</param>
        public static int IndexOf<T>(this T[] array, T value)
        {
            return Array.IndexOf(array, value);
        }

        /// <summary>
        /// Executes the given action on all the elements of the array
        /// </summary>
        /// <typeparam name="T">Type of the array</typeparam>
        /// <param name="action">Action to execute on each member of the array</param>
        public static void ForEach<T>(this T[] array, Action<T> action)
        {
            Array.ForEach(array, action);
        }

        /// <summary>
        /// Returns true only if the given index is within the range of the array (above 0 and under the lenght)
        /// </summary>
        /// <typeparam name="T">Type of the array</typeparam>
        /// <param name="index">Index to use</param>
        public static bool IndexInRange<T>(this T[] array, int index)
        {
            return index > 0 && index < array.Length;
        }
        #endregion
    }
}