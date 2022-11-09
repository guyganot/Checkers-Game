using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B22_Ex05_ItayGrinberg_209413277_GuyGanot_207044363
{
    public partial class FormGame : Form
    {
        private readonly Game r_Game;
        private const int k_FixedSpacing = 10;
        public PanelBoard PanelBoard { get; set; }

        public FormGame(Game i_Game)
        {
            r_Game = i_Game;
            InitializeComponent();
        }

        public Game Game
        {
            get { return r_Game; }
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

            //Player 1
            labelPlayerOne.Location = new System.Drawing.Point(k_FixedSpacing, k_FixedSpacing);
            labelPlayerOne.Text = $"{Game.Player1.Username}: {Game.Player1.Score}";
                        //PanelBoard
            //PanelBoard.GameEnded += panelCheckers_GameEnded;
            //PanelBoard.PlayerSwitched += panelCheckers_PlayerSwitched;\
            PanelBoard = new PanelBoard(r_Game.Board, r_Game);
            PanelBoard.Size = new Size(PictureBoxTile.s_BlockSize * r_Game.Board.BoardSize,
                PictureBoxTile.s_BlockSize * r_Game.Board.BoardSize + labelPlayerOne.Height - k_FixedSpacing);
            PanelBoard.Top = panelPlayersLabels.Bottom + k_FixedSpacing;
            //PanelBoard.Left = k_FixedSpacing;
            PanelBoard.Anchor = AnchorStyles.Bottom;
            PanelBoard.BorderStyle = BorderStyle.FixedSingle;
            //Players Panel
            panelPlayersLabels.Location = new Point(2*k_FixedSpacing, k_FixedSpacing);
            panelPlayersLabels.Size = new Size(PanelBoard.Width, labelPlayerOne.Height + (k_FixedSpacing * 2));
            //Player 2
            labelPlayerTwo.Left = panelPlayersLabels.Right - labelPlayerOne.Left - labelPlayerTwo.Width - 8*k_FixedSpacing;
            labelPlayerTwo.Top = labelPlayerOne.Top;
            labelPlayerTwo.Text = $@"{Game.Player2.Username}: {Game.Player2.Score}";

            // Init form 
            ClientSize = new Size(panelPlayersLabels.Width, 
                panelPlayersLabels.Height + PanelBoard.Height + 2 * k_FixedSpacing);
            FormBorderStyle = FormBorderStyle.FixedSingle; // change after
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false; //change after
            Text = "Damka";
            Controls.Add(panelPlayersLabels);
            Controls.Add(PanelBoard);
            PanelBoard.AlertOnFinish += AlertOnFinish;
            //panelBoard.Show();
            //FormClosing += FormGame_FormClosing;
        }

        void AlertOnFinish(object sender, EventArgs e)
        {
            labelPlayerOne.Text = $"{Game.Player1.Username}: {Game.Player1.Score}";
            labelPlayerTwo.Text = $@"{Game.Player2.Username}: {Game.Player2.Score}";
            //Environment.Exit(0);
        }

        //private static int i = 0;
        //private void PanelBoard_Click(object sender, EventArgs e)
        //{
        //    labelPlayerOne.Text = $@"{i++}: {Game.Player1.Score}";
        //    labelPlayerTwo.Text = $@"{Game.Player2.Username}: {Game.Player2.Score}";

        //}

        //public void ReloadScore()
        //{
        //    labelPlayerOne.Text = $@"{i++}: {Game.Player1.Score}";
        //    labelPlayerTwo.Text = $@"{Game.Player2.Username}: {Game.Player2.Score}";

        //}
    }
}

