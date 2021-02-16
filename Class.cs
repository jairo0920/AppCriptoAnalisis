using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCriptoAnalisis
{
    class Class
    {

    }
    class ReadingCSV
    {
        public void LeerFrecuencia(string[][] listIngles, string[][] listEspanol, string[][] listFrances, string[][] listAleman)
        {
            var reader = new StreamReader(File.OpenRead(@"C:\criptoanalisis\frecuencias.csv"));
            int count = 0;

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                listIngles[count] = new string[2] { values[0], values[1]};
                listEspanol[count] = new string[2] { values[2], values[3] };
                listFrances[count] = new string[2] { values[4], values[5] };
                listAleman[count] = new string[2] { values[6], values[7] };

                count++;
            }
        }

        public void LeerBigramaFrecuencia(string[][] listIngles, string[][] listEspanol, string[][] listFrances, string[][] listAleman)
        {
            var reader = new StreamReader(File.OpenRead(@"C:\criptoanalisis\bigramas.csv"));
            int count = 0;

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                listIngles[count] = new string[2] { values[0], values[1] };
                listEspanol[count] = new string[2] { values[2], values[3] };
                listFrances[count] = new string[2] { values[4], values[5] };
                listAleman[count] = new string[2] { values[6], values[7] };

                count++;
            }
        }

        public void LeerTrigramaFrecuencia(string[][] listIngles, string[][] listEspanol, string[][] listFrances, string[][] listAleman)
        {
            var reader = new StreamReader(File.OpenRead(@"C:\criptoanalisis\trigrama.csv"));
            int count = 0;

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');

                listIngles[count] = new string[2] { values[0], values[1] };
                listEspanol[count] = new string[2] { values[2], values[3] };
                listFrances[count] = new string[2] { values[4], values[5] };
                listAleman[count] = new string[2] { values[6], values[7] };

                count++;
            }
        }
    }
}
