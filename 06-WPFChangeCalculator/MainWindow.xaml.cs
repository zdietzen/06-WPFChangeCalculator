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

namespace _06_WPFChangeCalculator
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

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            string TPinput = textBoxTP.Text;
            string ARinput = textBoxAR.Text;
            decimal TotalPrice = Convert.ToDecimal(TPinput);
            decimal TotalRecieved = Convert.ToDecimal(ARinput);
            //math to get change and then displays it
            decimal change = TotalRecieved - TotalPrice;
            string stringchange = change.ToString("C");

            changeTxt.Text = stringchange;

            //number of each bill to return
            decimal NumOf100s = Math.Floor(change / 100.00M);
            decimal NumOf50s = Math.Floor(change % 100.00M / 50.00M);
            decimal NumOf20s = Math.Floor((change % 100.00M % 50.00M) / 20.00M);
            decimal NumOf10s = Math.Floor(((change % 100.00M % 50.00M) % 20.00M) / 10.00M);
            decimal NumOf5s = Math.Floor((((change % 100.00M % 50.00M) % 20.00M) % 10.00M) / 5.00M);
            decimal NumOf1s = Math.Floor(((((change % 100.00M % 50.00M) % 20.00M) % 10.00M) % 5.00M) / 1.00M);
            //number of each coin to return
            decimal numberOfQuarters = Math.Floor(change / 0.25M);
            decimal numberOfQuartersAfter = Math.Floor(numberOfQuarters % 4);
            decimal numberOfDimes = Math.Floor((change % 0.25M) / 0.10M);
            decimal numberOfNickles = Math.Floor(((change % 0.25M) % 0.10M / 0.05M));
            decimal numberOfPennies = Math.Floor((((change % 0.25M) % 0.10M % 0.05M / 0.01M)));

            //Converts all decimals to strings and formats them into a currency so 
            string stringnumOf100s = NumOf100s.ToString();
            string stringnumOf50s = NumOf50s.ToString();
            string stringnumOf20s = NumOf20s.ToString();
            string stringnumOf10s = NumOf10s.ToString();
            string stringnumOf5s = NumOf5s.ToString();
            string stringnumOf1s = NumOf1s.ToString();

            string stringnumberOfQuarters = numberOfQuartersAfter.ToString();
            string stringnumberOfDimes = numberOfDimes.ToString();
            string stringnumberOfNickles = numberOfNickles.ToString();
            string stringnumberOfPennies = numberOfPennies.ToString();
            //Displays the number of each bill
            numOf100stxt.Text = stringnumOf100s;
            numOf50stxt.Text = stringnumOf50s;
            numOf20stxt.Text = stringnumOf20s;
            numOf10stxt.Text = stringnumOf10s;
            numOf5stxt.Text = stringnumOf5s;
            numOf1stxt.Text = stringnumOf1s;
            //Displays the number of each coin
            numOfQuarterstxt.Text = stringnumberOfQuarters;
            numOfDimestxt.Text = stringnumberOfDimes;
            numOfNicklestxt.Text = stringnumberOfNickles;
            numOfPenniestxt.Text = stringnumberOfPennies;
        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            textBoxTP.Text = textBoxAR.Text = changeTxt.Text = numOf100stxt.Text = numOf50stxt.Text = numOf20stxt.Text = numOf10stxt.Text = numOf5stxt.Text = numOf1stxt.Text =
            numOfQuarterstxt.Text = numOfDimestxt.Text = numOfNicklestxt.Text = numOfPenniestxt.Text = "";
        }
    }
}
