using System.Windows;

namespace WpfAboutView
{
    /// <summary>
    /// Interaction logic for AboutDialog.xaml
    /// </summary>
    public partial class AboutDialog : Window
    {
        public static readonly DependencyProperty AboutViewProperty =
            DependencyProperty.Register(
                nameof(AboutView),
                typeof(AboutView),
                typeof(AboutDialog));

        public AboutDialog()
        {
            InitializeComponent();

            AboutView = new AboutView();
        }

        public AboutDialog(AboutView aboutView)
        {
            InitializeComponent();

            AboutView = aboutView;
        }

        public AboutView AboutView
        {
            get => (AboutView)GetValue(AboutViewProperty);
            set => SetValue(AboutViewProperty, value);
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}