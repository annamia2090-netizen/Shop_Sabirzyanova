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

namespace Shop_Sabirzyanova.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        public Item(object ItemData)
        {
            InitializeComponent();
            Classes.Shop ShopData = ItemData as Classes.Shop;
            tb_Name.Content = ShopData.Name;
            tb_Price.Content = "Цена: " + ShopData.Price;
            if (ItemData is Classes.Children)
            {
                Classes.Children ChildrenData = ItemData as Classes.Children;
                tb_Characteristics.Content = "Возраст: " + ChildrenData.Age;
            }
            if (ItemData is Classes.Sport)
            {
                Classes.Sport SportData = ItemData as Classes.Sport;
                tb_Characteristics.Content = "Размер: " + SportData.Size;
            }
            if (ItemData is Classes.Electronics)
            {
                Classes.Electronics ElectronicsData = ItemData as Classes.Electronics;
                tb_Characteristics.Content = "Емкость аккумулятора: : " + ElectronicsData.BatteryCapacity + " мАч";
                tb_Characteristics2.Content = "Скорость езды: " + ElectronicsData.MaxSpeed + " км/ч";
            }
        }
    }
}
