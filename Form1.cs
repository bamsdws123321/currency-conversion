using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_exchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert_but_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "Enter the amount" && textBox1.Text != " " )
            {
                if (Form_comboBox.Text != "")
                 {
                    if (To_comboBox2.Text != "")
                    {

                        if (Form_comboBox.Text == "YER")
                        {

                            if (To_comboBox2.Text == "SAR")
                            {
                                Result_textBox.Text = (double.Parse(textBox1.Text.ToString()) / 612).ToString();
                            }
                            else if (To_comboBox2.Text == "USD")
                            {
                                Result_textBox.Text = (double.Parse(textBox1.Text.ToString()) / 612 / 3.8).ToString();
                            }
                            else if (To_comboBox2.Text == "AED")
                            {
                                Result_textBox.Text = (double.Parse(textBox1.Text.ToString()) / 1.02 / 612).ToString();

                            }
                            else if (To_comboBox2.Text == "YER")
                            {
                                Result_textBox.Text = textBox1.Text;

                            }

                            else
                            {
                                Result_textBox.Text = "";
                            }
                        }

                        else if (Form_comboBox.Text == "SAR")
                        {
                            if (To_comboBox2.Text == "YER")
                            {
                                Result_textBox.Text = (double.Parse(textBox1.Text.ToString()) * 612).ToString();
                            }
                            else if (To_comboBox2.Text == "USD")
                            {
                                Result_textBox.Text = (double.Parse(textBox1.Text.ToString()) / 3.8).ToString();
                            }
                            else if (To_comboBox2.Text == "AED")
                            {
                                Result_textBox.Text = (double.Parse(textBox1.Text.ToString()) / 0.98).ToString();

                            }
                            else if (To_comboBox2.Text == "SAR")
                            {
                                Result_textBox.Text = textBox1.Text;

                            }

                            else
                            {
                                Result_textBox.Text = "";
                            }
                        }

                        else if (Form_comboBox.Text == "USD")
                        {
                            if (To_comboBox2.Text == "YER")
                            {
                                Result_textBox.Text = (double.Parse(textBox1.Text.ToString()) * 612 * 3.8).ToString();
                            }
                            else if (To_comboBox2.Text == "SAR")
                            {
                                Result_textBox.Text = (double.Parse(textBox1.Text.ToString()) * 3.8).ToString();
                            }
                            else if (To_comboBox2.Text == "AED")
                            {
                                Result_textBox.Text = (double.Parse(textBox1.Text.ToString()) * 3.67).ToString();

                            }
                            else if (To_comboBox2.Text == "USD")
                            {
                                Result_textBox.Text = textBox1.Text;

                            }

                            else
                            {
                                Result_textBox.Text = "";
                            }
                        }

                        else if (Form_comboBox.Text == "AED")
                        {
                            if (To_comboBox2.Text == "YER")
                            {
                                Result_textBox.Text = (double.Parse(textBox1.Text.ToString()) * 1.02 * 612).ToString();
                            }
                            else if (To_comboBox2.Text == "SAR")
                            {
                                Result_textBox.Text = (double.Parse(textBox1.Text.ToString()) * 1.02).ToString();
                            }
                            else if (To_comboBox2.Text == "USD")
                            {
                                Result_textBox.Text = (double.Parse(textBox1.Text.ToString()) * 0.27).ToString();

                            }
                            else if (To_comboBox2.Text == "AED")
                            {
                                Result_textBox.Text = textBox1.Text;

                            }

                            else
                            {
                                Result_textBox.Text = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the currency you want to convert to in the Text Box (( To ))");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the currency you want to convert from in the Text Box (( From: ))");
                }
               
            }

            else
            {
                MessageBox.Show("Please enter the amount you want to conver");
           }
            }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Enter the amount")
            {
                
                    textBox1.Text = "";
                    
                    

                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter the amount";

                textBox1.ForeColor = Color.Silver;
            }
        }

        private void Number_only(KeyPressEventArgs e)
        {
          switch(e.KeyChar)
            {
                case '0': case '1': case '2': case '3': case '4': case '5': case '6': case '7': case '8': case '9': case (char)Keys.Back:case (char)Keys.Enter:
                    e.Handled = false;
                    break;

                case '.':
                    if(!textBox1.Text.Contains('.'))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;

                default:
                    MessageBox.Show("Please use number only , your use is : " + e.KeyChar);
                    e.Handled = true;
                    break;

            }
        

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Number_only(e);       
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                Convert_but.PerformClick();
            }
           
        }

        private void Form_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (Form_comboBox.Text == "AED")
                label6.Text = "Transfer the amount to Emirati Dirham";
                
            else if (Form_comboBox.Text == "YER")
                label6.Text = "Transfer the amount from Yemeni Riyals";

            else if (Form_comboBox.Text == "SAR")
                label6.Text = "Transfer the amount from Saudi Riyals";

            else if (Form_comboBox.Text == "USD")
                label6.Text = "Transfer the amount from American Dollar";

            else
                label6.Text = "";
            

        }

        private void To_comboBox2_TextChanged(object sender, EventArgs e)
        {
            if (To_comboBox2.Text == "AED")                      
                label7.Text = "Transfer the amount to Emirati Dirham "; 
                      
            else if (To_comboBox2.Text == "YER")
                label7.Text = "Transfer the amount to Yemeni Riyals";

            else if (To_comboBox2.Text == "SAR")
                label7.Text = "Transfer the amount to Saudi Riyals";

            else if (To_comboBox2.Text == "USD")
                label7.Text = "Transfer the amount to American Dollar";

            else
                label7.Text = " ";
        }
    }
}
