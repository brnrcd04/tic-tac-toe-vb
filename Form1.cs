using System;
using System.Drawing;
using System.Windows.Forms;

namespace tic_tac_toe_vb
{
    public partial class Form1
    {

        private bool checker;
        private int plusone;

        public Form1()
        {
            InitializeComponent();
        }

        private void Enable_False()
        {
            btnRow1Column1.Enabled = false;
            btnRow1Column2.Enabled = false;
            btnRow1Column3.Enabled = false;
            btnRow2Column1.Enabled = false;
            btnRow2Column2.Enabled = false;
            btnRow2Column3.Enabled = false;
            btnRow3Column1.Enabled = false;
            btnRow3Column2.Enabled = false;
            btnRow3Column3.Enabled = false;
        }

        private void score()
        {
            if (btnRow1Column1.Text == "X" & btnRow1Column2.Text == "X" & btnRow1Column3.Text == "X")
            {
                btnRow1Column1.BackColor = Color.Red;
                btnRow1Column2.BackColor = Color.Red;
                btnRow1Column3.BackColor = Color.Red;
                MessageBox.Show("Congratulations! X is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelXScore.Text);
                labelXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow1Column1.Text == "X" & btnRow2Column1.Text == "X" & btnRow3Column1.Text == "X")
            {
                btnRow1Column1.BackColor = Color.Red;
                btnRow2Column1.BackColor = Color.Red;
                btnRow3Column1.BackColor = Color.Red;
                MessageBox.Show("Congratulations! X is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelXScore.Text);
                labelXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow1Column1.Text == "X" & btnRow2Column2.Text == "X" & btnRow3Column3.Text == "X")
            {
                btnRow1Column1.BackColor = Color.Red;
                btnRow2Column2.BackColor = Color.Red;
                btnRow3Column3.BackColor = Color.Red;
                MessageBox.Show("Congratulations! X is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelXScore.Text);
                labelXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow2Column1.Text == "X" & btnRow2Column2.Text == "X" & btnRow2Column3.Text == "X")
            {
                btnRow2Column1.BackColor = Color.Red;
                btnRow2Column2.BackColor = Color.Red;
                btnRow2Column3.BackColor = Color.Red;
                MessageBox.Show("Congratulations! X is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelXScore.Text);
                labelXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow1Column2.Text == "X" & btnRow2Column2.Text == "X" & btnRow3Column2.Text == "X")
            {
                btnRow1Column2.BackColor = Color.Red;
                btnRow2Column2.BackColor = Color.Red;
                btnRow3Column2.BackColor = Color.Red;
                MessageBox.Show("Congratulations! X is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelXScore.Text);
                labelXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow1Column3.Text == "X" & btnRow2Column2.Text == "X" & btnRow3Column1.Text == "X")
            {
                btnRow1Column3.BackColor = Color.Red;
                btnRow2Column2.BackColor = Color.Red;
                btnRow3Column1.BackColor = Color.Red;
                MessageBox.Show("Congratulations! X is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelXScore.Text);
                labelXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow3Column1.Text == "X" & btnRow3Column2.Text == "X" & btnRow3Column3.Text == "X")
            {
                btnRow3Column1.BackColor = Color.Red;
                btnRow3Column2.BackColor = Color.Red;
                btnRow3Column3.BackColor = Color.Red;
                MessageBox.Show("Congratulations! X is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelXScore.Text);
                labelXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow1Column3.Text == "X" & btnRow2Column3.Text == "X" & btnRow3Column3.Text == "X")
            {
                btnRow1Column3.BackColor = Color.Red;
                btnRow2Column3.BackColor = Color.Red;
                btnRow3Column3.BackColor = Color.Red;
                MessageBox.Show("Congratulations! X is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelXScore.Text);
                labelXScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow1Column1.Text == "O" & btnRow1Column2.Text == "O" & btnRow1Column3.Text == "O")
            {
                btnRow1Column1.BackColor = Color.Yellow;
                btnRow1Column2.BackColor = Color.Yellow;
                btnRow1Column3.BackColor = Color.Yellow;
                MessageBox.Show("Congratulations! O is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelOScore.Text);
                labelOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow1Column1.Text == "O" & btnRow2Column1.Text == "O" & btnRow3Column1.Text == "O")
            {
                btnRow1Column1.BackColor = Color.Yellow;
                btnRow2Column1.BackColor = Color.Yellow;
                btnRow3Column1.BackColor = Color.Yellow;
                MessageBox.Show("Congratulations! O is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelOScore.Text);
                labelOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow1Column1.Text == "O" & btnRow2Column2.Text == "O" & btnRow3Column3.Text == "O")
            {
                btnRow1Column1.BackColor = Color.Yellow;
                btnRow2Column2.BackColor = Color.Yellow;
                btnRow3Column3.BackColor = Color.Yellow;
                MessageBox.Show("Congratulations! O is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelOScore.Text);
                labelOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow2Column1.Text == "O" & btnRow2Column2.Text == "O" & btnRow2Column3.Text == "O")
            {
                btnRow2Column1.BackColor = Color.Yellow;
                btnRow2Column2.BackColor = Color.Yellow;
                btnRow2Column3.BackColor = Color.Yellow;
                MessageBox.Show("Congratulations! O is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelOScore.Text);
                labelOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow1Column2.Text == "O" & btnRow2Column2.Text == "O" & btnRow3Column2.Text == "O")
            {
                btnRow1Column2.BackColor = Color.Yellow;
                btnRow2Column2.BackColor = Color.Yellow;
                btnRow3Column2.BackColor = Color.Yellow;
                MessageBox.Show("Congratulations! O is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelOScore.Text);
                labelOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow1Column3.Text == "O" & btnRow2Column2.Text == "O" & btnRow3Column1.Text == "O")
            {
                btnRow1Column3.BackColor = Color.Yellow;
                btnRow2Column2.BackColor = Color.Yellow;
                btnRow3Column1.BackColor = Color.Yellow;
                MessageBox.Show("Congratulations! O is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelOScore.Text);
                labelOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow3Column1.Text == "O" & btnRow3Column2.Text == "O" & btnRow3Column3.Text == "O")
            {
                btnRow3Column1.BackColor = Color.Yellow;
                btnRow3Column2.BackColor = Color.Yellow;
                btnRow3Column3.BackColor = Color.Yellow;
                MessageBox.Show("Congratulations! O is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelOScore.Text);
                labelOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btnRow1Column3.Text == "O" & btnRow2Column3.Text == "O" & btnRow3Column3.Text == "O")
            {
                btnRow1Column3.BackColor = Color.Yellow;
                btnRow2Column3.BackColor = Color.Yellow;
                btnRow3Column3.BackColor = Color.Yellow;
                MessageBox.Show("Congratulations! O is the winner!", "BCN's TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = (int)Convert.ToInt64(labelOScore.Text);
                labelOScore.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelProgramName1_Click(object sender, EventArgs e)
        {

        }

        private void labelOScore_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRow1Column1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnRow1Column1.Text = "X";
                checker = true;
            }
            else
            {
                btnRow1Column1.Text = "O";
                checker = false;
            }
            score();
            btnRow1Column1.Enabled = false;
        }

        private void btnRow1Column2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnRow1Column2.Text = "X";
                checker = true;
            }
            else
            {
                btnRow1Column2.Text = "O";
                checker = false;
            }
            score();
            btnRow1Column2.Enabled = false;
        }

        private void btnRow1Column3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnRow1Column3.Text = "X";
                checker = true;
            }
            else
            {
                btnRow1Column3.Text = "O";
                checker = false;
            }
            score();
            btnRow1Column3.Enabled = false;
        }

        private void btnRow2Column1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnRow2Column1.Text = "X";
                checker = true;
            }
            else
            {
                btnRow2Column1.Text = "O";
                checker = false;
            }
            score();
            btnRow2Column1.Enabled = false;
        }

        private void btnRow2Column2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnRow2Column2.Text = "X";
                checker = true;
            }
            else
            {
                btnRow2Column2.Text = "O";
                checker = false;
            }
            score();
            btnRow2Column2.Enabled = false;
        }

        private void btnRow2Column3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnRow2Column3.Text = "X";
                checker = true;
            }
            else
            {
                btnRow2Column3.Text = "O";
                checker = false;
            }
            score();
            btnRow2Column3.Enabled = false;
        }

        private void btnRow3Column1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnRow3Column1.Text = "X";
                checker = true;
            }
            else
            {
                btnRow3Column1.Text = "O";
                checker = false;
            }
            score();
            btnRow3Column1.Enabled = false;
        }

        private void btnRow3Column2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnRow3Column2.Text = "X";
                checker = true;
            }
            else
            {
                btnRow3Column2.Text = "O";
                checker = false;
            }
            score();
            btnRow3Column2.Enabled = false;
        }

        private void btnRow3Column3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btnRow3Column3.Text = "X";
                checker = true;
            }
            else
            {
                btnRow3Column3.Text = "O";
                checker = false;
            }
            score();
            btnRow3Column3.Enabled = false;
        }

        private void btnResetScores_Click(object sender, EventArgs e)
        {
            btnRow1Column1.Enabled = true;
            btnRow1Column2.Enabled = true;
            btnRow1Column3.Enabled = true;
            btnRow2Column1.Enabled = true;
            btnRow2Column2.Enabled = true;
            btnRow2Column3.Enabled = true;
            btnRow3Column1.Enabled = true;
            btnRow3Column2.Enabled = true;
            btnRow3Column3.Enabled = true;

            btnRow1Column1.Text = "";
            btnRow1Column2.Text = "";
            btnRow1Column3.Text = "";
            btnRow2Column1.Text = "";
            btnRow2Column2.Text = "";
            btnRow2Column3.Text = "";
            btnRow3Column1.Text = "";
            btnRow3Column2.Text = "";
            btnRow3Column3.Text = "";

            labelXScore.Text = "0";
            labelOScore.Text = "0";

            btnRow1Column1.BackColor = Color.White;
            btnRow1Column2.BackColor = Color.White;
            btnRow1Column3.BackColor = Color.White;
            btnRow2Column1.BackColor = Color.White;
            btnRow2Column2.BackColor = Color.White;
            btnRow2Column3.BackColor = Color.White;
            btnRow3Column1.BackColor = Color.White;
            btnRow3Column2.BackColor = Color.White;
            btnRow3Column3.BackColor = Color.White;
        }

        private void btnResetGrid_Click(object sender, EventArgs e)
        {
            btnRow1Column1.Enabled = true;
            btnRow1Column2.Enabled = true;
            btnRow1Column3.Enabled = true;
            btnRow2Column1.Enabled = true;
            btnRow2Column2.Enabled = true;
            btnRow2Column3.Enabled = true;
            btnRow3Column1.Enabled = true;
            btnRow3Column2.Enabled = true;
            btnRow3Column3.Enabled = true;

            btnRow1Column1.Text = "";
            btnRow1Column2.Text = "";
            btnRow1Column3.Text = "";
            btnRow2Column1.Text = "";
            btnRow2Column2.Text = "";
            btnRow2Column3.Text = "";
            btnRow3Column1.Text = "";
            btnRow3Column2.Text = "";
            btnRow3Column3.Text = "";

            btnResetScores.Enabled = true;

            btnRow1Column1.BackColor = Color.White;
            btnRow1Column2.BackColor = Color.White;
            btnRow1Column3.BackColor = Color.White;
            btnRow2Column1.BackColor = Color.White;
            btnRow2Column2.BackColor = Color.White;
            btnRow2Column3.BackColor = Color.White;
            btnRow3Column1.BackColor = Color.White;
            btnRow3Column2.BackColor = Color.White;
            btnRow3Column3.BackColor = Color.White;
        }

        private void labelXScore_Click(object sender, EventArgs e)
        {

        }
    }
}