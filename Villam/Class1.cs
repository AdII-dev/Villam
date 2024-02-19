using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villam
{
    internal class VillaM
    {
        public List<int> Ora { get; set; }


        public VillaM(string v)
        {
            var tomb = v.Split(';');


            Ora = new List<int>();
            for (int i = 0; i < tomb.Length; i++)
            {
                Ora.Add(Convert.ToInt32(tomb[i]));
            }
        }

        public override string ToString()
        {

            string text = string.Empty;
            for (int i = 0; i < Ora.Count; i++)
                    {
                        text += Ora[i] + " ";

                    }

                return text;
        }

    }

}

