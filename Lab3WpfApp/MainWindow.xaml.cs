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

namespace Lab3WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (text!=null)
            text.FontFamily = new FontFamily(fontName);
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            object fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (text != null)
                text.FontSize = Convert.ToDouble(fontSize);
        }

        bool isBold;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (text != null)
            {
                if (!isBold)
                    text.FontWeight = FontWeights.Bold;
                else
                    text.FontWeight = FontWeights.Normal;
                isBold = !isBold;
            }
                
        }

        bool isItalic;
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!isItalic)
                text.FontStyle = FontStyles.Italic;
            else
                text.FontStyle = FontStyles.Normal;
            isItalic = !isItalic;
        }

        bool isUnderline;
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!isUnderline)
                text.TextDecorations = TextDecorations.Underline;
            else
                text.TextDecorations = null;
            isUnderline = !isUnderline;
        }

        private void BlackRadioButton_Click(object sender, RoutedEventArgs e)
        {
            text.Foreground = Brushes.Black;
        }

        private void GreenRadioButton_Click(object sender, RoutedEventArgs e)
        {
            text.Foreground = Brushes.Green;
        }
    }
}
