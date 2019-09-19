using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaseProgram
{
    class CText
    {
        public string RFile(string FilePath)
        {
            FileStream FileS = null;
            if (!File.Exists(FilePath))
            {
                FileS = File.Create(FilePath);
            }
            else
            {
                FileS = File.Open(FilePath, FileMode.Open);
            }
            string Result = "";
            using (StreamReader FileOut = new StreamReader(FileS))
            {
                while (FileOut.Peek() >= 0)
                {
                    Result = Result + "\n" + FileOut.ReadLine();
                }
            }
            return Result;
        }

        public void WFile(string FilePath, string HText)
        {
            FileStream FileS = null;
            if (!File.Exists(FilePath))
            {
                FileS = File.Create(FilePath);
            }
            else
            {
                FileS = File.Open(FilePath, FileMode.Append);
            }
            StreamWriter FileOut = new StreamWriter(FileS);
            FileOut.Write(HText);
            FileOut.Close();
        }

        public string WhenWriteFile(string FilePath)
        {
            FileInfo file = new FileInfo(FilePath);
            return file.LastWriteTime.Hour + ":" + file.LastWriteTime.Minute;
        }
    }
}
