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

namespace WpfApp17
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
        int[] masA = new int[12];
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Random randA = new Random();
                for (int i = 0; i < masA.Length; i++)
                {
                    masA[i] = randA.Next(20);
                    vivida.Text += masA[i] + " ";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                int c = 0;
                for (int i = 0; i < masA.Length; i++)
                {
                    if (masA[i] % 2 == 0)
                    {
                        c++;
                    }
                }
                vivodc.Text += c;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
