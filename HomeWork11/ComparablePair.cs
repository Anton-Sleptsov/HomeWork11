namespace HomeWork11
{
    internal class ComparablePair<T, U> : IComparable<ComparablePair<T, U>> 
        where T : IComparable<T> 
        where U : IComparable<U>
    {
        public T t {  get; }
        public U u { get; }

        public ComparablePair(T t, U u)
        {
            this.t = t;
            this.u = u;
        }

        public int CompareTo(ComparablePair<T, U>? other)
        {
            int tCompare = t.CompareTo(other.t);
            int uCompare = u.CompareTo(other.u);
            return tCompare == 0 ? uCompare : tCompare;
        }
    }
}
