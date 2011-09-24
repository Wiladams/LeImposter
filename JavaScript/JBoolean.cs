namespace JavaScript
{
    public class JBoolean : JObject
    {
        public bool val;

        public JBoolean(bool value)
        {
            this.val = value;
        }

        public JBoolean(double value)
        {
            if (value == 0 ||
                value == -0 ||
                value == double.NaN)
                val = false;
            else
                val = true;
        }

        public JBoolean(string value)
        {
            if (value.ToLower() == "true")
                val = true;

            else if (value == null ||
                value.ToLower() == "false" ||
                value == string.Empty)
                val = false;
            else
                val = false;
        }
    }
}