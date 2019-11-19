using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaiWsr.Forms
{
    public partial class ActorForm : Form
    {
        GaiBL.Meneger.ActorManeger ActorManeger = new GaiBL.Meneger.ActorManeger();

        public ActorForm()
        {
            InitializeComponent();
            StartForm();

        }

        private void StartForm()
        {
            try
            {
                dataGridView1.DataSource = ActorManeger.Actors;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Пользователи";
                dataGridView1.Columns[2].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Forms.AddActor addActor = new AddActor();
            if ( addActor.ShowDialog() == DialogResult.OK)
            {
                StartForm();
            }
        }
    }
}
