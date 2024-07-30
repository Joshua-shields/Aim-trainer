using System.Text;
using System.Windows;
using System.Windows.Automation;
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
        private int score;
        private int timeLeft;
        private readonly Random random = new Random();
        private readonly DispatcherTimer gameTimer = new DispatcherTimer();
        private readonly DispatcherTimer targetTimer = new DispatcherTimer();
        private const int GameDuration = 30;
        private const double MinTargetSize = 20;
        private const double MaxTargetSize = 50;

        public MainWindow()
        {
            InitializeComponent();
            gameTimer.Interval = TimeSpan.FromSeconds(1);
            gameTimer.Tick += GameTimer_Tick;

            targetTimer.Interval = TimeSpan.FromSeconds(1); 
            targetTimer.Tick += TargetTimer_Tick;
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

        private void GameTimer_Tick(object sender, EventArgs e) {
            timeLeft--;
            TimeText.Text = $"Time: {timeLeft}";
            if (timeLeft <= 0)
            {
                EndGame();
            }
        }

        private void TargetTimer_Tick(object sender, EventArgs e) {
            CreateTarget();
        }

        private void CreateTarget() {
            double size = random.Next(20, 50);
            double x = random.NextDouble() * (GameCanvas.ActualWidth - size);
            double y = random.NextDouble() * (GameCanvas.ActualHeight - size);

            Ellipse target = new Ellipse
            {
                Width = size,
                Height = size,
                Fill = Brushes.Red,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };

            Canvas.SetLeft(target, x);
            Canvas.SetTop(target, y);
            target.MouseDown += Target_MouseDown;

            GameCanvas.Children.Add(target);
        }

        public void percenthit(object sender, EventArgs) {
            // take the percent of target hit and display how acurate the user is 
            // when the target is hit should be displayed in  a window 
        }

        public void diffuclty(object sender, EventArgs e) {
            GameCanvas ();
            targetTimer.Start();

        // change the speed of how fast the targets spawn if extreme is selected then it needs to be 90 targets in 
        // 30 second also need to change timeing of the countdown
        }

        private void Target_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Ellipse target)
            {
                GameCanvas.Children.Remove(target);
                score++;
                ScoreText.Text = $"Score: {score}";
            }
        }

            private void EndGame() {
            gameTimer.Stop();
            targetTimer.Stop();
            MessageBox.Show($"Game Over! Your score: {score}", "Game Over", MessageBoxButton.OK, MessageBoxImage.Information);
            StartButton.IsEnabled = true;
        }
    }
}