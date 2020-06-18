using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FormHackApex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.NavigationService.Navigate(new HomePage());
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void ButtonWindowMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            OverlayMain.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            OverlayMain.Visibility = Visibility.Collapsed;
        }

        private void HandleMouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new HomePage());

            Storyboard sb = this.FindResource("CloseMenuLeft") as Storyboard;
            sb.Begin();
            OverlayMain.Visibility = Visibility.Collapsed;
        }

        private void ListViewItem2_Selected(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new Games());

            Storyboard sb = this.FindResource("CloseMenuLeft") as Storyboard;
            sb.Begin();
            OverlayMain.Visibility = Visibility.Collapsed;
        }
    }
}
