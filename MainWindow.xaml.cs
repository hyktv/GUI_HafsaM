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

namespace GUI_HafsaM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    //HAFSA MOHAMED OCT. 30 - GUI_HafsaM

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //create string variables
            //string num1 = txtNum1.Text;
            //string num2 = txtNum2.Text;

            //parse string variables into numbers
            double numba1 = double.Parse(txtNum1.Text);
            double numba2 = double.Parse(txtNum2.Text); 
            //um guess i found an easier way i should really
            //start experimenting what my mind tells me lol

            //create sign change
            //(the add or subtract label)
            string sign = "+";
            lblAddOrSubtract.Content = sign;

            //add the 2 numbers together
            //to get the result
            double result = numba1 + numba2;
            
            //covert it back to string and display result
            string w = $"{result}";
            txtResult1.Text = w;

            //create a message box for an invalid number
                       

        }//addition button



        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            //create string variables
            string num1 = txtNum1.Text;
            string num2 = txtNum2.Text;

            //parse string variables into numbers
            double numba1 = double.Parse(num1);
            double numba2 = double.Parse(num2);

            //create sign change
            //(the add or subtract label)
            string sign = "-";
            lblAddOrSubtract.Content = sign;

            //create equation and display result
            double result1 = numba1 - numba2;
            string x = $"{result1}";
            txtResult1.Text = x;

        }//subtraction button



        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            //create string variables
            string num3 = txtNum3.Text;
            string num4 = txtNum4.Text;

            //parse string variables into numbers
            double numba3 = double.Parse(num3);
            double numba4 = double.Parse(num4);

            //create sign change
            //(the multiply or divide label)
            string sign = "*";
            lblMultipyOrDivide.Content = sign;

            //create equation and display result
            double result2 = numba3 * numba4;
            string y = $"{result2}";
            txtResult2.Text = y;

        }//multiplication button



        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            //create string variables
            string num3 = txtNum3.Text;
            string num4 = txtNum4.Text;

            //parse string variables into numbers
            double numba3 = double.Parse(num3);
            double numba4 = double.Parse(num4);

            //create sign change
            //(the multiply or divide label)
            string sign = "/";
            lblMultipyOrDivide.Content = sign;

            //create equation and display result
            double result3 = numba3 / numba4;
            string z = $"{result3}";
            txtResult2.Text = z;

        }//division button



        private void btnAverage_Click(object sender, RoutedEventArgs e)
        {
            //lets find out how to display the average
            //(result 1 + result 2) / 2 = AVERAGE
            string a = txtResult1.Text;
            string b = txtResult2.Text;

            //idk if we're supposed to parse but lets try
            //edit: ofc we are, u have to turn it into
            //a numberrrrrr!!!!!
            double result1 = double.Parse(a);
            double result2 = double.Parse(b);

            //create the equation and display the result
            double equation = (result1 + result2) / 2;
            string c = $"{equation}";
            txtAverage.Text = c;
            
        }//average button



    }//class



}//namespace
