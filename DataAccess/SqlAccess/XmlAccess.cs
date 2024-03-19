using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.SqlAccess
{
    public class XmlAccess : IXmlAccess
    {
        private readonly string fileName = "Connectionstring.xml";


        public XmlAccess()
        {
            CreateXmlFileIfNotExists("Data Source=APHIWAT;Initial Catalog=MainStoreDataBaseManagement;Integrated Security=True;Connect Timeout=60;Encrypt=False");

        }

        public void CreateXmlFileIfNotExists(string connectionString)
        {
            // Get the directory of the currently running executable
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the directory path with the filename to get the full path
            string filePath = Path.Combine(directoryPath, fileName);

            // Check if the file already exists
            if (!File.Exists(filePath))
            {
                // Create the XML structure
                XElement connectToDbElement = new XElement("ConnectToDb",
                    new XElement("Connectionstring", connectionString));

                // Save the XML to the specified file path
                connectToDbElement.Save(filePath);
                Console.WriteLine("XML file created successfully in the application directory.");
            }
            else
            {
                Console.WriteLine("File already exists in the application directory. No new file was created.");
            }
        }
        public string ReadConnectionString()
        {
            // Get the directory of the currently running executable
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the directory path with the filename to get the full path
            string filePath = Path.Combine(directoryPath, fileName);

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Load the XML document
                XDocument doc = XDocument.Load(filePath);

                // Extract and return the connection string
                XElement connectionStringElement = doc.Element("ConnectToDb")?.Element("Connectionstring");
                if (connectionStringElement != null)
                {
                    return connectionStringElement.Value;
                }
                else
                {
                    //  Console.WriteLine("Connection string element not found.");
                    return string.Empty;
                }
            }
            else
            {
                //Console.WriteLine("XML file does not exist.");
                return string.Empty;
            }
        }
    }
}

