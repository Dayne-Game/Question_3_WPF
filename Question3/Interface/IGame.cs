using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3.Interface
{
    interface IGame
    {
        int Chosen_Number { get; set; }
        bool Chosen_Number_Guessed { get; set; }
        int max_Number_In_Range_For_Chosen_Number { get; set; }
        List<int> Guess_Database { get; set; }
        void Load_Game_Settings();
        bool Check_The_Inputed_Guess_From_The_User(int user_input);
        string Display_All_Guesses_Individual_And_Num_Of_Guesses_Taken();
        string Game_Commencing(int user_input);
    }
}
