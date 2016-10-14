using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace WindowsPhoneCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string inputNumber;
        private int result = 0, totalResult;
        private double resultDouble = 0.0;
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            if(txtInput.Text != "0")
            {
                txtInput.Text = txtInput.Text + "0";
            }
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (!txtInput.Text.Contains("."))
            {
                txtInput.Text = txtInput.Text + ".";
            }
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text != "0")
            {
                txtInput.Text = txtInput.Text + "1";
            }else
            {
                txtInput.Text = "1";
            }
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text != "0")
            {
                txtInput.Text = txtInput.Text + "2";
            }
            else
            {
                txtInput.Text = "2";
            }
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text != "0")
            {
                txtInput.Text = txtInput.Text + "3";
            }
            else
            {
                txtInput.Text = "3";
            }
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text != "0")
            {
                txtInput.Text = txtInput.Text + "4";
            }
            else
            {
                txtInput.Text = "4";
            }
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text != "0")
            {
                txtInput.Text = txtInput.Text + "5";
            }
            else
            {
                txtInput.Text = "5";
            }
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text != "0")
            {
                txtInput.Text = txtInput.Text + "6";
            }
            else
            {
                txtInput.Text = "6";
            }
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text != "0")
            {
                txtInput.Text = txtInput.Text + "7";
            }
            else
            {
                txtInput.Text = "7";
            }
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text != "0")
            {
                txtInput.Text = txtInput.Text + "8";
            }
            else
            {
                txtInput.Text = "8";
            }
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text != "0")
            {
                txtInput.Text = txtInput.Text + "9";
            }
            else
            {
                txtInput.Text = "9";
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = "0";
            tbPreview.Text = "";
            inputNumber = "";
            result = 0;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!tbPreview.Text.Contains("+"))
            {
                totalResult = 0; 
                inputNumber = txtInput.Text;
                tbPreview.Text = inputNumber + " + ";
                txtInput.Text = "0";
            }
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (!tbPreview.Text.Contains("-"))
            {
                inputNumber = txtInput.Text;
                tbPreview.Text = inputNumber + " - ";
                txtInput.Text = "0";
            }
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (!tbPreview.Text.Contains("x"))
            {
                inputNumber = txtInput.Text;
                tbPreview.Text = inputNumber + " x ";
                txtInput.Text = "0";
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (!tbPreview.Text.Contains("/"))
            {
                inputNumber = txtInput.Text;
                tbPreview.Text = inputNumber + " / ";
                txtInput.Text = "0";
            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            if (tbPreview.Text.Contains("+"))
            {
                //add
                tbPreview.Text = inputNumber + " + " + txtInput.Text;
                if (inputNumber.Contains(".") || txtInput.Text.Contains("."))
                {
                    txtInput.Text = (double.Parse(inputNumber) + double.Parse(txtInput.Text)).ToString();
                    resultDouble = double.Parse(txtInput.Text);
                }
                else
                {
                    txtInput.Text = (int.Parse(inputNumber) + int.Parse(txtInput.Text)).ToString();
                    result = int.Parse(txtInput.Text);
                }                                                
            }else if (tbPreview.Text.Contains("-"))
            {
                //minus
                tbPreview.Text = inputNumber + " - " + txtInput.Text;
                if (inputNumber.Contains(".") || txtInput.Text.Contains("."))
                {
                    txtInput.Text = (double.Parse(inputNumber) - double.Parse(txtInput.Text)).ToString();
                    resultDouble = double.Parse(txtInput.Text);
                }
                else
                {
                    txtInput.Text = (int.Parse(inputNumber) - int.Parse(txtInput.Text)).ToString();
                    result = int.Parse(txtInput.Text);
                }                
            }else if (tbPreview.Text.Contains("x"))
            {
                //multiply
                tbPreview.Text = inputNumber + " * " + txtInput.Text;
                if (inputNumber.Contains(".") || txtInput.Text.Contains("."))
                {
                    txtInput.Text = (double.Parse(inputNumber) * double.Parse(txtInput.Text)).ToString();
                    resultDouble = double.Parse(txtInput.Text);
                }
                else
                {
                    txtInput.Text = (int.Parse(inputNumber) * int.Parse(txtInput.Text)).ToString();
                    result = int.Parse(txtInput.Text);
                }             
            }
            if (tbPreview.Text.Contains("/"))
            {
                //divide
                tbPreview.Text = inputNumber + " / " + txtInput.Text;
                if (inputNumber.Contains(".") || txtInput.Text.Contains("."))
                {
                    txtInput.Text = (double.Parse(inputNumber) / double.Parse(txtInput.Text)).ToString();
                    resultDouble = double.Parse(txtInput.Text);
                }
                else
                {
                    txtInput.Text = (int.Parse(inputNumber) / int.Parse(txtInput.Text)).ToString();
                    result = int.Parse(txtInput.Text);
                }                
            }
        }

        private void btnBackspace_Click(object sender, RoutedEventArgs e)
        {
            if(txtInput.Text != "0" && txtInput.Text.Length > 0)
            {
                string text = txtInput.Text.Remove(txtInput.Text.Length - 1);
                if(text == "")
                {
                    txtInput.Text = "0";
                }
                else
                {
                    txtInput.Text = text;
                }                
            }
            else
            {
                txtInput.Text = "0";
            }
        }

        private void btnPlusOrMinus_Click(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            number = -number;
            txtInput.Text = "" + number;
        }
    }
}
