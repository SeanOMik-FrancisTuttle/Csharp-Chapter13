namespace FlorencesFloralCreations {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.occasionListBox = new System.Windows.Forms.ListBox();
            this.flowerListBox = new System.Windows.Forms.ListBox();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // occasionListBox
            // 
            this.occasionListBox.FormattingEnabled = true;
            this.occasionListBox.Items.AddRange(new object[] {
            "Get Well",
            "Anniversary",
            "Valentines Day"});
            this.occasionListBox.Location = new System.Drawing.Point(16, 14);
            this.occasionListBox.Name = "occasionListBox";
            this.occasionListBox.Size = new System.Drawing.Size(120, 95);
            this.occasionListBox.TabIndex = 0;
            this.occasionListBox.SelectedIndexChanged += new System.EventHandler(this.occasionListBox_SelectedIndexChanged);
            // 
            // flowerListBox
            // 
            this.flowerListBox.FormattingEnabled = true;
            this.flowerListBox.Items.AddRange(new object[] {
            "Rose",
            "Daisy"});
            this.flowerListBox.Location = new System.Drawing.Point(142, 14);
            this.flowerListBox.Name = "flowerListBox";
            this.flowerListBox.Size = new System.Drawing.Size(120, 95);
            this.flowerListBox.TabIndex = 1;
            this.flowerListBox.Visible = false;
            this.flowerListBox.SelectedIndexChanged += new System.EventHandler(this.flowerListBox_SelectedIndexChanged);
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Location = new System.Drawing.Point(54, 125);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(171, 13);
            this.lblCongrats.TabIndex = 2;
            this.lblCongrats.Text = "Congratulations, you choose good!";
            this.lblCongrats.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 153);
            this.Controls.Add(this.lblCongrats);
            this.Controls.Add(this.flowerListBox);
            this.Controls.Add(this.occasionListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox occasionListBox;
        private System.Windows.Forms.ListBox flowerListBox;
        private System.Windows.Forms.Label lblCongrats;
    }
}

