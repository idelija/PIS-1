using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DR1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.L_button.Click += new RoutedEventHandler(L_button_Click);
            this.R_button.Click += new RoutedEventHandler(R_button_Click);
            this.text_box1.MouseDoubleClick += new MouseButtonEventHandler(text_box1_MouseDoubleClick);

        }

        void text_box1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.text_box1.Clear();
        }

        void R_button_Click(object sender, RoutedEventArgs e)
        {
            var element1 = new Rectangle()
            {
                Height= 40,
                Width= 350,
                Fill = _GetRandomBrush(),
                Margin= new Thickness(5)
            };
            this.right_container.Children.Add(element1);
        }

        void L_button_Click(object sender, RoutedEventArgs e)
        {
            var element2 = new Rectangle()
            {
                Height = 65,
                Width = 65,
                Fill = _GetRandomBrush(),
                Margin = new Thickness(5)
            };
            this.left_container.Children.Add(element2);
        }

        private Brush _GetRandomBrush()
        {
            var random = new Random();

            var brushesType = typeof(Brushes);
            var properties = brushesType.GetProperties();

            var randomNumber = random.Next(properties.Length);

            return (Brush)properties[randomNumber].GetValue(null, null);
        }
    }
}
