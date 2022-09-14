using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Ese : Uksus
    {
        int punktideArv;
        string nimetus;

        public Ese(int punktideArv, string nimetus)
        {
            this.punktideArv = punktideArv;
            this.nimetus = nimetus;
        }
        
        public int PunktideArv() { return punktideArv; }// возращает кол-во строчек
        public string info() { return nimetus; }   //возрящет имя
    }
}
