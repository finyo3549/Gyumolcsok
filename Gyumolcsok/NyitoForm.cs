using Microsoft.VisualBasic.Logging;

namespace Gyumolcsok
{
    public partial class NyitoForm : Form
    {
        public NyitoForm()
        {
            InitializeComponent();
        }

        private void NyitoForm_Load(object sender, EventArgs e)
        {
            this.Activated += NyitoForm_Activated;
            LoadList();

        }

        private void LoadList()
        {
            NyitoForm_listbox.Items.Clear();
            NyitoForm_listbox.DisplayMember = "Name";
            
            foreach (Gyumolcs gyumolcsok in Program.gyumolcsokList)
            {
                NyitoForm_listbox.Items.Add(gyumolcsok);
            }
        }


        private void NyitoForm_Activated(object sender, EventArgs e)
        {
            LoadList();
        }

        private void újToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReszletekForm reszletekForm = new ReszletekForm("new");
            reszletekForm.ShowDialog();

        }

        private void törölToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedFruit == null)
            {
                MessageBox.Show("Nincs gyümölcs kiválasztva");
            }
            else
            {
                Gyumolcs gyumolcs = (Gyumolcs)selectedFruit;

                Program.database.DeleteFruit(gyumolcs);
                Program.gyumolcsokList.Remove(gyumolcs);
                LoadList();
            }
        }

        private void módosítToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReszletekForm reszletekForm = new ReszletekForm("update");
            reszletekForm.ShowDialog();
        }

        public object selectedFruit
        {
            get { return NyitoForm_listbox.SelectedItem; }
        }

    }
}
