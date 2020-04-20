using System;
using System.Collections;
using System.IO;

namespace ReadCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader(@"C:\Users\joyar\Documents\GitHub\puzzles\csv-sample.csv");
            string strBlock = file.ReadToEnd();

            string[] rows = strBlock.Split(",");
            Hashtable tbl = ReadLine(rows);
            Console.WriteLine("Total rows in the file = " + tbl.Count.ToString());
            file.Close();
            Console.ReadLine();
        }

        static Hashtable ReadLine(string[] strArray)
        {
            Hashtable tbl = new Hashtable();
            strArray[strArray.Length - 1] = strArray[strArray.Length - 1] + "\r\n";
            int line = 1;
            string tempStr = "";
            string tempStrNext = "";
            for (int i=0; i<strArray.Length; i++)
            {
                if (strArray[i].StartsWith('"') && strArray[i].EndsWith('"') && (strArray[i].Contains('\n') || strArray[i].Contains(',')))
                {
                    tempStr += strArray[i].Replace('\n', ' ');
                }
                else if (strArray[i].Contains('\n'))
                {
                    string[] newVal = strArray[i].Split('\n');
                    tempStr += newVal[0];
                    tempStrNext = newVal[1];
                    tbl.Add(line, tempStr);
                    line++;
                    tempStr = tempStrNext;
                }
                else
                {
                    tempStr += strArray[i];
                }
 
            }
            return tbl;
        }
    }
}
