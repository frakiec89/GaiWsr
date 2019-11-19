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
    public partial class AddActor : Form
    {
        GaiBL.Meneger.ActorManeger ActorManeger = new GaiBL.Meneger.ActorManeger();


        public AddActor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ActorManeger.SetActor(new GaiBL.Actor { Name = textBox1.Text });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("должность  успешно добавленна ");
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
