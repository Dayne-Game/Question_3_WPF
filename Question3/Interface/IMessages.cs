using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Question3.Interface
{
    interface IMessages
    {
        string Welcome { get; set; }
        string Enter_Guess { get; set; }
        string Guess_Number { get; set; }
        string Case_Select_Console { get; set; }
        string Case_Select_Incorrect { get; set; }
        string Enter_Name { get; set; }
        string Enter_Name_Incorrect_one { get; set; }
        string Enter_Name_Incorrect_two { get; set; }
        string Case_Select_UI { get; set; }
    }
}
