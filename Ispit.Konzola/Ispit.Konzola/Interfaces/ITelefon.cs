using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola.Interfaces
{
    public interface ITelefon
    {
        public string Model { get; }
        public string Poziv(string tel_broj);
        
    }
}
