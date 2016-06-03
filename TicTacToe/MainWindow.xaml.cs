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
        public int player1;
       
        public MainWindow()
        {
            InitializeComponent();

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
            GameStarted = true;
            MessageBox.Show("Game Started");
        }

        private void GameBoardSection00_Click(object sender, RoutedEventArgs e)
        {
            // ... Create a new BitmapImage.
            BitmapImage b = new BitmapImage();
            b.BeginInit();
            b.UriSource = new Uri("Resources/PlayerO.png");
            b.EndInit();

            // ... Get Image reference from sender.
            var image = sender as Image;
            // ... Assign Source.
            image.Source = b;
        
    }

        private bool checkGameStatus()
        {
            //player1Image = new ImageBrush();
            //player2Image = new ImageBrush();
            if (!GameStarted)
                return false;
            else
                return true;

            if (Player1CircleRB.IsChecked == true)
            {
                player1 = 0;
              //  player1Image.ImageSource = new BitmapImage(new Uri("Resources/PlayerO.png", UriKind.Relative));
               // player2Image.ImageSource = new BitmapImage(new Uri("Resources/PlayerX.png", UriKind.Relative));
            }

            else
            {
                player1 = 1;
               // player1Image.ImageSource = new BitmapImage(new Uri("Resources/PlayerX.png", UriKind.Relative));
                //player2Image.ImageSource = new BitmapImage(new Uri("Resources/PlayerO.png", UriKind.Relative));
            }
               

           
           
        }
    }
}
