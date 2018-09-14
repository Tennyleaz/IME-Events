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

namespace TextCompositionManager_Test
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            TextCompositionManager.AddPreviewTextInputHandler(tbSearch, OnPreviewTextInput);
            TextCompositionManager.AddPreviewTextInputStartHandler(tbSearch, OnPreviewTextInputStart);
            TextCompositionManager.AddPreviewTextInputUpdateHandler(tbSearch, OnPreviewTextInputUpdate);
        }

        private void OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            tbLog.Text += "PreviewTextInput\n";
        }
        private void OnPreviewTextInputStart(object sender, TextCompositionEventArgs e)
        {
            tbLog.Text += "PreviewTextInputStart\n";
        }
        private void OnPreviewTextInputUpdate(object sender, TextCompositionEventArgs e)
        {
            tbLog.Text += "PreviewTextInputStart\n";
        }

        private void tbSearch_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            tbLog.Text += "\nPreviewKeyDown\n";
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbLog.Text += "TextChanged\n";
        }
    }
}
