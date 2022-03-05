using System;
using System.Threading;
using System.Windows.Forms;

namespace Bataille_Winform
{
    public partial class gameForm : Form
    {
        public gameForm()
        {
            InitializeComponent();
        }

        private void btn_CreateCards_Click(object sender, EventArgs e)
        {
            CreerCarte(events_List);
        }

        private void btn_ShuffleCards_Click(object sender, EventArgs e)
        {
            BattreCarte(events_List);
        }

        private void btn_CouperDistrib_Click(object sender, EventArgs e)
        {
            CouperJeu(events_List);
            Thread.Sleep(2000);
            Distribuerjeu(events_List);
        }

        private void btn_StartGame_Click(object sender, EventArgs e)
        {
            Jeu(events_List);
            Thread.Sleep(2000);
            displayWinners(events_List);
        }

        private void btn_credits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jeu de la bataille réalisé par : " +
                "\n\n- Simon D" +
                "\n- Benjamin G");
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merci d'avoir utilisé cette application !");
            Application.Exit();
        }
    }
}
