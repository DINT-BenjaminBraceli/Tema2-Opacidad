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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tema2_Opacidad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            img1Image.Opacity = 0.5;
            img2Image.Opacity = 0.5;
            img3Image.Opacity = 0.5;
        }

        private void imgImage_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as System.Windows.Controls.Image).Opacity = 1;
        }

        private void imgImage_MouseLeave(object sender, MouseEventArgs e)
        {
            (sender as System.Windows.Controls.Image).Opacity = 0.5;
        }
    }
}
