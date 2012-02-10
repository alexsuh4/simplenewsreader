using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NewsReaderSharedLibabry;
using System.Windows.Threading;

namespace WPFNewsReader
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public Window1()
        {
            InitializeComponent();
            timer.Tick += (s, e) => {  RefreshView(); };
            timer.Interval = new TimeSpan(0, 2, 0);
            timer.Start();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshView();
            
        }

        private void RefreshView()
        {
            
            newsFeedList.DataContext =
                 from evt in ContentProvider.GetData()
                 select evt.Display;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            RefreshView();
        }
        
    }
}
