using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestProject1
{
    public static class LerCsv
    {
        public static List<string> Page_Load()
        {
            StreamReader stream = new StreamReader(@"A:\qlc-ids.csv");
            List<string> valores = new List<string>();

            string linha = null;
            while((linha = stream.ReadLine()) != null)
            {
                string[] coluna = linha.Split(';');

                valores.Add(coluna[0]);
            }

            return valores;
        }
    }
}
