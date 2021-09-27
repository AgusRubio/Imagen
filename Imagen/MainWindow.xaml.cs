using System.Windows;
using System.Windows.Media;


namespace Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void OpacidadAlta_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 1;
        }

        private void OpacidadMedia_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.5;
        }

        private void OpacidadBaja_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.25;
        }

        private void Relleno_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Fill;
        }

        private void Uniforme_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Uniform;
        }

        private void RellenoUniforme_Cheked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.UniformToFill;
        }

        private void SinAjuste_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.None;
        }
    }
}
