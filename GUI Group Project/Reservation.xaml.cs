﻿using System;
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
using System.Windows.Shapes;

namespace GUI_Group_Project
{
    /// <summary>
    /// Interaction logic for Reservation.xaml
    /// </summary>
    public partial class Reservation : Window
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, RoutedEventArgs e)
        {
            DashBoard db = new DashBoard();
            db.Show();
            this.Close();

        }

        private void btnlogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
