using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

public class Tutorial2
{
    public static void Main()
    {
        string connStr = "server=localhost;user=root;database=shop;port=3306;password=!dinnerfor2";
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();

            string sql = "SELECT * FROM t_admin";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string tt = (string) rdr[1];
                Console.WriteLine(rdr[0] + " -- " + rdr[1]);
            }
            rdr.Close();

<<<<<<< HEAD
<<<<<<< HEAD
	    Console.WriteLine("Connect test");
=======
	    Console.WriteLine("Connecting to MySQL 11111...");
>>>>>>> test
=======
	    Console.WriteLine("Connecting to MySQL 11111...");
>>>>>>> refs/remotes/origin/anothertest
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        conn.Close();
        Console.WriteLine("Done.");
    }
}