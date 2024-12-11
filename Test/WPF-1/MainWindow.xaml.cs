﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF1;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btSpara(object sender, RoutedEventArgs e)
    {
        string förnamn = tbFörnamn.Text;
        string efternamn = tbEfternamn.Text;
        MessageBox.Show($"Hej {förnamn} {efternamn}");
    }
}