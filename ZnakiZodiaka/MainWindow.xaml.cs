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

namespace ZnakiZodiaka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            char c = Convert.ToChar(e.Text);
            if (Char.IsNumber(c))
                e.Handled = false;
            else
                e.Handled = true;
            base.OnPreviewTextInput(e);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           int day = Convert.ToInt32(birthDay.Text);
           string month = monthsList.Text;
            if (Convert.ToInt32(day) > 31) MessageBox.Show($"Число {day} не является корректным для Дня Рождения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            
        }
    }
}
