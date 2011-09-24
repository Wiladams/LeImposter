
namespace JavaScript
{
    public static class Math
    {
        static System.Random rng = new System.Random();

        public const double E = 2.718281828459045;
        public const double LN2 = 0.6931471805599453;
        public const double LN10 = 2.302585092994046;
        public const double LOG2E = 1.4426950408889634;
        public const double LOG10E = 0.4342944819032518;
        public const double PI = 3.14159265358979323846;
        public const double SQRT1_2 = 0.7071067811865476;
        public const double SQRT2 = 1.4142135623730951;

        #region Arithmetic Methods
        // abs
        public static double abs(double x)
        {
            if (x < 0)
                return -x;
            return x;
        }

        // ceil
        public static int ceil(double x)
        {
            return (int)System.Math.Ceiling(x);
        }

        // exp
        public static double exp(double x)
        {
            return System.Math.Exp(x);
        }

        // floor
        public static int floor(double x)
        {
            return (int)System.Math.Floor(x);
        }

        // log
        public static double log(double x)
        {
            return System.Math.Log(x);
        }

        // max
        public static double max(double x, double y)
        {
            return x > y ? x : y;
        }

        // min
        public static double min(double x, double y)
        {
            return x < y ? x : y;
        }

        // pow
        public static float pow(double num, double exponent)
        {
            return (float)System.Math.Pow(num, exponent);
        }

        // round
        public static int round(double value)
        {
            return (int)System.Math.Round(value, System.MidpointRounding.AwayFromZero);
        }

        // sqrt
        public static double sqrt(double x)
        {
            return System.Math.Sqrt(x);
        }
        #endregion

        #region Trigonometry
        const double degToRad = (PI / 180);
        const double radToDeg = (180.0f / PI);

        // degrees
        static public double degrees(double radian)
        {
            return radian * radToDeg;
        }

        // radians
        static public double radians(double degree)
        {
            return degree * degToRad;
        }

        // cos
        public static float cos(float x)
        {
            return (float)System.Math.Cos(x);
        }

        // acos
        public static float acos(float v)
        {
            return (float)System.Math.Acos(v);
        }

        // sin
        public static float sin(float x)
        {
            return (float)System.Math.Sin(x);
        }

        // asin
        public static float asin(float x)
        {
            return (float)System.Math.Asin(x);
        }

        // tan
        public static float tan(float x)
        {
            return (float)System.Math.Tan(x);
        }

        // atan
        public static float atan(float x)
        {
            return (float)System.Math.Atan(x);
        }

        // atan2
        public static float atan2(float y, float x)
        {
            return (float)System.Math.Atan2(y, x);
        }
        #endregion Trigonometry

    }
}
