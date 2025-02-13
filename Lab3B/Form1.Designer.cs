namespace Lab3B
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ListBox3 = new System.Windows.Forms.ListBox();
            this.Label = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Location = new System.Drawing.Point(15, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(250, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Haidresser: ";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Jan",
            "Pat",
            "Ron",
            "Sue",
            "Laurie"});
            this.comboBox.Location = new System.Drawing.Point(45, 44);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(150, 26);
            this.comboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ListBox);
            this.groupBox2.Location = new System.Drawing.Point(291, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(250, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Service:";
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 18;
            this.ListBox.Items.AddRange(new object[] {
            "Cut ",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extension",
            "Up-do"});
            this.ListBox.Location = new System.Drawing.Point(8, 26);
            this.ListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(234, 166);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListBox2);
            this.groupBox3.Location = new System.Drawing.Point(575, 24);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(250, 206);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Charged Items:";
            // 
            // ListBox2
            // 
            this.ListBox2.FormattingEnabled = true;
            this.ListBox2.ItemHeight = 18;
            this.ListBox2.Location = new System.Drawing.Point(8, 26);
            this.ListBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.Size = new System.Drawing.Size(234, 166);
            this.ListBox2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ListBox3);
            this.groupBox4.Location = new System.Drawing.Point(852, 24);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(162, 206);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price:";
            // 
            // ListBox3
            // 
            this.ListBox3.FormattingEnabled = true;
            this.ListBox3.ItemHeight = 18;
            this.ListBox3.Location = new System.Drawing.Point(8, 24);
            this.ListBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ListBox3.Name = "ListBox3";
            this.ListBox3.Size = new System.Drawing.Size(146, 166);
            this.ListBox3.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(772, 266);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(105, 18);
            this.Label.TabIndex = 5;
            this.Label.Text = "Total Price : ";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(890, 266);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(124, 25);
            this.TextBox.TabIndex = 6;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(256, 326);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(148, 36);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Add Service";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(432, 326);
            this.Button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(199, 36);
            this.Button2.TabIndex = 8;
            this.Button2.Text = "Calculate Total Price";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(661, 326);
            this.Button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(164, 36);
            this.Button3.TabIndex = 9;
            this.Button3.Text = "Reset";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(852, 326);
            this.Button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(162, 36);
            this.Button4.TabIndex = 10;
            this.Button4.Text = "Exit";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button4);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox ListBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox ListBox3;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button4;
    }
}

