using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_CompanyManager
{
    public class Database
    {
        public string DbFileName { get; set; } // File name database

        public IObjectContainer DB;

        public void CloseDatabase()
        {
            DB.Close(); // Close database file
        }

        public Database()
        {
            DbFileName = "database.yap";
            DB = Db4oEmbedded.OpenFile(DbFileName); // Open database file
        }

        public void CreateDatabase()
        {
            // Read txt file and insert into database
            CreateEmployee("data_Employee.txt");
            CreateDependents("data_Dependent.txt");
            CreateProject("data_Project.txt");
            CreateDepartment("data_Department.txt");
            CreateWorksOn("data_WorksOn.txt");
            SetManager("SetManager.txt");
            SetControlledBy("SetControlledBy.txt");
            SetWorksFor("SetWorksFor.txt");
            SetSupervisors("SetSupervisors.txt");
        }

        public void CreateDependents(string fileName)
        {
            // Get Dependent data and delete
            IObjectSet result = null;
            Dependent dependent = new Dependent(null, null, null, null);
            result = DB.QueryByExample(dependent);
            int count = result.Count;

            for (int i = 0; i < count; ++i)
            {
                DB.Delete(result[i]);
            }

            // Read data from txt file
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open); // Open file
                StreamReader fin = new StreamReader(fs); // Initialize variable to read file
                int n = int.Parse(fin.ReadLine()); // Read first line to get size of Dependent

                for (int i = 0; i < n; ++i)
                {
                    string line = fin.ReadLine();
                    if (line != null)
                    {
                        string[] fields = line.Split(',');
                        int ssn_Employee = int.Parse(fields[0]);
                        string name = fields[1];
                        string gender = fields[2];
                        string birthdate = fields[3];
                        string relationship = fields[4];

                        Dependent d = new Dependent
                        {
                            Name = name,
                            Gender = gender,
                            BirthDate = birthdate,
                            Relationship = relationship,
                        };

                        // Find Employee with Ssn = ssn_Employee
                        // Condition: Employee data must be available in the database
                        Employee e = new Employee(ssn_Employee, null, null, null, null, null, 0, null);
                        IObjectSet result_Employee = DB.QueryByExample(e);
                        if (result_Employee.Count != 0)
                        {
                            Employee employee = (Employee)result_Employee[0];
                            d.DependentOf = employee;
                            if (employee.Dependents == null)
                            {
                                employee.Dependents = new List<Dependent>();
                                employee.Dependents.Add(d);
                            }
                            else
                            {
                                employee.Dependents.Add(d);
                            }

                            DB.Store(d);
                            DB.Store(employee);
                        }
                    }
                }
                fin.Close();
                fs.Close();
            }
        }

        public void CreateEmployee(string fileName)
        {
            // Get old Employee data and delete
            IObjectSet result = null;
            Employee employee = new Employee(0, null, null, null, null, null, 0, null);
            result = DB.QueryByExample(employee);
            int count = result.Count;

            for (int i = 0; i < count; ++i)
            {
                DB.Delete(result[i]);
            }

            // Read data from txt file
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open); // Open file
                StreamReader fin = new StreamReader(fs); // Initialize variable to read file
                int n = int.Parse(fin.ReadLine()); // Read first line to get size of Employee

                for (int i = 0; i < n; ++i)
                {
                    string line = fin.ReadLine();

                    if (line != null)
                    {
                        string[] fields = line.Split(':');

                        string fname = fields[0];
                        string minit = fields[1];
                        string lname = fields[2];
                        int ssn = int.Parse(fields[3]);
                        string bdate = fields[4];
                        string address = fields[5];
                        string gender = fields[6];
                        float salary = float.Parse(fields[7]);

                        Employee e = new Employee
                        {
                            Ssn = ssn,
                            FName = fname,
                            MInit = minit,
                            LName = lname,
                            Address = address,
                            BirthDate = bdate,
                            Salary = salary,
                            Gender = gender

                        };

                        DB.Store(e);
                    }
                }
                fin.Close();
                fs.Close();
            }
        }

        public void CreateProject(string fileName)
        {
            // Get old Project data and delete
            IObjectSet result = null;
            Project project = new Project(0, null, null);
            result = DB.QueryByExample(project);
            int count = result.Count;

            for (int i = 0; i < count; ++i)
            {
                DB.Delete(result[i]);
            }

            // Read data from txt file
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open); // Open file
                StreamReader fin = new StreamReader(fs); // Initialize variable to read file
                int n = int.Parse(fin.ReadLine()); // Read first line to get size of Project 

                for (int i = 0; i < n; ++i)
                {
                    string line = fin.ReadLine();

                    if (line != null)
                    {
                        string[] fields = line.Split(',');

                        int pnumber = int.Parse(fields[0]);
                        string pname = fields[1];
                        string location = fields[2];

                        Project p = new Project
                        {
                            PNumber = pnumber,
                            PName = pname,
                            Location = location

                        };

                        DB.Store(p);
                    }
                }
                fin.Close();
                fs.Close();
            }
        }
        public void CreateDepartment(string fileName)
        {
            // Get old Department data and delete
            IObjectSet result = null;
            Department department = new Department(0, null, null);
            result = DB.QueryByExample(department);
            int count = result.Count;

            for (int i = 0; i < count; ++i)
            {
                DB.Delete(result[i]);
            }

            // Read data from txt file
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open); // Open file
                StreamReader fin = new StreamReader(fs); // Initialize variable to read file
                int n = int.Parse(fin.ReadLine()); // Read first line to get size of Department  

                for (int i = 0; i < n; ++i)
                {
                    string line = fin.ReadLine();

                    if (line != null)
                    {
                        string[] fields = line.Split(':');

                        int dnumber = int.Parse(fields[0]);
                        string dname = fields[1];
                        string locations = fields[2];

                        List<string> list_Location = new List<string>();
                        string[] fields_Locations = locations.Split(',');
                        for (int j = 0; j < fields_Locations.Length; ++j)
                        {
                            list_Location.Add(fields_Locations[j]);
                        }

                        Department d = new Department
                        {
                            DNumber = dnumber,
                            DName = dname,
                            Locations = list_Location
                        };

                        DB.Store(d);
                    }
                }
                fin.Close();
                fs.Close();
            }
        }

        public void CreateWorksOn(string fileName)
        {
            // Get old WorksOn data and delete
            IObjectSet result = null;
            WorksOn worksOn = new WorksOn(0);
            result = DB.QueryByExample(worksOn);
            int count = result.Count;

            for (int i = 0; i < count; ++i)
            {
                DB.Delete(result[i]);
            }

            // Read data from txt file
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open); // Open file
                StreamReader fin = new StreamReader(fs); // Initialize variable to read file
                int n = int.Parse(fin.ReadLine()); // Read first line to get size of WorksOn

                for (int i = 0; i < n; ++i)
                {
                    string line = fin.ReadLine();

                    if (line != null)
                    {
                        string[] fields = line.Split(',');

                        int ssn_Employee = int.Parse(fields[0]);
                        int number_Project = int.Parse(fields[1]);
                        float hours = float.Parse(fields[2]);

                        WorksOn w = new WorksOn
                        {
                            Hours = hours
                        };

                        Employee e = null;
                        Project p = null;

                        // Find Employee with Ssn = ssn_Employee
                        // Condition: Employee data must be available in the database
                        Employee employee = new Employee(ssn_Employee, null, null, null, null, null, 0, null);
                        IObjectSet result_Employee = DB.QueryByExample(employee);
                        if (result_Employee.Count != 0)
                        {
                            e = (Employee)result_Employee[0];
                            w.Employee = e;
                        }

                        // Find Project with PNumber = number_Project
                        // Condition: Project data must be available in the database
                        Project project = new Project(number_Project, null, null);
                        IObjectSet result_Project = DB.QueryByExample(project);
                        if (result_Project.Count != 0)
                        {
                            p = (Project)result_Project[0];
                            w.Project = p;
                        }

                        if (e.WorksOn == null)
                        {
                            e.WorksOn = new List<WorksOn>();
                            e.WorksOn.Add(w);
                        }
                        else e.WorksOn.Add(w);

                        if (p.WorksOn == null)
                        {
                            p.WorksOn = new List<WorksOn>();
                            p.WorksOn.Add(w);
                        }
                        else p.WorksOn.Add(w);

                        DB.Store(e);
                        DB.Store(p);
                        DB.Store(w);
                    }
                }
                fin.Close();
                fs.Close();
            }
        }
        public IObjectSet result_Dependent()
        {
            Dependent d = new Dependent(null, null, null, null);
            IObjectSet result = DB.QueryByExample(d);
            return result;
        }
        public IObjectSet result_Employee()
        {
            Employee e = new Employee(0, null, null, null, null, null, 0, null);
            IObjectSet result = DB.QueryByExample(e);
            return result;
        }
        public IObjectSet result_Project()
        {
            Project p = new Project(0, null, null);
            IObjectSet result = DB.QueryByExample(p);
            return result;
        }
        public IObjectSet result_Department()
        {
            Department d = new Department(0, null, null);
            IObjectSet result = DB.QueryByExample(d);
            return result;
        }

        public IObjectSet result_WorksOn()
        {
            WorksOn w = new WorksOn(0);
            IObjectSet result = DB.QueryByExample(w);
            return result;
        }

        public void SetManager(string fileName)
        {
            // Read data from txt file
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open); // Open file
                StreamReader fin = new StreamReader(fs); // Initialize variable to read file
                int n = int.Parse(fin.ReadLine());

                for (int i = 0; i < n; ++i)
                {
                    string line = fin.ReadLine();

                    if (line != null)
                    {
                        string[] fields = line.Split(',');

                        int number_Department = int.Parse(fields[0]);
                        int ssn_Employee = int.Parse(fields[1]);
                        string mgrStartDate = fields[2];

                        Employee e = null;
                        Department d = null;

                        // Find Employee with Ssn = ssn_Employee
                        // Condition: Employee data must be available in the database
                        Employee employee = new Employee(ssn_Employee, null, null, null, null, null, 0, null);
                        IObjectSet result_Employee = DB.QueryByExample(employee);
                        if (result_Employee.Count != 0)
                        {
                            e = (Employee)result_Employee[0];
                        }

                        // Find Department with DNumber = number_Department
                        // Condition: Department data must be available in the database
                        Department department = new Department(number_Department, null, null);
                        IObjectSet result_Department = DB.QueryByExample(department);
                        if (result_Department.Count != 0)
                        {
                            d = (Department)result_Department[0];
                        }

                        // Set up Manager relationship (between Employee and Department)                        
                        if (e != null && d != null)
                        {
                            d.MgrStartDate = mgrStartDate;
                            d.Manager = e;
                            e.Manager = d;
                            DB.Store(d);
                            DB.Store(e);
                        }
                    }
                }
                fin.Close();
                fs.Close();
            }
        }

        public void SetControlledBy(string fileName)
        {
            // Read data from txt file
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open); // Open file
                StreamReader fin = new StreamReader(fs); // Initialize variable to read file
                int n = int.Parse(fin.ReadLine());

                for (int i = 0; i < n; ++i)
                {
                    string line = fin.ReadLine();

                    if (line != null)
                    {
                        string[] fields = line.Split(':');

                        int number_Department = int.Parse(fields[0]);
                        string list_NumberProject = fields[1];
                        string[] fields_NumberProject = list_NumberProject.Split(',');

                        Department d = null;
                        List<Project> Projects = new List<Project>();
                        Project p = null;

                        // Find Department with DNumber = number_Department
                        // Condition: Must have Department data in the database
                        Department department = new Department(number_Department, null, null);
                        IObjectSet result_Department = DB.QueryByExample(department);
                        if (result_Department.Count != 0)
                        {
                            d = (Department)result_Department[0];
                        }

                        for (int j = 0; j < fields_NumberProject.Length; ++j)
                        {
                            int number_Project = int.Parse(fields_NumberProject[j]);
                            Project project = new Project(number_Project, null, null);
                            IObjectSet result_Project = DB.QueryByExample(project);
                            if (result_Project.Count != 0 && d != null)
                            {
                                p = (Project)result_Project[0];
                                Projects.Add(p);
                                p.ControlledBy = d;
                                DB.Store(p);
                            }
                        }

                        if (Projects != null && d != null)
                        {
                            d.Projects = Projects;
                            DB.Store(d);
                        }
                    }
                }
                fin.Close();
                fs.Close();
            }
        }
        public void SetWorksFor(string fileName)
        {
            // Read data from txt file
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open); // Open file
                StreamReader fin = new StreamReader(fs); // Initialize variable to read file
                int n = int.Parse(fin.ReadLine());

                for (int i = 0; i < n; ++i)
                {
                    string line = fin.ReadLine();

                    if (line != null)
                    {
                        string[] fields = line.Split(':');

                        int number_Department = int.Parse(fields[0]);
                        string list_SsnEmployee = fields[1];
                        string[] fields_SsnEmployee = list_SsnEmployee.Split(',');

                        Department d = null;
                        List<Employee> Employees = new List<Employee>();
                        Employee p = null;

                        // Find Department with DNumber = number_Department
                        // Condition: Must have Department data in the database
                        Department department = new Department(number_Department, null, null);
                        IObjectSet result_Department = DB.QueryByExample(department);
                        if (result_Department.Count != 0)
                        {
                            d = (Department)result_Department[0];
                        }

                        for (int j = 0; j < fields_SsnEmployee.Length; ++j)
                        {
                            int number_Employee = int.Parse(fields_SsnEmployee[j]);
                            Employee employee = new Employee(number_Employee, null, null, null, null, null, 0, null);
                            IObjectSet result_Employee = DB.QueryByExample(employee);
                            if (result_Employee.Count != 0 && d != null)
                            {
                                p = (Employee)result_Employee[0];
                                Employees.Add(p);
                                p.WorksFor = d;
                                DB.Store(p);
                            }
                        }

                        if (Employees != null && d != null)
                        {
                            d.Employees = Employees;
                            DB.Store(d);
                        }
                    }
                }
                fin.Close();
                fs.Close();
            }
        }
        public void SetSupervisors(string fileName)
        {
            // Read data from txt file
            if (File.Exists(fileName))
            {
                FileStream fs = new FileStream(fileName, FileMode.Open); // Open file
                StreamReader fin = new StreamReader(fs); // Initialize variable to read file
                int n = int.Parse(fin.ReadLine());

                for (int i = 0; i < n; ++i)
                {
                    string line = fin.ReadLine();

                    if (line != null)
                    {
                        string[] fields = line.Split(':');

                        int ssn_Supervisor = int.Parse(fields[0]);
                        string[] listSsnSupervisees = fields[1].Split(',');

                        List<Employee> Supervisees = new List<Employee>();

                        Employee supervisor = new Employee(ssn_Supervisor, null, null, null, null, null, 0, null);
                        IObjectSet result = DB.QueryByExample(supervisor);
                        if (result.Count != 0)
                        {
                            supervisor = (Employee)result[0];
                            supervisor.Supervisees = new List<Employee>();

                            for (int j = 0; j < listSsnSupervisees.Length; ++j)
                            {
                                int ssn_Supervisees = int.Parse(listSsnSupervisees[j]);
                                Employee supervisees = new Employee(ssn_Supervisees, null, null, null, null, null, 0, null);
                                result = DB.QueryByExample(supervisees);
                                if (result.Count != 0)
                                {
                                    supervisees = (Employee)result[0];
                                    Supervisees.Add(supervisees);
                                    supervisees.Supervisor = supervisor;
                                    DB.Store(supervisees);
                                }
                            }

                            if (Supervisees.Count != 0)
                            {
                                supervisor.Supervisees = Supervisees;
                                DB.Store(supervisor);
                            }
                        }
                    }
                }
                fin.Close();
                fs.Close();
            }
        }
    }
}
