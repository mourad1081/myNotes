using System;
using System.Windows;
using System.Windows.Input;

namespace myNotes
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Boolean PleinEcran = false;
        public MainWindow()
        {
            InitializeComponent();
            // this.label.FontFamily = new FontFamily(new Uri("pack://application:,,,/Resources/"), "./#Roboto");
            Console.Write("Hello world !");
        }
        
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if(!((MainWindow)sender).titre.IsMouseDirectlyOver && // Sinon l'app crash bizarrement
               !((MainWindow)sender).contenu.IsMouseOver &&
               ((MainWindow)sender).WindowState != WindowState.Maximized && //Pas de drag si fenetre maximisée
                e.LeftButton == MouseButtonState.Pressed)
            {
                Mouse.SetCursor(Cursors.SizeAll);
                DragMove();
            }
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void maximize_Click(object sender, RoutedEventArgs e)
        {
            if (!PleinEcran)
            {
                WindowState = WindowState.Maximized;
                PleinEcran = true;
            } else
            {
                WindowState = WindowState.Normal;
                PleinEcran = false;
            }
        }
    }
}
