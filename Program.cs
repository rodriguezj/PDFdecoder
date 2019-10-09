using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var base64encoding = "JVBERi0xLjQNCiXi48/";
                byte[] decodePDF = Convert.FromBase64String(base64encoding);

                BinaryWriter writer = new BinaryWriter(File.Open(@"c:\Users\user\desktop\decodedpdf68.pdf", FileMode.CreateNew));
                writer.Write(decodePDF);

                string decodedString = Encoding.UTF8.GetString(decodePDF);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.ReadLine();
            }



        }


    }
}
