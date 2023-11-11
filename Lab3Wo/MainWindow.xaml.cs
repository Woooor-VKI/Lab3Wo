using Lab3Wo.Classes;
using Lab3Wo.Models;
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

namespace Lab3Wo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Output(InfTriangle triangle)
        {
            Result.Text = $"Сторона 1: → {triangle.One} \nСторона 2: → {triangle.Two} \nСторона 3: → {triangle.Three} \nТип треугольника:↓\n      →{triangle.Type}← \n{triangle.Exception}";
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            InfTriangle triangle = Controller.GetControl(Text_One.Text, Text_Two.Text, Text_Three.Text);
            Output(triangle);
        }
    }
}
