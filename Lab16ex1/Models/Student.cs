using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16ex1.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        public int SpecializareId { get; set; }

        public override string ToString()
        {
            var prettySpecializare = string.Empty;

            switch (SpecializareId)
            {
                case 1:
                    prettySpecializare = "Informatica";
                    break;
                case 2:
                    prettySpecializare = "Litere";
                    break;
                case 3:
                    prettySpecializare = "Constructii";
                    break;
            }
            return $"{Id},{Nume},{Prenume},{Varsta}, Specializarea => {prettySpecializare}";
        }
    }
}
