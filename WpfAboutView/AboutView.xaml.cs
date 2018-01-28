using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace WpfAboutView
{
    /// <summary>
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class AboutView : UserControl
    {
        public static readonly DependencyProperty AppIconSourceProperty =
            DependencyProperty.Register(
                nameof(AppIconSource),
                typeof(Uri),
                typeof(AboutView));

        public static readonly DependencyProperty AssemblyProperty =
                    DependencyProperty.Register(
                nameof(Assembly),
                typeof(Assembly),
                typeof(AboutView),
                new PropertyMetadata(Assembly.GetEntryAssembly()));

        public static readonly DependencyProperty CreditColumnsProperty =
                    DependencyProperty.Register(
                nameof(CreditColumns),
                typeof(int),
                typeof(AboutView),
                new PropertyMetadata(3));

        public static readonly DependencyProperty CreditsProperty =
            DependencyProperty.Register(
                nameof(Credits),
                typeof(ObservableCollection<Credit>),
                typeof(AboutView),
                new FrameworkPropertyMetadata(new ObservableCollection<Credit>(), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public AboutView()
        {
            InitializeComponent();

            Credits = new ObservableCollection<Credit>();
        }

        public Uri AppIconSource
        {
            get => (Uri)GetValue(AppIconSourceProperty);
            set => SetValue(AppIconSourceProperty, value);
        }

        public string AppName => Assembly.GetTitle();

        public Version AppVersion => Assembly.GetVersion();

        public Assembly Assembly
        {
            get => (Assembly)GetValue(AssemblyProperty);
            set => SetValue(AssemblyProperty, value);
        }

        public int CreditColumns
        {
            get => (int)GetValue(CreditColumnsProperty);
            set => SetValue(CreditColumnsProperty, value);
        }

        public ObservableCollection<Credit> Credits
        {
            get => (ObservableCollection<Credit>)GetValue(CreditsProperty);
            set => SetValue(CreditsProperty, value);
        }
    }
}