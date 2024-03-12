using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Modul_04
{
    internal class Program
    {
        public class KodePos
        {


            public string getKodePos(Kelurahan kelurahan)
            {
                string[] kodePos = {"40266", "40287", "40267", "40256", "40287",
                "40286", "40286", "40286", "40272", "40274",
                "40273"
                };
                {
                    int index = (int)kelurahan;
                    return kodePos[index];
                }
            }
        }

        public enum Kelurahan
        {
            Batununggal,
            Kujangsari,
            Mengger,
            Wates,
            Cijaura,
            Jatisari,
            Margasari,
            Sekejati,
            Kebonwaru,
            Maleer,
            Samoja
        }

        static void Main(string[] args)
        {
        }
    }
}
