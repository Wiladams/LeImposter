
namespace JavaScript
{
    public class Number : JObject
    {
        public static readonly Number MAX_VALUE = new Number(double.MaxValue);
        public static readonly Number MIN_VALUE = new Number(double.MinValue);
        public static readonly Number NaN = new Number(double.NaN);
        public static readonly Number NEGATIVE_INFINITY = new Number(double.NegativeInfinity);
        public static readonly Number POSITIVE_INFINITY = new Number(double.PositiveInfinity);

        public double val;

        Number(double aValue)
        {
            val = aValue;
        }

        public static implicit operator double (Number aNum)
        {
            return aNum.val;
        }

        public static explicit operator Number(double aDouble)
        {
            return new Number(aDouble);
        }
    }
}
