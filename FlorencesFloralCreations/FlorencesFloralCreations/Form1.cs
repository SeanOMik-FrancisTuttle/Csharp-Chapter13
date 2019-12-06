using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlorencesFloralCreations {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void occasionListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (lblCongrats.Visible) {
                flowerListBox.SelectedIndex = -1;
                lblCongrats.Visible = false;
            } else {
                flowerListBox.Visible = true;
            }
        }

        private void flowerListBox_SelectedIndexChanged(object sender, EventArgs e) {
            lblCongrats.Visible = true;
        }
    }
}
