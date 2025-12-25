using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryGeniusIdiot
{
    public class CheckingUserResponsesWinForms
    {
        public bool CheckingUserResponse(string response)
        {
            try
            {
                Convert.ToInt32(response);
                return true;
            }
            catch(OverflowException)
            {
                MessageBox.Show("Слишком большое число");
            }
            catch(Exception)
            {
                MessageBox.Show("Введите число");
            }
            return false;
        }
    }
}
