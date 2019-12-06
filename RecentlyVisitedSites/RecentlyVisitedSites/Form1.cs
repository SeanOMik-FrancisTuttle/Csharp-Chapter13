using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RecentlyVisitedSites {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        static Dictionary<string, string> _label_url = new Dictionary<string, string> {
            {"Google", "https://www.google.com/"},
            {"Bing", "https://www.bing.com/"},
            {"Youtube", "https://www.youtube.com/"}
        };
        static Dictionary<string, string> _label_description = new Dictionary<string, string> {
            {"Google", "A very popular search engine. Known as best."},
            {"Bing", "A popular search engine, competitor to Google. Known as second best."},
            {"Youtube", "A very popular video streaming and watching service."}
        };

        private void linkLabel_MouseEnter(object sender, EventArgs e) {
            try {
                string url_description = sender.ToString().Substring(38);
                if (_label_description.TryGetValue(url_description, out string description)) {
                    lblDesc.Text = description;
                }
            }
            catch (Exception exception) { }
        }

        private void linkLabel_Click(object sender, EventArgs e) {
            try {
                string url_website = sender.ToString().Substring(38);
                if (_label_url.TryGetValue(url_website, out string url)) {
                    Process.Start(url);
                }
            }
            catch (Exception exception) { }
        }
    }
}
