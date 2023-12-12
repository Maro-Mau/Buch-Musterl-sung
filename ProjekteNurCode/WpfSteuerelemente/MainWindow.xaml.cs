using System.Windows;
using System.Windows.Controls;

namespace WpfSteuerelemente
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

        private void Cb_Checked(object sender, RoutedEventArgs e)
            => Tb.Text = "CheckBox ein";

        private void Cb_Unchecked(object sender, RoutedEventArgs e)
            => Tb.Text = "CheckBox aus";

        private void Bu_Click(object sender, RoutedEventArgs e)
            => MessageBox.Show($"{Tb.Text} / {Tb.SelectedText}");

        private void Lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsLoaded)
            {
                Tb.Text = "";
                foreach (ListBoxItem lbi in Lb.SelectedItems)
                    Tb.Text += $"{lbi.Content} ";
            }
        }

        private void Sl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                Tb.Text = $"Wert: {Sl.Value}";
        }
    }
}
