using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Ablakv
{
    class Skuel
    {
        public bool Logi(string s) {
            bool b=true;
            string connStr = "server=localhost;user=root;database=tdb;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);            
            string[] ker = s.Split(';');
            try
            {
                conn.Open();
                string sql = "SELECT nev, adat FROM users WHERE nev LIKE '" + ker[0] + "' AND adat LIKE '" + ker[1]+"'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<string> z = new List<string>();
                while (rdr.Read())
                {
                    z.Add(rdr.GetString(0) + " " + rdr.GetString(1));
                }
                rdr.Close();
                if (z.Count == 0) {
                    b = false;
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            return b;
        }

        public void Regiz(string a, string b, string c)
        {
            string connStr = "server=localhost;user=root;database=tdb;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {               
                conn.Open();                
                int z = Szam() + 1;
                int w = Convert.ToInt32(c);
                string sql = "INSERT INTO users (id, nev, nem, adat) VALUES (" + z+ ",'" + a + "','" + b + "'," + w + ")";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
        }

        public string[] Keres(string c)
        {
            string connStr = "server=localhost;user=root;database=tdb;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            string[] g;
                          
                conn.Open();                
                string sql = "SELECT id, nev, nem FROM users WHERE nem LIKE '" + c + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<string> s = new List<string>();
                while (rdr.Read())
                {
                    s.Add(rdr.GetString(0) + " " + rdr.GetString(1) + " " + rdr.GetString(2));
                }
                rdr.Close();
                g = new string[s.Count];
                for (int i = 0; i < s.Count; i++)
                {
                    g[i]=s[i];
                }
                
           
            
            conn.Close();
            return g;
        }        

        public static int Szam()
        {
            string connStr = "server=localhost;user=root;database=tdb;port=3306;password=";
            MySqlConnection conn = new MySqlConnection(connStr);
            int r = 0;
            try
            {
                Console.WriteLine("Kapcsolódás...");
                conn.Open();

                string sql = "SELECT COUNT(*) FROM users";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                object kim = cmd.ExecuteScalar();
                if (kim != null)
                {
                    r = Convert.ToInt32(kim);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            return r;
        }
    }
}
