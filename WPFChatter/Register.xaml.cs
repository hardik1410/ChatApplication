using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;

using System.Data.SqlTypes;
using System.Web;
using System.Data;
using System.Configuration;

namespace WPFChatter
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        public static readonly RoutedEvent AddButtonClickEvent = EventManager.RegisterRoutedEvent(
            "AddButtonClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Register));

        /// <summary>
        /// Expose the AddButtonClick to external sources
        /// </summary>
        public event RoutedEventHandler AddButtonClick
        {
            add { AddHandler(AddButtonClickEvent, value); }
            remove { RemoveHandler(AddButtonClickEvent, value); }
        }

        public static readonly RoutedEvent RegisterButtonClickEvent = EventManager.RegisterRoutedEvent(
            "RegisterButtonClick", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Register));

        public event RoutedEventHandler RegisterButtonClick
        {
            add { AddHandler(RegisterButtonClickEvent, value); }
            remove { RemoveHandler(RegisterButtonClickEvent, value); }
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ToString());
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(AddButtonClickEvent));
        }
        

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text.Trim() != "" && pwd.Text.Trim() != "" )
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    string insertsql = "insert into users(Name,Password) values(@name,@pwd)";
                    cmd.CommandText = insertsql;
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@pwd", pwd.Text);

                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Registration Successfull.");
                        RaiseEvent(new RoutedEventArgs(RegisterButtonClickEvent));
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill all details");
            }
        }

       
    }

}

