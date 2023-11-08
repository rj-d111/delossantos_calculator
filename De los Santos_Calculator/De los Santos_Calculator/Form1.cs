using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic.Core.Parser;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_los_Santos_Calculator
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            ShowDigit(sender);

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            ShowDigit(sender);

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            ShowDigit(sender);

        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            ShowDigit(sender);

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            ShowDigit(sender);

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            ShowDigit(sender);

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            ShowDigit(sender);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            ShowDigit(sender);

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            ShowDigit(sender);

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if(txt_input.Text != "0") //Don't insert another zero if the txt_input is zero
            txt_input.Text += ((Button)sender).Text;

        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_input.Text))
            {
                lbl_placeholder.Text = txt_input.Text + "+";
                txt_input.Text = String.Empty;
            }

        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_input.Text))
            {
                lbl_placeholder.Text = txt_input.Text + "/";
                txt_input.Text = String.Empty;
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_input.Text))
            {
                lbl_placeholder.Text = txt_input.Text + "-";
                txt_input.Text = String.Empty;
            }

        }

        private void btn_times_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_input.Text))
            {
                lbl_placeholder.Text = txt_input.Text + "*";
                txt_input.Text = String.Empty;
            }
        }

       private void ShowDigit(object sender)
        {
            if (txt_input.Text == "0")
                txt_input.Text = string.Empty;

            txt_input.Text += ((Button)sender).Text;

        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            txt_input.Text = "0";
            lbl_placeholder.Text = String.Empty;
        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
           

            if (txt_input.Text.Length > 0)
            {
                txt_input.Text = txt_input.Text.Substring(0, txt_input.Text.Length - 1); 

                if(txt_input.Text.Length ==0)
                    txt_input.Text = "0";
            }

        }

        private void btn_equals_Click(object sender, EventArgs e)
        {
            int output;

            switch (LabelOperator())
            {
                case "+":
                    output = ExtractedValueFromLabel() + Convert.ToInt32(txt_input.Text);
                    lbl_placeholder.Text = ExtractedValueFromLabel().ToString() + "+" + txt_input.Text;
                    txt_input.Text = output.ToString();
                    break;
                case "-":
                    output = ExtractedValueFromLabel() - Convert.ToInt32(txt_input.Text);
                    lbl_placeholder.Text = ExtractedValueFromLabel().ToString() + "-" + txt_input.Text;
                    txt_input.Text = output.ToString();

                    break;
                case "*":
                    output = ExtractedValueFromLabel() * Convert.ToInt32(txt_input.Text);
                    lbl_placeholder.Text = ExtractedValueFromLabel().ToString() + "*" + txt_input.Text;
                    txt_input.Text = output.ToString();

                    break;
                case "/":
                    output = ExtractedValueFromLabel() / Convert.ToInt32(txt_input.Text);
                    lbl_placeholder.Text = ExtractedValueFromLabel().ToString() + "/" + txt_input.Text;
                    txt_input.Text = output.ToString();

                    break;
            }

        }

        private int ExtractedValueFromLabel()
        {
            return Convert.ToInt32(lbl_placeholder.Text.Substring(0, lbl_placeholder.Text.Length - 1));
        }

        private string LabelOperator()
        {
            return lbl_placeholder.Text[lbl_placeholder.Text.Length - 1].ToString();
        }
    }
}

