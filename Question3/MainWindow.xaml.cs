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
using Question3.Models;

namespace Question3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Messages messages = new Messages();
        public MainWindow()
        {
            InitializeComponent();
            CaseQuestion.Content = messages.Case_Select_UI;
        }

        private void EasyButton_Click(object sender, RoutedEventArgs e)
        {
            Easy easy = new Easy("1");
            easy.Show();
            this.Close();
        }

        private void MediumButton_Click(object sender, RoutedEventArgs e)
        {
            Easy medium = new Easy("2");
            medium.Show();
            this.Close();
        }

        private void HardButton_Click(object sender, RoutedEventArgs e)
        {
            Easy hard = new Easy("3");
            hard.Show();
            this.Close();
        }
    }
}
