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
    /// Interaction logic for Score.xaml
    /// </summary>
    public partial class Score : Window
    {
        static Scoring score = new Scoring();
        static GameExtended game = new GameExtended();
        static Messages messages = new Messages();
        static string level_difficulty = "";
        public Score(string win_lose, int rough_score, string difficulty)
        {
            InitializeComponent();
            ScoreTitle.Content = win_lose;
            level_difficulty = difficulty;
            score.Rough_Score_Value = rough_score;
            score.Convert_Rough_Score_Into_True_Score();
            Debug.WriteLine(game.difficulty_level);
            NameTitle.Content = messages.Enter_Name;

        }

        private void SubmitNameBtn_Click(object sender, RoutedEventArgs e)
        {

            if (score.Check_Five_Char_Name(NameInput.Text))
            {
                score.Five_Character_Name = NameInput.Text;
                ScoreDisplay.Content = score.Display_Five_Character_Name_And_True_Score_From_Score_And_Name_Database(level_difficulty);
            }
            else
            {
                NameTitle.Content = "Your Name is Too Long or No Name is Entererd";
            }
        }

        private void PlayAgainBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow start = new MainWindow();
            start.Show();
            this.Close();
        }
    }
}
