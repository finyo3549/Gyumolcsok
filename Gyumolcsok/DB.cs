using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gyumolcsok
{
    internal class DB
    {
        MySqlConnection conn = null;
        MySqlCommand sql = null;

        public DB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "172.20.10.9";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "join_gyumolcsok";
            conn = new MySqlConnection(builder.ConnectionString);
            sql = conn.CreateCommand();
            try
            {
                kapcsolatNyit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { kapcsolatZar(); }
        }

        private void kapcsolatZar()
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        private void kapcsolatNyit()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
        }

        internal List<Gyumolcs> GetAllFruits()
        {
            List<Gyumolcs> gyumolcsok = new List<Gyumolcs>();
            sql.CommandText = "SELECT * FROM t1";
            try
            {
                kapcsolatNyit();
                using (MySqlDataReader dr = sql.ExecuteReader())
                    while (dr.Read())
                    {
                        int id = dr.GetInt32("id");
                        string name = dr.GetString("gyumolcs");
                        int quantity = dr.GetInt32("mennyiseg");
                        gyumolcsok.Add(new Gyumolcs(id, name, quantity));
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { kapcsolatZar(); }
            return gyumolcsok;
        }
        internal void AddFruit(Gyumolcs gyumolcs)
        {
            sql.CommandText = "INSERT INTO `t1`(`gyumolcs`, `mennyiseg`) VALUES (@gyumolcs,@mennyiseg)";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@gyumolcs", gyumolcs.Name);
            sql.Parameters.AddWithValue("@mennyiseg", gyumolcs.Quantity);
            try
            {
                kapcsolatNyit();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally { kapcsolatZar(); }
        }

        internal void DeleteFruit(Gyumolcs gyumolcs)
        {
            sql.CommandText = "DELETE FROM t1 WHERE id LIKE @Id";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@Id",gyumolcs.Id);
            try
            {
                kapcsolatNyit();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException e) { MessageBox.Show(e.Message); }
        finally { kapcsolatZar(); }
        }

        internal void UpdateFruit(Gyumolcs gyumolcs)
        {
            sql.CommandText = "UPDATE `t1` SET `gyumolcs`=@gyumolcs,`mennyiseg`=@mennyiseg WHERE id = @Id";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@gyumolcs", gyumolcs.Name);
            sql.Parameters.AddWithValue("@mennyiseg", gyumolcs.Quantity);
            sql.Parameters.AddWithValue("@Id", gyumolcs.Id);
            try
            {
                kapcsolatNyit();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally { kapcsolatZar(); }
        }
    }
}
