using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickLarger {
    public partial class Form1 : Form {
        int[] _array_one = new int[100];
        int[] _array_two = new int[100];

        int _current_index = 0;

        public Form1() {
            InitializeComponent();
            Random random = new Random();
            for (int i = 0; i < _array_one.Length; ++i) {
                _array_one[i] = random.Next(1, 999);
                _array_two[i] = random.Next(1, 999);
            }
        }
        private void btn_Click(object sender, EventArgs e) {
            bool clicked_left = (int.Parse(sender.ToString().Substring(35))-1 == 1) ? false : true; // 0 = button one, but also bool true; 1 = button two, but also bool false

            lblNumberOne.Text = Convert.ToString(_array_one[_current_index]);
            lblNumberTwo.Text = Convert.ToString(_array_two[_current_index]);
            lblIndex.Text = "Number #" + _current_index + 1;

            if ((clicked_left && _array_one[_current_index] > _array_two[_current_index]) || (!clicked_left && _array_one[_current_index] < _array_two[_current_index])) {
                lblAnswer.Text = "Correct";
            } else {
                lblAnswer.Text = "Incorrect";
            }

            _current_index++;
        }
    }
}
