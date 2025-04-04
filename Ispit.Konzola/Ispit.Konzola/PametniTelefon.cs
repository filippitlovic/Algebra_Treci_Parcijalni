using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Ispit.Konzola.Interfaces;

namespace Ispit.Konzola
{
    public class PametniTelefon : IPametniTelefon,ITelefon
    {
        public string Model { get; private set; }

        public PametniTelefon(string model)
        {
            model = Model;
        }
        public string Surfanje(string url)
        {
            if (!ProvjeriAkoJeValidanUrl(url))
            {
                return url;
            }
            else
            {
                return "Neispravan url";
            }
        }

        public string Poziv(string tel_broj)
        {
            if (!ProvjeriAkoJeValidanBroj(tel_broj))
                return tel_broj;
            else
                return "Neispravan tel_broj";
        }

        public bool ProvjeriAkoJeValidanBroj(string tel_broj) {
            foreach (var str in tel_broj)
            {
                if(!char.IsDigit(str))
                    return false;
            }
            return true;
        }

        public bool ProvjeriAkoJeValidanUrl(string url)
        {
            string pattern = @"^(https?)://[^\s/$.?#].[^\s]*$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(url);
        }
    }
}
