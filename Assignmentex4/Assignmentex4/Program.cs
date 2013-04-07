using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Assignmentex4
{
    class Tester
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the path for your directory like D:\\tv shows\\");
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

            //creating a file information viewer application for storing details of the stock details
           
            FileStream fileinfo1= new FileStream(MydirInfo + "stock details.txt", FileMode.Append, FileAccess.Write);

            
            //creating file stream writer object for entering the detils
            BinaryWriter sw = new BinaryWriter(fileinfo1);
          

            //promoting user to enter the details of the stock
            int i, j;
            for (i = 1,j=2; i < j; i++)
            {
                Console.WriteLine("Enter the " + i + "st stock Details");

                sw.Write("stock details of " + i + " transaction\t");
                
                Console.WriteLine("Enter the Packing Slip");
                Console.WriteLine("This field specifies the packing slip number");
                string ps = Console.ReadLine();
                sw.Write(ps+"\t");

                Console.WriteLine("Enter the Part Number");
                Console.WriteLine("This field specifies the part number of the received item.");
                string pn = Console.ReadLine();
                sw.Write(pn+"\t");

                Console.WriteLine("Enter the Part Description");
                Console.WriteLine("This field specifies the part associated with this transaction.");
                string pd = Console.ReadLine();
                sw.Write(pd+"\t\n");
                
                //line brack for every transaction
                
                Console.WriteLine("\n");

                Console.WriteLine("press 1 to exit from the stock details");
                Console.WriteLine("press 2 to continue to enter the stock details");
                int ch=Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                    Environment.Exit(0);
                else
                    j++;
                    continue;
            }
            //clear all buffer of the current writer
            sw.Flush();

            //close the stream writer object
            sw.Close();

            //close the filestream object
            fileinfo1.Close();
            

            
        }
    }
}
