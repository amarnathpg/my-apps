using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assignmentex3
{
    class Tester
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the path for your directory(use back slash to enter your path)");
            string s = Console.ReadLine();
            //crating an instance of directory info class
            DirectoryInfo MydirInfo = new DirectoryInfo(s);
            
            //checks whether the path is correct or not
            if (MydirInfo.Exists == false)
            {

                Console.WriteLine("Enter the correct path");
                Console.ReadLine();
                Environment.Exit(0);
                //exit
            }

            /*get all the files in the directory and print their name and size*/
            DirectoryInfo[] DirInDir = MydirInfo.GetDirectories();
            foreach (DirectoryInfo dir in DirInDir)
            {
                Console.WriteLine("Dir Name:{0} \t \t Creation Time:{1}", dir.Name, dir.CreationTime);
            }

            FileInfo[] FileInDir = MydirInfo.GetFiles();
            foreach (FileInfo file in FileInDir)
            {
                Console.WriteLine("File Name:{0} \t \t size:{1} bytes \t \t creation time:{2}", file.Name, file.Length,file.CreationTime);
            }
            Console.ReadLine();
        }
    }
}
