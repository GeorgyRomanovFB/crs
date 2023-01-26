﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BlumBlumShub
{
    public class DB
    {
        private readonly string dataSource;
        public DB(string dataSource)
        {
            this.dataSource = dataSource;
        }
        public bool InitializeDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "DROP TABLE IF EXISTS users;"
                    + "CREATE TABLE users("
                    + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                    + "login TEXT, "
                    + "password TEXT);";
;
                    cmd.CommandText = sql_command;
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return true;
        }

        public bool createUser(string username, string password)
        {
            
            SQLiteConnection conn = new SQLiteConnection(dataSource);

            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("INSERT INTO users (login, password)"
                + "VALUES ('{0}', '{1}')",
                username, password);
                cmd.ExecuteNonQuery();
                return true;
            }
            return true;

        }

        public bool CheckLogin(User user)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format("SELECT COUNT(login)"
                    + "FROM users "
                    + "WHERE login = '{0}'",user.Login);
                    var usersCount = Convert.ToInt32(cmd.ExecuteScalar());
                    if (usersCount!=0)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return false;
        }

        public bool CheckUser(User user)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format("SELECT COUNT(login)"
                    + "FROM users "
                    + "WHERE login = '{0}' AND "
                    + "password = '{1}'",
                    user.Login, user.Password);
                    var usersCount = Convert.ToInt32(cmd.ExecuteScalar());
                    return usersCount > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return false;
        }
    }
}
