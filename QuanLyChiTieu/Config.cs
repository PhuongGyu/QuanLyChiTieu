namespace Demo
{
    public static class Config
    {
        private static string username = "";
        private static string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=SPENDMANAGEMENT;User ID=sa;Password=123456";

        public static string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public static string ConnectionSTR
        {
            get
            {
                return connectionSTR;
            }

            set
            {
                connectionSTR = value;
            }
        }
    }
}