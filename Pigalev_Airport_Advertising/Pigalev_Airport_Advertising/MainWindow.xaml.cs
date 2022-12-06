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
            WAB.From = 200;
            WAB.To = 300;
            WAB.Duration = TimeSpan.FromSeconds(1);
            WAB.RepeatBehavior = RepeatBehavior.Forever;
            WAB.AutoReverse = true;
            btnLink.BeginAnimation(WidthProperty, WAB);

            DoubleAnimation HAB = new DoubleAnimation(); // Высота кнопки
            HAB.From = 50;
            HAB.To = 80;
            HAB.Duration = TimeSpan.FromSeconds(1);
            HAB.RepeatBehavior = RepeatBehavior.Forever;
            HAB.AutoReverse = true;
            btnLink.BeginAnimation(HeightProperty, HAB);

            DoubleAnimation FSAB = new DoubleAnimation(); // Изменение размера шрифта у кнопки
            FSAB.From = 16;
            FSAB.To = 28;
            FSAB.Duration = TimeSpan.FromSeconds(1);
            FSAB.RepeatBehavior = RepeatBehavior.Forever;
            FSAB.AutoReverse = true;
            btnLink.BeginAnimation(FontSizeProperty, FSAB);

            ThicknessAnimation MAB = new ThicknessAnimation(); // изменение границ кнопки
            MAB.From = new Thickness(0, 0, 0, 0);
            MAB.To = new Thickness(0, 0, 100, 0);
            MAB.Duration = TimeSpan.FromSeconds(2);
            MAB.RepeatBehavior = RepeatBehavior.Forever;
            MAB.AutoReverse = true;
            btnLink.BeginAnimation(MarginProperty, MAB);

            ColorAnimation BAB = new ColorAnimation(); // Изменение цвета кнопки
            ColorConverter CC = new ColorConverter();
            Color Cstart = (Color)CC.ConvertFrom("#FF28C1F2");
            btnLink.Background = new SolidColorBrush(Cstart);
            BAB.From = Cstart;
            BAB.To = (Color)CC.ConvertFrom("#FF63B1F3");
            BAB.Duration = TimeSpan.FromSeconds(2);
            BAB.RepeatBehavior = RepeatBehavior.Forever;
            FSAB.AutoReverse = true;
            btnLink.Background.BeginAnimation(SolidColorBrush.ColorProperty, BAB);

            ThicknessAnimation MABan = new ThicknessAnimation(); // анимация банера
            MABan.From = new Thickness(0, 0, 0, 0);
            MABan.To = new Thickness(0, 50, 50, 0);
            MABan.Duration = TimeSpan.FromSeconds(2);
            MABan.RepeatBehavior = RepeatBehavior.Forever;
            MABan.AutoReverse = true;
            bBanner.BeginAnimation(MarginProperty, MABan);

            DoubleAnimation FSATB = new DoubleAnimation(); // Изменение шрифта у TextBlock
            FSATB.From = 24;
            FSATB.To = 40;
            FSATB.Duration = TimeSpan.FromSeconds(1);
            FSATB.RepeatBehavior = RepeatBehavior.Forever;
            FSATB.AutoReverse = true;
            tbHeader.BeginAnimation(FontSizeProperty, FSATB);

            DoubleAnimation WAI = new DoubleAnimation(); // Ширина картинки
            WAI.From = 150;
            WAI.To = 200;
            WAI.Duration = TimeSpan.FromSeconds(2);
            WAI.RepeatBehavior = RepeatBehavior.Forever;
            WAI.AutoReverse = true;
            imPrice.BeginAnimation(WidthProperty, WAI);

            DoubleAnimation HAI = new DoubleAnimation(); // Высота картинки
            HAI.From = 150;
            HAI.To = 200;
            HAI.Duration = TimeSpan.FromSeconds(2);
            HAI.RepeatBehavior = RepeatBehavior.Forever;
            HAI.AutoReverse = true;
            imPrice.BeginAnimation(HeightProperty, HAI);
        }
    }
}
