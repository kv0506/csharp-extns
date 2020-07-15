using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CSharpExtensions
{
	public static class ObservableCollectionExtensions
	{
		/// <summary>
		/// Adds the list of objects to the end of <see cref="F:System.Collections.ObjectModel.ObservableCollection"></see>
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="collection">The collection.</param>
		/// <param name="values">The values.</param>
		public static void AddRange<T>(this ObservableCollection<T> collection, ICollection<T> values)
		{
			foreach (var value in values)
			{
				collection.Add(value);
			}
		}
	}
}
