namespace HW_13
{
    public static class IEnumerableExtention
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percent)
        {
            if ((percent < 0) || (percent > 100)) throw new ArgumentException();
            var sortCollection = collection.OrderByDescending(collection=>collection);
            int countToExtract = (int)Math.Round((double)collection.Count() * percent / 100, MidpointRounding.ToPositiveInfinity);
            //вариант с отложенным выполнением:
            //for (int i = 0; i < countToExtract; i++)
            //{
            //    yield return sortCollection.ElementAt<T>(i);
            //}
            //реализовал также вариант в более коротком виде, но с немедленным выполнением, хотя в описании метода написано, что он также с отложенным выполнением :
            return sortCollection.Take(countToExtract);
            //оба метода работают, но для них нужен разный способ отлавливания исключений в main
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
