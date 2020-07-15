using System;

namespace CSharpExtensions
{
	public static class GuidExtensions
	{
		/// <summary>Indicates whether this instance is not null or an <see cref="F:System.Guid.Empty"></see> guid.</summary>
		/// <param name="value">The guid instance.</param>
		/// <returns><c>true</c> if this instance is not null or an empty guid; otherwise, <c>false</c>.</returns>
		public static bool IsNotNullOrEmpty(this Guid? value)
		{
			return value != null && value != Guid.Empty;
		}

		/// <summary>Indicates whether this instance is null or an <see cref="F:System.Guid.Empty"></see> guid.</summary>
		/// <param name="value">The guid instance.</param>
		/// <returns><c>true</c> if this instance is null or an empty guid; otherwise, <c>false</c>.</returns>
		public static bool IsNullOrEmpty(this Guid? value)
		{
			return value == null || value == Guid.Empty;
		}

		/// <summary>Indicates whether this instance is an <see cref="F:System.Guid.Empty"></see> guid.</summary>
		/// <param name="value">The guid instance.</param>
		/// <returns><c>true</c> if this instance is an empty guid; otherwise, <c>false</c>.</returns>
		public static bool IsEmpty(this Guid value)
		{
			return value == Guid.Empty;
		}

		/// <summary>Indicates whether this instance is not an <see cref="F:System.Guid.Empty"></see> guid.</summary>
		/// <param name="value">The guid instance.</param>
		/// <returns><c>true</c> if this instance is not an empty guid; otherwise, <c>false</c>.</returns>
		public static bool IsNotEmpty(this Guid value)
		{
			return value != Guid.Empty;
		}
	}
}
