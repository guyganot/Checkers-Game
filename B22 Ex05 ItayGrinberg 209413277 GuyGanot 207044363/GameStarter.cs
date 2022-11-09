using System.Windows.Forms;

namespace B22_Ex05_ItayGrinberg_209413277_GuyGanot_207044363
{
    public static class GameStarter
    {
        public static void Start()
        {
            FormGame formGame = null;
            GameSettings gameSettings = new GameSettings();

            gameSettings.ShowDialog();
            if (gameSettings.DialogResult == DialogResult.OK)
            {
                Player player1 = new Player(gameSettings.FirstPlayerName, 'X');
                Player player2 = new Player(gameSettings.SecondPlayerName, 'O', gameSettings.IsHuman);
                Board board = new Board(gameSettings.BoardSize());
                Game game = new Game(player1, player2, board);
                formGame = new FormGame(game);
                formGame.ShowDialog();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GameSettings gameSettingsForm = new GameSettings();
            Application.Run(gameSettingsForm);

        }
    }
}
