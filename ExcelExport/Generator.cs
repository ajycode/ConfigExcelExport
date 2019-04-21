using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToLua
{
    public static class Generator
    {
        public static string indir;
        public static string outdir;

        public static void Gen(string generatorType, List<string> files)
        {
            switch(generatorType)
            {
                case "Lua":
                    GenLua(files);
                    break;
                case "Json":
                    GenJson(files);
                    break;
                case "Xml":
                    GenXml(files);
                    break;
                default:
                    break;
            }
        }

        public static void GenLua(List<string> files)
        {

        }

        public static void GenJson(List<string> files)
        {

        }

        public static void GenXml(List<string> files)
        {

        }
    }
}
