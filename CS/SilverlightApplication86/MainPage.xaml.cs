using System.Windows;
using System.Windows.Controls;

namespace SilverlightApplication86
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            richeditor.ApplyTemplate();
            richeditor.Loaded += new RoutedEventHandler(richeditor_Loaded);
        }

        void richeditor_Loaded(object sender, RoutedEventArgs e)
        {
            richeditor.RichControl.Text = @"Use control template to selectively hide AgRichEdit elements.
In this example the Zoom slider in the status bar is hidden.";
            
        }
    }
}
