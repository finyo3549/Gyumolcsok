namespace Gyumolcsok
{
    partial class ReszletekForm
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
            ReszletekForm_textBox_Nev = new TextBox();
            ReszletekForm_numericUpDownMennyiseg = new NumericUpDown();
            ReszletekForm_numericUpDownId = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ReszletekForm_button = new Button();
            ((System.ComponentModel.ISupportInitialize)ReszletekForm_numericUpDownMennyiseg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ReszletekForm_numericUpDownId).BeginInit();
            SuspendLayout();
            // 
            // ReszletekForm_textBox_Nev
            // 
            ReszletekForm_textBox_Nev.Location = new Point(47, 136);
            ReszletekForm_textBox_Nev.Name = "ReszletekForm_textBox_Nev";
            ReszletekForm_textBox_Nev.Size = new Size(119, 23);
            ReszletekForm_textBox_Nev.TabIndex = 0;
            // 
            // ReszletekForm_numericUpDownMennyiseg
            // 
            ReszletekForm_numericUpDownMennyiseg.Location = new Point(47, 213);
            ReszletekForm_numericUpDownMennyiseg.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            ReszletekForm_numericUpDownMennyiseg.Name = "ReszletekForm_numericUpDownMennyiseg";
            ReszletekForm_numericUpDownMennyiseg.Size = new Size(120, 23);
            ReszletekForm_numericUpDownMennyiseg.TabIndex = 1;
            // 
            // ReszletekForm_numericUpDownId
            // 
            ReszletekForm_numericUpDownId.Location = new Point(47, 60);
            ReszletekForm_numericUpDownId.Name = "ReszletekForm_numericUpDownId";
            ReszletekForm_numericUpDownId.ReadOnly = true;
            ReszletekForm_numericUpDownId.Size = new Size(120, 23);
            ReszletekForm_numericUpDownId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 42);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Termékkód";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 118);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 4;
            label2.Text = "Gyümölcs név";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 195);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 5;
            label3.Text = "Elérhető mennyiség";
            // 
            // ReszletekForm_button
            // 
            ReszletekForm_button.Location = new Point(47, 250);
            ReszletekForm_button.Name = "ReszletekForm_button";
            ReszletekForm_button.Size = new Size(104, 37);
            ReszletekForm_button.TabIndex = 6;
            ReszletekForm_button.Text = "button1";
            ReszletekForm_button.UseVisualStyleBackColor = true;
            // 
            // ReszletekForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReszletekForm_button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReszletekForm_numericUpDownId);
            Controls.Add(ReszletekForm_numericUpDownMennyiseg);
            Controls.Add(ReszletekForm_textBox_Nev);
            Name = "ReszletekForm";
            Text = "ReszletekForm";
            Load += ReszletekForm_Load;
            ((System.ComponentModel.ISupportInitialize)ReszletekForm_numericUpDownMennyiseg).EndInit();
            ((System.ComponentModel.ISupportInitialize)ReszletekForm_numericUpDownId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ReszletekForm_textBox_Nev;
        private NumericUpDown ReszletekForm_numericUpDownMennyiseg;
        private NumericUpDown ReszletekForm_numericUpDownId;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button ReszletekForm_button;
    }
}