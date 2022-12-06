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
using System.Windows.Media.Animation;

namespace Pigalev_Airport_Advertising
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation WAB = new DoubleAnimation(); // Ширина кнопки
            WAB.From = 150;
            WAB.To = 300;
            WAB.Duration = TimeSpan.FromSeconds(0.5);
            WAB.RepeatBehavior = RepeatBehavior.Forever;
            WAB.AutoReverse = true;
            btnLink.BeginAnimation(WidthProperty, WAB);

            DoubleAnimation HAB = new DoubleAnimation(); // Высота кнопки
            HAB.From = 50;
            HAB.To = 100;
            HAB.Duration = TimeSpan.FromSeconds(0.5);
            HAB.RepeatBehavior = RepeatBehavior.Forever;
            HAB.AutoReverse = true;
            btnLink.BeginAnimation(HeightProperty, HAB);

            DoubleAnimation FSAB = new DoubleAnimation(); // Изменение шрифта у кнопки
            FSAB.From = 16;
            FSAB.To = 24;
            FSAB.Duration = TimeSpan.FromSeconds(0.5);
            FSAB.RepeatBehavior = RepeatBehavior.Forever;
            FSAB.AutoReverse = true;
            btnLink.BeginAnimation(FontSizeProperty, FSAB);

            ColorAnimation BAB = new ColorAnimation();
            ColorConverter CC = new ColorConverter();
            Color Cstart = (Color)CC.ConvertFrom("#ff0000");
            btnLink.Background = new SolidColorBrush(Cstart);
            BAB.From = Cstart;
            BAB.To = (Color)CC.ConvertFrom("#00ff00");
            BAB.Duration = TimeSpan.FromSeconds(2);
            BAB.RepeatBehavior = RepeatBehavior.Forever;
            FSAB.AutoReverse = true;
            btnLink.Background.BeginAnimation(SolidColorBrush.ColorProperty, BAB);

            //DoubleAnimation WATB = new DoubleAnimation(); // Ширина TextBlock
            //WATB.From = 350;
            //WATB.To = 400;
            //WATB.Duration = TimeSpan.FromSeconds(2);
            //WATB.RepeatBehavior = RepeatBehavior.Forever;
            //WATB.AutoReverse = true;
            //tbHeader.BeginAnimation(WidthProperty, WATB);

            DoubleAnimation FSATB = new DoubleAnimation(); // Изменение шрифта у TextBlock
            FSATB.From = 24;
            FSATB.To = 36;
            FSATB.Duration = TimeSpan.FromSeconds(1);
            FSATB.RepeatBehavior = RepeatBehavior.Forever;
            FSATB.AutoReverse = true;
            tbHeader.BeginAnimation(FontSizeProperty, FSATB);
        }
    }
}
