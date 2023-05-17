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

namespace MIAPO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MyTable _selectedItemDataGrid;

        private List<MyTable> list;

        public MainWindow()
        {
            InitializeComponent();

            DataGrid.ItemsSource = MethodDataSourse.DataList();
            list = MethodDataSourse.DataList();

            comboBox_select.ItemsSource = MethodDataSourse.DataListStr();
            comboBox_select.SelectedItem = "Все";
            
            CB.ItemsSource = new List<string>(MethodDataSourse.DataList().Select(x => x.Surname));
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = MethodChangeStatus.ChangeStatus((MyTable)DataGrid.SelectedItem, new List<MyTable>(DataGrid.ItemsSource as List<MyTable>));
        }

        private void ComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)e.OriginalSource;
            if (tb.SelectionStart != 0)
            {
                CB.SelectedItem = null; // Если набирается текст сбросить выбраный элемент
                DataGrid.ItemsSource = list;
            }
            if (tb.SelectionStart == 0 && CB.SelectedItem == null)
            {
                CB.IsDropDownOpen = false; // Если сбросили текст и элемент не выбран, сбросить фокус выпадающего списка
                DataGrid.ItemsSource = list;
            }

            CB.IsDropDownOpen = true;
            if (CB.SelectedItem == null)
            {
                // Если элемент не выбран менять фильтр
                CollectionView cv = (CollectionView)CollectionViewSource.GetDefaultView(CB.ItemsSource);
                cv.Filter = s => ((string)s).IndexOf(CB.Text, StringComparison.CurrentCultureIgnoreCase) >= 0;
            }
            else
            {
                var array = list.Where(x => x.Surname == CB.SelectedItem).ToList();
                DataGrid.ItemsSource = array;
            }
        }

        private void ComboBox_Selection(object sender, SelectionChangedEventArgs e)
        {
            list = MethodSelection.Selection(comboBox_select.SelectedItem.ToString(), list);
        }

        private void button_delete(object sender, RoutedEventArgs e)
        {
            DataGrid.ItemsSource = MethodRemove.RemoveSelected(list);
        }
    }
}
