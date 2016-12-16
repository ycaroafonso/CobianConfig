using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobianConfig
{
    class Program
    {
        static void Main(string[] args)
        {
            //new System.IO.DirectoryInfo(@"I:\Ycaro\Documentos\Projetos\GIS");
            var x = System.IO.Directory.GetDirectories(@"I:\Ycaro\Documentos\Projetos\GIS", "*.*", System.IO.SearchOption.AllDirectories)
                .Where(c => new[] { "bin", "obj", ".git", "packages" }.Contains(c.Split('\\').Last()))
                .Select(c => string.Concat("\"1, \"\"", c, "\"\",0,0000000000000000000000000000000000000000000000000000000000000000\","))
                .ToList();

            var xxx = string.Join("", x);

            int xx = 1;
        }
    }
}
