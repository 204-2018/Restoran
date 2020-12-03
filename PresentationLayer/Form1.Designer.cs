namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 420);
            this.listBox1.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(249, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(35, 17);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(249, 84);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(79, 17);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(249, 133);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 17);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Price";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(334, 28);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 22);
            this.textBoxTitle.TabIndex = 4;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(334, 81);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 22);
            this.textBoxDescription.TabIndex = 5;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(334, 133);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 6;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(350, 184);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 7;
            this.button.Text = "Add";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(492, 28);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(279, 228);
            this.listBox2.TabIndex = 8;
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Location = new System.Drawing.Point(497, 299);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(90, 17);
            this.labelMinPrice.TabIndex = 9;
            this.labelMinPrice.Text = "Minimal price";
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Location = new System.Drawing.Point(497, 340);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(101, 17);
            this.labelMaxPrice.TabIndex = 10;
            this.labelMaxPrice.Text = "Maximum price";
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(604, 299);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(100, 22);
            this.textBoxMin.TabIndex = 11;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(604, 340);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(100, 22);
            this.textBoxMax.TabIndex = 12;
            // 
            // buttonPrice
            // 
            this.buttonPrice.Location = new System.Drawing.Point(617, 385);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(75, 23);
            this.buttonPrice.TabIndex = 13;
            this.buttonPrice.Text = "Show";
            this.buttonPrice.UseVisualStyleBackColor = true;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPrice);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Jelovnik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Button buttonPrice;
    }
}

