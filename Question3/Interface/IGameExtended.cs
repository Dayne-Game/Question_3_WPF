using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3.Interface
{
    interface IGameExtended
    {
        string difficulty_level { get; set; }
        string Change_Max_Number_In_Range_Difficulty(string input);
        bool Check_Case_Input(string input);
    }
}
