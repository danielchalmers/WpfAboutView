using System.Windows;
using WpfAboutView;

namespace ExampleApp
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

        private void OpenAboutDialogButton_Click(object sender, RoutedEventArgs e)
        {
            new AboutDialog
            {
                Owner = this,
                AboutView = (AboutView)Resources["ExampleAboutView"]
            }.ShowDialog();
        }
    }
}