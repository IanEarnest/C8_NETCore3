using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data.SQLite;
using System.Diagnostics;

namespace WpfAppCore
{
    class Database
    {
        // DB Browser
        // Open Database, Create table - albums (id, title, artist) (int and text)
        // id = autoincrement
        // Write changes, close database

        public SQLiteConnection myConnection;
        public Database()
        {
            string fileName = "database.sqlite3";
            myConnection = new SQLiteConnection($"Data Source={fileName}");
            if (!File.Exists($"./{fileName}"))
            {
                SQLiteConnection.CreateFile($"{fileName}");
                Debug.Print($"File: {fileName} Created");
                //SQLiteConnection.CreateFile("database.sqlite3");
                //Debug file created
            }
        }

        public void OpenConnection()
        {
            if(myConnection.State != System.Data.ConnectionState.Open)
            {
                myConnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
            {
                myConnection.Close();
            }
        }
    }
}
