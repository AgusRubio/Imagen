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
            OpacidadAlta.IsChecked = true;
            AjusteRelleno.IsChecked = true;
        }


        private void OpacidadAlta_Checked(object sender, RoutedEventArgs e)
        {
            TheMandalorianImagen.Opacity = 1;
        }

        private void OpacidadMedia_Checked(object sender, RoutedEventArgs e)
        {
            TheMandalorianImagen.Opacity = 0.6;
        }

        private void OpacidadBaja_Checked(object sender, RoutedEventArgs e)
        {
            TheMandalorianImagen.Opacity = 0.3;
        }

        private void Relleno_Checked(object sender, RoutedEventArgs e)
        {
            TheMandalorianImagen.Stretch = Stretch.Fill;
        }

        private void Uniforme_Checked(object sender, RoutedEventArgs e)
        {
            TheMandalorianImagen.Stretch = Stretch.Uniform;
        }

        private void RellenoUniforme_Cheked(object sender, RoutedEventArgs e)
        {
            TheMandalorianImagen.Stretch = Stretch.UniformToFill;
        }

        private void SinAjuste_Checked(object sender, RoutedEventArgs e)
        {
            TheMandalorianImagen.Stretch = Stretch.None;
        }
    }
}
