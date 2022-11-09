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
    public partial class PanelBoard : Panel
    {
        private readonly Board r_Board;
        private readonly Game r_Game;
        //private readonly PictureBoxPuck[,] r_PictureBoxPucks;
        private readonly PictureBoxTile[,] r_PictureBoxTiles;
        private PictureBoxTile m_SelectedPuck;
        private bool ComputerAnotherTurn { get; set; }
        //private bool m_IsComputerTurn;

        private Color PrevColor { get; set; }

        public PanelBoard()
        {
            InitializeComponent();
        }

        public PanelBoard(Board i_Board, Game i_Game) : this()
        {
            r_Game = i_Game;
            r_Board = i_Board;
            r_PictureBoxTiles = new PictureBoxTile[r_Board.BoardSize, r_Board.BoardSize];
            //m_IsComputerTurn = r_Game.Player2.isHuman ? m_IsComputerTurn = null : true;
            initializePanelBoard();

            //InitializeComponent();
            ////init();
            //ShowDialog();
        }

        private void initializePanelBoard()
        {
            r_Board.InitializeBoard(r_Game.Player1, r_Game.Player2);
            //r_Game.BeginGame();

            foreach (Tile tile in r_Board.BoardMatrix)
            {
                PictureBoxTile pictureBox = new PictureBoxTile(tile);
                //Paint the background of the board
                if (tile.RowNumber % 2 == 0 && tile.ColumnNumber % 2 == 0 ||
                    tile.RowNumber % 2 == 1 && tile.ColumnNumber % 2 == 1)
                {
                    //pictureBox.BackgroundImage = new Bitmap(Properties.Resources.tile_black);
                    pictureBox.BackColor = Color.DarkGray;
                }
                else
                {
                    //pictureBox.BackgroundImage = new Bitmap(Properties.Resources.tile_white);
                    pictureBox.BackColor = Color.WhiteSmoke;
                }

                pictureBox.Click += tile_Click;
                Controls.Add(pictureBox);
                r_PictureBoxTiles[tile.RowNumber, tile.ColumnNumber] = pictureBox;
            }
        }

        private void cleanControlsOfBoard()
        {
            foreach (PictureBoxTile box in r_PictureBoxTiles)
            {
                box.Click -= tile_Click;
                Controls.Remove(box);
            }
        }

        private void tile_Click(object sender, EventArgs e)
        {
            PictureBoxTile tile = sender as PictureBoxTile;
            if (tile.Tile.Puck != ' ')
            {
                selectTile(tile);
            }
            else if (tile.Tile.Puck == ' ' && m_SelectedPuck != null)
            {
                playTurn(tile);
                if (!r_Game.CurrentPlayer.isHuman)
                {
                    do
                    {
                       string moveToMake;
                       moveToMake = ComputerAnotherTurn ? r_Board.MovementIndexString : r_Game.PlayComputerTurn(r_Game.CurrentPlayer);
                        string targetTileString = moveToMake.Substring(3);
                       string originTileString = moveToMake.Substring(0, 2);
                       int[] targetCoordinates = r_Board.GetCoordinate(targetTileString);
                       int[] originCoordinates = r_Board.GetCoordinate(originTileString);
                       PictureBoxTile targetTile = r_PictureBoxTiles[targetCoordinates[1], targetCoordinates[0]];
                       m_SelectedPuck = r_PictureBoxTiles[originCoordinates[1], originCoordinates[0]];
                       playTurn(targetTile);
                    } while (ComputerAnotherTurn);
                }
            }
        }

        private void setRematch()
        {

            r_Game.InitTurns();
            r_Game.Player1.QueenPucks.Clear();
            r_Game.Player1.SimplePucks.Clear();
            r_Game.Player2.QueenPucks.Clear();
            r_Game.Player2.SimplePucks.Clear();
            this.cleanControlsOfBoard();
            this.initializePanelBoard();
            AlertOnFinish.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler AlertOnFinish;

        private void selectTile(PictureBoxTile i_Tile)
        {
            bool isPlayerPuck = Board.DoesPuckBelongToPlayer(r_Game.CurrentPlayer, i_Tile.Tile);
            if (isPlayerPuck)
            {
                if (m_SelectedPuck != null)
                {
                    m_SelectedPuck.BackColor = PrevColor;
                    //m_SelectedPuck = null;
                }

                if (m_SelectedPuck != i_Tile)
                {
                    PrevColor = i_Tile.BackColor;
                    i_Tile.BackColor = Color.CornflowerBlue;
                    m_SelectedPuck = i_Tile;
                }
                else
                {
                    m_SelectedPuck = null;
                }
            }
        }

        private void playTurn(PictureBoxTile i_Tile)
        {
            int rowOfSelectedPuck = m_SelectedPuck.Tile.RowNumber;
            int colOfSelectedPuck = m_SelectedPuck.Tile.ColumnNumber;
            int rowOfDestTile = i_Tile.Tile.RowNumber;
            int colOfDestTile = i_Tile.Tile.ColumnNumber;
            string moveToMake = r_Board.IndexToCharArray(colOfSelectedPuck, rowOfSelectedPuck,
                colOfDestTile, rowOfDestTile);
            bool isValidMove = r_Board.ValidateInput(moveToMake, r_Game.CurrentPlayer, r_Game.LastMoveTile, r_Game.LastEaten != null);
            if (isValidMove)
            {
                Tile lastMoveTile = r_Game.LastMoveTile;
                bool isAnotherTurn = r_Game.Turn(moveToMake, r_Game.CurrentPlayer, r_Game.OppPlayer, ref lastMoveTile);
                Tile lastEaten = r_Game.LastEaten;
                if (lastEaten != null)
                {
                    r_PictureBoxTiles[lastEaten.RowNumber, lastEaten.ColumnNumber].SetImage();
                }

                r_PictureBoxTiles[rowOfDestTile, colOfDestTile].SetImage();
                r_PictureBoxTiles[rowOfSelectedPuck, colOfSelectedPuck].SetImage();
                m_SelectedPuck.BackColor = PrevColor;
                //m_SelectedPuck.BackColor = Color.Green;
                m_SelectedPuck = null;

                if (!isAnotherTurn)
                {
                    r_Game.SwapTurns();
                    r_Game.LastEaten = null;
                    lastMoveTile = null;
                }
                //i_Tile.BackColor = Color.CornflowerBlue;
                ComputerAnotherTurn = isAnotherTurn && !r_Game.CurrentPlayer.isHuman;
            }
            else
            {
                MessageBox.Show($"Invalid Move! ({moveToMake} is illegal.)");
            }

            checkEndGame();
        }

        private void checkEndGame()
        {
            //TODO ENDROUND LOGIC:
            if (!r_Game.IsGameActive(r_Game.CurrentPlayer, r_Game.OppPlayer))
            {
                MessageBox.Show("FINISHED");
                string endingMessage = r_Game.EndRound();
                DialogResult rematch = MessageBox.Show(endingMessage, "Damka", MessageBoxButtons.YesNo);
                if (rematch == DialogResult.Yes)
                {
                    setRematch();
                }
                else
                {
                    Dispose();
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //foreach (Control control in Controls)
            //{
            //    PictureBoxTile pictureBox = control as PictureBoxTile;

            //    if (pictureBox != null)
            //    {
            //        e.Graphics.DrawImage(
            //            pictureBox.Image,
            //            pictureBox.Location.X,
            //            pictureBox.Location.Y,
            //            pictureBox.Width,
            //            pictureBox.Height);
            //    }
            //}
        }

        private void PanelBoard_Load(object sender, EventArgs e)
        {

        }

    }
}
