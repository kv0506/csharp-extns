using System;

namespace CSharpExtensions
{
	public static class StringExtensions
	{
		/// <summary>Indicates whether this instance is null or an <see cref="F:System.String.Empty"></see> string.</summary>
		/// <param name="value">The string instance.</param>
		/// <returns><c>true</c> if this instance is null or an empty string (""); otherwise, <c>false</c>.</returns>
		public static bool IsNullOrEmpty(this string value)
		{
			return string.IsNullOrEmpty(value);
		}

		/// <summary>Indicates whether this instance is not null or an <see cref="F:System.String.Empty"></see> string.</summary>
		/// <param name="value">The string instance.</param>
		/// <returns><c>true</c> if this instance is not null or an empty string (""); otherwise, <c>false</c>.</returns>
		public static bool IsNotNullOrEmpty(this string value)
		{
			return !string.IsNullOrEmpty(value);
		}

		/// <summary>Indicates whether this instance is null or an <see cref="F:System.String.Empty"></see> string or whitespaces.</summary>
		/// <param name="value">The string instance.</param>
		/// <returns><c>true</c> if this instance is null or an empty string ("") or whitespaces; otherwise, <c>false</c>.</returns>
		public static bool IsNullOrWhiteSpace(this string value)
		{
			return string.IsNullOrWhiteSpace(value);
		}

		/// <summary>Indicates whether this instance is not null or an <see cref="F:System.String.Empty"></see> string or whitespaces.</summary>
		/// <param name="value">The string instance.</param>
		/// <returns><c>true</c> if this instance is not null or an empty string ("") or whitespaces; otherwise, <c>false</c>.</returns>
		public static bool IsNotNullOrWhiteSpace(this string value)
		{
			return !string.IsNullOrWhiteSpace(value);
		}

		/// <summary>
		/// Determines whether this instance and another specified <see cref="T:System.String"></see> object do not have the same value.
		/// </summary>
		/// <param name="value">The string instance.</param>
		/// <param name="otherValue">The string to compare to this instance.</param>
		/// <returns><c>true</c> if the value of the <paramref name="otherValue">value</paramref> parameter is not same as the value of this instance; otherwise, <c>false</c>.</returns>
		public static bool NotEquals(this string value, string otherValue)
		{
			if (value == null && otherValue == null)
				return false;

			if (value == null || otherValue == null)
				return true;

			return !value.Equals(otherValue);
		}

		/// <summary>
		/// Determines whether this instance and another specified <see cref="T:System.String"></see> object do not have the same value.
		/// </summary>
		/// <param name="value">The string instance.</param>
		/// <param name="otherValue">The string to compare to this instance.</param>
		/// <param name="comparisonType">Type of the comparison.</param>
		/// <returns><c>true</c> if the value of the <paramref name="otherValue">value</paramref> parameter is not same as the value of this instance; otherwise, <c>false</c>.</returns>
		public static bool NotEquals(this string value, string otherValue, StringComparison comparisonType)
		{
			if (value == null && otherValue == null)
				return false;

			if (value == null || otherValue == null)
				return true;

			return !value.Equals(otherValue, comparisonType);
		}

		/// <summary>
		/// Determines whether this instance and another specified <see cref="T:System.String"></see> object are not null or an <see cref="F:System.String.Empty"></see> string and have the same value.
		/// </summary>
		/// <param name="value">The string instance.</param>
		/// <param name="otherValue">The string to compare to this instance.</param>
		/// <returns>
		///   <c>true</c> if the value of the <paramref name="otherValue">value</paramref> parameter and this instance are not null or an empty string ("") and have the same value; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNotNullOrEmptyAndEquals(this string value, string otherValue)
		{
			return value.IsNotNullOrEmpty() && otherValue.IsNotNullOrEmpty() && value.Equals(otherValue);
		}

		/// <summary>
		/// Determines whether this instance and another specified <see cref="T:System.String"></see> object are not null or an <see cref="F:System.String.Empty"></see> string and have the same value.
		/// </summary>
		/// <param name="value">The string instance.</param>
		/// <param name="otherValue">The string to compare to this instance.</param>
		/// <param name="comparisonType">Type of the comparison.</param>
		/// <returns>
		///   <c>true</c> if the value of the <paramref name="otherValue">value</paramref> parameter and this instance are not null or an empty string ("") and have the same value; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNotNullOrEmptyAndEquals(this string value, string otherValue, StringComparison comparisonType)
		{
			return value.IsNotNullOrEmpty() && otherValue.IsNotNullOrEmpty() && value.Equals(otherValue, comparisonType);
		}

		/// <summary>
		/// Determines whether this instance and another specified <see cref="T:System.String"></see> object are not null or an <see cref="F:System.String.Empty"></see> string or whitespaces and have the same value.
		/// </summary>
		/// <param name="value">The string instance.</param>
		/// <param name="otherValue">The string to compare to this instance.</param>
		/// <returns>
		///   <c>true</c> if the value of the <paramref name="otherValue">value</paramref> parameter and this instance are not null or an empty string ("") or whitespaces and have the same value; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNotNullOrWhiteSpaceAndEquals(this string value, string otherValue)
		{
			return value.IsNotNullOrWhiteSpace() && otherValue.IsNotNullOrWhiteSpace() && value.Equals(otherValue);
		}

		/// <summary>
		/// Determines whether this instance and another specified <see cref="T:System.String"></see> object are not null or an <see cref="F:System.String.Empty"></see> string or whitespaces and have the same value.
		/// </summary>
		/// <param name="value">The string instance.</param>
		/// <param name="otherValue">The string to compare to this instance.</param>
		/// <param name="comparisonType">Type of the comparison.</param>
		/// <returns>
		///   <c>true</c> if the value of the <paramref name="otherValue">value</paramref> parameter and this instance are not null or an empty string ("") or whitespaces and have the same value; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNotNullOrWhiteSpaceAndEquals(this string value, string otherValue, StringComparison comparisonType)
		{
			return value.IsNotNullOrWhiteSpace() && otherValue.IsNotNullOrWhiteSpace() && value.Equals(otherValue, comparisonType);
		}

		/// <summary>
		/// Determines whether this instance and another specified <see cref="T:System.String"></see> object are not null or an <see cref="F:System.String.Empty"></see> string and do not have the same value.
		/// </summary>
		/// <param name="value">The string instance.</param>
		/// <param name="otherValue">The string to compare to this instance.</param>
		/// <returns>
		///   <c>true</c> if the value of the <paramref name="otherValue">value</paramref> parameter and this instance are not null or an empty string ("") and do not have the same value; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNotNullOrEmptyAndNotEquals(this string value, string otherValue)
		{
			return value.IsNotNullOrEmpty() && otherValue.IsNotNullOrEmpty() && value.NotEquals(otherValue);
		}

		/// <summary>
		/// Determines whether this instance and another specified <see cref="T:System.String"></see> object are not null or an <see cref="F:System.String.Empty"></see> string and do not have the same value.
		/// </summary>
		/// <param name="value">The string instance.</param>
		/// <param name="otherValue">The string to compare to this instance.</param>
		/// <param name="comparisonType">Type of the comparison.</param>
		/// <returns>
		///   <c>true</c> if the value of the <paramref name="otherValue">value</paramref> parameter and this instance are not null or an empty string ("") and do not have the same value; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNotNullOrEmptyAndNotEquals(this string value, string otherValue, StringComparison comparisonType)
		{
			return value.IsNotNullOrEmpty() && otherValue.IsNotNullOrEmpty() && value.NotEquals(otherValue, comparisonType);
		}

		/// <summary>
		/// Determines whether this instance and another specified <see cref="T:System.String"></see> object are not null or an <see cref="F:System.String.Empty"></see> string or whitespaces and do not have the same value.
		/// </summary>
		/// <param name="value">The string instance.</param>
		/// <param name="otherValue">The string to compare to this instance.</param>
		/// <returns>
		///   <c>true</c> if the value of the <paramref name="otherValue">value</paramref> parameter and this instance are not null or an empty string ("") or whitespaces and do not have the same value; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNotNullOrWhiteSpaceAndNotEquals(this string value, string otherValue)
		{
			return value.IsNotNullOrWhiteSpace() && otherValue.IsNotNullOrWhiteSpace() && value.NotEquals(otherValue);
		}

		/// <summary>
		/// Determines whether this instance and another specified <see cref="T:System.String"></see> object are not null or an <see cref="F:System.String.Empty"></see> string or whitespaces and do not have the same value.
		/// </summary>
		/// <param name="value">The string instance.</param>
		/// <param name="otherValue">The string to compare to this instance.</param>
		/// <param name="comparisonType">Type of the comparison.</param>
		/// <returns>
		///   <c>true</c> if the value of the <paramref name="otherValue">value</paramref> parameter and this instance are not null or an empty string ("") or whitespaces and do not have the same value; otherwise, <c>false</c>.
		/// </returns>
		public static bool IsNotNullOrWhiteSpaceAndNotEquals(this string value, string otherValue, StringComparison comparisonType)
		{
			return value.IsNotNullOrWhiteSpace() && otherValue.IsNotNullOrWhiteSpace() && value.NotEquals(otherValue, comparisonType);
		}
	}
}
