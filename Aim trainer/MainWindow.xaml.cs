using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Aim_trainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int score = 0;
        private int timeLeft = 30;
        private Random random = new Random();
        private DispatcherTimer gameTimer = new DispatcherTimer();
        private DispatcherTimer targetTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void StartButton_Click(object sender, RoutedEventArgs e) {
            StartGame();

        }

        private void StartGame() {
            score = 0;
            timeLeft = 30;
            ScoreText.Text = "Score: 0";
            TimeText.Text = "Time: 30";
            GameCanvas.Children.Clear();
            gameTimer.Start();
            targetTimer.Start();
            StartButton.IsEnabled = false;
        }

        private void GameTimer_Tick(object sender, EventArgs e) { }

        private void TargetTimer_Tick(object sender, EventArgs e) { }

        private void CreateTarget() { }

        private void Target_MouseDown(object sender, MouseButtonEventArgs e) { }

        private void EndGame() {
            gameTimer.Stop();
            targetTimer.Stop();
            MessageBox.Show($"Game Over! Your score: {score}", "Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
            StartButton.IsEnabled = true;
        }
    }
}