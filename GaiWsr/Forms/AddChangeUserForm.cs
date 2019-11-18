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
    public partial class AddChangeUserForm : Form
    {
        #region  бизнес логика
        protected GaiBL.Meneger.BinaryManager BinaryManager = new GaiBL.Meneger.BinaryManager();
        protected GaiBL.Meneger.UserManeger Maneger = new GaiBL.Meneger.UserManeger();
        protected GaiBL.Meneger.ActorManeger ActorManeger = new GaiBL.Meneger.ActorManeger();

        #endregion 

        public GaiBL.Users changeUser;

        public GaiBL.Actor selectActor;
       
       
        /// <summary>
        /// Добавить  пользователя
        /// </summary>
        public AddChangeUserForm()
        {
            InitializeComponent();
            btAddChange.Text = "добавить";
            this.Text = "Добавить  пользователя";
            comboBox1.DataSource = ActorManeger.Actors;

            selectActor = comboBox1.SelectedItem as GaiBL.Actor;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            btDell.Visible = false;

        }

        /// <summary>
        /// изменить  пользователя
        /// </summary>
        /// <param name="user"></param>
        public  AddChangeUserForm ( GaiBL.Users user )  : this ()
        {
            changeUser = user;

            tbName.Text = user.Name;
            tbSurName.Text = user.SurName;
            tbPatronumic.Text = user.Patronumic;

            tbLogin.Text = user.Login.Login1;
            tbPassword.Text = BinaryManager.GetStringToBinary(user.Login.Password);

            btDell.Visible = true;

            try
            {
                pictureBox1.Image = BinaryManager.GetImageToBinary(user.Pthoto, pictureBox1.Width, pictureBox1.Height);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btAddChange.Text = "Изменить";
            btRunFhoto.Text = "Изменить";

            comboBox1.DataSource = ActorManeger.Actors;
            if ( user.IdActor != null)
            {
                comboBox1.SelectedIndex = comboBox1.FindStringExact(user.Actor.Name);
            }
            else
            {
                comboBox1.SelectedItem = null;    
            }

        }



        #region buttons

        /// <summary>
        /// Bt Добавить  пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public virtual  void btAddChange_Click(object sender, EventArgs e)
        {
            try
            {
                Maneger.AddUser(GetNewUSer());
                MessageBox.Show("Пользователь  успешно добавлен");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Загрузить фото
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btRunFhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var array = BinaryManager.GetBinaryToImega(openFileDialog.FileName);

                    pictureBox1.Image = BinaryManager.GetImageToBinary(array, pictureBox1.Width, pictureBox1.Height);
                    
                }
                catch ( Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        protected virtual void BtDell_Click(object sender, EventArgs e) { }

        #endregion



        /// <summary>
        /// получить  нового  пользователя
        /// </summary>
        /// <returns></returns>
        protected GaiBL.Users GetNewUSer()
        {
            // todo  дописать проверку 


            return new GaiBL.Users
            {
                Name = tbName.Text,
                Patronumic = tbPatronumic.Text,
                SurName = tbSurName.Text,
                Login = new GaiBL.Login { Login1 = tbLogin.Text, Password = BinaryManager.GetBinatyToString(tbPassword.Text) },
                Pthoto = BinaryManager.GetBinaryToImega((Bitmap)pictureBox1.Image),
                IdActor = selectActor.IdActor,
                Show = true
                

            };
        }

        /// <summary>
        /// получить  измененного  пользователя
        /// </summary>
        /// <returns></returns>
        protected GaiBL.Users GetChangeUSer()
        {
            var user = GetNewUSer();
            user.IdUser = changeUser.IdUser;
            user.Login.IdUser = changeUser.Login.IdUser;

            return user;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            selectActor = comboBox1.SelectedItem as GaiBL.Actor;

           
        }
    }

    public class ChangeUserForm : AddChangeUserForm
    {

        public ChangeUserForm(GaiBL.Users users) : base(users) { }
       
        /// <summary>
        /// изменить пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void btAddChange_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Сохранить изменения ?", "Сообщение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                
                changeUser = GetChangeUSer();
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }


        }

        protected override void BtDell_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                 "Удалить  пользователя   ?", "Сообщение",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                changeUser.Show = false;
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }

        }

    }
}
