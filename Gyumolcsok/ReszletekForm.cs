using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gyumolcsok
{
    public partial class ReszletekForm : Form
    {
        string muvelet;
        public ReszletekForm(string muvelet)
        {
            InitializeComponent();
            this.muvelet = muvelet;
        }

        private void ReszletekForm_Load(object sender, EventArgs e)
        {
            switch (muvelet)
            {
                case "new":
                    ReszletekForm_numericUpDownId.Visible = false;
                    label1.Visible = false;
                    
                    this.Text = "Add new fruit";
                    ReszletekForm_button.Text = "Add";
                    ReszletekForm_button.ForeColor = Color.Black;
                    ReszletekForm_button.BackColor = Color.AliceBlue;
                    ReszletekForm_button.Click += new EventHandler(addFruit);
                    break;

                case "update":
                    this.Text = "Modify fruit";
                    ReszletekForm_button.Text = "Update";
                    ReszletekForm_button.ForeColor = Color.White;
                    ReszletekForm_button.BackColor = Color.Blue;
                    ReszletekForm_button.Click += new EventHandler(modifyFruit);
                    displayFruit();
                    break;
            }
        }

        private void displayFruit()
        {
            Gyumolcs gyumolcs = (Gyumolcs)Program.nyitoForm.selectedFruit;
            if (gyumolcs != null)
            {
                ReszletekForm_numericUpDownId.Value = gyumolcs.Id;
                ReszletekForm_numericUpDownMennyiseg.Value = gyumolcs.Quantity;
                ReszletekForm_textBox_Nev.Text = gyumolcs.Name;
            }
        }

        private void modifyFruit(object? sender, EventArgs e)
        {
            Gyumolcs gyumolcs = new Gyumolcs();
            gyumolcs.Id = (int)ReszletekForm_numericUpDownId.Value;
            gyumolcs.Name = ReszletekForm_textBox_Nev.Text;
            gyumolcs.Quantity = (int)ReszletekForm_numericUpDownMennyiseg.Value;
            Program.database.UpdateFruit(gyumolcs);
            Program.gyumolcsokList = Program.database.GetAllFruits();
            this.Close();
                
        }

        private void addFruit(object? sender, EventArgs e)
        {
            Gyumolcs gyumolcs = new Gyumolcs();
            int numericValue = (int)ReszletekForm_numericUpDownMennyiseg.Value;
            if ((ReszletekForm_textBox_Nev.Text is null) || (numericValue == 0)) {
                MessageBox.Show("Minden mező kitöltése kötelező!");
            }
            else
            {
                
                gyumolcs.Name = ReszletekForm_textBox_Nev.Text;
                gyumolcs.Quantity = (int)ReszletekForm_numericUpDownMennyiseg.Value;
                Program.gyumolcsokList.Add(gyumolcs);
                Program.database.AddFruit(gyumolcs);
                this.Close();
            }
        }
    }
}
