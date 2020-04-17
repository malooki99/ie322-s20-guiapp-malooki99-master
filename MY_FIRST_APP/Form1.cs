using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_application
{
    public partial class Form1 : Form
    {
        string username = "Abdulmalik";
        string mypassward = "1234";
        bool loggedin = false;
        int attempt = 1;
        int MaxAttemts = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {
            frmCheck frm = new frmCheck();
            frm.ShowDialog();

        }

        private void btnRadio_Click(object sender, EventArgs e)
        {
            frmRadio frm = new frmRadio();
            frm.ShowDialog();

        }

        private void btnCombo_Click(object sender, EventArgs e)
        {
            frmCombo frm = new frmCombo();
            frm.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Abdulmalik")
            {
                if (txtPassword.Text == "1234")


                {
                    MessageBox.Show("Login Successful");
                }
                else
                {
                    MessageBox.Show("Incorrect Password");

                }

            }
                else
            {
                MessageBox.Show("Invalid Username");
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            frmRandom frm = new frmRandom();
            frm.ShowDialog();
        }

        private void btnRandomCombo_Click(object sender, EventArgs e)
        {
            frmRandomCombo frm = new  frmRandomCombo();
            frm.ShowDialog();
        }

        private void btnPictureBox_Click(object sender, EventArgs e)
        {
            FrmPic frm = new FrmPic();
            frm.ShowDialog();
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {

        }

        private void btnTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnManufact_Click(object sender, EventArgs e)
        {

        }

        private void btnRobotic_Click(object sender, EventArgs e)
        {

        }

        private void btnABC_Click(object sender, EventArgs e)
        {

        }

        private void btnJohari_Click(object sender, EventArgs e)
        {

        }

        private void btnPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSelfieApp_Click(object sender, EventArgs e)
        {

        }

        private void btnGroupieApp_Click(object sender, EventArgs e)
        {

        }

        private void btnArduino_Click(object sender, EventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }

        private void btnTalk_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
