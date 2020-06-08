using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /*Tools - SQLite/ SQL Server Compact Toolbox - Add Connection (chose DB in "WpfAppCore\bin\Debug\netcoreapp3.1")
         * Can edit tables and run Query to add to table
         * 
         * DB Browser for SQLite program - Open database - (change things) - Write changes - Close database
         * 
         * "Entity Framework Tools"?
        Extension - SQLite / SQL Server Compact Toolbox
            install
        Tools - SQLite...
        Program - DB Browser for SQLite
            Add SQLite connections from current Solution
            Open "First.db"
                Tables
                Employees - edit
            Select * FROM Employees;
         */
        //if (db.Employees?.Count() == 0)//? what is?

        /*
        class Employee
	        ID, Name, Age

        class DatabaseContext:DbContext
	        public DbSet<Employee> Employees { get; set; }
            protected override void OnConfiguring
                optionsBuilder.UseSqlite(@"Data source = First.db");

        Nuget Packages 
                    - Microsoft.EntityFrameworkCore.Sqlite (only need ths one)
                    - Microsoft.EntityFrameworkCore?
					- SQLite?
                    - Microsoft.Data.Sqlite?
                    - Microsoft.Data.Sqlite.Core?
                    - System.Data.Sqlite

        XAML 
        Listbox set to Employees, TextBlock binded to Name
        <ListBox ItemsSource="{Binding Employees}">
         */

        public List<Employee> Employees { get; set; }
        public List<Employee> Employees2 { get; set; }
        public Employee steve2 = new Employee { Name = "Steve2", Age = 33 };
        //public DbContext db = new DatabaseContext();

        public MainWindow()
        {
            // Tutorial 1 - C# 8 learningc8andnetcore30 book
            var db = new DatabaseContext();
            CreateDatabase(db); //EnsureCreated()
            AddEmployees(db); // if no employees, create some (Steve1, Steve2)
            //db.Employees.Update(steve2);?
            SetMainViewData(db); // Set Employees to DB Employees




            // Tutorial 2 - https://www.youtube.com/watch?v=anTP-mgktiI
            Database databaseObject = new Database();
            
            string query1 = "INSERT INTO albums ('title', 'artist') VALUES (@title, @artist)";
            SQLiteCommand myCommand1 = new SQLiteCommand(query1, databaseObject.myConnection);
            //NewValue(databaseObject, myCommand1);


            string query2 = "SELECT * FROM albums";// ('title', 'artist') VALUES (@title, @artist)";
            SQLiteCommand myCommand2 = new SQLiteCommand(query2, databaseObject.myConnection);
            CheckValues(databaseObject, myCommand2);

            //Employees = Employees2;// use this to change data on table in XAML
        }

        void NewValue(Database databaseObject, SQLiteCommand myCommand)
        {
            databaseObject.OpenConnection();
            myCommand.Parameters.AddWithValue("@title", "mySteve1");
            myCommand.Parameters.AddWithValue("@artist", "mySteve2");
            var result = myCommand.ExecuteNonQuery();
            databaseObject.CloseConnection();
            Debug.Print($"Rows added: {result}");
        }

        void CheckValues(Database databaseObject, SQLiteCommand myCommand)
        {
            databaseObject.OpenConnection();
            SQLiteDataReader result = myCommand.ExecuteReader();
            List<Employee> Titles = new List<Employee>();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    Debug.Print($"Album {result["title"]}, Artist {result["artist"]}");
                    //Titles.Add(result["title"].ToString());
                    Titles.Add(new Employee() { Name = result["title"].ToString(), Age = 20 });
                }
            }
            Employees2 = Titles; 
            databaseObject.CloseConnection();
        }


        void CreateDatabase(DatabaseContext db)
        {
            db.Database.EnsureCreated();
        }
        void AddEmployees(DatabaseContext db)
        {
            //If no Employees, Add
            if (db.Employees?.Count() == 0)//? what is?
            {
                db.Employees.Add(new Employee() { Name = "Steve1", Age = 20 });
                db.Employees.Add(new Employee() { Name = "Steve2", Age = 30 });
                db.SaveChanges();
            }
        }
        void SetMainViewData(DatabaseContext db)
        {
            Employees = db.Employees.ToList();
            InitializeComponent();
            this.DataContext = this;
        }
        //public List<string> Employees { get; set; }
        //Employees = new List<string>();
        //Employees.Add("Steve11");
        //Employees.Add("Steve2");
        //Employees.Add("Steve3");

        /*
         <ListBox ItemsSource="{Binding Employees}">
                <ListBox.ItemTemplate>
                    <DataTemplate>
                        <TextBlock Text="{Binding Name}" />
         */

        /*
        <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="20*" />
            <RowDefinition Height="40*" />
            <RowDefinition Height="30*" />
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="20*" />
            <ColumnDefinition Width="40*" />
            <ColumnDefinition Width="30*" />
        </Grid.ColumnDefinitions>
        <StackPanel Orientation="Vertical" Grid.Row="1" Grid.Column="1">
            <ListBox>
                <ListBoxItem>
                    <TextBlock Text="Steve1"></TextBlock>
                </ListBoxItem>
                <ListBoxItem>
                    <TextBlock Text="Steve2"></TextBlock>
                </ListBoxItem>
                <ListBoxItem>
                    <TextBlock Text="Steve3"></TextBlock>
                </ListBoxItem>
            </ListBox>
        </StackPanel>
        </Grid>
         */

    }
}
