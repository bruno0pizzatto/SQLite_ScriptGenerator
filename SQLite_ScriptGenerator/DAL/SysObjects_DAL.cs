using SQLite_ScriptGenerator.MOL;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_ScriptGenerator.DAL
{
    public enum object_types { table = 0, view }

    public class SysObjects_DAL
    {               
        private SQLiteConnection conn;
        private string[] object_types_desc = { "table", "view" };

        public SysObjects_DAL(string path)
        {
            this.conn = new SQLiteConnection(path);
        }

        public List<SysObjects_MOL> select(object_types oType)
        {
            List<SysObjects_MOL> list = new List<SysObjects_MOL>();

            SQLiteCommand comm = new SQLiteCommand("SELECT name, sql FROM sqlite_master WHERE type = '"+ object_types_desc[(int)oType] +"'", conn);
            this.conn.Open();

            
            // Populate the reader
            SQLiteDataReader reader = comm.ExecuteReader();

            // Step through each row
            while (reader.Read())
            {
                SysObjects_MOL data = getData(reader);
                if (data != null)
                    list.Add(data);
            }

            this.conn.Close();

            return list;
        }

        SysObjects_MOL getData(SQLiteDataReader reader)
        {
            SysObjects_MOL item = new SysObjects_MOL();

            for (int iIdx = 0; iIdx < reader.FieldCount; iIdx++)
            {
                if(!reader.IsDBNull(iIdx))
                {
                    switch(reader.GetName(iIdx))
                    {
                        case "name":
                            item.strName = reader[iIdx].ToString();
                            break;
                        case "sql":
                            item.strSchema = reader[iIdx].ToString();
                            break;
                    }
                }
            }

            return item;
        }
    }
}
