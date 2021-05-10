//Utwórz prost¹ aplikacjê WinForms.
//Dodaj do formularza funkcje rejestracji i logowania.
//Podziel formularz na dwie czêœci. W sekcji rejestracji dodaj TextBoxy "Login", "Has³o", "Powtórz Has³o". 
//Dodaj CheckBox "Zgoda RODO". Pola z has³em musz¹ ukrywaæ znaki (wyœwietlaæ kropki). Dodaj Button "Zarejestruj", który utworzy konto w dowolnej kolekcji. 
//Po zarejestrowaniu wyœwietl MessageBox z informacj¹ o poprawnym zarejestrowaniu. ¯eby utworzyæ konto, Login nie mo¿e byæ pusty, 
//has³a musz¹ siê zgadzaæ a Checkbox musi byæ zaznaczony. W sekcji logowania dodaj tylko Textboxy "Login", "Has³o" i Button "Zaloguj". 
//Pole z has³em musi ukrywaæ znaki. Dane musz¹ nale¿eæ do istniej¹cego konta. Wyœwietl MessageBox z powiadomieniem.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using P4_PROJEKT_NR_1.Forms;

namespace P4_PROJEKT_NR_1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Login());
        }
    }
}
