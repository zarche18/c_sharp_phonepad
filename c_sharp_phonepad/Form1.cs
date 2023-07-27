using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_phonepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string inputText = string.Empty;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string ouptput = OldPhonePad(inputText);
            txtOutput.Text = ouptput.ToLower();
            inputText = string.Empty;
        }
        public static string OldPhonePad(string inputS)
        {
            string result = string.Empty;
            string[] nums = { "", "", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ" };
            char[] instr = inputS.ToCharArray();

            // Traverse the string str
            int i = 0;
            while (i < instr.Length)
            {
                int count = 0;
                while (i + 1 < instr.Length
                       && instr[i] == instr[i + 1])
                {

                    // 2, 3, 4, 5, 6 and 8 keys will
                    // have maximum of 3 letters
                    if (count == 2
                        && ((instr[i] >= '2' && instr[i] <= '6')
                            || (instr[i] == '8')))
                        break;

                    // 7 and 9 keys will have
                    // maximum of 4 keys
                    else if (count == 3
                             && (instr[i] == '7'
                                 || instr[i] == '9'))
                        break;
                    count++;
                    i++;

                    // Handle the end condition
                    if (i == instr.Length)
                        break;
                }

                // key is 7 or 9
                if (instr[i] == '7' || instr[i] == '9')
                {
                    result += Convert.ToString(nums[instr[i] - 48][count % 4]);
                }
                // key is 0 [1]
                else if (instr[i] == '1')
                {

                }
                // key is 0 [space]
                else if (instr[i] == ' ')
                {

                }
                // either 2, 3, 4, 5, 6 or 8
                else
                {
                    result += Convert.ToString(nums[instr[i] - 48][count % 3]);
                }
                i++;
            }

            return result;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            inputText += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            inputText += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            inputText += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            inputText += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            inputText += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            inputText += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            inputText += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            inputText += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            inputText += "9";
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            inputText += " ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
            inputText = inputText.Substring(0, inputText.Length - 1);
        }
    }
}
