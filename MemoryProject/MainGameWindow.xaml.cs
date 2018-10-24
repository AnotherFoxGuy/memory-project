using System.Windows;


namespace MemoryProject
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainGameWindow
    {
        private readonly NewGameWindow _newGameWindow;
        public MainGameWindow(NewGameWindow newGameWindow)
        {

            //zorgt ervoor dat de naam op andere window ook wordt veranderd
            //retry
            _newGameWindow = newGameWindow;
            label1.Content = _newGameWindow.textbox1.Text;
            label2.Content = _newGameWindow.textbox2.Text;


            GridManager.Instance.LiveGameGrid = LiveGameGrid;
            GridManager.Instance.ScoreLabel = Score1;
        }

        private void RestartGame(object sender, RoutedEventArgs e)
        {
            GridManager.Instance.Clear();
            GridManager.Instance.LiveGameGrid = null;
            GridManager.Instance.ScoreLabel = null;
            
            var mainWindow = new MainMenuWindow();
            mainWindow.Show();
            Close();
        }
    }
}