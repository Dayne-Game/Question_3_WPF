using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3.Models
{
    class Scoring
    {
        public string Five_Character_Name { get; set; }
        public string True_Score_Value { get; set; }
        public int Rough_Score_Value { get; set; }
        public List<string> Score_And_Name_Database { get; set; }

        public void Convert_Rough_Score_Into_True_Score()
        {
            if (Check_If_Rough_Score_Is_Null_Or_Zero())
            {
                switch (Rough_Score_Value)
                {
                    case 1:
                        {
                            True_Score_Value = "10";
                            break;
                        }
                    case 2:
                        {
                            True_Score_Value = "6";
                            break;
                        }
                    case 3:
                        {
                            True_Score_Value = "2";
                            break;
                        }
                }
            }
            else
            {
                True_Score_Value = "0";
            }
        }

        public bool Check_If_Rough_Score_Is_Null_Or_Zero()
        {
            if (Rough_Score_Value != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Check_Five_Char_Name(string name)
        {
            if (name.Length == 5 || name.Length < 5 && name.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Generate_New_Score_Database()
        {
            Score_And_Name_Database = new List<string>();
        }

        public void Add_Five_Character_Name_And_True_Score_And_Difficulty_Into_Score_And_Name_Database(string difficulty)
        {
            Generate_New_Score_Database();
            Score_And_Name_Database.Add(Five_Character_Name);
            Score_And_Name_Database.Add(True_Score_Value);
            Score_And_Name_Database.Add(difficulty);
        }

        public string Display_Five_Character_Name_And_True_Score_From_Score_And_Name_Database(string difficulty)
        {
            Add_Five_Character_Name_And_True_Score_And_Difficulty_Into_Score_And_Name_Database(difficulty);
            string output = "";
            foreach (string name_or_score in Score_And_Name_Database)
            {
                output += $"| {name_or_score} |";
            }
            return output;
        }
    }
}
