using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace familydirectory {
    public partial class Form1 : Form {
        string dataFileName = "";
        public string familyName = "";
        public string familyCellPhone = "";
        public string familyAddress = "";
        public string familyAppel = "";
        public int id = 1;
        public bool input = false;
        public Form1() {
            InitializeComponent();

        }

        private void InsertBtn_Click(object sender, EventArgs e) {
            input = true;
            Form2 frm2 = new Form2();
            frm2.Owner = this;
            frm2.ShowDialog();
            ds.familyDirectoryRow dr = ds.familyDirectory.NewfamilyDirectoryRow();
            dr["Id"] = id + 1;
            dr["Name"] = familyName;
            dr["cellphone"] = familyCellPhone;
            dr["appellation"] = familyAppel;
            dr["address"] = familyAddress;
            ds.familyDirectory.Rows.Add(dr);
            WriteXml(dr);
            input = false;
            Thread.Sleep(1000);
            if (File.Exists(this.dataFileName)) {
                ds1.familyDirectory.ReadXml(this.dataFileName);
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e) {
            input = false;
            int iRow = bindingSource1.Position;
            bindingSource1.RemoveAt(iRow);
            //ds.familyDirectoryRow dr = ds.familyDirectory.NewfamilyDirectoryRow();
            ds1.WriteXml(dataFileName);
            // WriteXml(dr);
            Thread.Sleep(100);
            if (File.Exists(this.dataFileName)) {
                ds1.familyDirectory.ReadXml(this.dataFileName);
                
            }
        }

        private void WriteXml(ds.familyDirectoryRow dr) {
            

            ds.familyDirectory.WriteXml(this.dataFileName);
        }

        private void UpdateBtn_Click(object sender, EventArgs e) {
            input = false;
            int iRow = bindingSource1.Position;
            ds.familyDirectoryRow dr = ds.familyDirectory[iRow];
            id = dr.Id;
            Form2 frm2 = new Form2();
            frm2.Owner = this;
            frm2.familyName = dr.Name;
            frm2.familyCellPhone = dr.cellphone;
            frm2.familyAppel=dr.appellation;
            frm2.familyAddress= dr.address;
            frm2.ShowDialog();

            dr["Name"] = familyName;
            dr["cellphone"] = familyCellPhone;
            dr["appellation"] = familyAppel;
            dr["address"] = familyAddress;
            XmlWriteMode WriteSchema = default(XmlWriteMode);
            // ds.wr
            ds1.WriteXml(dataFileName,WriteSchema);
            ds1.WriteXml(dr["cellphone"] true);
            ds1.WriteXml(dr["Name"], dr["cellphone"], dr["appellation"], dr["address"], true);
            //dataFileName


            ds1.ReadXml(this.dataFileName);

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            this.dataFileName = Application.ExecutablePath.Replace("familydirectory.exe", "familydirectory.xml");
            if (File.Exists(this.dataFileName)) {
                ds1.ReadXml(this.dataFileName);
            }
            if (ds.familyDirectory.Rows.Count > 0) { 
            ds.familyDirectoryRow dr = ds.familyDirectory
                [ds.familyDirectory.Rows.Count];
            id = (int)dr["Id"]+1;
            } else { id = 0; }
        }
    }
    }
