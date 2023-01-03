using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MVPSampleWPF.Models
{
    public class TestScript
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public string Browser { get; set; }
        //public Dictionary<int, string> TestSteps { get; set; }
        

        public void Save()
        {
            CheckFileExist();
            WriteToFile();
        }

        public void CheckFileExist()
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
            else
            {
                File.Create(FilePath).Close();
            }
        }

        public void WriteToFile()
        {
            XElement testElements = new XElement("test",
                new XElement("title", Title),
                new XElement("author", Author),
                new XElement("description", Description),
                new XElement("filePath", FilePath),
                new XElement("browser", Browser)
                );

            //List<XElement> testSteps = new List<XElement>();
            //foreach (var testStep in TestSteps)
            //{
            //    XElement step = new XElement("step",
            //        new XAttribute("id", testStep.Key.ToString()),
            //        new XElement("Action", testStep.Value));

            //    testSteps.Add(step);
            //}

            //testElements.Add(new XElement("Steps", testSteps));
           
            XDocument testXML = new XDocument(testElements);
            testXML.Save(FilePath);
        }
    }
}
