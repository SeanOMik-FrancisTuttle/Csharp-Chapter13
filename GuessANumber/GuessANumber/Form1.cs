using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessANumber {
    public partial class Form1 : Form {
        private int _random_number = -1;
        private bool isForm = true;
        public Form1() {
            InitializeComponent();

            Random random = new Random();
            _random_number = random.Next(1, 5);
            //lblHint.Text = "" + _random_number;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e) {
            if (isForm) {
                isForm = false;
                return;
            }
            var button = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            int choosen_number = int.Parse(button.Text);

            if (choosen_number == _random_number) {
                lblIsCorrect.Text = "Correct";
            } else {
                lblIsCorrect.Text = "Incorrect";
            }
        }
        //private bool _hint_has_shown = false;
        private void radioButton_MouseEnter(object sender, EventArgs e) {
            //var button = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            //int choosen_number = int.Parse(button.Text);

            //if (choosen_number != _random_number && !_hint_has_shown) {
            //    lblHint.Visible = true;
            //    lblHint.Text = "Hint: " + choosen_number + " is Incorrect";
            //    _hint_has_shown = true;
            //}
        }

        private void radioButton_MouseLeave(object sender, EventArgs e) {
            //if (lblHint.Visible) lblHint.Visible = false;
        }
    }
}
