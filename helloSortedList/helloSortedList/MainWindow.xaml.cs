using System;
using System.Collections;
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

namespace helloSortedList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList S;
        public MainWindow()
        {
            InitializeComponent();
            S = new SortedList();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            S.Add(key.Text,value.Text);
            string data = null ;
            ICollection collection = S.Keys;
            foreach (string key in collection) 
            {
                data = data + '\n' + S[key].ToString();
            
            }
            MessageBox.Show(data);
        }
    }
}
