using System;

namespace Ccd.GuardExample
{
     /// <summary>
    /// A basic guard
    /// </summary>
    public static class Guard 
    {
        /// <summary>
        /// Throws an exception if the <paramref name="value"/> is null.
        /// </summary>
        /// <param name="argumentName">The name of the argument that is validated</param>
        /// <param name="value">The value of the argument that is validated</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void IsNotNull(string argumentName, object value)
        {
            if (value == null)
                throw new ArgumentNullException(argumentName);
        }

        /// <summary>
        /// Throws an exception if the <paramref name="value"/> is null or empty.
        /// </summary>
        /// <param name="argumentName">The name of the argument that is validated</param>
        /// <param name="value">The value of the argument that is validated</param>
        /// <exception cref="ArgumentException">If the value is empty</exception>
        /// <exception cref="ArgumentNullException">If the value is null</exception>
        public static void IsNotEmpty(string argumentName, string value)
        {
            IsNotNull(argumentName, value);

            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Value cannot be empty", argumentName);
        }

        /// <summary>
        /// Throws an exception if <paramref name="value"/> is a negative number.
        /// </summary>
        /// <param name="argumentName">The name of the argument that is validated</param>
        /// <param name="value">The value of the argument that is validated</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void IsPositive(string argumentName, int value)
        {
            IsInRange(argumentName, value, 0, int.MaxValue);
        }

        /// <summary>
        /// Throws an exception if <paramref name="value"/> is not in the range <paramref name="minValue"/> to <paramref name="maxValue"/> (inclusive).
        /// </summary>
        /// <param name="argumentName">The name of the argument that is validated</param>
        /// <param name="value">The value of the argument that is validated</param>
        /// <param name="minValue">The minimum value</param>
        /// <param name="maxValue">The maxsimum value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void IsInRange(string argumentName, int value, int minValue, int maxValue)
        {
            if (value > maxValue || value < minValue)
                throw new ArgumentOutOfRangeException(argumentName, value, $"The value '{value}' is not in range {minValue}..{maxValue}.");
        }

        /// <summary>
        /// Throws an exception if <paramref name="value"/> is not in the range <paramref name="minValue"/> to <paramref name="maxValue"/> (inclusive).
        /// </summary>
        /// <param name="argumentName">The name of the argument that is validated</param>
        /// <param name="value">The value of the argument that is validated</param>
        /// <param name="minValue">The minimum value</param>
        /// <param name="maxValue">The maxsimum value</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void IsInRange(string argumentName, double value, double minValue, double maxValue)
        {
            if (value > maxValue || value < minValue)
                throw new ArgumentOutOfRangeException(argumentName, value, $"The value '{value}' is not in range {minValue}..{maxValue}.");
        }
    }
}
