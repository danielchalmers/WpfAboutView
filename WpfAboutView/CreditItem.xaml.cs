using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfAboutView
{
    /// <summary>
    /// Interaction logic for CreditItem.xaml
    /// </summary>
    public partial class CreditItem : UserControl
    {
        public static readonly DependencyProperty CreditProperty =
            DependencyProperty.Register(
                nameof(Credit),
                typeof(Credit),
                typeof(CreditItem));

        public CreditItem()
        {
            InitializeComponent();

            ViewLicenseCommand = new RelayCommand(
                () => MessageBox.Show(Credit.LicenseText, $"{Credit.Name} License"),
                (parameter) => Credit.LicenseText != null);

            ViewWebsiteCommand = new RelayCommand(
                () => Process.Start(Credit.Website?.ToString()),
                (parameter) => Credit.Website != null);
        }

        public Credit Credit
        {
            get => (Credit)GetValue(CreditProperty);
            set => SetValue(CreditProperty, value);
        }

        public ICommand ViewLicenseCommand { get; }
        public ICommand ViewWebsiteCommand { get; }
    }
}