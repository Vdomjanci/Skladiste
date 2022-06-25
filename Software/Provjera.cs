using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veronika_Domjancic
{
    public static class Provjera
    {
        internal static bool ProvjeraZaposlenika(string email, string tel)
        {
            bool mail = false, telefon = false;

            if (ValjanEmail(email))
                mail = true;

            if (ValjanTelefonskiBroj(tel))
                telefon = true;

            return mail && telefon;
        }

        public static bool ValjanEmail(string email)
        {
            bool duzina = false, ispravanOblik = false;

            if (IspravnaDuzina("Email", email, 9, 30))
            {
                duzina = true;
            }
            if (IspravanOblikEmaila(email))
            {
                ispravanOblik = true;
            }
            return duzina && ispravanOblik;
        }

        private static bool ValjanTelefonskiBroj(string tel)
        {
            bool duzina = false, ispravanOblik = false;

            if (IspravnaDuzina("Telefonski broj", tel, 5, 30))
            {
                duzina = true;
            }
            if (IspravanOblikTelBroja(tel))
            {
                ispravanOblik = true;
            }
            return duzina && ispravanOblik;
        }

        private static bool IspravanOblikTelBroja(string tel)
        {
            Match prviOblik = Regex.Match(tel, @"^\+385\d{9}$");
            Match drugiOblik = Regex.Match(tel, @"^09\d{8}$");

            if (prviOblik.Success || drugiOblik.Success)
                return true;
            else
            {
                MessageBox.Show("Telefonski broj mora biti oblika +385xxxxxxxxx ili 09xxxxxxxx!");
                return false;
            }
        }
        private static bool IspravanOblikEmaila(string email)
        {
            if (email != null)
            {
                try
                {
                    MailAddress m = new MailAddress(email);
                    return true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Email mora biti oblika ime@domena!");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Polje email ne smije biti prazno");
                return false;
            }
        }

        private static bool IspravnaDuzina(string objekt, string text, int min, int max)
        {
            if (text.Length >= min && text.Length <= max)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"{objekt} mora biti minimalne duzine {min} znaka i maksimalne duzine {max} znakova!");
                return false;
            }
        }
    }
}
