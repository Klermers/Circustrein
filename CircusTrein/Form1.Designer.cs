namespace CircusTrein
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Big = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Small = new System.Windows.Forms.RadioButton();
            this.Herbivour = new System.Windows.Forms.RadioButton();
            this.Carnivour = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AnimalAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrevWagon = new System.Windows.Forms.Button();
            this.NextWagon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(85, 15);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(193, 22);
            this.NameBox.TabIndex = 0;
            // 
            // Big
            // 
            this.Big.AutoSize = true;
            this.Big.Location = new System.Drawing.Point(11, 21);
            this.Big.Name = "Big";
            this.Big.Size = new System.Drawing.Size(49, 21);
            this.Big.TabIndex = 1;
            this.Big.TabStop = true;
            this.Big.Text = "Big";
            this.Big.UseVisualStyleBackColor = true;
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Location = new System.Drawing.Point(66, 21);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(78, 21);
            this.Medium.TabIndex = 2;
            this.Medium.TabStop = true;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            // 
            // Small
            // 
            this.Small.AutoSize = true;
            this.Small.Location = new System.Drawing.Point(150, 21);
            this.Small.Name = "Small";
            this.Small.Size = new System.Drawing.Size(63, 21);
            this.Small.TabIndex = 3;
            this.Small.TabStop = true;
            this.Small.Text = "Small";
            this.Small.UseVisualStyleBackColor = true;
            // 
            // Herbivour
            // 
            this.Herbivour.AutoSize = true;
            this.Herbivour.Location = new System.Drawing.Point(11, 21);
            this.Herbivour.Name = "Herbivour";
            this.Herbivour.Size = new System.Drawing.Size(91, 21);
            this.Herbivour.TabIndex = 4;
            this.Herbivour.TabStop = true;
            this.Herbivour.Text = "Herbivour";
            this.Herbivour.UseVisualStyleBackColor = true;
            // 
            // Carnivour
            // 
            this.Carnivour.AutoSize = true;
            this.Carnivour.Location = new System.Drawing.Point(139, 21);
            this.Carnivour.Name = "Carnivour";
            this.Carnivour.Size = new System.Drawing.Size(90, 21);
            this.Carnivour.TabIndex = 5;
            this.Carnivour.TabStop = true;
            this.Carnivour.Text = "Carnivour";
            this.Carnivour.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(411, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 196);
            this.listBox1.TabIndex = 6;
            // 
            // AnimalAdd
            // 
            this.AnimalAdd.Location = new System.Drawing.Point(29, 208);
            this.AnimalAdd.Name = "AnimalAdd";
            this.AnimalAdd.Size = new System.Drawing.Size(75, 23);
            this.AnimalAdd.TabIndex = 7;
            this.AnimalAdd.Text = "Add";
            this.AnimalAdd.UseVisualStyleBackColor = true;
            this.AnimalAdd.Click += new System.EventHandler(this.AnimalAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Naam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Wagon#";
            // 
            // PrevWagon
            // 
            this.PrevWagon.Location = new System.Drawing.Point(330, 208);
            this.PrevWagon.Name = "PrevWagon";
            this.PrevWagon.Size = new System.Drawing.Size(75, 23);
            this.PrevWagon.TabIndex = 10;
            this.PrevWagon.Text = "<<Prev";
            this.PrevWagon.UseVisualStyleBackColor = true;
            // 
            // NextWagon
            // 
            this.NextWagon.Location = new System.Drawing.Point(583, 208);
            this.NextWagon.Name = "NextWagon";
            this.NextWagon.Size = new System.Drawing.Size(75, 23);
            this.NextWagon.TabIndex = 11;
            this.NextWagon.Text = "Next>>";
            this.NextWagon.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Big);
            this.groupBox1.Controls.Add(this.Medium);
            this.groupBox1.Controls.Add(this.Small);
            this.groupBox1.Location = new System.Drawing.Point(85, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 47);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Herbivour);
            this.groupBox2.Controls.Add(this.Carnivour);
            this.groupBox2.Location = new System.Drawing.Point(85, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 48);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 244);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NextWagon);
            this.Controls.Add(this.PrevWagon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnimalAdd);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.NameBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.RadioButton Big;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton Small;
        private System.Windows.Forms.RadioButton Herbivour;
        private System.Windows.Forms.RadioButton Carnivour;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button AnimalAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PrevWagon;
        private System.Windows.Forms.Button NextWagon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

