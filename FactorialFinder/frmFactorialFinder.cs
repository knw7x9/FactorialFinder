// frmFactorialFinder.cs, FactorialFinder.sln
// CS 1181
// Katherine Wilsdon
// 21 September 2018
// Dr. Cody Permann
/* Description - Create a factorial finder. The user selects a number between 1 and 20 on the trackbar. 
 * The program calculates all the factorials between 1 and the selected number and outputs the factorials
 * into read-only textboxes that are stored in long variables and short variables. */
/* WOW:
 * 1. Add a checkbox that outputs the factorials in the reverse order.
 * 2. Add a checkbox that randomizes the input instead of reading from the trackbar.
 * 3. Use methods to avoid repetition of code. */
/* Cited: 
 * 1. Extracting the value from the trackbar: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.trackbar.value?view=netframework-4.7.2 
 * 2. ToString to the tens digit: https://stackoverflow.com/questions/2947675/int-value-under-10-convert-to-string-two-digit-number 
 * 5. Book, Chapters 4,5, and 6: Gaddis, T. (2017). Starting out with Visual C# (4th ed.). Boston, PA: Pearson. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialFinder {
    public partial class frmFactorialFinder : Form {
        public frmFactorialFinder() {
            InitializeComponent();
        }

        // Calculates the reverse factorials that are stored as long variables and integer variables 
        private void ReverseFactorials() {
            int trackbar = trOneToTwenty.Value;

            // Output all the factorials between the selected number and 1
            for (int i = trackbar; i >= 1; i--) {

                // Output the reverse factorials stored as long variables
                long longFactorialTotal = 1;
                for (int j = i; j >= 1; j--) {
                    longFactorialTotal *= j;

                    if (j > 1) {
                        txtLongFactorials.Text += j + "*";
                    }
                    if (j == 1) {
                        txtLongFactorials.Text += j + " = " + longFactorialTotal.ToString("n0") + "\r\n";
                    }
                }
                txtLongFactorialsDisplay.Text += i.ToString("00") + "!\r\n";

                // Output the reverse factorials stored as integer variables
                int intFactorialTotal = 1;
                for (int j = i; j >= 1; j--) {
                    intFactorialTotal *= j;
                    if (j > 1) {
                        txtIntFactorials.Text += j + "*";
                    }
                    if (j == 1) {
                        txtIntFactorials.Text += j + " = " + intFactorialTotal.ToString("n0");
                        if (intFactorialTotal != longFactorialTotal) {
                            txtIntFactorials.Text += "( Data overflow!)";
                        }
                    }
                }
                txtIntFactorials.Text += "\r\n";
                txtIntFactorialsDisplay.Text += i.ToString("00") + "!\r\n";
            }
        }
        // Calculates the forward factorials that are stored as long variables and integer variables
        private void ForwardFactorials() {
            int trackbar = trOneToTwenty.Value;

            // Output all the factorials between 1 and the selected number
            for (int i = 1; i <= trackbar; i++) {

                // Output the forward factorials stored as long variables
                long longFactorialTotal = 1;
                for (int j = 1; j <= i; j++) {
                    longFactorialTotal *= j;
                    if (j < i) {
                        txtLongFactorials.Text += j + "*";
                    }
                    if (j == i) {
                        txtLongFactorials.Text += j + " = " + longFactorialTotal.ToString("n0") + "\r\n";
                    }
                }
                txtLongFactorialsDisplay.Text += i.ToString("00") + "!\r\n";

                // Output the forward factorials stored as integer variables
                int intFactorialTotal = 1;
                for (int j = 1; j <= i; j++) {

                    intFactorialTotal *= j;
                    if (j < i) {
                        txtIntFactorials.Text += j + "*";
                    }
                    if (j == i) {
                        txtIntFactorials.Text += j + " = " + intFactorialTotal.ToString("n0");
                        if (intFactorialTotal != longFactorialTotal) {
                            txtIntFactorials.Text += "( Data overflow!)";
                        }
                    }
                }
                txtIntFactorials.Text += "\r\n";
                txtIntFactorialsDisplay.Text += i.ToString("00") + "!\r\n";
            }
        }

        // Randomizes the input on the trackbar
        private void RandomizeFactorials() {
            Random random = new Random();
            trOneToTwenty.Value = random.Next(20) + 1;
            lblTrackbarNumber.Text = trOneToTwenty.Value.ToString();
            int trackbar = trOneToTwenty.Value;
        }

        // Clears the textboxes on the form
        private void ClearTextboxes() {
            txtLongFactorialsDisplay.Text = "";
            txtLongFactorials.Text = "";
            txtIntFactorialsDisplay.Text = "";
            txtIntFactorials.Text = "";
        }

        // Update the label according to the value on the the trackbar
        private void trOneToTwenty_Scroll(object sender, EventArgs e) {
            int trackbar = trOneToTwenty.Value;
            lblTrackbarNumber.Text = trackbar.ToString();
        }

        // Outputs the generated factorials on the form
        private void btnGenerateFactorials_Click(object sender, EventArgs e) {
            ClearTextboxes();

            // Show labels
            lblLong.Text = "Outputs stored in long";
            lblInt.Text = "Outputs stored in int";

            // when the randomized checkbox is checked
            if (chkRandomize.Checked == true) {
                // when the reverse checkbox is checked or unchecked
                if (chkReverse.Checked == true) {
                    RandomizeFactorials();
                    ReverseFactorials();
                } else if (chkReverse.Checked == false) {
                    RandomizeFactorials();
                    ForwardFactorials();
                }
            }

            // when the randomized checkbox in unchecked 
            else if (chkRandomize.Checked == false) {
                // when the reverse checkbox is checked or unchecked
                if (chkReverse.Checked == true) {
                    ReverseFactorials();
                } else if (chkReverse.Checked == false) {
                    ForwardFactorials();
                }
            }
        }

        // Clears the textboxes and labels, unchecks the the checkboxes, and resets the trackbar and trackbar label to 1
        private void btnClear_Click(object sender, EventArgs e) {
            trOneToTwenty.Value = 1;
            lblTrackbarNumber.Text = "1";
            txtLongFactorialsDisplay.Text = "";
            txtLongFactorials.Text = "";
            txtIntFactorialsDisplay.Text = "";
            txtIntFactorials.Text = "";
            lblLong.Text = "";
            lblInt.Text = "";
            chkReverse.Checked = false;
            chkRandomize.Checked = false;
        }

        // Closes the form
        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
