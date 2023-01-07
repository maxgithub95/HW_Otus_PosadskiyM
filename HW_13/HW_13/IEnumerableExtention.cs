namespace HW_13
{
    public static class IEnumerableExtention
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percent)
        {
            if ((percent < 0) || (percent > 100)) throw new ArgumentException();
            var sortCollection = collection.OrderByDescending(collection => collection);
            int countToExtract = (int)Math.Round((double)collection.Count() * percent / 100, MidpointRounding.ToPositiveInfinity);
            return sortCollection.Take(countToExtract);
        }
        public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percent, Func<T, int> field)
        {
            if ((percent < 0) || (percent > 100)) throw new ArgumentException();

            var sortCollection = collection.OrderByDescending(field);
            int countToExtract = (int)Math.Round((double)collection.Count() * percent / 100, MidpointRounding.ToPositiveInfinity);
            return sortCollection.Take(countToExtract);
        }
    }
}
