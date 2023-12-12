using System.Windows;
using System.Windows.Media;

namespace WpfGeometriePfad
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

        private void Aendern(object sender, RoutedEventArgs e)
        {
            PathGeometry pg = (PathGeometry)Pt.Data;
            ArcSegment asg = (ArcSegment)pg.Figures[1].Segments[0];
            asg.Size = new Size(asg.Size.Width + 5, asg.Size.Height + 5);
        }
    }
}
