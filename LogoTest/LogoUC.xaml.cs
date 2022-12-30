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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LogoTest
{
    /// <summary>
    /// Interaction logic for LogoUC.xaml
    /// </summary>
    public partial class LogoUC : UserControl
    {
        public LogoUC()
        {
            InitializeComponent();
            //BackFromBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#11599f");
            //BackToBrush = (SolidColorBrush)new BrushConverter().ConvertFrom("#2fafe3");
        }


        public Color BackBottomColor
        {
            get { return (Color)GetValue(BackBottomColorProperty); }
            set { SetValue(BackBottomColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackBottomColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackBottomColorProperty =
            DependencyProperty.Register("BackBottomColor", typeof(Color), typeof(LogoUC), new PropertyMetadata(null));

        public Color BackTopColor
        {
            get { return (Color)GetValue(BackTopColorProperty); }
            set { SetValue(BackTopColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackTopColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackTopColorProperty =
            DependencyProperty.Register("BackTopColor", typeof(Color), typeof(LogoUC), new PropertyMetadata(null));

        public Color OneBottomColor
        {
            get { return (Color)GetValue(OneBottomColorProperty); }
            set { SetValue(OneBottomColorProperty, value); }
        }

        // Using a DependencyProperty as the Oneing store for OneBottomColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OneBottomColorProperty =
            DependencyProperty.Register("OneBottomColor", typeof(Color), typeof(LogoUC), new PropertyMetadata(null));

        public Color OneTopColor
        {
            get { return (Color)GetValue(OneTopColorProperty); }
            set { SetValue(OneTopColorProperty, value); }
        }

        // Using a DependencyProperty as the Oneing store for OneTopColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OneTopColorProperty =
            DependencyProperty.Register("OneTopColor", typeof(Color), typeof(LogoUC), new PropertyMetadata(null));



        public Brush FolderBackBrush
        {
            get { return (Brush)GetValue(FolderBackBrushProperty); }
            set { SetValue(FolderBackBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FolderBackBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FolderBackBrushProperty =
            DependencyProperty.Register("FolderBackBrush", typeof(Brush), typeof(LogoUC), new PropertyMetadata(Brushes.DarkBlue));



        public Brush OneBrush
        {
            get { return (Brush)GetValue(OneBrushProperty); }
            set { SetValue(OneBrushProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OneBrush.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OneBrushProperty =
            DependencyProperty.Register("OneBrush", typeof(Brush), typeof(LogoUC), new PropertyMetadata(Brushes.LightBlue));



        public Brush OneBrushBorder
        {
            get { return (Brush)GetValue(OneBrushBorderProperty); }
            set { SetValue(OneBrushBorderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OneBrushBorder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OneBrushBorderProperty =
            DependencyProperty.Register("OneBrushBorder", typeof(Brush), typeof(LogoUC), new
                PropertyMetadata(Brushes.Transparent));




        //public Brush OneBrushBorder
        //{
        //    get { return (Brush)GetValue(OneBrushBorderProperty); }
        //    set { SetValue(OneBrushBorderProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for OneBrushBorder.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty OneBrushBorderProperty =
        //    DependencyProperty.Register("OneBrushBorder", typeof(Brush), typeof(LogoUC), new PropertyMetadata(borderBrush));

        //static LinearGradientBrush borderBrush = new LinearGradientBrush()
        //{
        //    StartPoint = new Point(0, 0),
        //    EndPoint = new Point(0, 1),
        //    GradientStops = new GradientStopCollection()
        //    {
        //        new GradientStop((Color)ColorConverter.ConvertFromString("#FF2860A7"), 0),
        //        new GradientStop((Color)ColorConverter.ConvertFromString("#FF24C4FF"), 1),
        //    }, MappingMode = BrushMappingMode.RelativeToBoundingBox
        //};




        public double ShadowStength
        {
            get { return (double)GetValue(ShadowStengthProperty); }
            set { SetValue(ShadowStengthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShadowStength.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShadowStengthProperty =
            DependencyProperty.Register("ShadowStength", typeof(double), typeof(LogoUC), new
                PropertyMetadata(0.0));



        public double OneBorderThickness
        {
            get { return (double)GetValue(OneBorderThicknessProperty); }
            set { SetValue(OneBorderThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for OneBorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OneBorderThicknessProperty =
            DependencyProperty.Register("OneBorderThickness", typeof(double), typeof(LogoUC), new PropertyMetadata(2.0));



    }
}

