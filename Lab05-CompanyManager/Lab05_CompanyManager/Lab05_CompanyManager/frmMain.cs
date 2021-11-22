using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Lab05_CompanyManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Database database = new Database(); // Khởi tạo database
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            database.CreateDatabase(); // Mở database

            // Clear dataGridView
            dataGridView_Employee.Rows.Clear();
            dataGridView_Dependent.Rows.Clear();
            dataGridView_DependentOf.Rows.Clear();
            dataGridView_Project.Rows.Clear();
            dataGridView_ControlledBy.Rows.Clear();
            dataGridView_Department.Rows.Clear();
            dataGridView_Manager.Rows.Clear();
            dataGridView_WorksOn.Rows.Clear();
            dataGridView_EmployeeWorksOn.Rows.Clear();
            dataGridView_ProjectWorksOn.Rows.Clear();
            dataGridView_CauTruyVan1.Rows.Clear();
            dataGridView_CauTruyVan2.Rows.Clear();
            dataGridView_CauTruyVan3.Rows.Clear();
            dataGridView_CauTruyVan4.Rows.Clear();
            dataGridView_EmployeeWorksFor.Rows.Clear();
            dataGridView_DepartmentWorksFor.Rows.Clear();
            dataGridView_EmployeesWorksFor.Rows.Clear();
            dataGridView_SupervisorSupervisor.Rows.Clear();
            dataGridView_SuperviseesSupervisor.Rows.Clear();
            dataGridView_EmployeeSupervisor.Rows.Clear();

            // tab_Employee
            textBox_SsnEmployee.ReadOnly = false;
            textBox_SsnEmployee.Clear();
            textBox_FNameEmployee.Clear();
            textBox_LNameEmployee.Clear();
            comboBox_GenderEmployee.Text = "";
            comboBox_GenderEmployee.Items.Clear();
            comboBox_GenderEmployee.Items.Add("M");
            comboBox_GenderEmployee.Items.Add("F");
            textBox_MInitEmployee.Clear();
            textBox_BirthDateEmployee.Clear();
            textBox_AddressEmployee.Clear();
            textBox_SalaryEmployee.Clear();

            // tab_Dependent
            textBox_NameDependent.Clear();
            comboBox_GenderDependent.Text = "";
            comboBox_GenderDependent.Items.Clear();
            comboBox_GenderDependent.Items.Add("M");
            comboBox_GenderDependent.Items.Add("F");
            textBox_BirthDateDependent.Clear();
            comboBox_RelationshipDependent.Items.Clear();
            string[] relationships =
            {
                "Father",
                "Mother",
                "Son",
                "Daughter",
                "Husband",
                "Wife",
                "Brother",
                "Sister",
                "Uncle",
                "Aunt"
            };
            comboBox_RelationshipDependent.Items.AddRange(relationships);
            comboBox_RelationshipDependent.Text = "";
            textBox_SsnDependentOf.Clear();
            textBox_SsnDependentOfOld.Clear();
            textBox_NameDependentOf.Clear();
            textBox_NameDependentOld.Clear();
            textBox_GenderDependentOld.Clear();
            textBox_BirthDateDependentOld.Clear();
            textBox_RelationshipDependentOld.Clear();

            // tab_Project
            textBox_NumberProject.ReadOnly = false;
            textBox_NumberProject.Clear();
            textBox_NameProject.Clear();
            comboBox_LocationProject.Items.Clear();
            comboBox_LocationProject.Text = "";
            textBox_NumberControlledBy.Clear();
            textBox_NameControlledBy.Clear();
            textBox_NumberControlledByOld.Clear();

            // tab_Department
            textBox_NumberDepartment.ReadOnly = false;
            textBox_NumberDepartment.Clear();
            textBox_NameDepartment.Clear();
            textBox_LocationsDepartment.Clear();
            textBox_SsnManager.Clear();
            textBox_NameManager.Clear();
            textBox_SsnManagerOld.Clear();
            textBox_MgrStartDate.Clear();

            // tab WorksOn
            textBox_HoursWorksOn.Clear();
            textBox_SsnEmployeeWorksOn.Clear();
            textBox_SsnEmployeeWorksOnOld.Clear();
            textBox_NameEmployeeWorksOn.Clear();
            textBox_NumberProjectWorksOn.Clear();
            textBox_NumberProjectWorksOnOld.Clear();
            textBox_NameProjectWorksOn.Clear();

            // tab WorksFor
            textBox_NumberDepartmentWorksFor.Clear();

            // tab Supervisor
            textBox_SsnSupervisorSupervisor.Clear();

            // Khởi tạo biến list để lưu dữ liệu Employee
            List<Employee> list_Employee = new List<Employee>();
            // Khởi tạo biến list để lưu dữ liệu Dependent
            List<Dependent> list_Dependent = new List<Dependent>();
            // Khởi tạo biến list để lưu dữ liệu Project
            List<Project> list_Project = new List<Project>();
            // Khởi tạo biến list để lưu dữ liệu Department
            List<Department> list_Department = new List<Department>();
            // Khởi tạo biến list để lưu dữ liệu WorksOn
            List<WorksOn> list_WorksOn = new List<WorksOn>();

            IObjectSet result = null;

            // Lấy dữ liệu Employee từ database
            result = database.result_Employee();
            // Đưa từng dữ liệu Employee vào trong list_Employee
            for (int i = 0; i < result.Count; ++i)
            {
                Employee employee = (Employee)result[i];
                list_Employee.Add(employee);
            }

            // Lấy dữ liệu Dependent từ database
            result = database.result_Dependent();
            // Đưa từng dữ liệu Dependent vào trong list_Dependent
            for (int i = 0; i < result.Count; ++i)
            {
                Dependent dependent = (Dependent)result[i];
                list_Dependent.Add(dependent);
            }

            // Lấy dữ liệu Project từ database
            result = database.result_Project();
            // Đưa từng dữ liệu Project vào trong list_Project
            for (int i = 0; i < result.Count; ++i)
            {
                Project project = (Project)result[i];
                list_Project.Add(project);
            }

            // Lấy dữ liệu Department từ database
            result = database.result_Department();
            // Đưa từng dữ liệu Department vào trong list_Department
            for (int i = 0; i < result.Count; ++i)
            {
                Department department = (Department)result[i];
                list_Department.Add(department);
            }

            // Lấy dữ liệu WorksOn từ database
            result = database.result_WorksOn();
            // Đưa từng dữ liệu WorksOn vào trong list_WorksOn
            for (int i = 0; i < result.Count; ++i)
            {
                WorksOn worksOn = (WorksOn)result[i];
                list_WorksOn.Add(worksOn);
            }

            // Đưa dữ liệu vào dataGridView
            for(int i = 0; i < list_Employee.Count; ++i)
            {
                Employee e = list_Employee[i];
                string ssn = e.Ssn.ToString();
                string fname = e.FName;
                string lname = e.LName;
                string gender = e.Gender;
                string minit = e.MInit;
                string address = e.Address;
                string birthdate = e.BirthDate;
                string salary = e.Salary.ToString();
                string worksfor = (e.WorksFor == null) ? null : e.WorksFor.DName;
                string manager = (e.Manager == null) ? null : e.Manager.DName;
                string workson = null;
                if(e.WorksOn != null && e.WorksOn.Count != 0)
                {
                    for(int j = 0; j < e.WorksOn.Count; ++j)
                    {
                        if (j == 0) workson = e.WorksOn[j].Project.PName;
                        else workson += ", " + e.WorksOn[j].Project.PName;
                    }
                    
                }
                string dependent = null;
                if(e.Dependents != null && e.Dependents.Count != 0)
                {
                    for (int j = 0; j < e.Dependents.Count; ++j)
                    {
                        if (j == 0) dependent = e.Dependents[j].Name;
                        else dependent += ", " + e.Dependents[j].Name;
                    }
                }
                string supervisor = (e.Supervisor == null) ? null : e.Supervisor.FName + " " + e.Supervisor.LName;
                string supervisees = null;
                if(e.Supervisees != null && e.Supervisees.Count != 0)
                {
                    for (int j = 0; j < e.Supervisees.Count; ++j)
                    {
                        if (j == 0) supervisees = e.Supervisees[j].FName + " " + e.Supervisees[j].LName;
                        else supervisees += ", " + e.Supervisees[j].FName + " " + e.Supervisees[j].LName;
                    }
                }
                dataGridView_Employee.Rows.Add(ssn, fname, lname, gender, minit, address, birthdate, salary, worksfor, manager, workson, dependent, supervisor, supervisees);
                dataGridView_EmployeeWorksFor.Rows.Add(ssn, fname, lname);
            }
            for(int i = 0; i < list_Dependent.Count; ++i)
            {
                Dependent d = (Dependent)list_Dependent[i];
                string name = d.Name;
                string gender = d.Gender;
                string birthdate = d.BirthDate;
                string relationship = d.Relationship;
                string dependentof = d.DependentOf.FName + " " + d.DependentOf.LName;

                dataGridView_Dependent.Rows.Add(name, gender, birthdate, relationship, dependentof);
            }
            for(int i = 0; i < list_Project.Count; ++i)
            {
                Project p = (Project)list_Project[i];
                string number = p.PNumber.ToString();
                string name = p.PName;
                string location = p.Location;
                string controlledby = p.ControlledBy.DName;
                string workson = null;
                if(p.WorksOn != null && p.WorksOn.Count != 0)
                {
                    for (int j = 0; j < p.WorksOn.Count; ++j)
                    {
                        if (j == 0) workson = p.WorksOn[j].Employee.FName + " " + p.WorksOn[j].Employee.LName;
                        else workson += ", " + p.WorksOn[j].Employee.FName + " " + p.WorksOn[j].Employee.LName;
                    }
                }

                dataGridView_Project.Rows.Add(number, name, location, controlledby, workson);
                dataGridView_ProjectWorksOn.Rows.Add(number, name);
            }
            for(int i = 0; i < list_Department.Count; ++i)
            {
                Department d = (Department)list_Department[i];
                string number = d.DNumber.ToString();
                string name = d.DName;
                string locations = null;
                for(int j = 0; j < d.Locations.Count; ++j)
                {
                    if (j == 0) locations = d.Locations[j];
                    else locations += ", " + d.Locations[j];
                }
                string employees = null;
                if(d.Employees != null && d.Employees.Count != 0)
                {
                    for(int j = 0; j < d.Employees.Count; ++j)
                    {
                        if (j == 0) employees = d.Employees[j].FName + " " + d.Employees[j].LName;
                        else employees += ", " + d.Employees[j].FName + " " + d.Employees[j].LName;
                    }
                }
                string manager = (d.Manager == null) ? null : d.Manager.FName + " " + d.Manager.LName;
                string projects = null;
                if(d.Projects != null && d.Projects.Count != 0)
                {
                    for(int j = 0; j < d.Projects.Count; ++j)
                    {
                        if (j == 0) projects = d.Projects[j].PName;
                        else projects += ", " + d.Projects[j].PName;
                    }
                }
                string mgrstartdate = (d.MgrStartDate == null) ? null : d.MgrStartDate;

                dataGridView_Department.Rows.Add(number, name, locations, employees, manager, projects, mgrstartdate);
                dataGridView_DepartmentWorksFor.Rows.Add(number, name);
            }
            for(int i = 0; i < list_WorksOn.Count; ++i)
            {
                dataGridView_WorksOn.Rows.Add(list_WorksOn[i].Hours.ToString(), list_WorksOn[i].Employee.FName + " " + list_WorksOn[i].Employee.LName, list_WorksOn[i].Project.PName);
            }
            for(int i = 0; i < list_Employee.Count; ++i)
            {
                Employee e = (Employee)list_Employee[i];
                string ssn = e.Ssn.ToString();
                string fname = e.FName;
                string lname = e.LName;

                dataGridView_DependentOf.Rows.Add(ssn, fname, lname);
                dataGridView_Manager.Rows.Add(ssn, fname, lname);
                dataGridView_EmployeeWorksOn.Rows.Add(ssn, fname, lname);
                dataGridView_EmployeeSupervisor.Rows.Add(ssn, fname, lname);
                dataGridView_SupervisorSupervisor.Rows.Add(ssn, fname, lname);
            }
            for(int i = 0; i < list_Department.Count; ++i)
            {
                Department d = (Department)list_Department[i];
                string number = d.DNumber.ToString();
                string name = d.DName;

                dataGridView_ControlledBy.Rows.Add(number, name);
            }

            // Truy vấn 1: Tìm tất cả những người làm thuê có giới tính là nam
            IList<Employee> listEmployee = database.DB.Query(delegate (Employee e)
            {
                if (e.Gender == "M") return true;
                return false;
            });
            for(int i = 0; i < listEmployee.Count; ++i)
            {
                Employee e = listEmployee[i];
                string ssn = e.Ssn.ToString();
                string fname = e.FName;
                string lname = e.LName;
                string gender = e.Gender;
                string minit = e.MInit;
                string address = e.Address;
                string birthdate = e.BirthDate;
                string salary = e.Salary.ToString();
                string worksfor = (e.WorksFor == null) ? null : e.WorksFor.DName;
                string manager = (e.Manager == null) ? null : e.Manager.DName;
                string workson = null;
                if (e.WorksOn != null && e.WorksOn.Count != 0)
                {
                    for (int j = 0; j < e.WorksOn.Count; ++j)
                    {
                        if (j == 0) workson = e.WorksOn[j].Project.PName;
                        else workson += ", " + e.WorksOn[j].Project.PName;
                    }

                }
                string dependent = null;
                if (e.Dependents != null && e.Dependents.Count != 0)
                {
                    for (int j = 0; j < e.Dependents.Count; ++j)
                    {
                        if (j == 0) dependent = e.Dependents[j].Name;
                        else dependent += ", " + e.Dependents[j].Name;
                    }
                }
                string supervisor = (e.Supervisor == null) ? null : e.Supervisor.FName + " " + e.Supervisor.LName;
                string supervisees = null;
                if (e.Supervisees != null && e.Supervisees.Count != 0)
                {
                    for (int j = 0; j < e.Supervisees.Count; ++j)
                    {
                        if (j == 0) supervisees = e.Supervisees[j].FName + " " + e.Supervisees[j].LName;
                        else supervisees += ", " + e.Supervisees[j].FName + " " + e.Supervisees[j].LName;
                    }
                }
                dataGridView_CauTruyVan1.Rows.Add(ssn, fname, lname, minit, gender, address, birthdate, salary, worksfor, manager, workson, dependent, supervisor, supervisees);
            }

            // Truy vấn 2: Tìm tất cả những người làm thuê đã làm việc cho ban ngành có tên có chữ T ở đầu
            IList<Department> listDepartment = database.DB.Query(delegate(Department d) 
            {
                if (d.DName[0].ToString() == "T") return true;
                return false;
            });
            List<Employee> listCTV2 = new List<Employee>();
            for(int i = 0; i < listDepartment.Count; ++i)
            {
                for(int j = 0; j < listDepartment[i].Employees.Count; ++j)
                {
                    if (listCTV2.Count == 0) listCTV2.Add((Employee)listDepartment[i].Employees[j]);
                    else
                    {
                        bool check = false;
                        for(int k = 0; k < listCTV2.Count; ++k)
                        {
                            if (listCTV2[k] == (Employee)listDepartment[i].Employees[j]) check = true;
                        }
                        if (check == true) continue;
                        else
                        {
                            listCTV2.Add((Employee)listDepartment[i].Employees[j]);
                        }
                    }
                }
            }
            for(int i = 0; i < listCTV2.Count; ++i)
            {
                Employee e = listCTV2[i];
                string ssn = e.Ssn.ToString();
                string fname = e.FName;
                string lname = e.LName;
                string gender = e.Gender;
                string minit = e.MInit;
                string address = e.Address;
                string birthdate = e.BirthDate;
                string salary = e.Salary.ToString();
                string worksfor = (e.WorksFor == null) ? null : e.WorksFor.DName;
                string manager = (e.Manager == null) ? null : e.Manager.DName;
                string workson = null;
                if (e.WorksOn != null && e.WorksOn.Count != 0)
                {
                    for (int j = 0; j < e.WorksOn.Count; ++j)
                    {
                        if (j == 0) workson = e.WorksOn[j].Project.PName;
                        else workson += ", " + e.WorksOn[j].Project.PName;
                    }

                }
                string dependent = null;
                if (e.Dependents != null && e.Dependents.Count != 0)
                {
                    for (int j = 0; j < e.Dependents.Count; ++j)
                    {
                        if (j == 0) dependent = e.Dependents[j].Name;
                        else dependent += ", " + e.Dependents[j].Name;
                    }
                }
                string supervisor = (e.Supervisor == null) ? null : e.Supervisor.FName + " " + e.Supervisor.LName;
                string supervisees = null;
                if (e.Supervisees != null && e.Supervisees.Count != 0)
                {
                    for (int j = 0; j < e.Supervisees.Count; ++j)
                    {
                        if (j == 0) supervisees = e.Supervisees[j].FName + " " + e.Supervisees[j].LName;
                        else supervisees += ", " + e.Supervisees[j].FName + " " + e.Supervisees[j].LName;
                    }
                }
                dataGridView_CauTruyVan2.Rows.Add(ssn, fname, lname, minit, gender, address, birthdate, salary, worksfor, manager, workson, dependent, supervisor, supervisees);
            }

            // Truy vấn 3: Tìm tất cả những người làm thuê đã làm cho dự án có tên chứa chữ “A” và có thời gian làm việc là < 10h
            IList<WorksOn> listWorksOn = database.DB.Query(delegate (WorksOn w) 
            {
                if ((w.Project.PName.Contains("A") || w.Project.PName.Contains("a")) && w.Hours < 10) return true;
                return false;
            });
            List<Employee> listCTV3 = new List<Employee>();
            for(int i = 0; i < listWorksOn.Count; ++i)
            {
                listCTV3.Add(listWorksOn[i].Employee);
            }
            for(int i = 0; i < listCTV3.Count; ++i)
            {
                Employee e = listCTV3[i];
                string ssn = e.Ssn.ToString();
                string fname = e.FName;
                string lname = e.LName;
                string gender = e.Gender;
                string minit = e.MInit;
                string address = e.Address;
                string birthdate = e.BirthDate;
                string salary = e.Salary.ToString();
                string worksfor = (e.WorksFor == null) ? null : e.WorksFor.DName;
                string manager = (e.Manager == null) ? null : e.Manager.DName;
                string workson = null;
                if (e.WorksOn != null && e.WorksOn.Count != 0)
                {
                    for (int j = 0; j < e.WorksOn.Count; ++j)
                    {
                        if (j == 0) workson = e.WorksOn[j].Project.PName;
                        else workson += ", " + e.WorksOn[j].Project.PName;
                    }

                }
                string dependent = null;
                if (e.Dependents != null && e.Dependents.Count != 0)
                {
                    for (int j = 0; j < e.Dependents.Count; ++j)
                    {
                        if (j == 0) dependent = e.Dependents[j].Name;
                        else dependent += ", " + e.Dependents[j].Name;
                    }
                }
                string supervisor = (e.Supervisor == null) ? null : e.Supervisor.FName + " " + e.Supervisor.LName;
                string supervisees = null;
                if (e.Supervisees != null && e.Supervisees.Count != 0)
                {
                    for (int j = 0; j < e.Supervisees.Count; ++j)
                    {
                        if (j == 0) supervisees = e.Supervisees[j].FName + " " + e.Supervisees[j].LName;
                        else supervisees += ", " + e.Supervisees[j].FName + " " + e.Supervisees[j].LName;
                    }
                }
                dataGridView_CauTruyVan3.Rows.Add(ssn, fname, lname, minit, gender, address, birthdate, salary, worksfor, manager, workson, dependent, supervisor, supervisees);
            }

            // Truy vấn 4: Tìm tất cả các công việc được thực hiện bởi dự án có địa điểm là Houston
            IList<Project> listProject = database.DB.Query(delegate (Project p) 
            {
                if (p.Location == "Houston" && p.WorksOn != null) return true;
                return false;
            });
            for(int i = 0; i < listProject.Count; ++i)
            {
                Project p = listProject[i];
                string number = p.PNumber.ToString();
                string name = p.PName;
                string location = p.Location;
                string controlledby = p.ControlledBy.DName;
                string workson = null;
                if (p.WorksOn != null && p.WorksOn.Count != 0)
                {
                    for (int j = 0; j < p.WorksOn.Count; ++j)
                    {
                        if (j == 0) workson = p.WorksOn[j].Employee.FName + " " + p.WorksOn[j].Employee.LName;
                        else workson += ", " + p.WorksOn[j].Employee.FName + " " + p.WorksOn[j].Employee.LName;
                    }
                }

                dataGridView_CauTruyVan4.Rows.Add(number, name, location, controlledby, workson);
            }
        }

        private void dataGridView_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IObjectSet result = database.result_Employee();
            textBox_SsnEmployee.Clear();
            textBox_FNameEmployee.Clear();
            textBox_LNameEmployee.Clear();
            textBox_MInitEmployee.Clear();
            comboBox_GenderEmployee.Text = "";
            textBox_AddressEmployee.Clear();
            textBox_BirthDateEmployee.Clear(); ;
            textBox_SalaryEmployee.Clear();
            if (e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                Employee employee = (Employee)result[e.RowIndex];

                textBox_SsnEmployee.ReadOnly = true;
                textBox_SsnEmployee.Text = employee.Ssn.ToString();
                textBox_FNameEmployee.Text = employee.FName;
                textBox_LNameEmployee.Text = employee.LName;
                textBox_MInitEmployee.Text = employee.MInit;
                comboBox_GenderEmployee.Text = employee.Gender;
                textBox_AddressEmployee.Text = employee.Address;
                textBox_BirthDateEmployee.Text = employee.BirthDate;
                textBox_SalaryEmployee.Text = employee.Salary.ToString();
            }
        }
        private void dataGridView_DependentOf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IObjectSet result = database.result_Employee();
            textBox_SsnDependentOf.Clear();
            textBox_NameDependentOf.Clear();

            if (e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                Employee dependentOf = (Employee)result[e.RowIndex];

                textBox_SsnDependentOf.Text = dependentOf.Ssn.ToString();
                textBox_NameDependentOf.Text = dependentOf.FName + " " + dependentOf.LName;
            }
        }
        private void dataGridView_Dependent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IObjectSet result = database.result_Dependent();
            textBox_NameDependent.Clear();
            comboBox_GenderDependent.Text = "";
            textBox_BirthDateDependent.Clear();
            comboBox_RelationshipDependent.Text = "";
            textBox_SsnDependentOf.Clear();
            textBox_SsnDependentOfOld.Clear();
            textBox_NameDependentOf.Clear();
            textBox_NameDependentOld.Clear();
            textBox_GenderDependentOld.Clear();
            textBox_BirthDateDependentOld.Clear();
            textBox_RelationshipDependentOld.Clear();
            if (e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                Dependent dependent = (Dependent)result[e.RowIndex];

                textBox_NameDependent.Text = dependent.Name;
                comboBox_GenderDependent.Text = dependent.Gender;
                textBox_BirthDateDependent.Text = dependent.BirthDate;
                comboBox_RelationshipDependent.Text = dependent.Relationship;
                textBox_SsnDependentOf.Text = dependent.DependentOf.Ssn.ToString();
                textBox_SsnDependentOfOld.Text = dependent.DependentOf.Ssn.ToString();
                textBox_NameDependentOf.Text = dependent.DependentOf.FName + " " + dependent.DependentOf.LName;
                textBox_NameDependentOld.Text = dependent.Name;
                textBox_GenderDependentOld.Text = dependent.Gender;
                textBox_BirthDateDependentOld.Text = dependent.BirthDate;
                textBox_RelationshipDependentOld.Text = dependent.Relationship;
            }
        }
        private void dataGridView_ControlledBy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IObjectSet result = database.result_Department();

            textBox_NumberControlledBy.Clear();
            textBox_NameControlledBy.Clear();
            comboBox_LocationProject.Text = "";
            comboBox_LocationProject.Items.Clear();
            if(e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                Department department = (Department)result[e.RowIndex];

                textBox_NumberControlledBy.Text = department.DNumber.ToString();
                textBox_NameControlledBy.Text = department.DName;
                comboBox_LocationProject.Text = "";
                comboBox_LocationProject.Items.Clear();
                for (int i = 0; i < department.Locations.Count; ++i)
                {
                    comboBox_LocationProject.Items.Add(department.Locations[i]);
                }
            }
        }
        private void dataGridView_Project_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_NumberProject.ReadOnly = true;
            IObjectSet result = database.result_Project();

            textBox_NumberProject.Clear();
            textBox_NameProject.Clear();
            comboBox_LocationProject.Items.Clear();
            comboBox_LocationProject.Text = "";
            textBox_NumberControlledBy.Clear();
            textBox_NameControlledBy.Clear();
            textBox_NumberControlledByOld.Clear();

            if (e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                Project project = (Project)result[e.RowIndex];
                textBox_NumberProject.Text = project.PNumber.ToString();
                textBox_NameProject.Text = project.PName;
                comboBox_LocationProject.Items.Clear();
                for(int i = 0; i < project.ControlledBy.Locations.Count; ++i)
                {
                    comboBox_LocationProject.Items.Add(project.ControlledBy.Locations[i]);
                }
                comboBox_LocationProject.Text = project.Location;
                textBox_NumberControlledBy.Text = project.ControlledBy.DNumber.ToString();
                textBox_NameControlledBy.Text = project.ControlledBy.DName;
                textBox_NumberControlledByOld.Text = project.ControlledBy.DNumber.ToString();
            }
        }
        private void dataGridView_Manager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IObjectSet result = database.result_Employee();

            textBox_MgrStartDate.Clear();
            textBox_SsnManager.Clear();
            textBox_NameManager.Clear();

            if (e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                Employee manager = (Employee)result[e.RowIndex];

                textBox_MgrStartDate.Clear();
                textBox_SsnManager.Text = manager.Ssn.ToString();
                textBox_NameManager.Text = manager.FName + " " + manager.LName;
            }
        }
        private void dataGridView_Department_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_NumberDepartment.ReadOnly = true;
            IObjectSet result = database.result_Department();

            textBox_NumberDepartment.Clear();
            textBox_NameDepartment.Clear();
            textBox_LocationsDepartment.Clear();
            textBox_SsnManager.Clear();
            textBox_SsnManagerOld.Clear();
            textBox_NameManager.Clear();
            textBox_MgrStartDate.Clear();

            if (e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                Department department = (Department)result[e.RowIndex];

                textBox_NumberDepartment.Text = department.DNumber.ToString();
                textBox_NameDepartment.Text = department.DName;
                string locations = null;
                for(int i = 0; i < department.Locations.Count; ++i)
                {
                    if (i == 0) locations = department.Locations[i];
                    else locations += "," + department.Locations[i];
                }
                textBox_LocationsDepartment.Text = locations;
                if(department.Manager != null)
                {
                    textBox_SsnManager.Text = department.Manager.Ssn.ToString();
                    textBox_SsnManagerOld.Text = department.Manager.Ssn.ToString();
                    textBox_NameManager.Text = department.Manager.FName + " " + department.Manager.LName;
                    textBox_MgrStartDate.Text = department.MgrStartDate;
                }
                else
                {
                    textBox_SsnManager.Clear();
                    textBox_SsnManagerOld.Clear();
                    textBox_NameManager.Clear();
                    textBox_MgrStartDate.Clear();
                }
            }
        }
        private void dataGridView_WorksOn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IObjectSet result = database.result_WorksOn();

            textBox_HoursWorksOn.Clear();
            textBox_SsnEmployeeWorksOn.Clear();
            textBox_SsnEmployeeWorksOnOld.Clear();
            textBox_NameEmployeeWorksOn.Clear();
            textBox_NumberProjectWorksOn.Clear();
            textBox_NumberProjectWorksOnOld.Clear();
            textBox_NameProjectWorksOn.Clear();

            if(e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                WorksOn w = (WorksOn)result[e.RowIndex];

                textBox_HoursWorksOn.Text = w.Hours.ToString();
                textBox_SsnEmployeeWorksOn.Text = w.Employee.Ssn.ToString();
                textBox_SsnEmployeeWorksOnOld.Text = w.Employee.Ssn.ToString();
                textBox_NameEmployeeWorksOn.Text = w.Employee.FName + " " + w.Employee.LName;
                textBox_NumberProjectWorksOn.Text = w.Project.PNumber.ToString();
                textBox_NumberProjectWorksOnOld.Text = w.Project.PNumber.ToString();
                textBox_NameProjectWorksOn.Text = w.Project.PName;
            }
        }
        private void dataGridView_ProjectWorksOn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IObjectSet result = database.result_Project();

            textBox_NumberProjectWorksOn.Clear();
            textBox_NameProjectWorksOn.Clear();

            if(e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                Project p = (Project)result[e.RowIndex];

                textBox_NumberProjectWorksOn.Text = p.PNumber.ToString();
                textBox_NameProjectWorksOn.Text = p.PName;
            }
        }
        private void dataGridView_EmployeeWorksOn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IObjectSet result = database.result_Employee();

            textBox_SsnEmployeeWorksOn.Clear();
            textBox_NameEmployeeWorksOn.Clear();

            if(e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                Employee employee = (Employee)result[e.RowIndex];

                textBox_SsnEmployeeWorksOn.Text = employee.Ssn.ToString();
                textBox_NameEmployeeWorksOn.Text = employee.FName + " " + employee.LName;
            }
        }
        private void dataGridView_DepartmentWorksFor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IObjectSet result = database.result_Department();

            dataGridView_EmployeesWorksFor.Rows.Clear();
            textBox_NumberDepartmentWorksFor.Clear();

            if (e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                Department department = (Department)result[e.RowIndex];
                if(department.Employees != null)
                {
                    for(int i = 0; i < department.Employees.Count; ++i)
                    {
                        Employee employee = department.Employees[i];
                        dataGridView_EmployeesWorksFor.Rows.Add(employee.Ssn.ToString(), employee.FName, employee.LName);
                    }
                }
                textBox_NumberDepartmentWorksFor.Text = department.DNumber.ToString();
            }
        }
        private void dataGridView_EmployeesWorksFor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1 && dataGridView_EmployeesWorksFor.Rows.Count > 1)
            {
                dataGridView_EmployeesWorksFor.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void dataGridView_EmployeeWorksFor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IObjectSet result = database.result_Employee();

            if(e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                int check = 0;
                Employee employee = (Employee)result[e.RowIndex];

                if (dataGridView_EmployeesWorksFor.RowCount == 1) dataGridView_EmployeesWorksFor.Rows.Add(employee.Ssn.ToString(), employee.FName, employee.LName);
                else
                {
                    for (int i = 0; i < dataGridView_EmployeesWorksFor.Rows.Count - 1; ++i)
                    {
                        DataGridViewRow row = dataGridView_EmployeesWorksFor.Rows[i];
                        if (employee.Ssn.ToString() == row.Cells[0].Value.ToString())
                        {
                            check = 1;
                            break;
                        }
                    }
                    if (check == 0) dataGridView_EmployeesWorksFor.Rows.Add(employee.Ssn.ToString(), employee.FName, employee.LName);
                }
            }
        }
        private void dataGridView_SupervisorSupervisor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IObjectSet result = database.result_Employee();

            dataGridView_SuperviseesSupervisor.Rows.Clear();
            textBox_SsnSupervisorSupervisor.Clear();

            if (e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                Employee employee = (Employee)result[e.RowIndex];
                if (employee.Supervisees != null)
                {
                    for (int i = 0; i < employee.Supervisees.Count; ++i)
                    {
                        Employee temp = employee.Supervisees[i];
                        dataGridView_SuperviseesSupervisor.Rows.Add(temp.Ssn.ToString(), temp.FName, temp.LName);
                    }
                }
                textBox_SsnSupervisorSupervisor.Text = employee.Ssn.ToString();
            }
        }
        private void dataGridView_SuperviseesSupervisor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dataGridView_SuperviseesSupervisor.Rows.Count > 1)
            {
                dataGridView_SuperviseesSupervisor.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void dataGridView_EmployeeSupervisor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IObjectSet result = database.result_Employee();

            if (e.RowIndex != -1 && e.RowIndex != result.Count)
            {
                int check = 0;
                Employee employee = (Employee)result[e.RowIndex];

                if (dataGridView_SuperviseesSupervisor.RowCount == 1) dataGridView_SuperviseesSupervisor.Rows.Add(employee.Ssn.ToString(), employee.FName, employee.LName);
                else
                {
                    for (int i = 0; i < dataGridView_SuperviseesSupervisor.Rows.Count - 1; ++i)
                    {
                        DataGridViewRow row = dataGridView_SuperviseesSupervisor.Rows[i];
                        if (employee.Ssn.ToString() == row.Cells[0].Value.ToString())
                        {
                            check = 1;
                            break;
                        }
                    }
                    if (check == 0) dataGridView_SuperviseesSupervisor.Rows.Add(employee.Ssn.ToString(), employee.FName, employee.LName);
                }
            }
        }

        private void button_AddEmployee_Click(object sender, EventArgs e)
        {
            int ssn = -1;
            if (textBox_SsnEmployee.Text != "") ssn = int.Parse(textBox_SsnEmployee.Text);
            string fname = textBox_FNameEmployee.Text;
            string lname = textBox_LNameEmployee.Text;
            string gender = comboBox_GenderEmployee.Text;
            string minit = textBox_MInitEmployee.Text;
            string address = textBox_AddressEmployee.Text;
            string birthdate = textBox_BirthDateEmployee.Text;
            double salary = -1;
            if(textBox_SalaryEmployee.Text != "") salary = double.Parse(textBox_SalaryEmployee.Text);

            string thongbao = null;

            if(ssn == -1)
            {
                string thongbaossn = "- Ssn\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaossn;
                else thongbao += thongbaossn;
            }
            if (fname == "")
            {
                string thongbaofname = "- First name\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaofname;
                else thongbao += thongbaofname;
            }
            if (lname == "")
            {
                string thongbaolname = "- Last name\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaolname;
                else thongbao += thongbaolname;
            }
            if (gender == "")
            {
                string thongbaogender = "- Gender\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaogender;
                else thongbao += thongbaogender;
            }
            if (minit == "")
            {
                string thongbaominit = "- MInit\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaominit;
                else thongbao += thongbaominit;
            }
            if (address == "")
            {
                string thongbaoaddress = "- Address\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaoaddress;
                else thongbao += thongbaoaddress;
            }
            if (birthdate == "")
            {
                string thongbaobirthdate = "- Birthdate\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaobirthdate;
                else thongbao += thongbaobirthdate;
            }
            if (salary == -1)
            {
                string thongbaosalary = "- Salary\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaosalary;
                else thongbao += thongbaosalary;
            }

            if(thongbao != null) MessageBox.Show(thongbao);
            else
            {
                Employee employee = new Employee(ssn, null, null, null, null, null, 0, null);
                IObjectSet result = database.DB.QueryByExample(employee);
                if(result.Count != 0) MessageBox.Show("Ssn bị trùng, vui lòng nhập lại");
                else
                {
                    employee = new Employee(ssn, fname, minit, lname, address, birthdate, salary, gender);
                    database.DB.Store(employee);

                    result = database.result_Employee();
                    int countNew = result.Count;
                    string[] data_EmployeeNew = new string[countNew + 1];

                    data_EmployeeNew[0] = countNew.ToString();
                    for (int i = 0; i < countNew; ++i)
                    {
                        Employee temp = (Employee)result[i];
                        data_EmployeeNew[i + 1] = temp._ToString();
                    }
                    File.WriteAllLines("data_Employee.txt", data_EmployeeNew);

                    MessageBox.Show("Bạn đã thêm thành công");

                    LoadData();
                }
            }
        }
        private void button_DeleteEmployee_Click(object sender, EventArgs e) 
        {
            int ssn = -1;
            if (textBox_SsnEmployee.Text != "") ssn = int.Parse(textBox_SsnEmployee.Text);

            if (ssn == -1) MessageBox.Show("Bạn chưa chọn Employee để xóa");
            else
            {
                Employee employee = new Employee(ssn, null, null, null, null, null, 0, null);
                IObjectSet result = database.DB.QueryByExample(employee);
                if(result.Count != 0)
                {
                    employee = (Employee)result[0];

                    bool check = true;

                    if (employee.WorksFor != null || employee.Manager != null || employee.Supervisor != null || employee.WorksOn != null || employee.Dependents != null || employee.Supervisees != null) check = false;

                    if (check == true)
                    {
                        database.DB.Delete(employee);

                        result = database.result_Employee();
                        int countNew = result.Count;
                        string[] data_EmployeeNew = new string[countNew + 1];

                        data_EmployeeNew[0] = countNew.ToString();
                        for (int i = 0; i < countNew; ++i)
                        {
                            Employee temp = (Employee)result[i];
                            data_EmployeeNew[i + 1] = temp._ToString();
                        }

                        File.WriteAllLines("data_Employee.txt", data_EmployeeNew);

                        MessageBox.Show("Xóa thành công");

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa vì sẽ ảnh hưởng đến các bảng khác");

                        LoadData();
                    }
                }
            }
        }
        private void button_ModifyEmployee_Click(object sender, EventArgs e)
        {
            int ssn = -1;
            if(textBox_SsnEmployee.Text != "") ssn = int.Parse(textBox_SsnEmployee.Text);
            string fname = textBox_FNameEmployee.Text;
            string lname = textBox_LNameEmployee.Text;
            string gender = comboBox_GenderEmployee.Text;
            string minit = textBox_MInitEmployee.Text;
            string birthdate = textBox_BirthDateEmployee.Text;
            string address = textBox_AddressEmployee.Text;
            double salary = -1; 
            if(textBox_SalaryEmployee.Text != "") salary = double.Parse(textBox_SalaryEmployee.Text);

            string thongbao = null;

            if (ssn == -1) MessageBox.Show("Bạn chưa chọn employee để sửa");
            else
            {
                if (fname == "")
                {
                    string thongbaofname = "- First name\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaofname;
                    else thongbao += thongbaofname;
                }
                if (lname == "")
                {
                    string thongbaolname = "- Last name\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaolname;
                    else thongbao += thongbaolname;
                }
                if (gender == "")
                {
                    string thongbaogender = "- Gender\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaogender;
                    else thongbao += thongbaogender;
                }
                if (minit == "")
                {
                    string thongbaominit = "- MInit\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaominit;
                    else thongbao += thongbaominit;
                }
                if (address == "")
                {
                    string thongbaoaddress = "- Address\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaoaddress;
                    else thongbao += thongbaoaddress;
                }
                if (birthdate == "")
                {
                    string thongbaobirthdate = "- Birthdate\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaobirthdate;
                    else thongbao += thongbaobirthdate;
                }
                if (salary == -1)
                {
                    string thongbaosalary = "- Salary\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaosalary;
                    else thongbao += thongbaosalary;
                }

                if (thongbao != null) MessageBox.Show(thongbao);
                else
                {
                    Employee employee = new Employee(ssn, null, null, null, null, null, 0, null);
                    IObjectSet result = database.DB.QueryByExample(employee);
                    if (result.Count != 0)
                    {
                        employee = (Employee)result[0];
                        employee.FName = fname;
                        employee.LName = lname;
                        employee.Gender = gender;
                        employee.MInit = minit;
                        employee.BirthDate = birthdate;
                        employee.Address = address;
                        employee.Salary = salary;

                        database.DB.Store(employee);

                        result = database.result_Employee();
                        int countNew = result.Count;
                        string[] data_EmployeeNew = new string[countNew + 1];

                        data_EmployeeNew[0] = countNew.ToString();
                        for (int i = 0; i < countNew; ++i)
                        {
                            Employee temp = (Employee)result[i];
                            data_EmployeeNew[i + 1] = temp._ToString();
                        }

                        File.WriteAllLines("data_Employee.txt", data_EmployeeNew);

                        MessageBox.Show("Sửa thành công");

                        LoadData();
                    }
                }
            }
        }

        private void textBox_Ssn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void textBox_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void textBox_PNumberProject_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void textBox_NumberDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void textBox_HoursWorksOn_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void button_Reset_Employee_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void button_Reset_Dependent_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void button_Reset_Project_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void button_Reset_Department_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void button_Reset_WorksOn_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void button_Reset_WorksFor_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button_AddDependent_Click(object sender, EventArgs e)
        {
            string name = textBox_NameDependent.Text;
            string gender = comboBox_GenderDependent.Text;
            string birthdate = textBox_BirthDateDependent.Text;
            string relationship = comboBox_RelationshipDependent.Text;
            int ssnEmployee = -1;
            if(textBox_SsnDependentOf.Text != "") ssnEmployee = int.Parse(textBox_SsnDependentOf.Text);
            string nameEmployee = textBox_NameDependentOf.Text;

            string thongbao = null;

            if(name == "")
            {
                string thongbaoname = "- Name dependent\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaoname;
                else thongbao += thongbaoname;
            }
            if(gender == "")
            {
                string thongbaogender = "- Gender\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaogender;
                else thongbao += thongbaogender;
            }
            if (birthdate == "")
            {
                string thongbaobirthdate = "- BirthDate\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaobirthdate;
                else thongbao += thongbaobirthdate;
            }
            if (relationship == "")
            {
                string thongbaorelationship = "- Relationship\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaorelationship;
                else thongbao += thongbaorelationship;
            }
            if (ssnEmployee == -1)
            {
                string thongbaossn = "- Ssn Employee\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaossn;
                else thongbao += thongbaossn;
            }
            if (nameEmployee == "")
            {
                string thongbaoname = "- Name Employee\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaoname;
                else thongbao += thongbaoname;
            }

            if (thongbao != null) MessageBox.Show(thongbao);
            else
            {
                Dependent dependent = new Dependent(name, gender, birthdate, relationship);

                Employee employee = new Employee(ssnEmployee, null, null, null, null, null, 0, null);
                IObjectSet result = database.DB.QueryByExample(employee);
                employee = (Employee)result[0];

                if (employee.Dependents == null) employee.Dependents = new List<Dependent>();
                employee.Dependents.Add(dependent);
                dependent.DependentOf = employee;

                database.DB.Store(dependent);
                database.DB.Store(employee);

                result = database.result_Dependent();
                int countNew = result.Count;
                string[] data_DependentNew = new string[countNew + 1];

                data_DependentNew[0] = countNew.ToString();
                for(int i = 0; i < countNew; ++i)
                {
                    Dependent temp = (Dependent)result[i];
                    data_DependentNew[i + 1] = temp._ToString();
                }

                File.WriteAllLines("data_Dependent.txt", data_DependentNew);

                MessageBox.Show("Thêm thành công");

                LoadData();
            }
        }
        private void button_DeleteDependent_Click(object sender, EventArgs e)
        {
            string name = textBox_NameDependentOld.Text;
            string gender = textBox_GenderDependentOld.Text;
            string birthdate = textBox_BirthDateDependentOld.Text;
            string relationship = textBox_RelationshipDependentOld.Text;

            if (name == "" && gender == "" && birthdate == "" && relationship == "") MessageBox.Show("Bạn chưa chọn dependent để xóa");
            else
            {
                Dependent dependent = new Dependent(name, gender, birthdate, relationship);
                IObjectSet result = database.DB.QueryByExample(dependent);
                if (result.Count != 0)
                {
                    dependent = (Dependent)result[0];
                    database.DB.Delete(dependent);

                    result = database.result_Dependent();
                    int countNew = result.Count;
                    string[] data_DependentNew = new string[countNew + 1];

                    data_DependentNew[0] = countNew.ToString();
                    for (int i = 0; i < countNew; ++i)
                    {
                        Dependent temp = (Dependent)result[i];
                        data_DependentNew[i + 1] = temp._ToString();
                    }

                    File.WriteAllLines("data_Dependent.txt", data_DependentNew);

                    MessageBox.Show("Xóa thành công");

                    LoadData();
                }
            }
        }
        private void button_ModifyDependent_Click(object sender, EventArgs e)
        {
            string nameDependentNew = textBox_NameDependent.Text;
            string genderDependentNew = comboBox_GenderDependent.Text;
            string birthdateDependentNew = textBox_BirthDateDependent.Text;
            string relationshipDependentNew = comboBox_RelationshipDependent.Text;

            string nameDependentOld = textBox_NameDependentOld.Text;
            string genderDependentOld = textBox_GenderDependentOld.Text;
            string birthDateDependentOld = textBox_BirthDateDependentOld.Text;
            string relationshipDependentOld = textBox_RelationshipDependentOld.Text;

            int ssnDependentOf = -1;
            if(textBox_SsnDependentOf.Text != "") ssnDependentOf = int.Parse(textBox_SsnDependentOf.Text);
            int ssnDependentOfOld = -1;
            if(textBox_SsnDependentOfOld.Text != "") ssnDependentOfOld = int.Parse(textBox_SsnDependentOfOld.Text);

            if (ssnDependentOf == -1) MessageBox.Show("Bạn chưa chọn dependent để sửa");
            else
            {
                string thongbao = null;

                if (nameDependentNew == "")
                {
                    string thongbaoname = "- Name dependent\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaoname;
                    else thongbao += thongbaoname;
                }
                if (genderDependentNew == "")
                {
                    string thongbaogender = "- Gender dependent\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaogender;
                    else thongbao += thongbaogender;
                }
                if (birthdateDependentNew == "")
                {
                    string thongbaobirthdate = "- BirthDate dependent\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaobirthdate;
                    else thongbao += thongbaobirthdate;
                }
                if (relationshipDependentNew == "")
                {
                    string thongbaorelationship = "- Relationship dependent\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaorelationship;
                    else thongbao += thongbaorelationship;
                }

                if (thongbao != null) MessageBox.Show(thongbao);
                else
                {
                    Dependent dependent = new Dependent(nameDependentOld, genderDependentOld, birthDateDependentOld, relationshipDependentOld);
                    IObjectSet result = database.DB.QueryByExample(dependent);
                    if (result.Count != 0)
                    {
                        dependent = (Dependent)result[0];
                        dependent.Name = nameDependentNew;
                        dependent.Gender = genderDependentNew;
                        dependent.BirthDate = birthdateDependentNew;
                        dependent.Relationship = relationshipDependentNew;

                        if (ssnDependentOf != ssnDependentOfOld)
                        {
                            Employee dependentOfNew = new Employee(ssnDependentOf, null, null, null, null, null, 0, null);
                            result = database.DB.QueryByExample(dependentOfNew);
                            dependentOfNew = (Employee)result[0];

                            dependent.DependentOf = dependentOfNew;
                        }

                        database.DB.Store(dependent);

                        result = database.result_Dependent();
                        int countNew = result.Count;
                        string[] data_DependentNew = new string[countNew + 1];

                        data_DependentNew[0] = countNew.ToString();
                        for (int i = 0; i < countNew; ++i)
                        {
                            Dependent temp = (Dependent)result[i];
                            data_DependentNew[i + 1] = temp._ToString();
                        }

                        File.WriteAllLines("data_Dependent.txt", data_DependentNew);

                        MessageBox.Show("Sửa thành công");

                        LoadData();
                    }
                }
            }
        }

        private void button_AddProject_Click(object sender, EventArgs e)
        {
            int numberProject = -1;
            if (textBox_NumberProject.Text != "") numberProject = int.Parse(textBox_NumberProject.Text);
            string nameProject = textBox_NameProject.Text;
            string locationProject = comboBox_LocationProject.Text;
            int numberDepartment = -1;
            if (textBox_NumberControlledBy.Text != "") numberDepartment = int.Parse(textBox_NumberControlledBy.Text);
            string nameDepartment = textBox_NameControlledBy.Text;

            string thongbao = null;

            if(numberProject == -1)
            {
                string thongbaonumberProject = "- Number project\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaonumberProject;
                else thongbao += thongbaonumberProject;
            }
            if (nameProject == "")
            {
                string thongbaonameProject = "- Name project\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaonameProject;
                else thongbao += thongbaonameProject;
            }
            if (locationProject == "")
            {
                string thongbaolocationProject = "- Location project\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaolocationProject;
                else thongbao += thongbaolocationProject;
            }
            if (numberDepartment == -1)
            {
                string thongbaonumberDepartment = "- Number department\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaonumberDepartment;
                else thongbao += thongbaonumberDepartment;
            }
            if (nameDepartment == "")
            {
                string thongbaonameDepartment = "- Name department\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaonameDepartment;
                else thongbao += thongbaonameDepartment;
            }

            if (thongbao != null) MessageBox.Show(thongbao);
            else
            {
                Project project = new Project(numberProject, null, null);
                IObjectSet result = database.DB.QueryByExample(project);
                if (result.Count != 0) MessageBox.Show("Number project bị trùng, vui lòng nhập lại");
                else
                {
                    project = new Project(numberProject, nameProject, locationProject);

                    Department department = new Department(numberDepartment, nameDepartment, null);
                    result = database.DB.QueryByExample(department);
                    if (result.Count != 0)
                    {
                        department = (Department)result[0];
                        if (department.Projects == null) department.Projects = new List<Project>();
                        department.Projects.Add(project);
                        project.ControlledBy = department;

                        database.DB.Store(department);
                        database.DB.Store(project);

                        result = database.result_Project();
                        int countNew = result.Count;
                        string[] data_ProjectNew = new string[countNew + 1];

                        data_ProjectNew[0] = countNew.ToString();
                        for (int i = 0; i < countNew; ++i)
                        {
                            Project temp = (Project)result[i];
                            data_ProjectNew[i + 1] = temp._ToString();
                        }

                        File.WriteAllLines("data_Project.txt", data_ProjectNew);

                        result = database.result_Department();
                        int count = 0;
                        string[] data_Temp = new string[result.Count];

                        for (int i = 0; i < result.Count; ++i)
                        {
                            Department temp = (Department)result[i];
                            if (temp.Projects != null)
                            {
                                data_Temp[i] = temp.DNumber.ToString() + ": ";
                                for (int j = 0; j < temp.Projects.Count; ++j)
                                {
                                    if (j == 0)
                                    {
                                        data_Temp[i] += temp.Projects[j].PNumber.ToString();
                                    }
                                    else
                                    {
                                        data_Temp[i] += ", " + temp.Projects[j].PNumber.ToString();
                                    }
                                }
                                ++count;
                            }
                        }

                        string[] data_ControlledByNew = new string[count + 1];
                        data_ControlledByNew[0] = count.ToString();
                        for (int i = 0; i < data_ControlledByNew.Length - 1; ++i)
                        {
                            if(data_Temp[i] != null) data_ControlledByNew[i + 1] = data_Temp[i];
                        }

                        File.WriteAllLines("SetControlledBy.txt", data_ControlledByNew);

                        MessageBox.Show("Thêm thành công");

                        LoadData();
                    }
                }
            }
        }
        private void button_DeleteProject_Click(object sender, EventArgs e)
        {
            int numberProject = -1;
            if(textBox_NumberProject.Text != "") numberProject = int.Parse(textBox_NumberProject.Text);
            int numberDepartment = -1;
            if(textBox_NumberControlledByOld.Text != "") numberDepartment = int.Parse(textBox_NumberControlledByOld.Text);

            if (numberDepartment == -1) MessageBox.Show("Bạn chưa chọn project để xóa");
            else
            {
                Project project = new Project(numberProject, null, null);
                IObjectSet result = database.DB.QueryByExample(project);
                project = (Project)result[0];

                Department department = new Department(numberDepartment, null, null);
                result = database.DB.QueryByExample(department);
                department = (Department)result[0];
                department.Projects.Remove(project);

                database.DB.Store(department);
                database.DB.Delete(project);

                result = database.result_Project();
                int countNew = result.Count;
                string[] data_ProjectNew = new string[countNew + 1];

                data_ProjectNew[0] = countNew.ToString();
                for (int i = 0; i < countNew; ++i)
                {
                    Project temp = (Project)result[i];
                    data_ProjectNew[i + 1] = temp._ToString();
                }

                File.WriteAllLines("data_Project.txt", data_ProjectNew);

                result = database.result_Department();
                int count = 0;
                string[] data_Temp = new string[result.Count];

                for (int i = 0; i < result.Count; ++i)
                {
                    Department temp = (Department)result[i];
                    if (temp.Projects != null && temp.Projects.Count != 0)
                    {
                        data_Temp[i] = temp.DNumber.ToString() + ": ";
                        for (int j = 0; j < temp.Projects.Count; ++j)
                        {
                            if (j == 0)
                            {
                                data_Temp[i] += temp.Projects[j].PNumber.ToString();
                            }
                            else
                            {
                                data_Temp[i] += ", " + temp.Projects[j].PNumber.ToString();
                            }
                        }
                        ++count;
                    }
                }

                string[] data_ControlledByNew = new string[count + 1];
                data_ControlledByNew[0] = count.ToString();
                for (int i = 0; i < data_ControlledByNew.Length - 1; ++i)
                {
                    if (data_Temp[i] != null) data_ControlledByNew[i + 1] = data_Temp[i];
                }

                File.WriteAllLines("SetControlledBy.txt", data_ControlledByNew);

                MessageBox.Show("Xóa thành công");

                LoadData();
            }
        }
        private void button_ModifyProject_Click(object sender, EventArgs e)
        {
            int numberProject = -1;
            if(textBox_NumberProject.Text != "") numberProject = int.Parse(textBox_NumberProject.Text);
            string nameProjectNew = textBox_NameProject.Text;
            string locationProjectNew = comboBox_LocationProject.Text;

            int numberDepartmentNew = -1;
            if(textBox_NumberControlledBy.Text != "") numberDepartmentNew = int.Parse(textBox_NumberControlledBy.Text);
            int numberDepartmentOld = -1; 
            if(textBox_NumberControlledByOld.Text != "") numberDepartmentOld = int.Parse(textBox_NumberControlledByOld.Text);

            if (numberDepartmentOld == -1) MessageBox.Show("Bạn chưa chọn project để sửa");
            else
            {
                string thongbao = null;

                if (nameProjectNew == "")
                {
                    string thongbaoname = "- Name project\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaoname;
                    else thongbao += thongbaoname;
                }
                if (locationProjectNew == "")
                {
                    string thongbaolocation = "- Location project\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaolocation;
                    else thongbao += thongbaolocation;
                }

                if (thongbao != null) MessageBox.Show(thongbao);
                else
                {
                    Project project = new Project(numberProject, null, null);
                    IObjectSet result = database.DB.QueryByExample(project);
                    project = (Project)result[0];

                    project.PName = nameProjectNew;
                    project.Location = locationProjectNew;

                    if (numberDepartmentOld == numberDepartmentNew)
                    {
                        database.DB.Store(project);

                        result = database.result_Project();
                        int countNew = result.Count;
                        string[] data_ProjectNew = new string[countNew + 1];

                        data_ProjectNew[0] = countNew.ToString();
                        for (int i = 0; i < countNew; ++i)
                        {
                            Project temp = (Project)result[i];
                            data_ProjectNew[i + 1] = temp._ToString();
                        }

                        File.WriteAllLines("data_Project.txt", data_ProjectNew);
                    }
                    else if (numberDepartmentOld != numberDepartmentNew)
                    {
                        Department departmentOld = new Department(numberDepartmentOld, null, null);
                        result = database.DB.QueryByExample(departmentOld);
                        departmentOld = (Department)result[0];

                        Department departmentNew = new Department(numberDepartmentNew, null, null);
                        result = database.DB.QueryByExample(departmentNew);
                        departmentNew = (Department)result[0];

                        departmentOld.Projects.Remove(project);
                        if (departmentNew.Projects == null) departmentNew.Projects = new List<Project>();
                        departmentNew.Projects.Add(project);
                        project.ControlledBy = departmentNew;

                        database.DB.Store(project);
                        database.DB.Store(departmentOld);
                        database.DB.Store(departmentNew);

                        result = database.result_Project();
                        int countNew = result.Count;
                        string[] data_ProjectNew = new string[countNew + 1];

                        data_ProjectNew[0] = countNew.ToString();
                        for (int i = 0; i < countNew; ++i)
                        {
                            Project temp = (Project)result[i];
                            data_ProjectNew[i + 1] = temp._ToString();
                        }

                        File.WriteAllLines("data_Project.txt", data_ProjectNew);

                        result = database.result_Department();
                        int count = 0;
                        string[] data_Temp = new string[result.Count];

                        for (int i = 0; i < result.Count; ++i)
                        {
                            Department department = (Department)result[i];
                            if (department.Projects != null && department.Projects.Count != 0)
                            {
                                data_Temp[i] = department.DNumber.ToString() + ": ";
                                for (int j = 0; j < department.Projects.Count; ++j)
                                {
                                    if (j == 0) data_Temp[i] += department.Projects[j].PNumber.ToString();
                                    else data_Temp[i] += ", " + department.Projects[j].PNumber.ToString();
                                }
                                ++count;
                            }
                        }

                        string[] data_ControlledByNew = new string[count + 1];
                        data_ControlledByNew[0] = count.ToString();
                        for (int i = 0; i < count; ++i)
                        {
                            data_ControlledByNew[i + 1] = data_Temp[i];
                        }

                        File.WriteAllLines("SetControlledBy.txt", data_ControlledByNew);
                    }

                    MessageBox.Show("Sửa thành công");

                    LoadData();
                }
            }
        }

        private void button_AddDepartment_Click(object sender, EventArgs e)
        {
            int numberDepartment = -1;
            if (textBox_NumberDepartment.Text != "") numberDepartment = int.Parse(textBox_NumberDepartment.Text);
            string nameDepartment = textBox_NameDepartment.Text;
            string locationsDepartment = textBox_LocationsDepartment.Text;

            int ssnManager = -1;
            if (textBox_SsnManager.Text != "") ssnManager = int.Parse(textBox_SsnManager.Text);
            string mgrStartDate = textBox_MgrStartDate.Text;

            string thongbao = null;

            if(numberDepartment == -1)
            {
                string thongbaonumber = "- Number department\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaonumber;
                else thongbao += thongbaonumber;
            }
            if (nameDepartment == "")
            {
                string thongbaoname = "- Name department\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaoname;
                else thongbao += thongbaoname;
            }
            if (locationsDepartment == "")
            {
                string thongbaolocations = "- Locations department\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaolocations;
                else thongbao += thongbaolocations;
            }
            if (ssnManager == -1)
            {
                string thongbaossn = "- Ssn manager\n- Name manager\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaossn;
                else thongbao += thongbaossn;
            }
            if(mgrStartDate == "")
            {
                string thongbaodate = "- Manager start date\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaodate;
                else thongbao += thongbaodate;
            }

            if (thongbao != null) MessageBox.Show(thongbao);
            else
            {
                Department department = new Department(numberDepartment, null, null);
                IObjectSet result = database.DB.QueryByExample(department);
                if (result.Count != 0) MessageBox.Show("Number department bị trùng, vui lòng nhập lại");
                else
                {
                    Employee employee = new Employee(ssnManager, null, null, null, null, null, 0, null);
                    result = database.DB.QueryByExample(employee);
                    employee = (Employee)result[0];
                    if (employee.Manager != null) MessageBox.Show("Một department được quản lí bởi employee này, vui lòng nhập lại");
                    else
                    {
                        List<string> Locations = new List<string>();
                        string[] listLocations = locationsDepartment.Split(',');
                        for (int i = 0; i < listLocations.Length; ++i)
                        {
                            while (listLocations[i][0] == ' ') listLocations[i] = listLocations[i].Remove(0, 1);
                            while (listLocations[i][listLocations[i].Length - 1] == ' ') listLocations[i] = listLocations[i].Remove(listLocations[i].Length - 1, 1);

                            Locations.Add(listLocations[i]);
                        }

                        department = new Department(numberDepartment, nameDepartment, Locations);

                        Employee manager = new Employee(ssnManager, null, null, null, null, null, 0, null);
                        result = database.DB.QueryByExample(manager);

                        department.Manager = manager;
                        department.MgrStartDate = mgrStartDate;
                        manager.Manager = department;

                        database.DB.Store(department);
                        database.DB.Store(manager);

                        result = database.result_Employee();
                        int count = 0;
                        string[] data_Temp = new string[result.Count];

                        for (int i = 0; i < result.Count; ++i)
                        {
                            employee = (Employee)result[i];
                            if (employee.Manager != null)
                            {
                                string lineManager = employee.Manager.DNumber.ToString() + "," + employee.Ssn.ToString() + "," + employee.Manager.MgrStartDate;
                                data_Temp[count] = lineManager;
                                ++count;
                            }
                        }

                        string[] data_ManagerNew = new string[count + 1];
                        data_ManagerNew[0] = count.ToString();
                        for (int i = 0; i < count; ++i)
                        {
                            data_ManagerNew[i + 1] = data_Temp[i];
                        }

                        File.WriteAllLines("SetManager.txt", data_ManagerNew);

                        result = database.result_Department();
                        int countNew = result.Count;
                        string[] data_DepartmentNew = new string[countNew + 1];

                        data_DepartmentNew[0] = countNew.ToString();
                        for (int i = 0; i < countNew; ++i)
                        {
                            Department temp = (Department)result[i];
                            string lineDepartment = temp.DNumber.ToString() + ":" + temp.DName + ":";
                            for (int j = 0; j < temp.Locations.Count; ++j)
                            {
                                if (j == 0) lineDepartment += temp.Locations[j];
                                else lineDepartment += "," + temp.Locations[j];
                            }
                            data_DepartmentNew[i + 1] = lineDepartment;
                        }

                        File.WriteAllLines("data_Department.txt", data_DepartmentNew);

                        MessageBox.Show("Thêm thành công");

                        LoadData();
                    }
                }
            }
        }
        private void button_ModifyDepartment_Click(object sender, EventArgs e)
        {
            int numberDepartment = -1;
            if (textBox_NumberDepartment.Text != "") numberDepartment = int.Parse(textBox_NumberDepartment.Text);
            string nameDepartment = textBox_NameDepartment.Text;
            string locationsDepartment = textBox_LocationsDepartment.Text;

            int ssnManagerOld = -1;
            if (textBox_SsnManagerOld.Text != "") ssnManagerOld = int.Parse(textBox_SsnManagerOld.Text);
            int ssnManagerNew = -1;
            if (textBox_SsnManager.Text != "") ssnManagerNew = int.Parse(textBox_SsnManager.Text);
            string mgrStartDate = textBox_MgrStartDate.Text;

            if (numberDepartment == -1) MessageBox.Show("Bạn chưa chọn department để sửa");
            else
            {
                string thongbao = null;

                if(nameDepartment == "")
                {
                    string thongbaoname = "- Name department\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaoname;
                    else thongbao += thongbaoname;
                }
                if(locationsDepartment == "")
                {
                    string thongbaolocations = "- Locations department\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaolocations;
                    else thongbao += thongbaolocations;
                }
                if(ssnManagerNew == -1)
                {
                    string thongbaossn = "- Ssn manager\n";
                    if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaossn;
                    else thongbao += thongbaossn;
                }

                if (thongbao != null) MessageBox.Show(thongbao);
                else
                {
                    Department department = new Department(numberDepartment, null, null);
                    IObjectSet result = database.DB.QueryByExample(department);
                    department = (Department)result[0];

                    List<string> Locations = new List<string>();
                    string[] listLocations = locationsDepartment.Split(',');
                    for (int i = 0; i < listLocations.Length; ++i)
                    {
                        while (listLocations[i][0] == ' ') listLocations[i] = listLocations[i].Remove(0, 1);
                        while (listLocations[i][listLocations[i].Length - 1] == ' ') listLocations[i] = listLocations[i].Remove(listLocations[i].Length - 1, 1);

                        Locations.Add(listLocations[i]);
                    }

                    department.DName = nameDepartment;
                    department.Locations = Locations;
                    department.MgrStartDate = mgrStartDate;

                    if (ssnManagerOld == ssnManagerNew)
                    {
                        database.DB.Store(department);
                    }
                    else if(ssnManagerOld != ssnManagerNew)
                    {
                        if(ssnManagerOld == -1)
                        {
                            Employee managerNew = new Employee(ssnManagerNew, null, null, null, null, null, 0, null);
                            result = database.DB.QueryByExample(managerNew);
                            managerNew = (Employee)result[0];

                            managerNew.Manager = department;
                            department.Manager = managerNew;

                            database.DB.Store(managerNew);
                            database.DB.Store(department);
                        }
                        else if(ssnManagerOld != -1)
                        {
                            Employee managerNew = new Employee(ssnManagerNew, null, null, null, null, null, 0, null);
                            result = database.DB.QueryByExample(managerNew);
                            managerNew = (Employee)result[0];

                            Employee managerOld = new Employee(ssnManagerOld, null, null, null, null, null, 0, null);
                            result = database.DB.QueryByExample(managerOld);
                            managerOld = (Employee)result[0];

                            managerOld.Manager = null;
                            managerNew.Manager = department;
                            department.Manager = managerNew;

                            database.DB.Store(managerOld);
                            database.DB.Store(managerNew);
                            database.DB.Store(department);
                        }
                    }

                    result = database.result_Employee();
                    int count = 0;
                    string[] data_Temp = new string[result.Count];

                    for (int i = 0; i < result.Count; ++i)
                    {
                        Employee employee = (Employee)result[i];
                        if (employee.Manager != null)
                        {
                            string lineManager = employee.Manager.DNumber.ToString() + "," + employee.Ssn.ToString() + "," + employee.Manager.MgrStartDate;
                            data_Temp[count] = lineManager;
                            ++count;
                        }
                    }

                    string[] data_ManagerNew = new string[count + 1];
                    data_ManagerNew[0] = count.ToString();
                    for (int i = 0; i < count; ++i)
                    {
                        data_ManagerNew[i + 1] = data_Temp[i];
                    }

                    File.WriteAllLines("SetManager.txt", data_ManagerNew);

                    result = database.result_Department();
                    int countNew = result.Count;
                    string[] data_DepartmentNew = new string[countNew + 1];

                    data_DepartmentNew[0] = countNew.ToString();
                    for (int i = 0; i < countNew; ++i)
                    {
                        Department temp = (Department)result[i];
                        string lineDepartment = temp.DNumber.ToString() + ":" + temp.DName + ":";
                        for (int j = 0; j < temp.Locations.Count; ++j)
                        {
                            if (j == 0) lineDepartment += temp.Locations[j];
                            else lineDepartment += "," + temp.Locations[j];
                        }
                        data_DepartmentNew[i + 1] = lineDepartment;
                    }

                    File.WriteAllLines("data_Department.txt", data_DepartmentNew);

                    MessageBox.Show("Thêm thành công");

                    LoadData();
                }
            }
        }
        private void button_DeleteDepartment_Click(object sender, EventArgs e)
        {
            int numberDepartment = -1;
            if (textBox_NumberDepartment.Text != "") numberDepartment = int.Parse(textBox_NumberDepartment.Text);
            int ssnManager = -1;
            if (textBox_SsnManagerOld.Text != "") ssnManager = int.Parse(textBox_SsnManagerOld.Text);

            if (numberDepartment == -1 && ssnManager == -1) MessageBox.Show("Bạn chưa chọn department để xóa");
            else
            {
                Department department = new Department(numberDepartment, null, null);
                IObjectSet result = database.DB.QueryByExample(department);
                department = (Department)result[0];

                Employee manager = new Employee(ssnManager, null, null, null, null, null, 0, null);
                result = database.DB.QueryByExample(manager);
                manager = (Employee)result[0];

                manager.Manager = null;

                database.DB.Store(manager);
                database.DB.Delete(department);

                result = database.result_Employee();
                int count = 0;
                string[] data_Temp = new string[result.Count];

                for (int i = 0; i < result.Count; ++i)
                {
                    Employee employee = (Employee)result[i];
                    if (employee.Manager != null)
                    {
                        string lineManager = employee.Manager.DNumber.ToString() + "," + employee.Ssn.ToString() + "," + employee.Manager.MgrStartDate;
                        data_Temp[count] = lineManager;
                        ++count;
                    }
                }

                string[] data_ManagerNew = new string[count + 1];
                data_ManagerNew[0] = count.ToString();
                for (int i = 0; i < count; ++i)
                {
                    data_ManagerNew[i + 1] = data_Temp[i];
                }

                File.WriteAllLines("SetManager.txt", data_ManagerNew);

                result = database.result_Department();
                int countNew = result.Count;
                string[] data_DepartmentNew = new string[countNew + 1];

                data_DepartmentNew[0] = countNew.ToString();
                for (int i = 0; i < countNew; ++i)
                {
                    Department temp = (Department)result[i];
                    string lineDepartment = temp.DNumber.ToString() + ":" + temp.DName + ":";
                    for (int j = 0; j < temp.Locations.Count; ++j)
                    {
                        if (j == 0) lineDepartment += temp.Locations[j];
                        else lineDepartment += "," + temp.Locations[j];
                    }
                    data_DepartmentNew[i + 1] = lineDepartment;
                }

                File.WriteAllLines("data_Department.txt", data_DepartmentNew);

                MessageBox.Show("Xóa thành công");

                LoadData();
            }
        }

        private void button_AddWorksOn_Click(object sender, EventArgs e)
        {
            float hours = -1;
            if (textBox_HoursWorksOn.Text != "") hours = float.Parse(textBox_HoursWorksOn.Text);
            int ssnEmployee = -1;
            if (textBox_SsnEmployeeWorksOn.Text != "") ssnEmployee = int.Parse(textBox_SsnEmployeeWorksOn.Text);
            int numberProject = -1;
            if (textBox_NumberProjectWorksOn.Text != "") numberProject = int.Parse(textBox_NumberProjectWorksOn.Text);

            string thongbao = null;

            if(hours == -1)
            {
                string thongbaohours = "- Hours\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaohours;
                else thongbao += thongbaohours;
            }
            if (ssnEmployee == -1)
            {
                string thongbaossn = "- Employee\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaossn;
                else thongbao += thongbaossn;
            }
            if (numberProject == -1)
            {
                string thongbaonumber = "- Project\n";
                if (thongbao == null) thongbao = "Bạn chưa nhập:\n" + thongbaonumber;
                else thongbao += thongbaonumber;
            }

            if (thongbao != null) MessageBox.Show(thongbao);
            else
            {
                int check = 0;

                IObjectSet result = database.result_WorksOn();
                for (int i = 0; i < result.Count; ++i)
                {
                    WorksOn w = (WorksOn)result[i];
                    if (w.Employee.Ssn == ssnEmployee && w.Project.PNumber == numberProject)
                    {
                        check = 1;
                        break;
                    }
                }
                if (check == 1) MessageBox.Show("Employee và project bị trùng, vui lòng nhập lại");
                else
                {
                    Employee employee = new Employee(ssnEmployee, null, null, null, null, null, 0, null);
                    result = database.DB.QueryByExample(employee);
                    employee = (Employee)result[0];

                    Project project = new Project(numberProject, null, null);
                    result = database.DB.QueryByExample(project);
                    project = (Project)result[0];

                    WorksOn workson = new WorksOn(hours);
                    workson.Employee = employee;
                    workson.Project = project;

                    if (employee.WorksOn == null) employee.WorksOn = new List<WorksOn>();
                    employee.WorksOn.Add(workson);
                    if (project.WorksOn == null) project.WorksOn = new List<WorksOn>();
                    project.WorksOn.Add(workson);

                    database.DB.Store(workson);
                    database.DB.Store(employee);
                    database.DB.Store(project);

                    result = database.result_WorksOn();
                    int countNew = result.Count;
                    string[] data_WorksOn = new string[countNew + 1];

                    data_WorksOn[0] = countNew.ToString();
                    for(int i = 0; i < countNew; ++i)
                    {
                        WorksOn temp = (WorksOn)result[i];
                        data_WorksOn[i + 1] = temp.Employee.Ssn.ToString() + "," + temp.Project.PNumber.ToString() + "," + temp.Hours.ToString();
                    }

                    File.WriteAllLines("data_WorksOn.txt", data_WorksOn);

                    MessageBox.Show("Thêm thành công");

                    LoadData();
                }
            }
        }
        private void button_ModifyWorksOn_Click(object sender, EventArgs e)
        {
            float hours = -1;
            if (textBox_HoursWorksOn.Text != "") hours = float.Parse(textBox_HoursWorksOn.Text);
            int ssnEmployeeNew = -1;
            if (textBox_SsnEmployeeWorksOn.Text != "") ssnEmployeeNew = int.Parse(textBox_SsnEmployeeWorksOn.Text);
            int numberProjectNew = -1;
            if (textBox_NumberProjectWorksOn.Text != "") numberProjectNew = int.Parse(textBox_NumberProjectWorksOn.Text);
            int ssnEmployeeOld = -1;
            if (textBox_SsnEmployeeWorksOnOld.Text != "") ssnEmployeeOld = int.Parse(textBox_SsnEmployeeWorksOnOld.Text);
            int numberProjectOld = -1;
            if (textBox_NumberProjectWorksOnOld.Text != "") numberProjectOld = int.Parse(textBox_NumberProjectWorksOnOld.Text);

            if (hours == -1 || ssnEmployeeOld == -1 || numberProjectOld == -1) MessageBox.Show("Bạn chưa chọn WorksOn để sửa");
            else
            {
                int check = 0;
                if(ssnEmployeeOld != ssnEmployeeNew || numberProjectOld != numberProjectNew)
                {
                    IList<WorksOn> ck = database.DB.Query(delegate (WorksOn w) 
                    {
                        if (w.Employee.Ssn == ssnEmployeeNew && w.Project.PNumber == numberProjectNew) return true;
                        return false;
                    });
                    if (ck.Count != 0) check = 1;
                }

                if (check == 1) MessageBox.Show("Employee và project bị trùng, vui lòng nhập lại");
                else
                {
                    IList<WorksOn> r = database.DB.Query(delegate (WorksOn w)
                    {
                        if (w.Employee.Ssn == ssnEmployeeOld && w.Project.PNumber == numberProjectOld) return true;
                        return false;
                    });
                    WorksOn workson = (WorksOn)r[0];

                    Employee employeeNew = new Employee(ssnEmployeeNew, null, null, null, null, null, 0, null);
                    IObjectSet result = database.DB.QueryByExample(employeeNew);
                    employeeNew = (Employee)result[0];

                    Project projectNew = new Project(numberProjectNew, null, null);
                    result = database.DB.QueryByExample(projectNew);
                    projectNew = (Project)result[0];

                    workson.Hours = hours;
                    workson.Employee = employeeNew;
                    workson.Project = projectNew;

                    if (ssnEmployeeNew != ssnEmployeeOld)
                    {
                        Employee employeeOld = new Employee(ssnEmployeeOld, null, null, null, null, null, 0, null);
                        result = database.DB.QueryByExample(employeeOld);
                        employeeOld = (Employee)result[0];

                        employeeOld.WorksOn.Remove(workson);
                        if (employeeOld.WorksOn.Count == 0) employeeOld.WorksOn = null;
                        if (employeeNew.WorksOn == null) employeeNew.WorksOn = new List<WorksOn>();
                        employeeNew.WorksOn.Add(workson);

                        database.DB.Store(employeeOld);
                    }
                    if (numberProjectNew != numberProjectOld)
                    {
                        Project projectOld = new Project(numberProjectOld, null, null);
                        result = database.DB.QueryByExample(projectOld);
                        projectOld = (Project)result[0];

                        projectOld.WorksOn.Remove(workson);
                        if (projectOld.WorksOn.Count == 0) projectOld.WorksOn = null;
                        if (projectNew.WorksOn == null) projectNew.WorksOn = new List<WorksOn>();
                        projectNew.WorksOn.Add(workson);

                        database.DB.Store(projectOld);
                    }

                    database.DB.Store(workson);
                    database.DB.Store(employeeNew);
                    database.DB.Store(projectNew);

                    result = database.result_WorksOn();
                    int countNew = result.Count;
                    string[] data_WorksOn = new string[countNew + 1];

                    data_WorksOn[0] = countNew.ToString();
                    for (int i = 0; i < countNew; ++i)
                    {
                        WorksOn temp = (WorksOn)result[i];
                        data_WorksOn[i + 1] = temp.Employee.Ssn.ToString() + "," + temp.Project.PNumber.ToString() + "," + temp.Hours.ToString();
                    }

                    File.WriteAllLines("data_WorksOn.txt", data_WorksOn);

                    MessageBox.Show("Sửa thành công");

                    LoadData();
                }
            }
        }
        private void button_DeleteWorksOn_Click(object sender, EventArgs e)
        {
            float hours = -1;
            if (textBox_HoursWorksOn.Text != "") hours = float.Parse(textBox_HoursWorksOn.Text);
            int ssnEmployee = -1;
            if (textBox_SsnEmployeeWorksOnOld.Text != "") ssnEmployee = int.Parse(textBox_SsnEmployeeWorksOnOld.Text);
            int numberProject = -1;
            if (textBox_NumberProjectWorksOnOld.Text != "") numberProject = int.Parse(textBox_NumberProjectWorksOnOld.Text);

            if (hours == -1 || ssnEmployee == -1 || numberProject == -1) MessageBox.Show("Bạn chưa chọn WorksOn để xóa");
            else
            {
                IList<WorksOn> r = database.DB.Query(delegate(WorksOn w) 
                {
                    if (w.Employee.Ssn == ssnEmployee && w.Project.PNumber == numberProject) return true;
                    return false;
                });
                WorksOn workson = (WorksOn)r[0];

                Employee employee = new Employee(ssnEmployee, null, null, null, null, null, 0, null);
                IObjectSet result = database.DB.QueryByExample(employee);
                employee = (Employee)result[0];

                Project project = new Project(numberProject, null, null);
                result = database.DB.QueryByExample(project);
                project = (Project)result[0];

                employee.WorksOn.Remove(workson);
                if (employee.WorksOn.Count == 0) employee.WorksOn = null;
                project.WorksOn.Remove(workson);
                if (project.WorksOn.Count == 0) project.WorksOn = null;

                database.DB.Store(employee);
                database.DB.Store(project);
                database.DB.Delete(workson);

                result = database.result_WorksOn();
                int countNew = result.Count;
                string[] data_WorksOn = new string[countNew + 1];

                data_WorksOn[0] = countNew.ToString();
                for (int i = 0; i < countNew; ++i)
                {
                    WorksOn temp = (WorksOn)result[i];
                    data_WorksOn[i + 1] = temp.Employee.Ssn.ToString() + "," + temp.Project.PNumber.ToString() + "," + temp.Hours.ToString();
                }

                File.WriteAllLines("data_WorksOn.txt", data_WorksOn);

                MessageBox.Show("Xóa thành công");

                LoadData();
            }
        }

        private void button_SaveWorksFor_Click(object sender, EventArgs e)
        {
            int numberDepartment = -1;
            if (textBox_NumberDepartmentWorksFor.Text != "") numberDepartment = int.Parse(textBox_NumberDepartmentWorksFor.Text);

            if (numberDepartment == -1) MessageBox.Show("Bạn chưa chọn department");
            else
            {
                Department department = new Department(numberDepartment, null, null);
                IObjectSet result = database.DB.QueryByExample(department);
                department = (Department)result[0];

                department.Employees = new List<Employee>();

                if(dataGridView_EmployeesWorksFor.Rows.Count > 1)
                {
                    for(int i = 0; i < dataGridView_EmployeesWorksFor.Rows.Count - 1; ++i)
                    {
                        DataGridViewRow row = dataGridView_EmployeesWorksFor.Rows[i];
                        Employee employee = new Employee(int.Parse(row.Cells[0].Value.ToString()), null, null, null, null, null, 0, null);
                        result = database.DB.QueryByExample(employee);
                        employee = (Employee)result[0];

                        department.Employees.Add(employee);
                        employee.WorksFor = department;

                        database.DB.Store(employee);
                    }
                }

                database.DB.Store(department);

                result = database.result_Department();
                int count = 0;
                string[] data_Temp = new string[result.Count];

                for(int i = 0; i < result.Count; ++i)
                {
                    Department d = (Department)result[i];
                    if(d.Employees != null && d.Employees.Count != 0)
                    {
                        data_Temp[count] = d.DNumber.ToString() + ":";
                        for(int j = 0; j < d.Employees.Count; ++j)
                        {
                            Employee employee = d.Employees[j];
                            if (j == 0) data_Temp[count] += employee.Ssn.ToString();
                            else data_Temp[count] += "," + employee.Ssn.ToString();
                        }
                        ++count;
                    }
                }

                string[] data_WorksForNew = new string[count + 1];
                data_WorksForNew[0] = count.ToString();
                for(int i = 0; i < count; ++i)
                {
                    data_WorksForNew[i + 1] = data_Temp[i];
                }

                File.WriteAllLines("SetWorksFor.txt", data_WorksForNew);

                MessageBox.Show("Lưu thành công");

                LoadData();
            }
        }

        private void button_SaveSupervisor_Click(object sender, EventArgs e)
        {
            int ssnSupervisor = -1;
            if (textBox_SsnSupervisorSupervisor.Text != "") ssnSupervisor = int.Parse(textBox_SsnSupervisorSupervisor.Text);

            if (ssnSupervisor == -1) MessageBox.Show("Bạn chưa chọn supervisor");
            else
            {
                Employee supervisor = new Employee(ssnSupervisor, null, null, null, null, null, 0, null);
                IObjectSet result = database.DB.QueryByExample(supervisor);
                supervisor = (Employee)result[0];

                supervisor.Supervisees = new List<Employee>();

                if(dataGridView_SuperviseesSupervisor.Rows.Count > 1)
                {
                    for(int i = 0; i < dataGridView_SuperviseesSupervisor.Rows.Count - 1; ++i)
                    {
                        DataGridViewRow row = dataGridView_SuperviseesSupervisor.Rows[i];
                        Employee supervisees = new Employee(int.Parse(row.Cells[0].Value.ToString()), null, null, null, null, null, 0, null);
                        result = database.DB.QueryByExample(supervisees);
                        supervisees = (Employee)result[0];

                        supervisor.Supervisees.Add(supervisees);
                        supervisees.Supervisor = supervisor;

                        database.DB.Store(supervisees);
                    }
                }

                database.DB.Store(supervisor);

                result = database.result_Employee();
                int count = 0;
                string[] data_Temp = new string[result.Count];

                for(int i = 0; i < result.Count; ++i)
                {
                    Employee employee = (Employee)result[i];
                    if (employee.Supervisees == null || employee.Supervisees.Count == 0) continue;
                    else
                    {
                        data_Temp[count] = employee.Ssn.ToString() + ":";
                        for(int j = 0; j < employee.Supervisees.Count; ++j)
                        {
                            if (j == 0) data_Temp[count] += employee.Supervisees[j].Ssn.ToString();
                            else data_Temp[count] += "," + employee.Supervisees[j].Ssn.ToString();
                        }
                        ++count;
                    }
                }

                string[] data_SupervisorNew = new string[count + 1];
                data_SupervisorNew[0] = count.ToString();
                for(int i = 0; i < count; ++i)
                {
                    data_SupervisorNew[i + 1] = data_Temp[i];
                }

                File.WriteAllLines("SetSupervisors.txt", data_SupervisorNew);

                MessageBox.Show("Lưu thành công");

                LoadData();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CauTruyVan2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_CauTruyVan1_Click(object sender, EventArgs e)
        {

        }
    }
}