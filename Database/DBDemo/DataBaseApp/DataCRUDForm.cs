using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;

namespace DataBaseApp
{
    public partial class DataCRUDForm : Form
    {
        EmpDataStore dataStore = new EmpDataStore(@"server=(localdb)\MSSQLLocalDB;database=Training;Integrated Security=True");
        public DataCRUDForm()
        {
            InitializeComponent();
        }

        private void DataCRUDForm_Load(object sender, EventArgs e)
        {
            dgData.DataSource = dataStore.GetEmps();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtEmpNo.Clear();
            txtEmpName.Clear();
            txtHireDate.Clear();
            txtSalary.Clear();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                Emp newEmp = new Emp();
                newEmp.EmpNo = int.Parse(txtEmpNo.Text);
                newEmp.EmpName = txtEmpName.Text;
                newEmp.HireDate = Convert.ToDateTime(txtHireDate.Text);
                newEmp.Salary = decimal.Parse(txtSalary.Text);

                int count = dataStore.AddEmp(newEmp);

                if(count==1)
                {
                    MessageBox.Show("Record inserted");
                    dgData.DataSource=dataStore.GetEmps();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int count = dataStore.RemoveEmp(int.Parse(txtEmpNo.Text));

                if (count == 1)
                {
                    MessageBox.Show("Record removed");
                    dgData.DataSource = dataStore.GetEmps();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Emp newEmp = new Emp();
                newEmp.EmpNo = int.Parse(txtEmpNo.Text);
                newEmp.EmpName = txtEmpName.Text;
                newEmp.HireDate = Convert.ToDateTime(txtHireDate.Text);
                newEmp.Salary = decimal.Parse(txtSalary.Text);

                int count = dataStore.EditEmp(newEmp);

                if (count == 1)
                {
                    MessageBox.Show("Record updated");
                    dgData.DataSource = dataStore.GetEmps();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtEmpNo.Text == string.Empty)
            {
                return;
            }

            try
            {
                int empno = int.Parse(txtEmpNo.Text);
                Emp emp = dataStore.GetEmpByNo(empno);
               

                if (emp!=null)
                {
                    txtEmpName.Text = emp.EmpName;
                    txtHireDate.Text = emp.HireDate.ToString();
                    txtSalary.Text = emp.Salary.ToString();
                    
                }
                else
                {
                    MessageBox.Show($"Employee by no{empno} not found");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
