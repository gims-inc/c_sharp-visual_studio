using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace udclassFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            // string flstring = @"F:\createdBYCHARP\createdBYCHARP.txt";
            // string flstring2 = @"F:\soft\downloads";
            string flstring = @"C:\Users\gimsinc 0153\Desktop\New Text Document.txt";


            //string[] dirs = Directory.GetDirectories(flstring2,"*",SearchOption.AllDirectories);// directories
            //var files = Directory.GetFiles(flstring2,"*.*",SearchOption.TopDirectoryOnly);

            try
            {
                var lines = new List<string> ();
                lines = File.ReadAllLines(flstring).ToList();


                

                lines.Add(" created by gimsinc");
                File.WriteAllLines(flstring,lines);



                foreach (var line in lines)
                {
                    Console.WriteLine(line);
                }


                /*foreach(var dir in dirs)
                    Console.WriteLine(dir);*/
                //foreach (var file in files)
                //Console.WriteLine(fl); 
                // Console.WriteLine(Path.GetFileName(fl));
                //Console.WriteLine(Path.GetFileNameWithoutExtension(fl));



                /*var infor = new FileInfo(file);

                Console.WriteLine($"{Path.GetFileName(file)}: {infor.Length} bytes");*/



                // Console.WriteLine(String.Format("File name: {0} \n File path: {1} \n file size:{2} \n",Path.GetFileName(file),Path.GetFullPath(file), File.ReadAllBytes(file) ));


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            Console.ReadLine();
        }
    }
}
