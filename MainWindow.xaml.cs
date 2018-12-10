using System;
using System.Collections.Generic;
using System.Data;
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

namespace startedWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private String lastChar { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void BtnNumber1_Click(object sender, RoutedEventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = (sender as Button).Content.ToString();
            }
            else
            {
                txtScreen.Text += (sender as Button).Content.ToString();
            }
        }

        private void BtnNumber2_Click(object sender, RoutedEventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = (sender as Button).Content.ToString();
            }
            else
            {
                txtScreen.Text += (sender as Button).Content.ToString();
            }
        }

        private void BtnNumber4_Click(object sender, RoutedEventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = (sender as Button).Content.ToString();
            }
            else
            {
                txtScreen.Text += (sender as Button).Content.ToString();
            }
        }

        private void BtnNumber5_Click(object sender, RoutedEventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = (sender as Button).Content.ToString();
            }
            else
            {
                txtScreen.Text += (sender as Button).Content.ToString();
            }
        }

        private void BtnNumber6_Click(object sender, RoutedEventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = (sender as Button).Content.ToString();
            }
            else
            {
                txtScreen.Text += (sender as Button).Content.ToString();
            }
        }

        private void BtnNumber7_Click(object sender, RoutedEventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = (sender as Button).Content.ToString();
            }
            else
            {
                txtScreen.Text += (sender as Button).Content.ToString();
            }
        }

        private void BtnNumber8_Click(object sender, RoutedEventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = (sender as Button).Content.ToString();
            }
            else
            {
                txtScreen.Text += (sender as Button).Content.ToString();
            }
        }

        private void BtnNumber9_Click(object sender, RoutedEventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = (sender as Button).Content.ToString();
            }
            else
            {
                txtScreen.Text += (sender as Button).Content.ToString();
            }
        }

        private void BtnNumber0_Click(object sender, RoutedEventArgs e)
        {
            if (txtScreen.Text == "0") {
                txtScreen.Text = "0";
            }
            else {
                txtScreen.Text += (sender as Button).Content.ToString();
            }
            
        }

        private void BtnClearScreen_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.Text = "0";
        }

        private void BtnNumber3_Click(object sender, RoutedEventArgs e)
        {
            if (txtScreen.Text == "0")
            {
                txtScreen.Text = (sender as Button).Content.ToString();
            }
            else
            {
                txtScreen.Text += (sender as Button).Content.ToString();
            }
        }

        private void BtnMinus_Click(object sender, RoutedEventArgs e)
        {
            lastChar = txtScreen.Text.Substring(txtScreen.Text.Length - 1, 1);
            if (lastChar=="-") {
                return;
            }
            if ("+ * /".ToLower().Contains(lastChar))
            {
                string stamp = txtScreen.Text.Remove(txtScreen.Text.Length - 1);
                txtScreen.Text = stamp;
            }
            txtScreen.Text += "-";

        }

        private void BtnSum_Click(object sender, RoutedEventArgs e)
        {
            lastChar = txtScreen.Text.Substring(txtScreen.Text.Length - 1, 1);
            if (lastChar == "+")
            {
                return;
            }
            if ("- * /".ToLower().Contains(lastChar))
            {
                string stamp = txtScreen.Text.Remove(txtScreen.Text.Length - 1);
                txtScreen.Text = stamp;
            }
            txtScreen.Text += (sender as Button).Content.ToString();
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            lastChar = txtScreen.Text.Substring(txtScreen.Text.Length - 1, 1);
            if (lastChar == "*")
            {
                return;
            }
            if ("- + /".ToLower().Contains(lastChar))
            {
                string stamp = txtScreen.Text.Remove(txtScreen.Text.Length - 1);
                txtScreen.Text = stamp;
            }
            txtScreen.Text += (sender as Button).Content.ToString();
        }

        private void BtnDivision_Click(object sender, RoutedEventArgs e)
        {
            lastChar = txtScreen.Text.Substring(txtScreen.Text.Length - 1, 1);
            if (lastChar == "/")
            {
                return;
            }
            if ("- * +".ToLower().Contains(lastChar))
            {
                string stamp = txtScreen.Text.Remove(txtScreen.Text.Length - 1);
                txtScreen.Text = stamp;
            }
            txtScreen.Text += (sender as Button).Content.ToString();
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.Text = new DataTable().Compute(txtScreen.Text, null).ToString();
        }
    }
}
