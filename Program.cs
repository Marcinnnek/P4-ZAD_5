//Utw�rz prost� aplikacj� WinForms.
//Dodaj do formularza funkcje rejestracji i logowania.
//Podziel formularz na dwie cz�ci. W sekcji rejestracji dodaj TextBoxy "Login", "Has�o", "Powt�rz Has�o". 
//Dodaj CheckBox "Zgoda RODO". Pola z has�em musz� ukrywa� znaki (wy�wietla� kropki). Dodaj Button "Zarejestruj", kt�ry utworzy konto w dowolnej kolekcji. 
//Po zarejestrowaniu wy�wietl MessageBox z informacj� o poprawnym zarejestrowaniu. �eby utworzy� konto, Login nie mo�e by� pusty, 
//has�a musz� si� zgadza� a Checkbox musi by� zaznaczony. W sekcji logowania dodaj tylko Textboxy "Login", "Has�o" i Button "Zaloguj". 
//Pole z has�em musi ukrywa� znaki. Dane musz� nale�e� do istniej�cego konta. Wy�wietl MessageBox z powiadomieniem.

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
