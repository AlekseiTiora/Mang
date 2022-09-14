using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Tegelane : Uksus, IComparable<Tegelane>
    {
        public string nimi;
        List<Ese> eseList = new List<Ese>();
        public int esemeteArv;

            public Tegelane(string nimi)
            {
                this.nimi = nimi;
                eseList = new List<Ese>();        
            }

        public void info()
        {
            string info = $"nimi - {nimi}, esemete arv - {esemeteArv}, punktide arv - {PunktideArv()}";
            Console.WriteLine(info);
        }

        public int PunktideArv()
        {
            int sum = 0;
            foreach (Ese ese in eseList)
            {
                sum += ese.PunktideArv();
            }
            return sum;
        }
        public int LisaEse(int ese) { return ese;}
         public string valjastaEsemed()
        {
            foreach (Ese ese in eseList)
            {
                Console.WriteLine(ese);
            }
            return valjastaEsemed();
        }

        public string info()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Tegelane? other)
        {
            throw new NotImplementedException();
        }
    }
}
