using System;
using NUnit.Framework;

namespace CSharpExtensions.Tests
{
	[TestFixture]
	public class StringExtensionsTests
	{
		[TestCase(null, true)]
		[TestCase("", true)]
		[TestCase(" ", false)]
		[TestCase("test", false)]
		public void IsNullOrEmpty(string value, bool result)
		{
			Assert.AreEqual(result, value.IsNullOrEmpty());
		}

		[TestCase(null, false)]
		[TestCase("", false)]
		[TestCase(" ", true)]
		[TestCase("test", true)]
		public void IsNotNullOrEmpty(string value, bool result)
		{
			Assert.AreEqual(result, value.IsNotNullOrEmpty());
		}

		[TestCase(null, true)]
		[TestCase("", true)]
		[TestCase(" ", true)]
		[TestCase("test", false)]
		public void IsNullOrWhiteSpace(string value, bool result)
		{
			Assert.AreEqual(result, value.IsNullOrWhiteSpace());
		}

		[TestCase(null, false)]
		[TestCase("", false)]
		[TestCase(" ", false)]
		[TestCase("test", true)]
		public void IsNotNullOrWhiteSpace(string value, bool result)
		{
			Assert.AreEqual(result, value.IsNotNullOrWhiteSpace());
		}

		[TestCase(null, null, false)]
		[TestCase("", "", false)]
		[TestCase(" ", " ", false)]
		[TestCase("test", "test", false)]
		[TestCase(null, "", true)]
		[TestCase(null, " ", true)]
		[TestCase(null, "test", true)]
		[TestCase("", null, true)]
		[TestCase("", " ", true)]
		[TestCase("", "test", true)]
		[TestCase(" ", null, true)]
		[TestCase(" ", "", true)]
		[TestCase(" ", "test", true)]
		[TestCase("test", null, true)]
		[TestCase("test", "", true)]
		[TestCase("test", " ", true)]
		[TestCase("test", "testing", true)]
		[TestCase("test", "Test", true)]
		public void NotEquals(string value, string otherValue, bool result)
		{
			Assert.AreEqual(result, value.NotEquals(otherValue));
		}

		[TestCase(null, null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("", "", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(" ", " ", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", "test", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", "Test", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(null, "", StringComparison.InvariantCultureIgnoreCase, true)]
		[TestCase(null, " ", StringComparison.InvariantCultureIgnoreCase, true)]
		[TestCase(null, "test", StringComparison.InvariantCultureIgnoreCase, true)]
		[TestCase("", null, StringComparison.InvariantCultureIgnoreCase, true)]
		[TestCase(" ", null, StringComparison.InvariantCultureIgnoreCase, true)]
		[TestCase("test", null, StringComparison.InvariantCultureIgnoreCase, true)]
		[TestCase("test", "testing", StringComparison.InvariantCultureIgnoreCase, true)]
		public void NotEquals_ComparisonType(string value, string otherValue, StringComparison comparisonType, bool result)
		{
			Assert.AreEqual(result, value.NotEquals(otherValue, comparisonType));
		}

		[TestCase(null, null, false)]
		[TestCase(null, "", false)]
		[TestCase(null, " ", false)]
		[TestCase(null, "test", false)]
		[TestCase("", "", false)]
		[TestCase("", null, false)]
		[TestCase(" ", null, false)]
		[TestCase("test", null, false)]
		[TestCase("test", "testing", false)]
		[TestCase("test", "Test", false)]
		[TestCase(" ", " ", true)]
		[TestCase("test", "test", true)]
		public void IsNotNullOrEmptyAndEquals(string value, string otherValue, bool result)
		{
			Assert.AreEqual(result, value.IsNotNullOrEmptyAndEquals(otherValue));
		}

		[TestCase(null, null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(null, "", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(null, " ", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(null, "test", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("", "", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("", null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(" ", null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", "testing", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", "Test", StringComparison.InvariantCultureIgnoreCase, true)]
		[TestCase(" ", " ", StringComparison.InvariantCultureIgnoreCase, true)]
		[TestCase("test", "test", StringComparison.InvariantCultureIgnoreCase, true)]
		public void IsNotNullOrEmptyAndEquals_ComparisonType(string value, string otherValue, StringComparison comparisonType, bool result)
		{
			Assert.AreEqual(result, value.IsNotNullOrEmptyAndEquals(otherValue, comparisonType));
		}

		[TestCase(null, null, false)]
		[TestCase(null, "", false)]
		[TestCase(null, " ", false)]
		[TestCase(null, "test", false)]
		[TestCase("", "", false)]
		[TestCase("", null, false)]
		[TestCase(" ", null, false)]
		[TestCase("test", null, false)]
		[TestCase("test", "testing", false)]
		[TestCase("test", "Test", false)]
		[TestCase(" ", " ", false)]
		[TestCase("test", "test", true)]
		public void IsNotNullOrWhiteSpaceAndEquals(string value, string otherValue, bool result)
		{
			Assert.AreEqual(result, value.IsNotNullOrWhiteSpaceAndEquals(otherValue));
		}

		[TestCase(null, null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(null, "", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(null, " ", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(null, "test", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("", "", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("", null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(" ", null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", "testing", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(" ", " ", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", "Test", StringComparison.InvariantCultureIgnoreCase, true)]
		[TestCase("test", "test", StringComparison.InvariantCultureIgnoreCase, true)]
		public void IsNotNullOrWhiteSpaceAndEquals_ComparisonType(string value, string otherValue, StringComparison comparisonType, bool result)
		{
			Assert.AreEqual(result, value.IsNotNullOrWhiteSpaceAndEquals(otherValue, comparisonType));
		}

		[TestCase(null, null, false)]
		[TestCase(null, "", false)]
		[TestCase(null, " ", false)]
		[TestCase(null, "test", false)]
		[TestCase("", "", false)]
		[TestCase("", null, false)]
		[TestCase(" ", null, false)]
		[TestCase("test", null, false)]
		[TestCase("test", "test", false)]
		[TestCase(" ", " ", false)]
		[TestCase("test", "Test", true)]
		[TestCase("test", "testing", true)]
		public void IsNotNullOrEmptyAndNotEquals(string value, string otherValue, bool result)
		{
			Assert.AreEqual(result, value.IsNotNullOrEmptyAndNotEquals(otherValue));
		}

		[TestCase(null, null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(null, "", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(null, " ", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(null, "test", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("", "", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("", null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(" ", null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", "test", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(" ", " ", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", "Test", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", "testing", StringComparison.InvariantCultureIgnoreCase, true)]
		public void IsNotNullOrEmptyAndNotEquals_ComparisonType(string value, string otherValue, StringComparison comparisonType, bool result)
		{
			Assert.AreEqual(result, value.IsNotNullOrEmptyAndNotEquals(otherValue, comparisonType));
		}

		[TestCase(null, null, false)]
		[TestCase(null, "", false)]
		[TestCase(null, " ", false)]
		[TestCase(null, "test", false)]
		[TestCase("", "", false)]
		[TestCase("", null, false)]
		[TestCase(" ", null, false)]
		[TestCase(" ", " ", false)]
		[TestCase("test", null, false)]
		[TestCase("test", "test", false)]
		[TestCase("test", "Test", true)]
		[TestCase("test", "testing", true)]
		public void IsNotNullOrWhiteSpaceAndNotEquals(string value, string otherValue, bool result)
		{
			Assert.AreEqual(result, value.IsNotNullOrWhiteSpaceAndNotEquals(otherValue));
		}

		[TestCase(null, null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(null, "", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(null, " ", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(null, "test", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("", "", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("", null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(" ", null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", null, StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase(" ", " ", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", "test", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", "Test", StringComparison.InvariantCultureIgnoreCase, false)]
		[TestCase("test", "testing", StringComparison.InvariantCultureIgnoreCase, true)]
		public void IsNotNullOrWhiteSpaceAndNotEquals_ComparisonType(string value, string otherValue, StringComparison comparisonType, bool result)
		{
			Assert.AreEqual(result, value.IsNotNullOrWhiteSpaceAndNotEquals(otherValue, comparisonType));
		}
	}
}