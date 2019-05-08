using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3.Interface
{
    interface IScoring
    {
        string Five_Character_Name { get; set; }
        string True_Score_Value { get; set; }
        int Rough_Score_Value { get; set; }
        List<string> Score_And_Name_Database { get; set; }
        void Convert_Rough_Score_Into_True_Score();
        bool Check_If_Rough_Score_Is_Null_Or_Zero();
        bool Check_Five_Char_Name(string name);
        void Generate_New_Score_Database();
        void Add_Five_Character_Name_And_True_Score_And_Difficulty_Into_Score_And_Name_Database(string difficulty);
        string Display_Five_Character_Name_And_True_Score_From_Score_And_Name_Database(string difficulty);

    }
}
