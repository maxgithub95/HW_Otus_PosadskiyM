namespace HW_13
{
    public static class IEnumerableExtention
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percent)
        {
            if ((percent < 0) || (percent > 100)) throw new ArgumentException();
            int countToExtract = (int)Math.Round((double)collection.Count() * percent / 100, MidpointRounding.ToPositiveInfinity);
            //вариант с отложенным выполнением:
            for (int i = collection.Count() - 1; i >= (collection.Count() - countToExtract); i--)
            {
                yield return collection.ElementAt<T>(i);
            }
            //реализовал также вариант в более коротком виде, но с немедленным выполнением:
            //return collection.Take((collection.Count() - countToExtract)..collection.Count()).Reverse();
            //оба метода работают, но для них нужен разный способ отлавливания исключений в main
        }
        public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percent, Func<T, int> field)
        {
            if ((percent < 0) || (percent > 100)) throw new ArgumentException();

            var sortCollection = collection.OrderBy(field);
            int countToExtract = (int)Math.Round((double)collection.Count() * percent / 100, MidpointRounding.ToPositiveInfinity);
            for (int i = collection.Count() - 1; i >= (collection.Count() - countToExtract); i--)
            {
                yield return sortCollection.ElementAt<T>(i);
            }
        }
    }
}
