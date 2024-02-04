namespace Gyumolcsok
{
    partial class NyitoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NyitoForm_listbox = new ListBox();
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            újToolStripMenuItem = new ToolStripMenuItem();
            módosítToolStripMenuItem = new ToolStripMenuItem();
            törölToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(130, 42);
            label1.Name = "label1";
            label1.Size = new Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Raktárkészlet";
            // 
            // NyitoForm_listbox
            // 
            NyitoForm_listbox.FormattingEnabled = true;
            NyitoForm_listbox.ItemHeight = 15;
            NyitoForm_listbox.Location = new Point(42, 66);
            NyitoForm_listbox.Name = "NyitoForm_listbox";
            NyitoForm_listbox.Size = new Size(287, 349);
            NyitoForm_listbox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { újToolStripMenuItem, módosítToolStripMenuItem, törölToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // újToolStripMenuItem
            // 
            újToolStripMenuItem.Name = "újToolStripMenuItem";
            újToolStripMenuItem.Size = new Size(180, 22);
            újToolStripMenuItem.Text = "Új";
            újToolStripMenuItem.Click += újToolStripMenuItem_Click;
            // 
            // módosítToolStripMenuItem
            // 
            módosítToolStripMenuItem.Name = "módosítToolStripMenuItem";
            módosítToolStripMenuItem.Size = new Size(180, 22);
            módosítToolStripMenuItem.Text = "Módosít";
            módosítToolStripMenuItem.Click += módosítToolStripMenuItem_Click;
            // 
            // törölToolStripMenuItem
            // 
            törölToolStripMenuItem.Name = "törölToolStripMenuItem";
            törölToolStripMenuItem.Size = new Size(180, 22);
            törölToolStripMenuItem.Text = "Töröl";
            törölToolStripMenuItem.Click += törölToolStripMenuItem_Click;
            // 
            // NyitoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NyitoForm_listbox);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "NyitoForm";
            Text = "NyitoForm";
            Load += NyitoForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox NyitoForm_listbox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem újToolStripMenuItem;
        private ToolStripMenuItem módosítToolStripMenuItem;
        private ToolStripMenuItem törölToolStripMenuItem;
    }
}
