using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using Question3.Models;
using System.Diagnostics;

namespace Question3
{
    /// <summary>
    /// Interaction logic for Easy.xaml
    /// </summary>
    public partial class Easy : Window
    {
        static Messages messages = new Messages();
        static GameExtended game = new GameExtended();
        static int rough_score = 0;
        static string win_lose = "";
        static int counter = 0;

        public Easy(string difficulty)
        {
            InitializeComponent();
            counter = 0;
            game.Chosen_Number_Guessed = false;
            GameTitle.Content = messages.Welcome;
            GuessTitle.Content = messages.Enter_Guess;
            Difficulty.Content = game.Change_Max_Number_In_Range_Difficulty(difficulty);
            game.Load_Game_Settings();
        }

        private void SubmitGuessBtn_Click(object sender, RoutedEventArgs e)
        {
            while(counter < 3 && !game.Chosen_Number_Guessed)
            {
                int.TryParse(GuessInput.Text, out int user_input);
                GuessTitle.Content = game.Game_Commencing(user_input);
                Debug.WriteLine(game.Guess_Database.Count);
                Debug.WriteLine(game.Chosen_Number_Guessed);
                if(game.Chosen_Number_Guessed == true)
                {
                    rough_score = game.Guess_Database.Count;
                    win_lose = "You Win";
                    Score score = new Score(win_lose, rough_score, game.difficulty_level);
                    score.Show();
                    this.Close();
                }
                counter++;
                Debug.WriteLine(counter);
                break;
            }
            if(game.Guess_Database.Count == 3 && game.Chosen_Number_Guessed == false)
            {
                win_lose = "You Lost";
                Score score = new Score(win_lose, rough_score, game.difficulty_level);
                score.Show();
                this.Close();
            }
        }
    }
}
