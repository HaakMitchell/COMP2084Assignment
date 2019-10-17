using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleAppADO
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=localhost; UserId=root; Password=root; Database=ado";
            MySqlConnection mySql = new MySqlConnection(connectionString);
            string q = "select * from orders";
            MySqlCommand sqlCommand = new MySqlCommand(q, mySql);
            mySql.Open();
            DataSet d = new DataSet();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            mySqlDataAdapter.Fill(d);
            foreach (DataColumn item in d.Tables[0].Columns)
            {
                Console.Write(item.Caption + "   ");

            }
            Console.WriteLine();
                foreach (DataRow item in d.Tables[0].Rows)
            {
                for (int i = 0; i < d.Tables[0].Columns.Count; i++)
                {
                    Console.Write(item[i] + "   ");
                }
                Console.WriteLine();
            }

            string q2 = "insert into orders (name, total, customer_id, employee_sales_id) values ('bob', 10, 1, 1)";
            MySqlCommand sqlCommand2 = new MySqlCommand(q2, mySql);
            int ii = sqlCommand2.ExecuteNonQuery();
            mySql.Close();
            Console.Read();

            string q3 = "update orders set name = 'dad' where orders_id =7";
            MySqlCommand sqlCommand3 = new MySqlCommand(q3, mySql);
            int iii = sqlCommand3.ExecuteNonQuery();
            mySql.Close();
            Console.Read();

            string q4 = "delete orders where customer_id = 2";
            MySqlCommand sqlCommand4 = new MySqlCommand(q4, mySql);
            int iiii = sqlCommand4.ExecuteNonQuery();
            mySql.Close();
            Console.Read();


        }
    }
}
