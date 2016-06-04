using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public GameEngine game;
        public int turns;
        public bool GameStarted = false;
        public bool player1turn = true;
        public int player1 = 1;
        public int player2 = 2;
        public Button OBtn;
        public Button XBtn;
        public Button P1Btn;
        public Button P2Btn;
        public StackPanel P1ImgPnl;
        public StackPanel P2ImgPnl;
        public Image Oimg;
        public Image Ximg;
    
        public MainWindow()
        {
            InitializeComponent();
            GameBoardGrid.IsEnabled = false;
        }

        private void Player1SelectedCircle(object sender, RoutedEventArgs e)
        {
            Player2XRB.IsChecked = true;
            Player1CircleRB.IsChecked = true;

        }
        private void Player2SelectedCircle(object sender, RoutedEventArgs e)
        {
            Player1XRB.IsChecked = true;
            Player2CircleRB.IsChecked = true;
        }

        private void Player1SelectedX(object sender, RoutedEventArgs e)
        {
            Player1XRB.IsChecked = true;
            Player2CircleRB.IsChecked = true;
        }
        private void Player2SelectedX(object sender, RoutedEventArgs e)
        {
            Player2XRB.IsChecked = true;
            Player1CircleRB.IsChecked = true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            game = new GameEngine();
            MessageBox.Show("Game Started");
            GameBoardGrid.IsEnabled = true;
            PlayerTurnLable.Content = "Player 1";
            StartBtn.IsEnabled = false;
            Player1CircleRB.IsEnabled = false;
            Player1XRB.IsEnabled = false;
            Player2CircleRB.IsEnabled = false;
            Player2XRB.IsEnabled = false;

            if (Player1CircleRB.IsChecked == false)
                player1turn = false;
        }


        private void updateGameStatus()
        {
            if (!player1turn)
            {
                if (game.CheckWinner(2))
                {
                    MessageBox.Show("Winner : Player 2");
                    GameBoardGrid.IsEnabled = false;
                }

                player1turn = true;
                PlayerTurnLable.Content = "Player 1";

            }

            else
            {
                if (game.CheckWinner(1))
                {
                    MessageBox.Show("Winner : Player 1");
                    GameBoardGrid.IsEnabled = false;
                }

                player1turn = false;
                PlayerTurnLable.Content = "Player 2";
            }
            turns++;
            TurnsLable.Content = turns;

        }


        private void GameBoardSection00_Click(object sender, RoutedEventArgs e)
        {
            var X = new Image();
            X.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerO.png"));
            var P1Img = new StackPanel();
            P1Img.Orientation = Orientation.Horizontal;
            P1Img.Margin = new Thickness(10);
            P1Img.Children.Add(X);

            var Y = new Image();
            Y.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerX.png"));
            var P2Img = new StackPanel();
            P2Img.Orientation = Orientation.Horizontal;
            P2Img.Margin = new Thickness(10);
            P2Img.Children.Add(Y);

            if (player1turn)
            {
                GameBoardSection00.Content = P1Img;
                game.board[0, 0] = 1;
            }
            else
            {
                GameBoardSection00.Content = P2Img;
                game.board[0, 0] = 2;
            }

            GameBoardSection00.Opacity = 100;
            GameBoardSection00.IsEnabled = false;
            updateGameStatus();
        }

        private void GameBoardSection01_Click(object sender, RoutedEventArgs e)
        {

            var X = new Image();
            X.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerO.png"));
            var P1Img = new StackPanel();
            P1Img.Orientation = Orientation.Horizontal;
            P1Img.Margin = new Thickness(10);
            P1Img.Children.Add(X);

            var Y = new Image();
            Y.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerX.png"));
            var P2Img = new StackPanel();
            P2Img.Orientation = Orientation.Horizontal;
            P2Img.Margin = new Thickness(10);
            P2Img.Children.Add(Y);

            if (player1turn)
            {
                GameBoardSection01.Content = P1Img;
                game.board[0, 1] = 1;
            }
            else
            {
                GameBoardSection01.Content = P2Img;
                game.board[0, 1] = 2;
            }

            GameBoardSection01.Opacity = 100;
            GameBoardSection01.IsEnabled = false;
            updateGameStatus();
        }

        private void GameBoardSection02_Click(object sender, RoutedEventArgs e)
        {
            var X = new Image();
            X.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerO.png"));
            var P1Img = new StackPanel();
            P1Img.Orientation = Orientation.Horizontal;
            P1Img.Margin = new Thickness(10);
            P1Img.Children.Add(X);

            var Y = new Image();
            Y.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerX.png"));
            var P2Img = new StackPanel();
            P2Img.Orientation = Orientation.Horizontal;
            P2Img.Margin = new Thickness(10);
            P2Img.Children.Add(Y);

            if (player1turn)
            {
                GameBoardSection02.Content = P1Img;
                game.board[0, 2] = 1;
            }
            else
            {
                GameBoardSection02.Content = P2Img;
                game.board[0, 2] = 2;
            }

            GameBoardSection02.Opacity = 100;
            GameBoardSection02.IsEnabled = false;
            updateGameStatus();
        }

        private void GameBoardSection10_Click(object sender, RoutedEventArgs e)
        {
            var X = new Image();
            X.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerO.png"));
            var P1Img = new StackPanel();
            P1Img.Orientation = Orientation.Horizontal;
            P1Img.Margin = new Thickness(10);
            P1Img.Children.Add(X);

            var Y = new Image();
            Y.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerX.png"));
            var P2Img = new StackPanel();
            P2Img.Orientation = Orientation.Horizontal;
            P2Img.Margin = new Thickness(10);
            P2Img.Children.Add(Y);

            if (player1turn)
            {
                GameBoardSection10.Content = P1Img;
                game.board[1, 0] = 1;
            }
            else
            {
                GameBoardSection10.Content = P2Img;
                game.board[1, 0] = 2;
            }


            GameBoardSection10.Opacity = 100;
            GameBoardSection10.IsEnabled = false;
            updateGameStatus();
        }

        private void GameBoardSection11_Click(object sender, RoutedEventArgs e)
        {
            var X = new Image();
            X.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerO.png"));
            var P1Img = new StackPanel();
            P1Img.Orientation = Orientation.Horizontal;
            P1Img.Margin = new Thickness(10);
            P1Img.Children.Add(X);

            var Y = new Image();
            Y.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerX.png"));
            var P2Img = new StackPanel();
            P2Img.Orientation = Orientation.Horizontal;
            P2Img.Margin = new Thickness(10);
            P2Img.Children.Add(Y);

            if (player1turn)
            {
                GameBoardSection11.Content = P1Img;
                game.board[1, 1] = 1;
            }
            else
            {
                GameBoardSection11.Content = P2Img;
                game.board[1, 1] = 2;
            }

            GameBoardSection11.Opacity = 100;
            GameBoardSection11.IsEnabled = false;
            updateGameStatus();
        }

        private void GameBoardSection12_Click(object sender, RoutedEventArgs e)
        {
            var X = new Image();
            X.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerO.png"));
            var P1Img = new StackPanel();
            P1Img.Orientation = Orientation.Horizontal;
            P1Img.Margin = new Thickness(10);
            P1Img.Children.Add(X);

            var Y = new Image();
            Y.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerX.png"));
            var P2Img = new StackPanel();
            P2Img.Orientation = Orientation.Horizontal;
            P2Img.Margin = new Thickness(10);
            P2Img.Children.Add(Y);

            if (player1turn)
            {
                GameBoardSection12.Content = P1Img;
                game.board[1, 2] = 1;
            }
            else
            {
                GameBoardSection12.Content = P2Img;
                game.board[1, 2] = 2;
            }

            GameBoardSection12.Opacity = 100;
            GameBoardSection12.IsEnabled = false;
            updateGameStatus();
        }

        private void GameBoardSection20_Click(object sender, RoutedEventArgs e)
        {
            var X = new Image();
            X.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerO.png"));
            var P1Img = new StackPanel();
            P1Img.Orientation = Orientation.Horizontal;
            P1Img.Margin = new Thickness(10);
            P1Img.Children.Add(X);

            var Y = new Image();
            Y.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerX.png"));
            var P2Img = new StackPanel();
            P2Img.Orientation = Orientation.Horizontal;
            P2Img.Margin = new Thickness(10);
            P2Img.Children.Add(Y);

            if (player1turn)
            {
                GameBoardSection20.Content = P1Img;
                game.board[2, 0] = 1;
            }
            else
            {
                GameBoardSection20.Content = P2Img;
                game.board[2, 0] = 2;
            }

            GameBoardSection20.Opacity = 100;
            GameBoardSection20.IsEnabled = false;
            updateGameStatus();
        }

        private void GameBoardSection21_Click(object sender, RoutedEventArgs e)
        {

            var X = new Image();
            X.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerO.png"));
            var P1Img = new StackPanel();
            P1Img.Orientation = Orientation.Horizontal;
            P1Img.Margin = new Thickness(10);
            P1Img.Children.Add(X);

            var Y = new Image();
            Y.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerX.png"));
            var P2Img = new StackPanel();
            P2Img.Orientation = Orientation.Horizontal;
            P2Img.Margin = new Thickness(10);
            P2Img.Children.Add(Y);

            if (player1turn)
            {
                GameBoardSection21.Content = P1Img;
                game.board[2, 1] = 1;
            }
            else
            {
                GameBoardSection21.Content = P2Img;
                game.board[2, 1] = 2;
            }

            GameBoardSection21.Opacity = 100;
            GameBoardSection21.IsEnabled = false;
            updateGameStatus();
        }

        private void GameBoardSection22_Click(object sender, RoutedEventArgs e)
        {

            //var X = new Image();
            //X.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerO.png"));
            //var P1Img = new StackPanel();
            //P1Img.Orientation = Orientation.Horizontal;
            //P1Img.Margin = new Thickness(10);
            //P1Img.Children.Add(X);

            var P1Img = GetStackPanel();

            var Y = new Image();
            Y.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerX.png"));
            var P2Img = new StackPanel();
            P2Img.Orientation = Orientation.Horizontal;
            P2Img.Margin = new Thickness(10);
            P2Img.Children.Add(Y);

            if (player1turn)
            {
                GameBoardSection22.Content = P1Img;
                game.board[2, 2] = 1;
            }
            else
            {
                GameBoardSection22.Content = P2Img;
                game.board[2, 2] = 2;
            }

            GameBoardSection22.Opacity = 100;
            GameBoardSection22.IsEnabled = false;
            updateGameStatus();
        }

        public StackPanel GetStackPanel()
        {
            var X = new Image();
            X.Source = new BitmapImage(new Uri(@"C:\Users\User1\Desktop\Van C# Programs\Tic Tac Toe\WPF-TicTacToe\TicTacToe\Resources\PlayerO.png"));
            var P1Img = new StackPanel();
            P1Img.Orientation = Orientation.Horizontal;
            P1Img.Margin = new Thickness(10);
            P1Img.Children.Add(X);

            return P1Img;
        }
       
    }
}
