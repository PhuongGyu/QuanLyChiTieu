using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.DatabaseHelper
{
    public class DatabaseDAO
    {
        private static DatabaseDAO instance;
        private SqlConnection conn;
        


        public static DatabaseDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DatabaseDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private DatabaseDAO()
        {
            string connectionSTR = Config.ConnectionSTR; //  create connection string
            try
            {
                conn = new SqlConnection(connectionSTR); // create connect
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* 
         * Xử dụng cho các câu SELECT trả ra một bảng hoặc các trường của bản
         */
        public DataTable getDataExec(string query)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                DataTable result = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(command); // exec query
                adapter.Fill(result); // fill data return into result

                conn.Close();
                return result;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        /*
         * Xử dụng cho trường hợp insert, update, delete data
         */
        public int setDataExec(string query)
        {
            try
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                int rows = command.ExecuteNonQuery(); //exec query, return num of row affected

                conn.Close();

                return rows;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return -1;
        }

        /*
         * Xử dụng trong việc lấy ra giá trị của các câu select count(*),...
         */
        public object execScalar(string query)
        {
            try
            {
                conn.Open(); // open connection

                SqlCommand command = new SqlCommand(query, conn);
                object result = command.ExecuteScalar(); // exec query

                conn.Close(); // close connection
                return result;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

    }
}
