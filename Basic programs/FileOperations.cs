using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{
    internal class FileOperations
    { public void CreateFile()
        {
            FileInfo file = new
                FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            using StreamWriter str = file.CreateText();
            Console.WriteLine("File has been created");
            str.WriteLine("Hello there");
            str.WriteLine("HI");
            Console.WriteLine("Written");
        } 
        public void WriteData()
        {
            FileStream fss = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Sample1.txt", FileMode.Create, FileAccess.Write);
            StreamWriter stw=new StreamWriter(fss);
            Console.WriteLine("Enter the text which" + "you want to write to the file");
            string? str=Console.ReadLine();
            stw.WriteLine(str);
            stw.Flush();
            stw.Close();
            fss.Close();
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr=new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str=sr.ReadLine(); 
            while(str!=null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
        public void CopyMoveFile()

        {
            FileInfo fili = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample.txt");
            FileInfo fili2 = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\Sample1.txt");
            fili.CopyTo("C:\\Users\\Administrator\\Desktop\\Files\\temp1\\Sample.txt");
            fili2.MoveTo("C:\\Users\\Administrator\\Desktop\\Files\\temp2\\Sample1.txt");


        }
        public void DeleteFile()
        {FileInfo fili = new 
            FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\temp1\\Sample.txt");
            fili.Delete();
        }
        public void FileProperties()
        {
            FileInfo fi = new FileInfo("C:\\Users\\Administrator\\Desktop\\Files\\" + "Sample.txt");
            Console.WriteLine(fi.FullName);
        Console.WriteLine(fi.CreationTime);
            Console.WriteLine(fi.Extension);    
            Console.WriteLine(fi.LastAccessTime);
            Console.WriteLine(fi.Length.ToString());
            Console.WriteLine(fi.Exists);
            Console.WriteLine(fi.LastWriteTime);


        }
    }
}
