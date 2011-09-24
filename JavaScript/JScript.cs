
namespace JavaScript
{

    public class JScript
    {

        #region Constants
        protected const float HALF_PI = 1.57079632679489661923f;
        protected const float QUARTER_PI = 0.7853982f;
        protected const float TWO_PI = 6.28318530717958647693f;
        #endregion Constants



        public static Number parseInt(string aString)
        {
            int anInt;
            if (int.TryParse(aString, out anInt))
                return (Number)anInt;

            // Throw an exception?
            return (Number)Number.NaN;

        }

        public static Number parseFloat(string aString)
        {
            float aFloat;
            if (float.TryParse(aString, out aFloat))
                return (Number)aFloat;

            // Throw exception?
            return (Number)Number.NaN;
        }

        public Number eval(string strExpression)
        {
            return Number.NaN;
        }

        public static bool isNaN(double aValue)
        {
            return (Number)aValue == Number.NaN;
        }
    }
}
