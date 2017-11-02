using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace SQLite_ScriptGenerator.Tools
{
    public class IniXml
    {
        string _strDestinationPath;
        string _strDataBasePath;
        bool _boTable;
        bool _boView;

        public string strDestinationPath { get { return _strDestinationPath; } set { _strDestinationPath = value; } }
        public string strDataBasePath { get { return _strDataBasePath; } set { _strDataBasePath = value; } }
        public bool boTable { get { return _boTable; } set { _boTable = value; } }
        public bool boView { get { return _boView; } set { _boView = value; } }

        public IniXml() : this(".\\ini.xml") { }

        public IniXml(string strFileName)
        {
            if (File.Exists(strFileName))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(strFileName);

                XmlElement ini = doc["ini"];
                if (ini != null)
                {
                    XmlElement options = ini["options"];

                    if (options != null)
                    {
                        XmlElement path = options["path"];
                        if (path != null)
                            _strDestinationPath = path.InnerText;
                        XmlElement database = options["database"];
                        if (database != null)
                            _strDataBasePath = database.InnerText;
                        XmlElement table = options["table"];
                        if (table != null)
                            _boTable = Convert.ToBoolean(string.IsNullOrEmpty(table.InnerText) ? "False" : "True");
                        XmlElement view = options["view"];
                        if (view != null)
                            _boView = Convert.ToBoolean(string.IsNullOrEmpty(view.InnerText) ? "False" : "True");     
                    }                  
                }
            }
        }      

        public void save()
        {
            XmlDocument doc = new XmlDocument();

            XmlElement ini = doc.CreateElement("ini");            
            XmlElement options = doc.CreateElement("options");

            doc.AppendChild(ini);            
            ini.AppendChild(options);

            XmlElement path = doc.CreateElement("path");
            path.InnerText = strDestinationPath;
            XmlElement database = doc.CreateElement("database");
            database.InnerText = strDataBasePath;
            XmlElement table = doc.CreateElement("table");
            table.InnerText = boTable.ToString();
            XmlElement view = doc.CreateElement("view");
            view.InnerText = boView.ToString();

            options.AppendChild(path);
            options.AppendChild(database);
            options.AppendChild(table);
            options.AppendChild(view);                       

            doc.Save(".\\ini.xml");
        }

        public static IniXml iniXml = null;

        public static void loadIniXml(string strFileName)
        {
            iniXml = new IniXml(strFileName);
        }
    }
}
