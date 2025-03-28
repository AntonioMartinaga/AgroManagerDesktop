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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PresentationLayer.UserControls
{
    /// <summary>
    /// Interaction logic for UcSearchBar.xaml
    /// </summary>
    public partial class UcSearchBar : UserControl
    {
        private string placeholder;

        public string Placeholder 
        {
            get 
            {
                return placeholder;
            }
            set
            {
                placeholder = value;
                tbPlaceholder.Text = placeholder;
            }
        }
        public UcSearchBar()
        {
            InitializeComponent();
        }

        private void btnOcisti_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Clear();
            txtInput.Focus();
        }

        private void txtInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbPlaceholder.Visibility = txtInput.Text.Length == 0 ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
