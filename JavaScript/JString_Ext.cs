namespace JaveScript
{
    public static class JString_Ext
    {
        public static char charAt(this string str, int index)
        {
            return str[index];
        }

        public static int indexOf(this string str, string find)
        {
            return str.IndexOf(find);
        }

        public static int lastIndexOf(this string str, string find, int index)
        {
            return str.LastIndexOf(find, index);
        }

        public static string substring(this string str, int indexA, int indexB)
        {
            return str.Substring(indexA, indexB - indexA);
        }

        public static string escape(this string str)
        {
            return str;
        }

        public static string unescape(this string str)
        {
            return str;
        }
    }
}