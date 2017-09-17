using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public static readonly DependencyProperty AppNameProperty =
            DependencyProperty.Register(
                nameof(AppName),
                typeof(string),
                typeof(AboutView));

        public static readonly DependencyProperty AppVersionProperty =
            DependencyProperty.Register(
                nameof(AppVersion),
                typeof(string),
                typeof(AboutView));

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

        public string AppName
        {
            get => (string)GetValue(AppNameProperty);
            set => SetValue(AppNameProperty, value);
        }

        public string AppVersion
        {
            get => (string)GetValue(AppVersionProperty);
            set => SetValue(AppVersionProperty, value);
        }

        public List<Credit> Credits
        {
            get => (List<Credit>)GetValue(CreditsProperty);
            set => SetValue(CreditsProperty, value);
        }

        public ICommand ProcessStartCommand { get; }

        private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = e.Uri.ToString(), UseShellExecute = true });
        }
    }
}