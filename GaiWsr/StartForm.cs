using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaiBL;

namespace GaiWsr
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

        }

        private void btFormUser_Click(object sender, EventArgs e)
        {
            Forms.UserForm userForm = new Forms.UserForm();
            userForm.Show();
        }

        private void btActor_Click(object sender, EventArgs e)
        {
            Forms.ActorForm actor  = new Forms.ActorForm();
            actor.Show();
        }
    }
}
