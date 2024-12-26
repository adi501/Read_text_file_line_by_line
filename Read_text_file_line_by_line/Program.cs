using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_text_file_line_by_line
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = String.Empty;
            string location = @"E:\Test Projects\C#\Read_text_file_line_by_line\files\lines.txt";
            List<string> list = new List<string>();
            bool status = false;
            int index = 0;
            if (System.IO.File.Exists(location) == true)
            {
                using (StreamReader reader = new StreamReader(location))
                {
                    string line = String.Empty;
                    while ((line = reader.ReadLine()) != null) 
                    {
                        if (line.Contains("source=\""))
                        {
                             index = line.IndexOf("\"");
                            status = true;
                        }
                        if(status==true)
                        {
                            list.Add(line);
                            if (line.Contains("\"")&&(index!= line.IndexOf("\"")))
                            {
                                status = false;
                            }
                        }

                    }
                }
               
            }
            foreach(var a in list)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
