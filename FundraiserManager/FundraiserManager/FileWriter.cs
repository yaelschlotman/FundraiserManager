using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FundraiserManager
{
    public class FileWriter
    {
        public void WriteRecordToFile(string FileName, string RecordName)
        {
            File.WriteAllText(FileName, RecordName);
        }

        public void AddRecordToFile(string FileName, string RecordToAdd)
        {
            File.AppendAllText(FileName, RecordToAdd);
        }




    }
}
