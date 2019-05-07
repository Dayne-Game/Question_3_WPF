using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3.Models
{
    class Messages
    {
        public string Welcome { get; set; } = "Welcome to the Number Guessing Game";
        public string Enter_Guess { get; set; } = "Enter a Guess >> ";
        public string Guess_Number { get; set; } = "I've picked a Random Number? Can you Guess it? I Will Only Give you 3 Goes...";
        public string Case_Select_Console { get; set; } = "Select 1 for Easy, 2 For Medium, and 3 for Hard";
        public string Case_Select_Incorrect { get; set; } = "You didn't enter 1, 2, or 3";
        public string Enter_Name { get; set; } = "Enter your Name (5 Characters MAX)";
        public string Enter_Name_Incorrect_one { get; set; } = "Please Enter a five character name";
        public string Enter_Name_Incorrect_two { get; set; } = "Your name is longer than 5 characters";
        public string Case_Select_UI { get; set; } = "Choose your Game Difficulty";
    }
}
