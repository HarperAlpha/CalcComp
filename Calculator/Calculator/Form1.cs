using System;
using System.Windows.Forms;
// Author: Harper Alpha
namespace Calculator
{
    public partial class Calc : Form
    {
        String opperator_selct = "";
        Double result_val = 0;
        bool isopperatorselected = false;
        public Calc()
        {
            InitializeComponent();
            MessageBox.Show("Please Do not start with an operator...its an error...⛒ a fixable one....but I ran out of lines 😅", "Pre-Crash Warning⛒");
        }
        private void insert_numbers(object sender, EventArgs e)
        {
            if (answer_box.Text == "0" || isopperatorselected)
            {
                answer_box.Clear();
            }
            isopperatorselected = false;
            Button number = (Button)sender;
            if (number.Text == ".")
            {
                if (!answer_box.Text.Contains("."))
                {
                    answer_box.Text = $"{answer_box.Text}{number.Text}";
                }
            }
            else
            {
                answer_box.Text = $"{answer_box.Text}{number.Text}";
            }
        }
        private void insert_opperators(object sender, EventArgs e)
        {
            Button opperator_btn = (Button)sender;
            if (result_val != 0)
            {
                keyeq.PerformClick();
                opperator_selct = opperator_btn.Text;
                calclbl.Text = $"{result_val}{opperator_selct}";
                isopperatorselected = true;
            }
            else
            {
                opperator_selct = opperator_btn.Text;
                result_val = Double.Parse(answer_box.Text);
                calclbl.Text = $"{result_val}{opperator_selct}";
                isopperatorselected = true;
            }
        }
        private void keycls_Click(object sender, EventArgs e)
        {
            answer_box.Text = "";
            result_val = 0;
        }
        private void keyeq_Click(object sender, EventArgs e)
        {
            calclbl.Text = "";
            switch (opperator_selct)
            {
                case "+":
                    answer_box.Text = (result_val + Double.Parse(answer_box.Text)).ToString();
                    break;
                case "-":
                    answer_box.Text = (result_val - Double.Parse(answer_box.Text)).ToString();
                    break;
                case "/":
                    answer_box.Text = (result_val / Double.Parse(answer_box.Text)).ToString();
                    break;
                case "X":
                    answer_box.Text = (result_val * Double.Parse(answer_box.Text)).ToString();
                    break;
                default:
                    MessageBox.Show("Something went wrong... actually it did not... You may Continue 😛", "Working on It...");
                    break;
            }
            if (answer_box.Text == "∞" || answer_box.Text == "-∞")
            {
                answer_box.Text = "";
                result_val = 0;
                MessageBox.Show("Did you Really just try to divide by 0...?\n sorry thats not allowed 😛  ", "WHY :|");
            }
            else
            {
                result_val = Double.Parse(answer_box.Text);
                opperator_selct = "";
            }
        }
    }
}
