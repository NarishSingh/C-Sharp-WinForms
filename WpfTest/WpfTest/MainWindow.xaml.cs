using System.Windows;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button Click event handler - add a name to log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !listNames.Items.Contains(txtName))
            {
                listNames.Items.Add(txtName.Text);
                
                txtName.Clear();
            }
        }
    }
}