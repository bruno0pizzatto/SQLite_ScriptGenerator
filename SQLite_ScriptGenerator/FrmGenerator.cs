using SQLite_ScriptGenerator.DAL;
using SQLite_ScriptGenerator.MOL;
using SQLite_ScriptGenerator.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLite_ScriptGenerator
{
    public partial class FrmGenerator : Form
    {
        IniXml iniXml = new IniXml();

        public FrmGenerator()
        {
            InitializeComponent();                    
        }

        private void FrmGenerator_Load(object sender, EventArgs e)
        {
            txtDbPath.Text = iniXml.strDataBasePath;
            txtPath.Text = iniXml.strDestinationPath;
            chkTable.Checked = iniXml.boTable;
            chkView.Checked = iniXml.boView;
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtPath.Text))
                folderBrowser.SelectedPath = txtPath.Text;

            folderBrowser.ShowDialog();

            txtPath.Text = folderBrowser.SelectedPath;
        }

        private void btnSelectDbPath_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtDbPath.Text))
                openFile.FileName = txtDbPath.Text;

            openFile.ShowDialog();

            txtDbPath.Text = openFile.FileName;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {             
            if (!Directory.Exists(txtPath.Text))
                MessageBox.Show("Pasta de destino inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (!File.Exists(txtDbPath.Text))
                MessageBox.Show("Escolha uma base de dados","Erro",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (!chkTable.Checked && !chkView.Checked)
                MessageBox.Show("Escolha pelo menos um item", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                iniXml.strDataBasePath = txtDbPath.Text;
                iniXml.strDestinationPath = txtPath.Text;
                iniXml.boTable = chkTable.Checked;
                iniXml.boView = chkView.Checked;
                iniXml.save();

                if (chkTable.Checked)
                    generateFiles(object_types.table);
                if(chkView.Checked)
                    generateFiles(object_types.view);

                MessageBox.Show("Arquivos Gerados!", "Sucesso", MessageBoxButtons.OK);
            }
        }

        private void generateFiles(object_types oType)
        {
            SysObjects_DAL dal = new SysObjects_DAL(@"data source=" + txtDbPath.Text);

            List<SysObjects_MOL> list = dal.select(oType);
            StreamWriter file = null;

            foreach (SysObjects_MOL item in list)
            {
                //int iPos = item.strSchema.ToUpper().IndexOf("\r\nCREATE ");
                //if (iPos > 0)
                //    item.strDefinition = item.strSchema.Substring(0, iPos) + "\r\nALTER " + item.strSchema.Substring(iPos + 8, item.strSchema.Length - iPos - 8);

                string strFullPath = txtPath.Text + "\\" + (oType == object_types.table ? "Tables" : "Views"); 
                string strFileName = strFullPath + "\\" + item.strName + ".sql";

                if (!Directory.Exists(strFullPath))
                    Directory.CreateDirectory(strFullPath);

                file = File.CreateText(strFileName);
                file.Write(item.strSchema);

                file.Flush();
                file.Close();
            }
        }
    }
}
