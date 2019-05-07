using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3.Models
{
    class GameExtended : Game
    {
        public string difficulty_level { get; set; }
        public string Change_Max_Number_In_Range_Difficulty(string input)
        {
            string difficulty = "Difficulty Selected: ";
            if (Check_Case_Input(input))
            {
                switch (input)
                {
                    case "1":
                        {
                            max_Number_In_Range_For_Chosen_Number = 5;
                            difficulty += "Easy";
                            difficulty_level = "Easy";
                            break;
                        }
                    case "2":
                        {
                            max_Number_In_Range_For_Chosen_Number = 10;
                            difficulty += "Medium";
                            difficulty_level = "Medium";
                            break;
                        }
                    case "3":
                        {
                            max_Number_In_Range_For_Chosen_Number = 20;
                            difficulty += "Hard";
                            difficulty_level = "Hard";
                            break;
                        }
                }
                return difficulty;
            }
            else
            {
                return "Enter 1, 2, or 3";
            }
        }

        public bool Check_Case_Input(string input)
        {
            int.TryParse(input, out int user_input);
            if (user_input >= 1 && user_input <= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
