using System;
using System.Collections.Generic;
using System.Data;

namespace Demo.DatabaseHelper
{
    public static class DatabaseProcess
    {
        // check username
        public static bool isExistsUsername(string username)
        {
            string query = string.Format("SELECT COUNT(*) FROM [USERACCOUNT] WHERE USERNAME = '{0}'", username);
            object result = DatabaseDAO.Instance.execScalar(query);
            if (result != null)
            {
                if (Convert.ToInt32(result) >= 1)
                    return true;
            }
            return false; 
        }
        // register
        public static bool register(string username, string password, int money = 0)
        {
            string query = string.Format("INSERT INTO [USERACCOUNT] VALUES ('{0}', '{1}', {2})", username, password, money.ToString());
            int rows = DatabaseDAO.Instance.setDataExec(query);
            if (rows != -1)
                return true;
            return false;
        }

        // login
        public static bool login(string username, string password)
        {
            string query = string.Format("EXEC sp_LOGIN '{0}', '{1}'", username, password);
            DataTable result = DatabaseDAO.Instance.getDataExec(query);
            if (result != null)
            {
                if (result.Rows.Count == 1)
                    return true;
            }
            return false;
        }


        // thêm chi tiêu vào database
        public static bool addSpend(Spend spend)
        {
            string query = string.Format("INSERT INTO [CHITIEU] (USERNAME, TENCT, SOTIEN, NGAYGIO) VALUES ('{0}', N'{1}', {2}, '{3}')", Config.Username, spend.Name, spend.Money.ToString(), spend.Date.ToString("yyyy-MM-dd HH:mm:ss"));
            int row = DatabaseDAO.Instance.setDataExec(query);
            if (row != -1)
                return true;
            return false;
        }
        // thêm tiền vào user
        public static bool updateMoney(int money)
        {
            string query = string.Format("EXEC sp_ADD_MONEY '{0}', {1}", Config.Username, money.ToString());
            int row = DatabaseDAO.Instance.setDataExec(query);
            if (row != -1)
                return true;
            return false;
        }
        // set money số tiền của user sẽ được cập nhật thành số tiền mới
        public static bool setMoney(int money)
        {
            string query = string.Format("UPDATE [USERACCOUNT] SET MONEY = {0} WHERE USERNAME = '{1}'", money.ToString(), Config.Username);
            int row = DatabaseDAO.Instance.setDataExec(query);
            if (row != -1)
                return true;
            return false;
        }


        // lấy ra số tiền hiện tại của user
        public static int getMoney()
        {
            int money = 0;
            string query = string.Format("SELECT MONEY FROM [USERACCOUNT] WHERE USERNAME = '{0}'", Config.Username);
            object ob = DatabaseDAO.Instance.execScalar(query);
            if (ob != null)
                money = Convert.ToInt32(ob);
            return money;
        }

        // lấy lịch sử chi tiêu theo ngày
        public static List<Spend> loadSpend(DateTime date)
        {
            string query = string.Format("EXEC sp_GET_SPEND '{0}', '{1}'", Config.Username, date.ToString("yyyy-MM-dd"));
            DataTable result = DatabaseDAO.Instance.getDataExec(query);
            if (result != null && result.Rows.Count >= 0)
            {
                List<Spend> listSpend = new List<Spend>();

                DataRowCollection rows = result.Rows;
                foreach(DataRow row in rows)
                {
                    Spend spend = new Spend();
                    if (spend == null)
                        return null;
                    spend.Name = row.ItemArray[1].ToString();
                    spend.Money = Convert.ToInt32(row.ItemArray[2]);
                    spend.Date = Convert.ToDateTime(row.ItemArray[3].ToString());

                    listSpend.Add(spend);
                }

                return listSpend;
            }
            return null;
        }

        // xóa một chi tiêu
        public static bool deleteSpend(Spend spend)
        {
            string query = string.Format("DELETE [CHITIEU] WHERE USERNAME = '{0}' AND NGAYGIO = '{1}'",Config.Username, spend.Date.ToString("yyyy-MM-DD HH:mm:ss"));
            int rows = DatabaseDAO.Instance.setDataExec(query);
            if (rows != -1)
                return true;
            return false;
        }

        // xóa nhiều chi tiêu theo ngày
        public static bool deleteSpends(DateTime date)
        {
            string query = string.Format("EXEC sp_DELETE_SPEND '{0}', '{1}'", Config.Username, date.ToString("yyyy-MM-dd"));
            int rows = DatabaseDAO.Instance.setDataExec(query);
            if (rows != -1)
                return true;
            return false;
        }

    }
}
