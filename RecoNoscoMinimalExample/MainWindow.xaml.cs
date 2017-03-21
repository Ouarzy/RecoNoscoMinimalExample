using System;
using System.Windows;
using RSDK.Reporting;

namespace ToDelete
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object _reporting;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                _reporting = ReportingFactory.Reporting;
                MessageBox.Show("ok");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"fail {exception?.InnerException?.Message}");
            }
        }
    }
}
