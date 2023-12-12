using System.Windows;
using System.Windows.Controls;

namespace WpfLayoutKombi
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

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("B1");
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("B2");
        }

        private void Sp_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)e.Source;
            MessageBox.Show(b.Name);
        }
    }
}
