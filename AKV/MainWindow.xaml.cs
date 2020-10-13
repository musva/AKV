using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AKV
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Person> person2 = new ObservableCollection<Person>();
        public MainWindow()
        {
            InitializeComponent();
            cb1.ItemsSource = person2;
            cb1.DisplayMemberPath = "Name";
            cb1.SelectedValuePath = "Value";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person2.Add(new Person() { Name = "王五", Value = "25" });
        }

        private void cb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string aaa = cb1.SelectedValue.ToString();
            MessageBox.Show(aaa);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
