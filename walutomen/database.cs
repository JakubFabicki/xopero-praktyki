using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.IO;

namespace walutomen
{
    class database
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;


        public void CreateDatabaseAndTable()
        {
            if (!File.Exists("Statistic.sqlite"))
            {
                SQLiteConnection.CreateFile("Statistic.sqlite");

                string sql = @"CREATE TABLE statistic(
                               ID              INTEGER      NOT NULL,
                               Score           INTEGER      NOT NULL,
                               Code            TEXT         NOT NULL
                            );";
                con = new SQLiteConnection("Data Source=Statistic.sqlite;Version=3;");
                con.Open();
                cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                con = new SQLiteConnection("Data Source=Statistic.sqlite;Version=3;");
            }
        }

        public void AddData(ulong id, string code)
        {
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into statistic(ID ,Score, Code) values (" + id + ", " + "1" + ",'" + code + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateData(ulong id, string code)
        {
            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "update statistic set Score = Score + 1 where id = " + id + " and code = '" + code + "'";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public int SelectData(ulong id, string code)
        {
            int counter = 0;
            cmd = new SQLiteCommand("Select * From statistic where ID = " + id + " and Code = '" + code + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                counter++;
                counter = (int)Convert.ToInt64(dr[1]);
            }
            dr.Close();
            con.Close();
            return counter;
        }

        public int SelectStats(ulong id, string code)
        {

            int score = 0;
            cmd = new SQLiteCommand("Select Score From statistic WHERE ID = " + id + " AND Code = '" + code + "'", con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                score = (int)Convert.ToInt64(dr[0]);
            }
            dr.Close();
            con.Close();
            return score;
        }
    }
}
