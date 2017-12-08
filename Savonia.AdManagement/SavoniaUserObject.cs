using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savonia.AdManagement
{
    public class SavoniaUserObject
    {
        public string Path { get; set; }
        public string Dn { get; set; }

        [DisplayName("Etuimi")]
        public string Name { get; set; }

        [DisplayName("Sukunimi")]
        public string Surname { get; set; }

        [DisplayName("Käyttäjätunnus")]
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Title { get; set; }

        [DisplayName("Sähköposti")]
        public string Email { get; set; }

        [DisplayName("Salasana")]
        public string Password { get; set; }

        [DisplayName("Enable/Disable")]
        public bool IsEnabled { get; set; }

        public override string ToString()
        {
            return $"Path: {Path}\nDn: {Dn}\nUsername: {Username}\nDisplay name: {DisplayName}\nTitle: {Title}\nEmail: {Email}\nIs enabled: {IsEnabled}";
        }
    }
}
