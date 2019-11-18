using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GaiBL.Meneger;

namespace GaiWsr.Forms
{
    public partial class UserForm : Form
    {
        private  UserManeger GetUserManeger = new UserManeger();

        private  List<GaiBL.Users> Users = new List<GaiBL.Users>();

        private GaiBL.Users selectUser;


        public UserForm()
        {
            InitializeComponent();

            try
            {
                SetUserForm();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void  SetUserForm ()
        {
            Users = GetUserManeger.Users;
            dataGridView1.DataSource = Users;

            for (int i = 4; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].Visible = false;
            }
            
            dataGridView1.Columns[0].HeaderText = "Id";
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Фамилия";
            dataGridView1.Columns[3].HeaderText = "Отчество";
        }

        /// <summary>
        ///  изменяет пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GetSelectUser(e.RowIndex);

            Forms.AddChangeUserForm addChangeUserForm = new ChangeUserForm (selectUser);
            
            addChangeUserForm.ShowDialog();

            if (addChangeUserForm.DialogResult == DialogResult.Yes)
            {

                selectUser = addChangeUserForm.changeUser;
                try
                {
                    GetUserManeger.SetUser( ref  selectUser);
                    MessageBox.Show("Сохранение  успешно  произошло ");
                    SetUserForm();

                }
               catch ( Exception  ex)
                {
                    MessageBox.Show(ex.Message , "Error" );
                }


            }



           
        }

        private void GetSelectUser(int  e)
        {
            if (e >= 0)
            {
                selectUser = dataGridView1.Rows[e].DataBoundItem as GaiBL.Users;
            }
        }

        private void btAddUser_Click(object sender, EventArgs e)
        {
            Forms.AddChangeUserForm addChangeUserForm = new AddChangeUserForm();
            addChangeUserForm.ShowDialog();

        }
    }
}
