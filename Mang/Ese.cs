using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Ese : Entity
    {
        int punktideArv;
        string nimetus;

        public Ese(int punktideArv, string nimetus)
        {
            this.punktideArv = punktideArv;
            this.nimetus = nimetus;
        }
        
        public int PunktideArv() { return punktideArv; }
        public string info() { return nimetus; }   
    }
}
