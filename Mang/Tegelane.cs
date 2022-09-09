using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Tegelane : Entity 
    {
        public string nimi;
        List<Ese> items;

            public Tegelane(string nimi)
            {
                this.nimi = nimi;
                items = new List<Ese>();        
            }
    }
}
