using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XML_Database
{
    public partial class frmMain : Form
    {
        private List<Person> m_Person;
        private List<Pet> m_Pet;

        public enum GenderType
        {
            Male,
            Female
        }

        [Serializable]
        public class Pet
        {
            public string Name
            {
                get;
                set;
            }

            public string Type
            {
                get;
                set;
            }

            public int Age
            {
                get;
                set;
            }

            public bool Trained
            {
                get;
                set;
            }
        }

        [Serializable]
        public class Person
        {
            public Person()
            {
                Pets = new List<Pet>();
            }

            public int ID
            {
                get;
                set;
            }

            public string Name
            {
                get;
                set;
            }

            public string Family
            {
                get;
                set;
            }

            public bool Cool
            {
                get;
                set;
            }

            public GenderType Gender
            {
                get;
                set;
            }

            [XmlArray]
            public List<Pet> Pets
            {
                get;
                set;
            }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string sFileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\PersonsPetsDatabase.xml";

            InitializePersonForm();
            InitializePetForm();

            PreparePersonDataGridView();
            PreparePetDataGridView();

            if (File.Exists(sFileName))
            {
                m_Person = ReadFromXmlFile<List<Person>>(sFileName);
                FillPersonDataGridView();
            }
            else
            {
                m_Person = new List<Person>();
            }
        }

        private void PreparePersonDataGridView()
        {
            dgvPerson.Columns.Add("colName", "Name");
            dgvPerson.Columns.Add("colFamily", "Family");
            dgvPerson.Columns.Add("colGender", "Gender");
            dgvPerson.Columns.Add("colCool", "Cool");
            dgvPerson.Columns.Add("colID", "ID");
        }

        private void PreparePetDataGridView()
        {
            dgvPet.Columns.Add("colName", "Name");
            dgvPet.Columns.Add("colType", "Type");
            dgvPet.Columns.Add("colAge", "Age");
            dgvPet.Columns.Add("colTrained", "Trained");
            dgvPet.Columns.Add("colPersonID", "ID");
        }

        private void FillPersonDataGridView()
        {
            if (m_Person != null)
            {
                dgvPerson.Rows.Clear();

                for (int i = 0; i < m_Person.Count; i++)
                {
                    int n = dgvPerson.Rows.Add();

                    dgvPerson.Rows[n].Cells[0].Value = m_Person[i].Name;
                    dgvPerson.Rows[n].Cells[1].Value = m_Person[i].Family;
                    dgvPerson.Rows[n].Cells[2].Value = m_Person[i].Gender;
                    dgvPerson.Rows[n].Cells[3].Value = m_Person[i].Cool;
                    dgvPerson.Rows[n].Cells[4].Value = m_Person[i].ID;
                }
            }
        }

        private void FillPetDataGridView(int iIndex)
        {
            dgvPet.Rows.Clear();

            if (m_Person != null)
            {
                if (iIndex < m_Person.Count)
                {
                    if (m_Person[iIndex].Pets != null)
                    {
                        for (int i = 0; i < m_Person[iIndex].Pets.Count; i++)
                        {
                            int n = dgvPet.Rows.Add();

                            dgvPet.Rows[n].Cells[0].Value = m_Person[iIndex].Pets[i].Name;
                            dgvPet.Rows[n].Cells[1].Value = m_Person[iIndex].Pets[i].Type;
                            dgvPet.Rows[n].Cells[2].Value = m_Person[iIndex].Pets[i].Age;
                            dgvPet.Rows[n].Cells[3].Value = m_Person[iIndex].Pets[i].Trained;
                        } 
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person newPerson = new XML_Database.frmMain.Person();

            newPerson.ID = GetNewID();
            newPerson.Cool = chkCool.Checked;
            newPerson.Name = txtName.Text;
            newPerson.Family = txtFamily.Text;
            newPerson.Gender = (rbMale.Checked) ? GenderType.Male : GenderType.Female;

            if (m_Pet != null)
            {
                newPerson.Pets = m_Pet;
            }

            m_Person.Add(newPerson);

            InitializePersonForm();
            InitializePetForm();

            m_Pet = null;
        }

        private int GetNewID()
        {
            int iMaxID = 0;

            if (m_Person == null)
            {
                return 1;
            }

            for (int i = 0; i < m_Person.Count; i++)
            {
                iMaxID = (m_Person[i].ID > iMaxID) ? m_Person[i].ID : iMaxID;
            }

            return (iMaxID + 1);
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            m_Pet = new List<Pet>();
        }

        private void btnAddThePet_Click(object sender, EventArgs e)
        {
            Pet newPet = new Pet();

            newPet.Trained = chkCool.Checked;
            newPet.Name = txtPetName.Text;
            newPet.Type = txtPetType.Text;
            newPet.Age = (int)nudAge.Value;

            m_Pet.Add(newPet);

            InitializePetForm();
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            string sResult = "";

            string sFileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\PersonsPetsDatabase.xml";
            if (!WriteToXmlFile(sFileName, m_Person))
            {
                sResult = "Failed To Write Persons And Pets To XML Database";
            }

            if (!string.IsNullOrEmpty(sResult))
            {
                MessageBox.Show(sResult);
            }
        }

        private void dgvPerson_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTestInfo;

            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    if ((dgvPerson.SelectedRows.Count == 1) &&
                        (dgvPerson.Rows[0].Cells[4].Value != null))
                    {
                        hitTestInfo = dgvPerson.HitTest(e.X, e.Y);

                        if (hitTestInfo.Type == DataGridViewHitTestType.RowHeader)
                        {
                            int iCurrentPersonId = int.Parse(dgvPerson.SelectedRows[0].Cells[4].Value.ToString());
                            FillPetDataGridView(iCurrentPersonId);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void InitializePersonForm()
        {
            chkCool.Checked = false;
            txtName.Text = "";
            txtFamily.Text = "";
            rbMale.Checked = true;
        }

        private void InitializePetForm()
        {
            txtPetName.Text = "";
            txtPetType.Text = "";
            nudAge.Value = 0;
            chkTrained.Checked = false; 
        }

        public static bool WriteToXmlFile<T>(string sFilePath, T objectToWrite, bool bAppend = false) where T : new()
        {
            TextWriter twTextWriter = null;

            try
            {
                var vSerializer = new XmlSerializer(typeof(T));
                twTextWriter = new StreamWriter(sFilePath, bAppend);
                vSerializer.Serialize(twTextWriter, objectToWrite);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return false;
            }
            finally
            {
                if (twTextWriter != null)
                {
                    twTextWriter.Close();
                }
            }
        }

        public static T ReadFromXmlFile<T>(string sFilePath) where T : new()
        {
            TextReader trTextReader = null;

            try
            {
                var vSerializer = new XmlSerializer(typeof(T));
                trTextReader = new StreamReader(sFilePath);

                return (T)vSerializer.Deserialize(trTextReader);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

                return default(T);
            }
            finally
            {
                if (trTextReader != null)
                {
                    trTextReader.Close();
                }
            }
        }        
    }
}
