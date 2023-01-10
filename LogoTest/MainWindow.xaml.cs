using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace LogoTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int i = 1;
            foreach (var item in wpanel.Children)
            {
                ((LogoUC)item).ToolTip = i;
                i++;
            }
            CreateLogos(v1);
            CreateLogos(v2);
            CreateLogos(v3a);
            CreateLogos(v3);
            CreateLogos(v4); 
            CreateLogos(v5);
        }
        private LogoUC MakeACopy(LogoUC logo)
        {
            string saved = XamlWriter.Save(logo);
            StringReader sReader = new StringReader(saved);
            XmlReader xReader = XmlReader.Create(sReader);
            LogoUC newCanvas = (LogoUC)XamlReader.Load(xReader);
            return newCanvas;
        }
        private void CreateLogos(LogoUC logo)
        {
            return;

            StackPanel sp = new StackPanel();
            sp.Orientation = Orientation.Horizontal;

                      
            //ScaleTransform scaleTransform3 = new ScaleTransform(4, 4, .5, 0.5);
            //l64.RenderTransform = scaleTransform3;
            ////l64.Width = 64;
            ////l64.Height = 64;
            //l64.Margin = new Thickness(0);
            logo.ShadowStength = 1;
            var l64 = MakeACopy(logo);
            Viewbox vb64 = new Viewbox();
            vb64.Width = 64;
            vb64.Height = 64;
            vb64.Child = l64;
            sp.Children.Add(vb64);

            
            
            Viewbox vb128 = new Viewbox();
            vb128.Width = 128;
            vb128.Height = 128;
            
            //ScaleTransform scaleTransform3 = new ScaleTransform(4, 4, .5, 0.5);
            //l128.RenderTransform = scaleTransform3;
            ////l128.Width = 128;
            ////l128.Height = 128;
            //l128.Margin = new Thickness(0);
            logo.ShadowStength = 4;
            var l128 = MakeACopy(logo);
            vb128.Child = l128;
            sp.Children.Add(vb128);

            ScaleTransform scaleTransform1 = new ScaleTransform(1, 1, 0, 0);
            logo.RenderTransform = scaleTransform1;
            logo.Width = 32;
            logo.Height = 32;
            logo.Margin = new Thickness(0);
            logo.ShadowStength = 0;
            var l32 = MakeACopy(logo);
            sp.Children.Insert(1, l32);

            scaleTransform1 = new ScaleTransform(.5, .5, 0, 0);
            logo.RenderTransform = scaleTransform1;
            logo.Width = 16;
            logo.Height = 16;
            logo.Margin = new Thickness(0, 0, 8, 0);
            logo.ShadowStength = 0;
            var l16 = MakeACopy(logo);
            sp.Children.Insert(0, l16);

            SelSP.Children.Add(sp);
        }



        private void Light11_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e0edf8"));
        }

        private void Dark10_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#202022"));

        }

        private void Light10_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eeeeee"));
        }

        private void Size16_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in wpanel.Children)
            {
                ScaleTransform scaleTransform1 = new ScaleTransform(.5, .5, 0, 0);
                ((LogoUC)item).RenderTransform = scaleTransform1;
                ((LogoUC)item).Width = 16;
                ((LogoUC)item).Height = 16;
            }
        }

        private void Size32_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in wpanel.Children)
            {
                ScaleTransform scaleTransform1 = new ScaleTransform(1, 1, 0, 0);
                ((LogoUC)item).RenderTransform = scaleTransform1;
                ((LogoUC)item).Width = 32;
                ((LogoUC)item).Height = 32;
            }
        }

        private void Size64_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in wpanel.Children)
            {
                ScaleTransform scaleTransform1 = new ScaleTransform(2, 2, 0, 0);
                ((LogoUC)item).RenderTransform = scaleTransform1;
                ((LogoUC)item).Width = 64;
                ((LogoUC)item).Height = 64;
            }
        }

        private void Size128_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in wpanel.Children)
            {
                ScaleTransform scaleTransform1 = new ScaleTransform(4, 4, 64, 64);
                ((LogoUC)item).RenderTransform = scaleTransform1;
                ((LogoUC)item).Width = 128;
                ((LogoUC)item).Height = 128;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var picture = GetImage(imageToSave);
            if (picture == null) return;
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save picture as ";
            save.Filter = "Image File(*.png)|*.png";
            if (save.ShowDialog() == true)
            {
                PngBitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(picture));
                using (var fileStream = new FileStream(save.FileName, FileMode.Create))
                    encoder.Save(fileStream);

            }

        }
        public static RenderTargetBitmap GetImage(FrameworkElement view)
        {
            Size size = new Size(view.ActualWidth, view.ActualHeight);
            if (size.IsEmpty)
                return null;

            RenderTargetBitmap result = new RenderTargetBitmap((int)size.Width, (int)size.Height, 96, 96, PixelFormats.Pbgra32);

            DrawingVisual drawingvisual = new DrawingVisual();
            using (DrawingContext context = drawingvisual.RenderOpen())
            {
                context.DrawRectangle(new VisualBrush(view), null, new Rect(new Point(), size));
                context.Close();
            }

            result.Render(drawingvisual);
            return result;
        }
    }
}
