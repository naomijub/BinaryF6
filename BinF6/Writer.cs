using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinF6
{
    public class Writer
    {
        public StreamWriter writer { get; set; }

        public Writer() {
            string folderPath = @"C:\BinaryF6Data";
            string fileName = "BinaryF6_" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "__" +
                DateTime.Now.Hour + "-" + DateTime.Now.Minute;

            try { 
                if (!Directory.Exists(folderPath)) {
                    System.IO.Directory.CreateDirectory(folderPath);
                }

                StreamWriter writerOpener = new StreamWriter("C:\\BinaryF6Data\\" + fileName + ".txt", true);
                writerOpener.WriteLine(" ");
                writerOpener.WriteLine(fileName);
                writerOpener.Close();
            }catch (IOException e) {
                Console.WriteLine(e.InnerException);
                Console.WriteLine();
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
            }


            try
            {
                writer = new StreamWriter(@"C:\BinaryF6Data\" + fileName + ".txt", true);
            }
            catch (IOException e) {
                Console.WriteLine(e.InnerException);
                Console.WriteLine();
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
            }
        }

        public void close() {
            writer.Close();
        }

    }
}
