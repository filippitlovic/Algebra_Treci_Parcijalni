using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola.Interfaces
{
    public interface IPametniTelefon : ITelefon
    {
        public string Surfanje(string url);
    }
}
