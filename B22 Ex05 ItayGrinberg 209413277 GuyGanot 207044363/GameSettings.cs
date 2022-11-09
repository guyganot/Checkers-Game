using System;
using System.Windows.Forms;

namespace B22_Ex05_ItayGrinberg_209413277_GuyGanot_207044363
{
    public partial class GameSettings : Form
    {
        public GameSettings()
        {
            InitializeComponent();
        }

        public string FirstPlayerName
        {
            get { return textPlayerOneName.Text; }
        }

        public string SecondPlayerName
        {
            get { return textPlayerTwoName.Text; }
        }

        public bool IsHuman
        {
            get { return checkboxIsPlayerHuman.Checked; }
        }

        public int BoardSize()
        {
            int boardSize = 6;
            if (radioSixBySix.Checked)
            {
                boardSize = 6;
            }
            else if (radioEightByEight.Checked)
            {
                boardSize = 8;
            }
            else
            {
                boardSize = 10;
            }

            return boardSize;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            bool isFormValid = MainMenu.CheckInput(textPlayerOneName) && MainMenu.CheckInput(textPlayerTwoName);
            if (isFormValid)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //MessageBox.Show("Invalid Input, try again.");
                MessageBox.Show("Wrong input", "Error", MessageBoxButtons.OK);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkboxIsPlayerHuman_CheckedChanged(object sender, EventArgs e)
        {
            textPlayerTwoName.Enabled = (checkboxIsPlayerHuman.CheckState == CheckState.Checked);
            if (!textPlayerTwoName.Enabled)
            {
                textPlayerTwoName.Text = "[Computer]";
            }
            else
            {
                textPlayerTwoName.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textPlayerTwoName_TextChanged(object sender, EventArgs e)
        {

        }

        private void GameSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
