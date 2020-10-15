using System;

namespace StoringText {
    class Program {
        static void Main (string[] args) {
            // Char uses single Quote '
            char letter = 'A'; //assing literal characters
            char digit = '1';
            char symbol = '$';
            char userChoice = GetKeystroke (); //assinging from a function
            // String uses double Quotes "
            string firstName = "Everton"; // Assinging literal strings
            string lastName = "Trajano";
            string phoneNumber = "(55) 12345-6789";

            // Assinging a string returned from a function call
            String address = GetAddressFromDatabase(id: 563);
        }
    }
}