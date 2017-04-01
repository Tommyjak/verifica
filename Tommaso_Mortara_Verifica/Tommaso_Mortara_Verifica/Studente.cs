using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tommaso_Mortara_Verifica
{
    class Studente:Persona
    {
        public List<float> voti = new List<float>();

        private string _sezione;
        public string sezione { get; set; }

        private float _media;
        public float media { get { return _media; } }

        public Studente (string name , string surname , int years , string sezione) : base (name, surname , years)
        {
            _sezione = sezione;
        }

        public override string describe()
        {
            int nVoti = voti.Count;
            float SommaVoti=0;

            string output = base.describe();
            output += "SEZIONE: " + sezione + "\r\n";
            output += "NUMERO DI VOTI: " + nVoti + "\r\n";
            for (int i = 0; i < nVoti; i++)
            {
                output += "VOTO " + i + ": " + voti[i] + "\r\n";
                SommaVoti += voti[i];
            }

            _media = SommaVoti / nVoti;
            output += "MEDIA DEI VOTI: " + _media;

            return output;
        }
    }
}
