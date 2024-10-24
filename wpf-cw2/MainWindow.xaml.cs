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

namespace wpf_cw2
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            txtFunction.Text = String.Empty;
            txtResult.Text = String.Empty;
            double doubleWspA;
            double doubleWspB;
            double doubleWspC;
            if (double.TryParse(wspA.Text, out doubleWspA) && double.TryParse(wspB.Text, out doubleWspB) && double.TryParse(wspC.Text, out doubleWspC)) 
            {
                QuadraticFunction qf = new QuadraticFunction(doubleWspA, doubleWspB, doubleWspC);
                txtResult.Text = qf.calculate().ToString();
                txtFunction.Text = qf.showFunction();
            } else
            {
                txtResult.Text = "Nieprawidłowe parametry";
            }
        }
    }
}