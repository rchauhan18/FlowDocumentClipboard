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

namespace FlowDocumentClipboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void CheckClipboardData(object sender, RoutedEventArgs args)
        {
            IDataObject clipboardData = Clipboard.GetDataObject();
            //var clipboardContent = clipboardData.GetData(typeof(string));
            var clipboardContent = clipboardData.GetData(DataFormats.StringFormat);
            //var clipboardContent = clipboardData.GetData(DataFormats.Serializable);

            System.Diagnostics.Debug.WriteLine(clipboardContent);
            //if (clipboardContent.Contains("FixedPage")) {
            //    System.Diagnostics.Debug.WriteLine("Test Passed!");
            //}
        }
    }
}