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

namespace WpfApp2
{
    public partial class MainWindow:Window
    {
        private void Window_MouseLeftButtonDown(object sen, MouseButtonEventArgs x)
        {
            Button кнопка = new Button  //Создание кнопки, которая будет появляться при клике в любое свободное местоэ
            {
                Content = "Тыкай",   //Напишем текст, который будет внутри этой кнопки
                Background = Brushes.DarkRed,    //Зададим цвет самой кнопки  
                Foreground = Brushes.Lime,       //Зададим цвет текста внутри кнопки
                Height = 30,   //Зададим размер кнопки, а именно высоту кнопки
                Width = 60,    //Зададим размер кнопки, а именно длинну кнопки
            };

            Point положение = x.GetPosition(Рандом);    //Запишем команду для определения позиции кнопки в месте клика
            Canvas.SetLeft(кнопка, положение.X);   //Определим положение по Х
            Canvas.SetTop(кнопка, положение.Y);    //Определим положение по У
            Рандом.Children.Add(кнопка);           //Добавим кнопки на  Canvas
        }
    }
}