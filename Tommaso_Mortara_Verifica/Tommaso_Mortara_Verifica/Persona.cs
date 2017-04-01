using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tommaso_Mortara_Verifica
{
    class Persona
    {
        private string _fName;
        public string fName { get; set; }

        private string _lName;
        public string lName { get; set; }

        private int _age;
        public int age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value <= 0)
                {
                    value = 1;
                }

                _age = value;
            }      
        }

        public Persona(string name , string surname, int years)
        {
            _fName = name;
            _lName = surname;
            _age = years;   
        }

        public override string ToString()
        {
            return fName+ "/ "+ lName;
        }

        public virtual string describe()
        {
            string output = "NOME: " + fName+ "\r\n";
                   output += "COGNOME: " + lName + "\r\n";
                   output += "ANNI: " + age + "\r\n";

            return output;
        }

    }
}
