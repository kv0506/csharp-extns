using System.Collections.Generic;

namespace CSharpExtensions
{
	public static class CollectionExtensions
	{
		/// <summary>
		/// Adds the list of objects to the end of <see cref="F:System.Collections.Generic.ICollection"></see>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="values">The values.</param>
		public static void AddRange<T>(this ICollection<T> collection, ICollection<T> values)
		{
			foreach (var value in values)
			{
				collection.Add(value);
			}
		}
	}
}
