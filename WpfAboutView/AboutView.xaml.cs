using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

        public static readonly DependencyProperty CreditsProperty =
            DependencyProperty.Register(
                nameof(Credits),
                typeof(List<Credit>),
                typeof(AboutView),
                new FrameworkPropertyMetadata(new List<Credit>(), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public AboutView()
        {
            InitializeComponent();
            ProcessStartCommand = new ProcessStartCommand();
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

        public List<Credit> Credits
        {
            get => (List<Credit>)GetValue(CreditsProperty);
            set => SetValue(CreditsProperty, value);
        }

        public ICommand ProcessStartCommand { get; }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = e.Uri.ToString(),
                WorkingDirectory = Assembly.GetDirectory(),
                UseShellExecute = true
            });
        }
    }
}