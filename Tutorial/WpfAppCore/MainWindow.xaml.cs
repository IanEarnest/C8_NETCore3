using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        /*
         * "Entity Framework Tools"?
        Extension - SQLite / SQL Server Compact Toolbox
            install
        Tools - SQLite...
            Add SQLite connections from current Solution
            Open "First.db"
                Tables
                Employees - edit
            Select * FROM Employees;
         */

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

        XAML 
        Listbox set to Employees, TextBlock binded to Name
        <ListBox ItemsSource="{Binding Employees}">
         */

        public List<Employee> Employees { get; set; }

        public MainWindow()
        {
            var db = new DatabaseContext();
            db.Database.EnsureCreated();
            // If no Employees, Add
            if (db.Employees?.Count() == 0)//? what is?
            {
                db.Employees.Add(new Employee() { Name = "Steve1", Age = 20 });
                db.Employees.Add(new Employee() { Name = "Steve2", Age = 30 });
                db.SaveChanges();
            }
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
