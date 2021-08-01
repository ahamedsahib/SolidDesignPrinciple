using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPrinciple.SingleResponsibilityPrinciple
{
    class Operation :IReport,IReportSaver,Exception
    {
        public List<string> list = new List<string>();
        public void AddEntry(string item) => list.Add(item);

        public void RemoveItem(string item) => list.Remove(item);

        public void SaveToFile(string path)
        {
            string str = string.Join(",", list.ToArray());

            File.WriteAllText(path, str);
        }
    }
}
