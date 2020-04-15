using System;
using System.Collections.Generic;
using System.Windows;

namespace DynamoWPFSample.UI
{

    /// <summary>
    /// Interaction logic for SampleWindow.xaml
    /// </summary>
    
    partial class SampleWindow : Window
    {
        public SampleWindow(List<Object> list)
        {
            InitializeComponent();

            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            //this allows us to bind the listbox to the input list
            ItemList = list;
            DataContext = this;
        }
        
        public List<Object> ItemList { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
