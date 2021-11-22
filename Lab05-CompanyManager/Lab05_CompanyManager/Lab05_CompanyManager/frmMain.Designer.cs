
namespace Lab05_CompanyManager
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Employee = new System.Windows.Forms.TabPage();
            this.comboBox_GenderEmployee = new System.Windows.Forms.ComboBox();
            this.button_Reset_Employee = new System.Windows.Forms.Button();
            this.button_DeleteEmployee = new System.Windows.Forms.Button();
            this.button_ModifyEmployee = new System.Windows.Forms.Button();
            this.button_AddEmployee = new System.Windows.Forms.Button();
            this.textBox_FNameEmployee = new System.Windows.Forms.TextBox();
            this.textBox_LNameEmployee = new System.Windows.Forms.TextBox();
            this.textBox_MInitEmployee = new System.Windows.Forms.TextBox();
            this.textBox_BirthDateEmployee = new System.Windows.Forms.TextBox();
            this.textBox_AddressEmployee = new System.Windows.Forms.TextBox();
            this.textBox_SalaryEmployee = new System.Windows.Forms.TextBox();
            this.textBox_SsnEmployee = new System.Windows.Forms.TextBox();
            this.label_GenderEmployee = new System.Windows.Forms.Label();
            this.label_SalaryEmployee = new System.Windows.Forms.Label();
            this.label_BirthDateEmployee = new System.Windows.Forms.Label();
            this.label_AddressEmployee = new System.Windows.Forms.Label();
            this.label_LNameEmployee = new System.Windows.Forms.Label();
            this.label_MInitEmployee = new System.Windows.Forms.Label();
            this.label_FNameEmployee = new System.Windows.Forms.Label();
            this.label_SsnEmployee = new System.Windows.Forms.Label();
            this.dataGridView_Employee = new System.Windows.Forms.DataGridView();
            this.ssn_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fname_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lname_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minit_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salary_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worksfor_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manager_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workson_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dependents_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisor_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisees_Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Dependent = new System.Windows.Forms.TabPage();
            this.comboBox_GenderDependent = new System.Windows.Forms.ComboBox();
            this.textBox_SsnDependentOfOld = new System.Windows.Forms.TextBox();
            this.textBox_RelationshipDependentOld = new System.Windows.Forms.TextBox();
            this.textBox_BirthDateDependentOld = new System.Windows.Forms.TextBox();
            this.textBox_NameDependentOld = new System.Windows.Forms.TextBox();
            this.textBox_GenderDependentOld = new System.Windows.Forms.TextBox();
            this.label_NameDependentOf = new System.Windows.Forms.Label();
            this.label_SsnDependentOf = new System.Windows.Forms.Label();
            this.textBox_NameDependentOf = new System.Windows.Forms.TextBox();
            this.dataGridView_DependentOf = new System.Windows.Forms.DataGridView();
            this.ssn_DependentOf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName_DependentOf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName_DependentOf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_RelationshipDependent = new System.Windows.Forms.ComboBox();
            this.button_Reset_Dependent = new System.Windows.Forms.Button();
            this.textBox_SsnDependentOf = new System.Windows.Forms.TextBox();
            this.label_DependentOf = new System.Windows.Forms.Label();
            this.button_DeleteDependent = new System.Windows.Forms.Button();
            this.button_ModifyDependent = new System.Windows.Forms.Button();
            this.button_AddDependent = new System.Windows.Forms.Button();
            this.textBox_BirthDateDependent = new System.Windows.Forms.TextBox();
            this.textBox_NameDependent = new System.Windows.Forms.TextBox();
            this.label_RelationshipDependent = new System.Windows.Forms.Label();
            this.label_BirthDateDependent = new System.Windows.Forms.Label();
            this.label_GenderDependent = new System.Windows.Forms.Label();
            this.label_NameDependent = new System.Windows.Forms.Label();
            this.dataGridView_Dependent = new System.Windows.Forms.DataGridView();
            this.name_Dependent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender_Dependent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate_Dependent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relationship_Dependent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dependentof_Denpedent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Project = new System.Windows.Forms.TabPage();
            this.comboBox_LocationProject = new System.Windows.Forms.ComboBox();
            this.textBox_NumberControlledByOld = new System.Windows.Forms.TextBox();
            this.label_controlledby_DepartmetProject = new System.Windows.Forms.Label();
            this.label_NumberControlledBy = new System.Windows.Forms.Label();
            this.label_NameControlledBy = new System.Windows.Forms.Label();
            this.textBox_NumberControlledBy = new System.Windows.Forms.TextBox();
            this.textBox_NameControlledBy = new System.Windows.Forms.TextBox();
            this.dataGridView_ControlledBy = new System.Windows.Forms.DataGridView();
            this.dnumber_DepartmentProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dname_DepartmentProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Reset_Project = new System.Windows.Forms.Button();
            this.button_DeleteProject = new System.Windows.Forms.Button();
            this.button_ModifyProject = new System.Windows.Forms.Button();
            this.button_AddProject = new System.Windows.Forms.Button();
            this.textBox_NameProject = new System.Windows.Forms.TextBox();
            this.textBox_NumberProject = new System.Windows.Forms.TextBox();
            this.label_LocationProject = new System.Windows.Forms.Label();
            this.label_NameProject = new System.Windows.Forms.Label();
            this.label_NumberProject = new System.Windows.Forms.Label();
            this.dataGridView_Project = new System.Windows.Forms.DataGridView();
            this.number_Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location_Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlledby_Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workson_Project = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Department = new System.Windows.Forms.TabPage();
            this.textBox_MgrStartDate = new System.Windows.Forms.TextBox();
            this.label_MgrStartDateManager = new System.Windows.Forms.Label();
            this.textBox_SsnManagerOld = new System.Windows.Forms.TextBox();
            this.label_NameManager = new System.Windows.Forms.Label();
            this.label_SsnManager = new System.Windows.Forms.Label();
            this.textBox_SsnManager = new System.Windows.Forms.TextBox();
            this.textBox_NameManager = new System.Windows.Forms.TextBox();
            this.dataGridView_Manager = new System.Windows.Forms.DataGridView();
            this.ssnManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameManager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Reset_Department = new System.Windows.Forms.Button();
            this.button_DeleteDepartment = new System.Windows.Forms.Button();
            this.button_ModifyDepartment = new System.Windows.Forms.Button();
            this.button_AddDepartment = new System.Windows.Forms.Button();
            this.textBox_LocationsDepartment = new System.Windows.Forms.TextBox();
            this.textBox_NameDepartment = new System.Windows.Forms.TextBox();
            this.textBox_NumberDepartment = new System.Windows.Forms.TextBox();
            this.label_LocationsDepartment = new System.Windows.Forms.Label();
            this.label_NameDepartment = new System.Windows.Forms.Label();
            this.label_NumberDepartment = new System.Windows.Forms.Label();
            this.dataGridView_Department = new System.Windows.Forms.DataGridView();
            this.number_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locations_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employees_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manager_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projects_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgrstartdate_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_WorksOn = new System.Windows.Forms.TabPage();
            this.button_DeleteWorksOn = new System.Windows.Forms.Button();
            this.button_ModifyWorksOn = new System.Windows.Forms.Button();
            this.button_AddWorksOn = new System.Windows.Forms.Button();
            this.label_NameProjectWorksOn = new System.Windows.Forms.Label();
            this.label_NumberProjectWorksOn = new System.Windows.Forms.Label();
            this.label_NameEmployeeWorksOn = new System.Windows.Forms.Label();
            this.label_SsnEmployeeWorksOn = new System.Windows.Forms.Label();
            this.label_HoursWorksOn = new System.Windows.Forms.Label();
            this.textBox_SsnEmployeeWorksOn = new System.Windows.Forms.TextBox();
            this.textBox_NameEmployeeWorksOn = new System.Windows.Forms.TextBox();
            this.textBox_NumberProjectWorksOn = new System.Windows.Forms.TextBox();
            this.textBox_NameProjectWorksOn = new System.Windows.Forms.TextBox();
            this.textBox_SsnEmployeeWorksOnOld = new System.Windows.Forms.TextBox();
            this.textBox_NumberProjectWorksOnOld = new System.Windows.Forms.TextBox();
            this.textBox_HoursWorksOn = new System.Windows.Forms.TextBox();
            this.button_Reset_WorksOn = new System.Windows.Forms.Button();
            this.dataGridView_EmployeeWorksOn = new System.Windows.Forms.DataGridView();
            this.ssnEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_ProjectWorksOn = new System.Windows.Forms.DataGridView();
            this.numberProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_WorksOn = new System.Windows.Forms.DataGridView();
            this.hours_WorksOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employee_WorksOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.project_WorksOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_WorksFor = new System.Windows.Forms.TabPage();
            this.label_ND2 = new System.Windows.Forms.Label();
            this.label_ND1 = new System.Windows.Forms.Label();
            this.button_SaveWorksFor = new System.Windows.Forms.Button();
            this.button_Reset_WorksFor = new System.Windows.Forms.Button();
            this.textBox_NumberDepartmentWorksFor = new System.Windows.Forms.TextBox();
            this.label_EmployeesWorksFor = new System.Windows.Forms.Label();
            this.label_DepartmentWorksFor = new System.Windows.Forms.Label();
            this.label_EmployeeWorksFor = new System.Windows.Forms.Label();
            this.dataGridView_EmployeeWorksFor = new System.Windows.Forms.DataGridView();
            this.ssnEmployeeWorksFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameEmployeeWorksFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameEmployeeWorksFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_EmployeesWorksFor = new System.Windows.Forms.DataGridView();
            this.ssnEmployeesWorksFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameEmployeesWorksFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameEmployeesWorksFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_DepartmentWorksFor = new System.Windows.Forms.DataGridView();
            this.numberDepartmentWorksFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDepartmentWorksFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Supervisor = new System.Windows.Forms.TabPage();
            this.label_ND4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_ND3 = new System.Windows.Forms.Label();
            this.button_SaveSupervisor = new System.Windows.Forms.Button();
            this.label_SupervisorSupervisor = new System.Windows.Forms.Label();
            this.label_EmployeesSupervisor = new System.Windows.Forms.Label();
            this.label_EmployeeSupervisor = new System.Windows.Forms.Label();
            this.textBox_SsnSupervisorSupervisor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView_SuperviseesSupervisor = new System.Windows.Forms.DataGridView();
            this.ssnSuperviseesSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameSuperviseesSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameSuperviseesSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_EmployeeSupervisor = new System.Windows.Forms.DataGridView();
            this.ssnEmployeeSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameEmployeeSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameEmployeeSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_SupervisorSupervisor = new System.Windows.Forms.DataGridView();
            this.ssnSupervisorSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameSupervisorSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameSupervisorSupervisor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_CauTruyVan1 = new System.Windows.Forms.TabPage();
            this.dataGridView_CauTruyVan1 = new System.Windows.Forms.DataGridView();
            this.ssnEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minitEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worksforEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worksonEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dependentsEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superviseesEmployee_CTV1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_CauTruyVan1 = new System.Windows.Forms.Label();
            this.tabPage_CauTruyVan2 = new System.Windows.Forms.TabPage();
            this.dataGridView_CauTruyVan2 = new System.Windows.Forms.DataGridView();
            this.ssnEmployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameEmployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameEmployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minitEmployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderEmployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressEmployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateEmployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryEmployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worksforEmployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerEmployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worksonEmployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dependentsEmployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorEMployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superviseesEmployee_CTV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_CauTruyVan2 = new System.Windows.Forms.Label();
            this.tabPage_CauTruyVan3 = new System.Windows.Forms.TabPage();
            this.dataGridView_CauTruyVan3 = new System.Windows.Forms.DataGridView();
            this.ssnEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minitEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worksforEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worksonEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dependentsEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superviseesEmployee_CTV3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_CauTruyVan3 = new System.Windows.Forms.Label();
            this.tabPage_CauTruyVan4 = new System.Windows.Forms.TabPage();
            this.dataGridView_CauTruyVan4 = new System.Windows.Forms.DataGridView();
            this.numberProject_CTV4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameProject_CTV4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationProject_CTV4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlledbyProject_CTV4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worksonProject_CTV4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_CauTruyVan4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_Employee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).BeginInit();
            this.tabPage_Dependent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DependentOf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dependent)).BeginInit();
            this.tabPage_Project.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ControlledBy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Project)).BeginInit();
            this.tabPage_Department.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Department)).BeginInit();
            this.tabPage_WorksOn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeWorksOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProjectWorksOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WorksOn)).BeginInit();
            this.tabPage_WorksFor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeWorksFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeesWorksFor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DepartmentWorksFor)).BeginInit();
            this.tabPage_Supervisor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SuperviseesSupervisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeSupervisor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SupervisorSupervisor)).BeginInit();
            this.tabPage_CauTruyVan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauTruyVan1)).BeginInit();
            this.tabPage_CauTruyVan2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauTruyVan2)).BeginInit();
            this.tabPage_CauTruyVan3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauTruyVan3)).BeginInit();
            this.tabPage_CauTruyVan4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauTruyVan4)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage_Employee);
            this.tabControl1.Controls.Add(this.tabPage_Dependent);
            this.tabControl1.Controls.Add(this.tabPage_Project);
            this.tabControl1.Controls.Add(this.tabPage_Department);
            this.tabControl1.Controls.Add(this.tabPage_WorksOn);
            this.tabControl1.Controls.Add(this.tabPage_WorksFor);
            this.tabControl1.Controls.Add(this.tabPage_Supervisor);
            this.tabControl1.Controls.Add(this.tabPage_CauTruyVan1);
            this.tabControl1.Controls.Add(this.tabPage_CauTruyVan2);
            this.tabControl1.Controls.Add(this.tabPage_CauTruyVan3);
            this.tabControl1.Controls.Add(this.tabPage_CauTruyVan4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1166, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Employee
            // 
            this.tabPage_Employee.Controls.Add(this.comboBox_GenderEmployee);
            this.tabPage_Employee.Controls.Add(this.button_Reset_Employee);
            this.tabPage_Employee.Controls.Add(this.button_DeleteEmployee);
            this.tabPage_Employee.Controls.Add(this.button_ModifyEmployee);
            this.tabPage_Employee.Controls.Add(this.button_AddEmployee);
            this.tabPage_Employee.Controls.Add(this.textBox_FNameEmployee);
            this.tabPage_Employee.Controls.Add(this.textBox_LNameEmployee);
            this.tabPage_Employee.Controls.Add(this.textBox_MInitEmployee);
            this.tabPage_Employee.Controls.Add(this.textBox_BirthDateEmployee);
            this.tabPage_Employee.Controls.Add(this.textBox_AddressEmployee);
            this.tabPage_Employee.Controls.Add(this.textBox_SalaryEmployee);
            this.tabPage_Employee.Controls.Add(this.textBox_SsnEmployee);
            this.tabPage_Employee.Controls.Add(this.label_GenderEmployee);
            this.tabPage_Employee.Controls.Add(this.label_SalaryEmployee);
            this.tabPage_Employee.Controls.Add(this.label_BirthDateEmployee);
            this.tabPage_Employee.Controls.Add(this.label_AddressEmployee);
            this.tabPage_Employee.Controls.Add(this.label_LNameEmployee);
            this.tabPage_Employee.Controls.Add(this.label_MInitEmployee);
            this.tabPage_Employee.Controls.Add(this.label_FNameEmployee);
            this.tabPage_Employee.Controls.Add(this.label_SsnEmployee);
            this.tabPage_Employee.Controls.Add(this.dataGridView_Employee);
            this.tabPage_Employee.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Employee.Name = "tabPage_Employee";
            this.tabPage_Employee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Employee.Size = new System.Drawing.Size(1158, 534);
            this.tabPage_Employee.TabIndex = 0;
            this.tabPage_Employee.Text = "Employee";
            this.tabPage_Employee.UseVisualStyleBackColor = true;
            // 
            // comboBox_GenderEmployee
            // 
            this.comboBox_GenderEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_GenderEmployee.FormattingEnabled = true;
            this.comboBox_GenderEmployee.Location = new System.Drawing.Point(8, 111);
            this.comboBox_GenderEmployee.Name = "comboBox_GenderEmployee";
            this.comboBox_GenderEmployee.Size = new System.Drawing.Size(121, 28);
            this.comboBox_GenderEmployee.TabIndex = 22;
            // 
            // button_Reset_Employee
            // 
            this.button_Reset_Employee.Location = new System.Drawing.Point(11, 502);
            this.button_Reset_Employee.Name = "button_Reset_Employee";
            this.button_Reset_Employee.Size = new System.Drawing.Size(48, 23);
            this.button_Reset_Employee.TabIndex = 21;
            this.button_Reset_Employee.Text = "Reset";
            this.button_Reset_Employee.UseVisualStyleBackColor = true;
            this.button_Reset_Employee.Click += new System.EventHandler(this.button_Reset_Employee_Click);
            // 
            // button_DeleteEmployee
            // 
            this.button_DeleteEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteEmployee.Location = new System.Drawing.Point(8, 364);
            this.button_DeleteEmployee.Name = "button_DeleteEmployee";
            this.button_DeleteEmployee.Size = new System.Drawing.Size(152, 32);
            this.button_DeleteEmployee.TabIndex = 19;
            this.button_DeleteEmployee.Text = "Delete Employee";
            this.button_DeleteEmployee.UseVisualStyleBackColor = true;
            this.button_DeleteEmployee.Click += new System.EventHandler(this.button_DeleteEmployee_Click);
            // 
            // button_ModifyEmployee
            // 
            this.button_ModifyEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ModifyEmployee.Location = new System.Drawing.Point(8, 326);
            this.button_ModifyEmployee.Name = "button_ModifyEmployee";
            this.button_ModifyEmployee.Size = new System.Drawing.Size(152, 32);
            this.button_ModifyEmployee.TabIndex = 18;
            this.button_ModifyEmployee.Text = "Modify Employee";
            this.button_ModifyEmployee.UseVisualStyleBackColor = true;
            this.button_ModifyEmployee.Click += new System.EventHandler(this.button_ModifyEmployee_Click);
            // 
            // button_AddEmployee
            // 
            this.button_AddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddEmployee.Location = new System.Drawing.Point(8, 288);
            this.button_AddEmployee.Name = "button_AddEmployee";
            this.button_AddEmployee.Size = new System.Drawing.Size(152, 32);
            this.button_AddEmployee.TabIndex = 17;
            this.button_AddEmployee.Text = "Add Employee";
            this.button_AddEmployee.UseVisualStyleBackColor = true;
            this.button_AddEmployee.Click += new System.EventHandler(this.button_AddEmployee_Click);
            // 
            // textBox_FNameEmployee
            // 
            this.textBox_FNameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FNameEmployee.Location = new System.Drawing.Point(136, 19);
            this.textBox_FNameEmployee.Name = "textBox_FNameEmployee";
            this.textBox_FNameEmployee.Size = new System.Drawing.Size(196, 27);
            this.textBox_FNameEmployee.TabIndex = 16;
            // 
            // textBox_LNameEmployee
            // 
            this.textBox_LNameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LNameEmployee.Location = new System.Drawing.Point(136, 64);
            this.textBox_LNameEmployee.Name = "textBox_LNameEmployee";
            this.textBox_LNameEmployee.Size = new System.Drawing.Size(196, 27);
            this.textBox_LNameEmployee.TabIndex = 15;
            // 
            // textBox_MInitEmployee
            // 
            this.textBox_MInitEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MInitEmployee.Location = new System.Drawing.Point(136, 111);
            this.textBox_MInitEmployee.Name = "textBox_MInitEmployee";
            this.textBox_MInitEmployee.Size = new System.Drawing.Size(100, 27);
            this.textBox_MInitEmployee.TabIndex = 13;
            // 
            // textBox_BirthDateEmployee
            // 
            this.textBox_BirthDateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BirthDateEmployee.Location = new System.Drawing.Point(8, 156);
            this.textBox_BirthDateEmployee.Name = "textBox_BirthDateEmployee";
            this.textBox_BirthDateEmployee.Size = new System.Drawing.Size(228, 27);
            this.textBox_BirthDateEmployee.TabIndex = 12;
            // 
            // textBox_AddressEmployee
            // 
            this.textBox_AddressEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_AddressEmployee.Location = new System.Drawing.Point(8, 201);
            this.textBox_AddressEmployee.Name = "textBox_AddressEmployee";
            this.textBox_AddressEmployee.Size = new System.Drawing.Size(324, 27);
            this.textBox_AddressEmployee.TabIndex = 11;
            // 
            // textBox_SalaryEmployee
            // 
            this.textBox_SalaryEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SalaryEmployee.Location = new System.Drawing.Point(8, 246);
            this.textBox_SalaryEmployee.Name = "textBox_SalaryEmployee";
            this.textBox_SalaryEmployee.Size = new System.Drawing.Size(228, 27);
            this.textBox_SalaryEmployee.TabIndex = 10;
            this.textBox_SalaryEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Salary_KeyPress);
            // 
            // textBox_SsnEmployee
            // 
            this.textBox_SsnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SsnEmployee.Location = new System.Drawing.Point(6, 19);
            this.textBox_SsnEmployee.Name = "textBox_SsnEmployee";
            this.textBox_SsnEmployee.Size = new System.Drawing.Size(124, 27);
            this.textBox_SsnEmployee.TabIndex = 9;
            this.textBox_SsnEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Ssn_KeyPress);
            // 
            // label_GenderEmployee
            // 
            this.label_GenderEmployee.AutoSize = true;
            this.label_GenderEmployee.Location = new System.Drawing.Point(8, 95);
            this.label_GenderEmployee.Name = "label_GenderEmployee";
            this.label_GenderEmployee.Size = new System.Drawing.Size(48, 15);
            this.label_GenderEmployee.TabIndex = 8;
            this.label_GenderEmployee.Text = "Gender";
            // 
            // label_SalaryEmployee
            // 
            this.label_SalaryEmployee.AutoSize = true;
            this.label_SalaryEmployee.Location = new System.Drawing.Point(8, 230);
            this.label_SalaryEmployee.Name = "label_SalaryEmployee";
            this.label_SalaryEmployee.Size = new System.Drawing.Size(41, 15);
            this.label_SalaryEmployee.TabIndex = 7;
            this.label_SalaryEmployee.Text = "Salary";
            // 
            // label_BirthDateEmployee
            // 
            this.label_BirthDateEmployee.AutoSize = true;
            this.label_BirthDateEmployee.Location = new System.Drawing.Point(8, 140);
            this.label_BirthDateEmployee.Name = "label_BirthDateEmployee";
            this.label_BirthDateEmployee.Size = new System.Drawing.Size(58, 15);
            this.label_BirthDateEmployee.TabIndex = 6;
            this.label_BirthDateEmployee.Text = "BirthDate";
            // 
            // label_AddressEmployee
            // 
            this.label_AddressEmployee.AutoSize = true;
            this.label_AddressEmployee.Location = new System.Drawing.Point(8, 185);
            this.label_AddressEmployee.Name = "label_AddressEmployee";
            this.label_AddressEmployee.Size = new System.Drawing.Size(51, 15);
            this.label_AddressEmployee.TabIndex = 5;
            this.label_AddressEmployee.Text = "Address";
            // 
            // label_LNameEmployee
            // 
            this.label_LNameEmployee.AutoSize = true;
            this.label_LNameEmployee.Location = new System.Drawing.Point(133, 48);
            this.label_LNameEmployee.Name = "label_LNameEmployee";
            this.label_LNameEmployee.Size = new System.Drawing.Size(65, 15);
            this.label_LNameEmployee.TabIndex = 4;
            this.label_LNameEmployee.Text = "Last name";
            // 
            // label_MInitEmployee
            // 
            this.label_MInitEmployee.AutoSize = true;
            this.label_MInitEmployee.Location = new System.Drawing.Point(137, 95);
            this.label_MInitEmployee.Name = "label_MInitEmployee";
            this.label_MInitEmployee.Size = new System.Drawing.Size(34, 15);
            this.label_MInitEmployee.TabIndex = 3;
            this.label_MInitEmployee.Text = "MInit";
            // 
            // label_FNameEmployee
            // 
            this.label_FNameEmployee.AutoSize = true;
            this.label_FNameEmployee.Location = new System.Drawing.Point(134, 3);
            this.label_FNameEmployee.Name = "label_FNameEmployee";
            this.label_FNameEmployee.Size = new System.Drawing.Size(65, 15);
            this.label_FNameEmployee.TabIndex = 2;
            this.label_FNameEmployee.Text = "First name";
            // 
            // label_SsnEmployee
            // 
            this.label_SsnEmployee.AutoSize = true;
            this.label_SsnEmployee.Location = new System.Drawing.Point(8, 3);
            this.label_SsnEmployee.Name = "label_SsnEmployee";
            this.label_SsnEmployee.Size = new System.Drawing.Size(28, 15);
            this.label_SsnEmployee.TabIndex = 1;
            this.label_SsnEmployee.Text = "Ssn";
            // 
            // dataGridView_Employee
            // 
            this.dataGridView_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssn_Employee,
            this.fname_Employee,
            this.lname_Employee,
            this.gender_Employee,
            this.minit_Employee,
            this.address_Employee,
            this.birthdate_Employee,
            this.salary_Employee,
            this.worksfor_Employee,
            this.manager_Employee,
            this.workson_Employee,
            this.dependents_Employee,
            this.supervisor_Employee,
            this.supervisees_Employee});
            this.dataGridView_Employee.Location = new System.Drawing.Point(338, 0);
            this.dataGridView_Employee.Name = "dataGridView_Employee";
            this.dataGridView_Employee.RowHeadersWidth = 43;
            this.dataGridView_Employee.Size = new System.Drawing.Size(895, 534);
            this.dataGridView_Employee.TabIndex = 0;
            this.dataGridView_Employee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Employee_CellClick);
            // 
            // ssn_Employee
            // 
            this.ssn_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ssn_Employee.DataPropertyName = "Ssn";
            this.ssn_Employee.HeaderText = "Ssn";
            this.ssn_Employee.Name = "ssn_Employee";
            this.ssn_Employee.Width = 53;
            // 
            // fname_Employee
            // 
            this.fname_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fname_Employee.DataPropertyName = "FName";
            this.fname_Employee.HeaderText = "First name";
            this.fname_Employee.Name = "fname_Employee";
            this.fname_Employee.Width = 90;
            // 
            // lname_Employee
            // 
            this.lname_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lname_Employee.DataPropertyName = "LName";
            this.lname_Employee.HeaderText = "Last name";
            this.lname_Employee.Name = "lname_Employee";
            this.lname_Employee.Width = 90;
            // 
            // gender_Employee
            // 
            this.gender_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.gender_Employee.DataPropertyName = "Gender";
            this.gender_Employee.HeaderText = "Gender";
            this.gender_Employee.Name = "gender_Employee";
            this.gender_Employee.Width = 73;
            // 
            // minit_Employee
            // 
            this.minit_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.minit_Employee.DataPropertyName = "MInit";
            this.minit_Employee.HeaderText = "MInit";
            this.minit_Employee.Name = "minit_Employee";
            this.minit_Employee.Width = 59;
            // 
            // address_Employee
            // 
            this.address_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.address_Employee.DataPropertyName = "Address";
            this.address_Employee.HeaderText = "Address";
            this.address_Employee.Name = "address_Employee";
            this.address_Employee.Width = 76;
            // 
            // birthdate_Employee
            // 
            this.birthdate_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.birthdate_Employee.DataPropertyName = "BirthDate";
            this.birthdate_Employee.HeaderText = "BirthDate";
            this.birthdate_Employee.Name = "birthdate_Employee";
            this.birthdate_Employee.Width = 83;
            // 
            // salary_Employee
            // 
            this.salary_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salary_Employee.DataPropertyName = "Salary";
            this.salary_Employee.HeaderText = "Salary";
            this.salary_Employee.Name = "salary_Employee";
            this.salary_Employee.Width = 66;
            // 
            // worksfor_Employee
            // 
            this.worksfor_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.worksfor_Employee.DataPropertyName = "WorksFor";
            this.worksfor_Employee.HeaderText = "WorksFor";
            this.worksfor_Employee.Name = "worksfor_Employee";
            this.worksfor_Employee.Width = 84;
            // 
            // manager_Employee
            // 
            this.manager_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.manager_Employee.DataPropertyName = "Manager";
            this.manager_Employee.HeaderText = "Manager";
            this.manager_Employee.Name = "manager_Employee";
            this.manager_Employee.Width = 82;
            // 
            // workson_Employee
            // 
            this.workson_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workson_Employee.DataPropertyName = "WorksOn";
            this.workson_Employee.HeaderText = "WorksOn";
            this.workson_Employee.MinimumWidth = 80;
            this.workson_Employee.Name = "workson_Employee";
            this.workson_Employee.Width = 82;
            // 
            // dependents_Employee
            // 
            this.dependents_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dependents_Employee.DataPropertyName = "Dependents";
            this.dependents_Employee.HeaderText = "Dependents";
            this.dependents_Employee.Name = "dependents_Employee";
            this.dependents_Employee.Width = 99;
            // 
            // supervisor_Employee
            // 
            this.supervisor_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.supervisor_Employee.DataPropertyName = "Supervisor";
            this.supervisor_Employee.HeaderText = "Supervisor";
            this.supervisor_Employee.Name = "supervisor_Employee";
            this.supervisor_Employee.Width = 90;
            // 
            // supervisees_Employee
            // 
            this.supervisees_Employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.supervisees_Employee.DataPropertyName = "supervisees";
            this.supervisees_Employee.HeaderText = "Supervisees";
            this.supervisees_Employee.Name = "supervisees_Employee";
            this.supervisees_Employee.Width = 99;
            // 
            // tabPage_Dependent
            // 
            this.tabPage_Dependent.Controls.Add(this.comboBox_GenderDependent);
            this.tabPage_Dependent.Controls.Add(this.textBox_SsnDependentOfOld);
            this.tabPage_Dependent.Controls.Add(this.textBox_RelationshipDependentOld);
            this.tabPage_Dependent.Controls.Add(this.textBox_BirthDateDependentOld);
            this.tabPage_Dependent.Controls.Add(this.textBox_NameDependentOld);
            this.tabPage_Dependent.Controls.Add(this.textBox_GenderDependentOld);
            this.tabPage_Dependent.Controls.Add(this.label_NameDependentOf);
            this.tabPage_Dependent.Controls.Add(this.label_SsnDependentOf);
            this.tabPage_Dependent.Controls.Add(this.textBox_NameDependentOf);
            this.tabPage_Dependent.Controls.Add(this.dataGridView_DependentOf);
            this.tabPage_Dependent.Controls.Add(this.comboBox_RelationshipDependent);
            this.tabPage_Dependent.Controls.Add(this.button_Reset_Dependent);
            this.tabPage_Dependent.Controls.Add(this.textBox_SsnDependentOf);
            this.tabPage_Dependent.Controls.Add(this.label_DependentOf);
            this.tabPage_Dependent.Controls.Add(this.button_DeleteDependent);
            this.tabPage_Dependent.Controls.Add(this.button_ModifyDependent);
            this.tabPage_Dependent.Controls.Add(this.button_AddDependent);
            this.tabPage_Dependent.Controls.Add(this.textBox_BirthDateDependent);
            this.tabPage_Dependent.Controls.Add(this.textBox_NameDependent);
            this.tabPage_Dependent.Controls.Add(this.label_RelationshipDependent);
            this.tabPage_Dependent.Controls.Add(this.label_BirthDateDependent);
            this.tabPage_Dependent.Controls.Add(this.label_GenderDependent);
            this.tabPage_Dependent.Controls.Add(this.label_NameDependent);
            this.tabPage_Dependent.Controls.Add(this.dataGridView_Dependent);
            this.tabPage_Dependent.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Dependent.Name = "tabPage_Dependent";
            this.tabPage_Dependent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Dependent.Size = new System.Drawing.Size(1158, 534);
            this.tabPage_Dependent.TabIndex = 1;
            this.tabPage_Dependent.Text = "Dependent";
            this.tabPage_Dependent.UseVisualStyleBackColor = true;
            // 
            // comboBox_GenderDependent
            // 
            this.comboBox_GenderDependent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_GenderDependent.FormattingEnabled = true;
            this.comboBox_GenderDependent.Location = new System.Drawing.Point(8, 62);
            this.comboBox_GenderDependent.Name = "comboBox_GenderDependent";
            this.comboBox_GenderDependent.Size = new System.Drawing.Size(121, 28);
            this.comboBox_GenderDependent.TabIndex = 35;
            // 
            // textBox_SsnDependentOfOld
            // 
            this.textBox_SsnDependentOfOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SsnDependentOfOld.Location = new System.Drawing.Point(413, 24);
            this.textBox_SsnDependentOfOld.Name = "textBox_SsnDependentOfOld";
            this.textBox_SsnDependentOfOld.ReadOnly = true;
            this.textBox_SsnDependentOfOld.Size = new System.Drawing.Size(128, 27);
            this.textBox_SsnDependentOfOld.TabIndex = 34;
            this.textBox_SsnDependentOfOld.Visible = false;
            // 
            // textBox_RelationshipDependentOld
            // 
            this.textBox_RelationshipDependentOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RelationshipDependentOld.Location = new System.Drawing.Point(8, 407);
            this.textBox_RelationshipDependentOld.Name = "textBox_RelationshipDependentOld";
            this.textBox_RelationshipDependentOld.ReadOnly = true;
            this.textBox_RelationshipDependentOld.Size = new System.Drawing.Size(88, 27);
            this.textBox_RelationshipDependentOld.TabIndex = 33;
            this.textBox_RelationshipDependentOld.Visible = false;
            // 
            // textBox_BirthDateDependentOld
            // 
            this.textBox_BirthDateDependentOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BirthDateDependentOld.Location = new System.Drawing.Point(8, 375);
            this.textBox_BirthDateDependentOld.Name = "textBox_BirthDateDependentOld";
            this.textBox_BirthDateDependentOld.ReadOnly = true;
            this.textBox_BirthDateDependentOld.Size = new System.Drawing.Size(88, 27);
            this.textBox_BirthDateDependentOld.TabIndex = 32;
            this.textBox_BirthDateDependentOld.Visible = false;
            // 
            // textBox_NameDependentOld
            // 
            this.textBox_NameDependentOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NameDependentOld.Location = new System.Drawing.Point(8, 311);
            this.textBox_NameDependentOld.Name = "textBox_NameDependentOld";
            this.textBox_NameDependentOld.ReadOnly = true;
            this.textBox_NameDependentOld.Size = new System.Drawing.Size(88, 27);
            this.textBox_NameDependentOld.TabIndex = 31;
            this.textBox_NameDependentOld.Visible = false;
            // 
            // textBox_GenderDependentOld
            // 
            this.textBox_GenderDependentOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GenderDependentOld.Location = new System.Drawing.Point(8, 343);
            this.textBox_GenderDependentOld.Name = "textBox_GenderDependentOld";
            this.textBox_GenderDependentOld.ReadOnly = true;
            this.textBox_GenderDependentOld.Size = new System.Drawing.Size(88, 27);
            this.textBox_GenderDependentOld.TabIndex = 30;
            this.textBox_GenderDependentOld.Visible = false;
            // 
            // label_NameDependentOf
            // 
            this.label_NameDependentOf.AutoSize = true;
            this.label_NameDependentOf.Location = new System.Drawing.Point(410, 61);
            this.label_NameDependentOf.Name = "label_NameDependentOf";
            this.label_NameDependentOf.Size = new System.Drawing.Size(41, 15);
            this.label_NameDependentOf.TabIndex = 27;
            this.label_NameDependentOf.Text = "Name";
            // 
            // label_SsnDependentOf
            // 
            this.label_SsnDependentOf.AutoSize = true;
            this.label_SsnDependentOf.Location = new System.Drawing.Point(276, 61);
            this.label_SsnDependentOf.Name = "label_SsnDependentOf";
            this.label_SsnDependentOf.Size = new System.Drawing.Size(28, 15);
            this.label_SsnDependentOf.TabIndex = 26;
            this.label_SsnDependentOf.Text = "Ssn";
            // 
            // textBox_NameDependentOf
            // 
            this.textBox_NameDependentOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NameDependentOf.Location = new System.Drawing.Point(413, 77);
            this.textBox_NameDependentOf.Name = "textBox_NameDependentOf";
            this.textBox_NameDependentOf.ReadOnly = true;
            this.textBox_NameDependentOf.Size = new System.Drawing.Size(229, 27);
            this.textBox_NameDependentOf.TabIndex = 25;
            // 
            // dataGridView_DependentOf
            // 
            this.dataGridView_DependentOf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DependentOf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssn_DependentOf,
            this.FName_DependentOf,
            this.LName_DependentOf});
            this.dataGridView_DependentOf.Location = new System.Drawing.Point(279, 109);
            this.dataGridView_DependentOf.Name = "dataGridView_DependentOf";
            this.dataGridView_DependentOf.RowHeadersWidth = 43;
            this.dataGridView_DependentOf.Size = new System.Drawing.Size(363, 425);
            this.dataGridView_DependentOf.TabIndex = 24;
            this.dataGridView_DependentOf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DependentOf_CellClick);
            // 
            // ssn_DependentOf
            // 
            this.ssn_DependentOf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ssn_DependentOf.DataPropertyName = "Ssn";
            this.ssn_DependentOf.HeaderText = "Ssn";
            this.ssn_DependentOf.Name = "ssn_DependentOf";
            this.ssn_DependentOf.Width = 53;
            // 
            // FName_DependentOf
            // 
            this.FName_DependentOf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FName_DependentOf.DataPropertyName = "FName";
            this.FName_DependentOf.HeaderText = "First name";
            this.FName_DependentOf.Name = "FName_DependentOf";
            // 
            // LName_DependentOf
            // 
            this.LName_DependentOf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LName_DependentOf.DataPropertyName = "LName";
            this.LName_DependentOf.HeaderText = "Last name";
            this.LName_DependentOf.Name = "LName_DependentOf";
            // 
            // comboBox_RelationshipDependent
            // 
            this.comboBox_RelationshipDependent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_RelationshipDependent.FormattingEnabled = true;
            this.comboBox_RelationshipDependent.Location = new System.Drawing.Point(8, 152);
            this.comboBox_RelationshipDependent.Name = "comboBox_RelationshipDependent";
            this.comboBox_RelationshipDependent.Size = new System.Drawing.Size(194, 28);
            this.comboBox_RelationshipDependent.TabIndex = 23;
            // 
            // button_Reset_Dependent
            // 
            this.button_Reset_Dependent.Location = new System.Drawing.Point(11, 502);
            this.button_Reset_Dependent.Name = "button_Reset_Dependent";
            this.button_Reset_Dependent.Size = new System.Drawing.Size(48, 23);
            this.button_Reset_Dependent.TabIndex = 22;
            this.button_Reset_Dependent.Text = "Reset";
            this.button_Reset_Dependent.UseVisualStyleBackColor = true;
            this.button_Reset_Dependent.Click += new System.EventHandler(this.button_Reset_Dependent_Click);
            // 
            // textBox_SsnDependentOf
            // 
            this.textBox_SsnDependentOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SsnDependentOf.Location = new System.Drawing.Point(279, 77);
            this.textBox_SsnDependentOf.Name = "textBox_SsnDependentOf";
            this.textBox_SsnDependentOf.ReadOnly = true;
            this.textBox_SsnDependentOf.Size = new System.Drawing.Size(128, 27);
            this.textBox_SsnDependentOf.TabIndex = 13;
            // 
            // label_DependentOf
            // 
            this.label_DependentOf.AutoSize = true;
            this.label_DependentOf.Location = new System.Drawing.Point(276, 32);
            this.label_DependentOf.Name = "label_DependentOf";
            this.label_DependentOf.Size = new System.Drawing.Size(80, 15);
            this.label_DependentOf.TabIndex = 12;
            this.label_DependentOf.Text = "DependentOf";
            // 
            // button_DeleteDependent
            // 
            this.button_DeleteDependent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteDependent.Location = new System.Drawing.Point(8, 273);
            this.button_DeleteDependent.Name = "button_DeleteDependent";
            this.button_DeleteDependent.Size = new System.Drawing.Size(194, 32);
            this.button_DeleteDependent.TabIndex = 11;
            this.button_DeleteDependent.Text = "Delete Dependent";
            this.button_DeleteDependent.UseVisualStyleBackColor = true;
            this.button_DeleteDependent.Click += new System.EventHandler(this.button_DeleteDependent_Click);
            // 
            // button_ModifyDependent
            // 
            this.button_ModifyDependent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ModifyDependent.Location = new System.Drawing.Point(8, 235);
            this.button_ModifyDependent.Name = "button_ModifyDependent";
            this.button_ModifyDependent.Size = new System.Drawing.Size(194, 32);
            this.button_ModifyDependent.TabIndex = 10;
            this.button_ModifyDependent.Text = "Modify Dependent";
            this.button_ModifyDependent.UseVisualStyleBackColor = true;
            this.button_ModifyDependent.Click += new System.EventHandler(this.button_ModifyDependent_Click);
            // 
            // button_AddDependent
            // 
            this.button_AddDependent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddDependent.Location = new System.Drawing.Point(8, 197);
            this.button_AddDependent.Name = "button_AddDependent";
            this.button_AddDependent.Size = new System.Drawing.Size(194, 32);
            this.button_AddDependent.TabIndex = 9;
            this.button_AddDependent.Text = "Add Dependent";
            this.button_AddDependent.UseVisualStyleBackColor = true;
            this.button_AddDependent.Click += new System.EventHandler(this.button_AddDependent_Click);
            // 
            // textBox_BirthDateDependent
            // 
            this.textBox_BirthDateDependent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BirthDateDependent.Location = new System.Drawing.Point(8, 109);
            this.textBox_BirthDateDependent.Name = "textBox_BirthDateDependent";
            this.textBox_BirthDateDependent.Size = new System.Drawing.Size(221, 27);
            this.textBox_BirthDateDependent.TabIndex = 7;
            // 
            // textBox_NameDependent
            // 
            this.textBox_NameDependent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NameDependent.Location = new System.Drawing.Point(8, 19);
            this.textBox_NameDependent.Name = "textBox_NameDependent";
            this.textBox_NameDependent.Size = new System.Drawing.Size(221, 27);
            this.textBox_NameDependent.TabIndex = 5;
            // 
            // label_RelationshipDependent
            // 
            this.label_RelationshipDependent.AutoSize = true;
            this.label_RelationshipDependent.Location = new System.Drawing.Point(8, 138);
            this.label_RelationshipDependent.Name = "label_RelationshipDependent";
            this.label_RelationshipDependent.Size = new System.Drawing.Size(76, 15);
            this.label_RelationshipDependent.TabIndex = 4;
            this.label_RelationshipDependent.Text = "Relationship";
            // 
            // label_BirthDateDependent
            // 
            this.label_BirthDateDependent.AutoSize = true;
            this.label_BirthDateDependent.Location = new System.Drawing.Point(8, 93);
            this.label_BirthDateDependent.Name = "label_BirthDateDependent";
            this.label_BirthDateDependent.Size = new System.Drawing.Size(58, 15);
            this.label_BirthDateDependent.TabIndex = 3;
            this.label_BirthDateDependent.Text = "BirthDate";
            // 
            // label_GenderDependent
            // 
            this.label_GenderDependent.AutoSize = true;
            this.label_GenderDependent.Location = new System.Drawing.Point(8, 48);
            this.label_GenderDependent.Name = "label_GenderDependent";
            this.label_GenderDependent.Size = new System.Drawing.Size(48, 15);
            this.label_GenderDependent.TabIndex = 2;
            this.label_GenderDependent.Text = "Gender";
            // 
            // label_NameDependent
            // 
            this.label_NameDependent.AutoSize = true;
            this.label_NameDependent.Location = new System.Drawing.Point(8, 3);
            this.label_NameDependent.Name = "label_NameDependent";
            this.label_NameDependent.Size = new System.Drawing.Size(41, 15);
            this.label_NameDependent.TabIndex = 1;
            this.label_NameDependent.Text = "Name";
            // 
            // dataGridView_Dependent
            // 
            this.dataGridView_Dependent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Dependent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name_Dependent,
            this.gender_Dependent,
            this.birthdate_Dependent,
            this.relationship_Dependent,
            this.dependentof_Denpedent});
            this.dataGridView_Dependent.Location = new System.Drawing.Point(648, 0);
            this.dataGridView_Dependent.Name = "dataGridView_Dependent";
            this.dataGridView_Dependent.RowHeadersWidth = 43;
            this.dataGridView_Dependent.Size = new System.Drawing.Size(510, 534);
            this.dataGridView_Dependent.TabIndex = 0;
            this.dataGridView_Dependent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Dependent_CellClick);
            // 
            // name_Dependent
            // 
            this.name_Dependent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name_Dependent.DataPropertyName = "Name";
            this.name_Dependent.HeaderText = "Name";
            this.name_Dependent.Name = "name_Dependent";
            // 
            // gender_Dependent
            // 
            this.gender_Dependent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gender_Dependent.DataPropertyName = "Gender";
            this.gender_Dependent.HeaderText = "Gender";
            this.gender_Dependent.Name = "gender_Dependent";
            // 
            // birthdate_Dependent
            // 
            this.birthdate_Dependent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birthdate_Dependent.DataPropertyName = "BirthDate";
            this.birthdate_Dependent.HeaderText = "BirthDate";
            this.birthdate_Dependent.Name = "birthdate_Dependent";
            // 
            // relationship_Dependent
            // 
            this.relationship_Dependent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.relationship_Dependent.DataPropertyName = "Relationship";
            this.relationship_Dependent.HeaderText = "Relationship";
            this.relationship_Dependent.Name = "relationship_Dependent";
            // 
            // dependentof_Denpedent
            // 
            this.dependentof_Denpedent.DataPropertyName = "DependentOf";
            this.dependentof_Denpedent.HeaderText = "DepedentOf";
            this.dependentof_Denpedent.Name = "dependentof_Denpedent";
            this.dependentof_Denpedent.Width = 105;
            // 
            // tabPage_Project
            // 
            this.tabPage_Project.Controls.Add(this.comboBox_LocationProject);
            this.tabPage_Project.Controls.Add(this.textBox_NumberControlledByOld);
            this.tabPage_Project.Controls.Add(this.label_controlledby_DepartmetProject);
            this.tabPage_Project.Controls.Add(this.label_NumberControlledBy);
            this.tabPage_Project.Controls.Add(this.label_NameControlledBy);
            this.tabPage_Project.Controls.Add(this.textBox_NumberControlledBy);
            this.tabPage_Project.Controls.Add(this.textBox_NameControlledBy);
            this.tabPage_Project.Controls.Add(this.dataGridView_ControlledBy);
            this.tabPage_Project.Controls.Add(this.button_Reset_Project);
            this.tabPage_Project.Controls.Add(this.button_DeleteProject);
            this.tabPage_Project.Controls.Add(this.button_ModifyProject);
            this.tabPage_Project.Controls.Add(this.button_AddProject);
            this.tabPage_Project.Controls.Add(this.textBox_NameProject);
            this.tabPage_Project.Controls.Add(this.textBox_NumberProject);
            this.tabPage_Project.Controls.Add(this.label_LocationProject);
            this.tabPage_Project.Controls.Add(this.label_NameProject);
            this.tabPage_Project.Controls.Add(this.label_NumberProject);
            this.tabPage_Project.Controls.Add(this.dataGridView_Project);
            this.tabPage_Project.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Project.Name = "tabPage_Project";
            this.tabPage_Project.Size = new System.Drawing.Size(1158, 534);
            this.tabPage_Project.TabIndex = 2;
            this.tabPage_Project.Text = "Project";
            this.tabPage_Project.UseVisualStyleBackColor = true;
            // 
            // comboBox_LocationProject
            // 
            this.comboBox_LocationProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_LocationProject.FormattingEnabled = true;
            this.comboBox_LocationProject.Location = new System.Drawing.Point(8, 115);
            this.comboBox_LocationProject.Name = "comboBox_LocationProject";
            this.comboBox_LocationProject.Size = new System.Drawing.Size(235, 28);
            this.comboBox_LocationProject.TabIndex = 35;
            // 
            // textBox_NumberControlledByOld
            // 
            this.textBox_NumberControlledByOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumberControlledByOld.Location = new System.Drawing.Point(454, 17);
            this.textBox_NumberControlledByOld.Name = "textBox_NumberControlledByOld";
            this.textBox_NumberControlledByOld.ReadOnly = true;
            this.textBox_NumberControlledByOld.Size = new System.Drawing.Size(85, 27);
            this.textBox_NumberControlledByOld.TabIndex = 34;
            this.textBox_NumberControlledByOld.Visible = false;
            // 
            // label_controlledby_DepartmetProject
            // 
            this.label_controlledby_DepartmetProject.AutoSize = true;
            this.label_controlledby_DepartmetProject.Location = new System.Drawing.Point(360, 25);
            this.label_controlledby_DepartmetProject.Name = "label_controlledby_DepartmetProject";
            this.label_controlledby_DepartmetProject.Size = new System.Drawing.Size(79, 15);
            this.label_controlledby_DepartmetProject.TabIndex = 29;
            this.label_controlledby_DepartmetProject.Text = "Controlled By";
            // 
            // label_NumberControlledBy
            // 
            this.label_NumberControlledBy.AutoSize = true;
            this.label_NumberControlledBy.Location = new System.Drawing.Point(360, 51);
            this.label_NumberControlledBy.Name = "label_NumberControlledBy";
            this.label_NumberControlledBy.Size = new System.Drawing.Size(52, 15);
            this.label_NumberControlledBy.TabIndex = 28;
            this.label_NumberControlledBy.Text = "Number";
            // 
            // label_NameControlledBy
            // 
            this.label_NameControlledBy.AutoSize = true;
            this.label_NameControlledBy.Location = new System.Drawing.Point(451, 51);
            this.label_NameControlledBy.Name = "label_NameControlledBy";
            this.label_NameControlledBy.Size = new System.Drawing.Size(41, 15);
            this.label_NameControlledBy.TabIndex = 27;
            this.label_NameControlledBy.Text = "Name";
            // 
            // textBox_NumberControlledBy
            // 
            this.textBox_NumberControlledBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumberControlledBy.Location = new System.Drawing.Point(363, 67);
            this.textBox_NumberControlledBy.Name = "textBox_NumberControlledBy";
            this.textBox_NumberControlledBy.ReadOnly = true;
            this.textBox_NumberControlledBy.Size = new System.Drawing.Size(85, 27);
            this.textBox_NumberControlledBy.TabIndex = 26;
            // 
            // textBox_NameControlledBy
            // 
            this.textBox_NameControlledBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NameControlledBy.Location = new System.Drawing.Point(454, 67);
            this.textBox_NameControlledBy.Name = "textBox_NameControlledBy";
            this.textBox_NameControlledBy.ReadOnly = true;
            this.textBox_NameControlledBy.Size = new System.Drawing.Size(185, 27);
            this.textBox_NameControlledBy.TabIndex = 25;
            // 
            // dataGridView_ControlledBy
            // 
            this.dataGridView_ControlledBy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ControlledBy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dnumber_DepartmentProject,
            this.dname_DepartmentProject});
            this.dataGridView_ControlledBy.Location = new System.Drawing.Point(363, 99);
            this.dataGridView_ControlledBy.Name = "dataGridView_ControlledBy";
            this.dataGridView_ControlledBy.RowHeadersWidth = 43;
            this.dataGridView_ControlledBy.Size = new System.Drawing.Size(276, 435);
            this.dataGridView_ControlledBy.TabIndex = 24;
            this.dataGridView_ControlledBy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ControlledBy_CellClick);
            // 
            // dnumber_DepartmentProject
            // 
            this.dnumber_DepartmentProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dnumber_DepartmentProject.DataPropertyName = "DNumber";
            this.dnumber_DepartmentProject.HeaderText = "DNumber";
            this.dnumber_DepartmentProject.Name = "dnumber_DepartmentProject";
            this.dnumber_DepartmentProject.Width = 86;
            // 
            // dname_DepartmentProject
            // 
            this.dname_DepartmentProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dname_DepartmentProject.DataPropertyName = "DName";
            this.dname_DepartmentProject.HeaderText = "DName";
            this.dname_DepartmentProject.Name = "dname_DepartmentProject";
            // 
            // button_Reset_Project
            // 
            this.button_Reset_Project.Location = new System.Drawing.Point(11, 502);
            this.button_Reset_Project.Name = "button_Reset_Project";
            this.button_Reset_Project.Size = new System.Drawing.Size(48, 23);
            this.button_Reset_Project.TabIndex = 23;
            this.button_Reset_Project.Text = "Reset";
            this.button_Reset_Project.UseVisualStyleBackColor = true;
            this.button_Reset_Project.Click += new System.EventHandler(this.button_Reset_Project_Click);
            // 
            // button_DeleteProject
            // 
            this.button_DeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteProject.Location = new System.Drawing.Point(8, 244);
            this.button_DeleteProject.Name = "button_DeleteProject";
            this.button_DeleteProject.Size = new System.Drawing.Size(198, 36);
            this.button_DeleteProject.TabIndex = 9;
            this.button_DeleteProject.Text = "Delete Project";
            this.button_DeleteProject.UseVisualStyleBackColor = true;
            this.button_DeleteProject.Click += new System.EventHandler(this.button_DeleteProject_Click);
            // 
            // button_ModifyProject
            // 
            this.button_ModifyProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ModifyProject.Location = new System.Drawing.Point(8, 202);
            this.button_ModifyProject.Name = "button_ModifyProject";
            this.button_ModifyProject.Size = new System.Drawing.Size(198, 36);
            this.button_ModifyProject.TabIndex = 8;
            this.button_ModifyProject.Text = "Modify Project";
            this.button_ModifyProject.UseVisualStyleBackColor = true;
            this.button_ModifyProject.Click += new System.EventHandler(this.button_ModifyProject_Click);
            // 
            // button_AddProject
            // 
            this.button_AddProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddProject.Location = new System.Drawing.Point(8, 160);
            this.button_AddProject.Name = "button_AddProject";
            this.button_AddProject.Size = new System.Drawing.Size(198, 36);
            this.button_AddProject.TabIndex = 7;
            this.button_AddProject.Text = "Add Project";
            this.button_AddProject.UseVisualStyleBackColor = true;
            this.button_AddProject.Click += new System.EventHandler(this.button_AddProject_Click);
            // 
            // textBox_NameProject
            // 
            this.textBox_NameProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NameProject.Location = new System.Drawing.Point(8, 70);
            this.textBox_NameProject.Name = "textBox_NameProject";
            this.textBox_NameProject.Size = new System.Drawing.Size(235, 27);
            this.textBox_NameProject.TabIndex = 5;
            // 
            // textBox_NumberProject
            // 
            this.textBox_NumberProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumberProject.Location = new System.Drawing.Point(8, 25);
            this.textBox_NumberProject.Name = "textBox_NumberProject";
            this.textBox_NumberProject.Size = new System.Drawing.Size(111, 27);
            this.textBox_NumberProject.TabIndex = 4;
            this.textBox_NumberProject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_PNumberProject_KeyPress);
            // 
            // label_LocationProject
            // 
            this.label_LocationProject.AutoSize = true;
            this.label_LocationProject.Location = new System.Drawing.Point(8, 99);
            this.label_LocationProject.Name = "label_LocationProject";
            this.label_LocationProject.Size = new System.Drawing.Size(54, 15);
            this.label_LocationProject.TabIndex = 3;
            this.label_LocationProject.Text = "Location";
            // 
            // label_NameProject
            // 
            this.label_NameProject.AutoSize = true;
            this.label_NameProject.Location = new System.Drawing.Point(8, 54);
            this.label_NameProject.Name = "label_NameProject";
            this.label_NameProject.Size = new System.Drawing.Size(41, 15);
            this.label_NameProject.TabIndex = 2;
            this.label_NameProject.Text = "Name";
            // 
            // label_NumberProject
            // 
            this.label_NumberProject.AutoSize = true;
            this.label_NumberProject.Location = new System.Drawing.Point(8, 9);
            this.label_NumberProject.Name = "label_NumberProject";
            this.label_NumberProject.Size = new System.Drawing.Size(52, 15);
            this.label_NumberProject.TabIndex = 1;
            this.label_NumberProject.Text = "Number";
            // 
            // dataGridView_Project
            // 
            this.dataGridView_Project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Project.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number_Project,
            this.name_Project,
            this.location_Project,
            this.controlledby_Project,
            this.workson_Project});
            this.dataGridView_Project.Location = new System.Drawing.Point(654, 0);
            this.dataGridView_Project.Name = "dataGridView_Project";
            this.dataGridView_Project.RowHeadersWidth = 43;
            this.dataGridView_Project.Size = new System.Drawing.Size(504, 534);
            this.dataGridView_Project.TabIndex = 0;
            this.dataGridView_Project.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Project_CellClick);
            // 
            // number_Project
            // 
            this.number_Project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.number_Project.DataPropertyName = "PNumber";
            this.number_Project.HeaderText = "Number";
            this.number_Project.Name = "number_Project";
            this.number_Project.Width = 77;
            // 
            // name_Project
            // 
            this.name_Project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name_Project.DataPropertyName = "PName";
            this.name_Project.HeaderText = "Name";
            this.name_Project.Name = "name_Project";
            this.name_Project.Width = 66;
            // 
            // location_Project
            // 
            this.location_Project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.location_Project.DataPropertyName = "Location";
            this.location_Project.HeaderText = "Location";
            this.location_Project.Name = "location_Project";
            this.location_Project.Width = 79;
            // 
            // controlledby_Project
            // 
            this.controlledby_Project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.controlledby_Project.DataPropertyName = "ControlledBy";
            this.controlledby_Project.HeaderText = "ControlledBy";
            this.controlledby_Project.Name = "controlledby_Project";
            this.controlledby_Project.Width = 101;
            // 
            // workson_Project
            // 
            this.workson_Project.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.workson_Project.DataPropertyName = "WorksOn";
            this.workson_Project.HeaderText = "WorksOn";
            this.workson_Project.Name = "workson_Project";
            this.workson_Project.Width = 82;
            // 
            // tabPage_Department
            // 
            this.tabPage_Department.Controls.Add(this.textBox_MgrStartDate);
            this.tabPage_Department.Controls.Add(this.label_MgrStartDateManager);
            this.tabPage_Department.Controls.Add(this.textBox_SsnManagerOld);
            this.tabPage_Department.Controls.Add(this.label_NameManager);
            this.tabPage_Department.Controls.Add(this.label_SsnManager);
            this.tabPage_Department.Controls.Add(this.textBox_SsnManager);
            this.tabPage_Department.Controls.Add(this.textBox_NameManager);
            this.tabPage_Department.Controls.Add(this.dataGridView_Manager);
            this.tabPage_Department.Controls.Add(this.button_Reset_Department);
            this.tabPage_Department.Controls.Add(this.button_DeleteDepartment);
            this.tabPage_Department.Controls.Add(this.button_ModifyDepartment);
            this.tabPage_Department.Controls.Add(this.button_AddDepartment);
            this.tabPage_Department.Controls.Add(this.textBox_LocationsDepartment);
            this.tabPage_Department.Controls.Add(this.textBox_NameDepartment);
            this.tabPage_Department.Controls.Add(this.textBox_NumberDepartment);
            this.tabPage_Department.Controls.Add(this.label_LocationsDepartment);
            this.tabPage_Department.Controls.Add(this.label_NameDepartment);
            this.tabPage_Department.Controls.Add(this.label_NumberDepartment);
            this.tabPage_Department.Controls.Add(this.dataGridView_Department);
            this.tabPage_Department.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Department.Name = "tabPage_Department";
            this.tabPage_Department.Size = new System.Drawing.Size(1158, 534);
            this.tabPage_Department.TabIndex = 3;
            this.tabPage_Department.Text = "Department";
            this.tabPage_Department.UseVisualStyleBackColor = true;
            // 
            // textBox_MgrStartDate
            // 
            this.textBox_MgrStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_MgrStartDate.Location = new System.Drawing.Point(257, 99);
            this.textBox_MgrStartDate.Name = "textBox_MgrStartDate";
            this.textBox_MgrStartDate.Size = new System.Drawing.Size(192, 27);
            this.textBox_MgrStartDate.TabIndex = 31;
            // 
            // label_MgrStartDateManager
            // 
            this.label_MgrStartDateManager.AutoSize = true;
            this.label_MgrStartDateManager.Location = new System.Drawing.Point(254, 83);
            this.label_MgrStartDateManager.Name = "label_MgrStartDateManager";
            this.label_MgrStartDateManager.Size = new System.Drawing.Size(59, 15);
            this.label_MgrStartDateManager.TabIndex = 30;
            this.label_MgrStartDateManager.Text = "Start date";
            // 
            // textBox_SsnManagerOld
            // 
            this.textBox_SsnManagerOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SsnManagerOld.Location = new System.Drawing.Point(257, 9);
            this.textBox_SsnManagerOld.Name = "textBox_SsnManagerOld";
            this.textBox_SsnManagerOld.ReadOnly = true;
            this.textBox_SsnManagerOld.Size = new System.Drawing.Size(128, 27);
            this.textBox_SsnManagerOld.TabIndex = 29;
            this.textBox_SsnManagerOld.Visible = false;
            // 
            // label_NameManager
            // 
            this.label_NameManager.AutoSize = true;
            this.label_NameManager.Location = new System.Drawing.Point(388, 38);
            this.label_NameManager.Name = "label_NameManager";
            this.label_NameManager.Size = new System.Drawing.Size(94, 15);
            this.label_NameManager.TabIndex = 28;
            this.label_NameManager.Text = "Name manager";
            // 
            // label_SsnManager
            // 
            this.label_SsnManager.AutoSize = true;
            this.label_SsnManager.Location = new System.Drawing.Point(254, 38);
            this.label_SsnManager.Name = "label_SsnManager";
            this.label_SsnManager.Size = new System.Drawing.Size(81, 15);
            this.label_SsnManager.TabIndex = 27;
            this.label_SsnManager.Text = "Ssn manager";
            // 
            // textBox_SsnManager
            // 
            this.textBox_SsnManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SsnManager.Location = new System.Drawing.Point(257, 54);
            this.textBox_SsnManager.Name = "textBox_SsnManager";
            this.textBox_SsnManager.ReadOnly = true;
            this.textBox_SsnManager.Size = new System.Drawing.Size(128, 27);
            this.textBox_SsnManager.TabIndex = 26;
            // 
            // textBox_NameManager
            // 
            this.textBox_NameManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NameManager.Location = new System.Drawing.Point(391, 54);
            this.textBox_NameManager.Name = "textBox_NameManager";
            this.textBox_NameManager.ReadOnly = true;
            this.textBox_NameManager.Size = new System.Drawing.Size(207, 27);
            this.textBox_NameManager.TabIndex = 25;
            // 
            // dataGridView_Manager
            // 
            this.dataGridView_Manager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Manager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssnManager,
            this.fnameManager,
            this.lnameManager});
            this.dataGridView_Manager.Location = new System.Drawing.Point(257, 131);
            this.dataGridView_Manager.Name = "dataGridView_Manager";
            this.dataGridView_Manager.RowHeadersWidth = 43;
            this.dataGridView_Manager.Size = new System.Drawing.Size(341, 403);
            this.dataGridView_Manager.TabIndex = 24;
            this.dataGridView_Manager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Manager_CellClick);
            // 
            // ssnManager
            // 
            this.ssnManager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ssnManager.DataPropertyName = "Ssn";
            this.ssnManager.HeaderText = "Ssn";
            this.ssnManager.Name = "ssnManager";
            this.ssnManager.Width = 53;
            // 
            // fnameManager
            // 
            this.fnameManager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fnameManager.DataPropertyName = "FName";
            this.fnameManager.HeaderText = "First name";
            this.fnameManager.Name = "fnameManager";
            // 
            // lnameManager
            // 
            this.lnameManager.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lnameManager.DataPropertyName = "LName";
            this.lnameManager.HeaderText = "Last name";
            this.lnameManager.Name = "lnameManager";
            // 
            // button_Reset_Department
            // 
            this.button_Reset_Department.Location = new System.Drawing.Point(11, 502);
            this.button_Reset_Department.Name = "button_Reset_Department";
            this.button_Reset_Department.Size = new System.Drawing.Size(48, 23);
            this.button_Reset_Department.TabIndex = 23;
            this.button_Reset_Department.Text = "Reset";
            this.button_Reset_Department.UseVisualStyleBackColor = true;
            this.button_Reset_Department.Click += new System.EventHandler(this.button_Reset_Department_Click);
            // 
            // button_DeleteDepartment
            // 
            this.button_DeleteDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteDepartment.Location = new System.Drawing.Point(8, 246);
            this.button_DeleteDepartment.Name = "button_DeleteDepartment";
            this.button_DeleteDepartment.Size = new System.Drawing.Size(190, 36);
            this.button_DeleteDepartment.TabIndex = 9;
            this.button_DeleteDepartment.Text = "Delete Department";
            this.button_DeleteDepartment.UseVisualStyleBackColor = true;
            this.button_DeleteDepartment.Click += new System.EventHandler(this.button_DeleteDepartment_Click);
            // 
            // button_ModifyDepartment
            // 
            this.button_ModifyDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ModifyDepartment.Location = new System.Drawing.Point(8, 204);
            this.button_ModifyDepartment.Name = "button_ModifyDepartment";
            this.button_ModifyDepartment.Size = new System.Drawing.Size(190, 36);
            this.button_ModifyDepartment.TabIndex = 8;
            this.button_ModifyDepartment.Text = "Modify Department";
            this.button_ModifyDepartment.UseVisualStyleBackColor = true;
            this.button_ModifyDepartment.Click += new System.EventHandler(this.button_ModifyDepartment_Click);
            // 
            // button_AddDepartment
            // 
            this.button_AddDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddDepartment.Location = new System.Drawing.Point(8, 162);
            this.button_AddDepartment.Name = "button_AddDepartment";
            this.button_AddDepartment.Size = new System.Drawing.Size(190, 36);
            this.button_AddDepartment.TabIndex = 7;
            this.button_AddDepartment.Text = "Add Department";
            this.button_AddDepartment.UseVisualStyleBackColor = true;
            this.button_AddDepartment.Click += new System.EventHandler(this.button_AddDepartment_Click);
            // 
            // textBox_LocationsDepartment
            // 
            this.textBox_LocationsDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LocationsDepartment.Location = new System.Drawing.Point(8, 115);
            this.textBox_LocationsDepartment.Name = "textBox_LocationsDepartment";
            this.textBox_LocationsDepartment.Size = new System.Drawing.Size(243, 27);
            this.textBox_LocationsDepartment.TabIndex = 6;
            // 
            // textBox_NameDepartment
            // 
            this.textBox_NameDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NameDepartment.Location = new System.Drawing.Point(8, 70);
            this.textBox_NameDepartment.Name = "textBox_NameDepartment";
            this.textBox_NameDepartment.Size = new System.Drawing.Size(206, 27);
            this.textBox_NameDepartment.TabIndex = 5;
            // 
            // textBox_NumberDepartment
            // 
            this.textBox_NumberDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumberDepartment.Location = new System.Drawing.Point(8, 25);
            this.textBox_NumberDepartment.Name = "textBox_NumberDepartment";
            this.textBox_NumberDepartment.Size = new System.Drawing.Size(112, 27);
            this.textBox_NumberDepartment.TabIndex = 4;
            this.textBox_NumberDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NumberDepartment_KeyPress);
            // 
            // label_LocationsDepartment
            // 
            this.label_LocationsDepartment.AutoSize = true;
            this.label_LocationsDepartment.Location = new System.Drawing.Point(8, 99);
            this.label_LocationsDepartment.Name = "label_LocationsDepartment";
            this.label_LocationsDepartment.Size = new System.Drawing.Size(60, 15);
            this.label_LocationsDepartment.TabIndex = 3;
            this.label_LocationsDepartment.Text = "Locations";
            // 
            // label_NameDepartment
            // 
            this.label_NameDepartment.AutoSize = true;
            this.label_NameDepartment.Location = new System.Drawing.Point(8, 54);
            this.label_NameDepartment.Name = "label_NameDepartment";
            this.label_NameDepartment.Size = new System.Drawing.Size(41, 15);
            this.label_NameDepartment.TabIndex = 2;
            this.label_NameDepartment.Text = "Name";
            // 
            // label_NumberDepartment
            // 
            this.label_NumberDepartment.AutoSize = true;
            this.label_NumberDepartment.Location = new System.Drawing.Point(8, 9);
            this.label_NumberDepartment.Name = "label_NumberDepartment";
            this.label_NumberDepartment.Size = new System.Drawing.Size(52, 15);
            this.label_NumberDepartment.TabIndex = 1;
            this.label_NumberDepartment.Text = "Number";
            // 
            // dataGridView_Department
            // 
            this.dataGridView_Department.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Department.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.number_Department,
            this.name_Department,
            this.locations_Department,
            this.employees_Department,
            this.manager_Department,
            this.projects_Department,
            this.mgrstartdate_Department});
            this.dataGridView_Department.Location = new System.Drawing.Point(614, 0);
            this.dataGridView_Department.Name = "dataGridView_Department";
            this.dataGridView_Department.RowHeadersWidth = 43;
            this.dataGridView_Department.Size = new System.Drawing.Size(544, 534);
            this.dataGridView_Department.TabIndex = 0;
            this.dataGridView_Department.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Department_CellClick);
            // 
            // number_Department
            // 
            this.number_Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.number_Department.DataPropertyName = "DNumber";
            this.number_Department.HeaderText = "Number";
            this.number_Department.Name = "number_Department";
            this.number_Department.Width = 77;
            // 
            // name_Department
            // 
            this.name_Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name_Department.DataPropertyName = "DName";
            this.name_Department.HeaderText = "Name";
            this.name_Department.Name = "name_Department";
            this.name_Department.Width = 66;
            // 
            // locations_Department
            // 
            this.locations_Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.locations_Department.DataPropertyName = "Locations";
            this.locations_Department.HeaderText = "Locations";
            this.locations_Department.Name = "locations_Department";
            this.locations_Department.Width = 85;
            // 
            // employees_Department
            // 
            this.employees_Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employees_Department.DataPropertyName = "Employees";
            this.employees_Department.HeaderText = "Employees";
            this.employees_Department.Name = "employees_Department";
            this.employees_Department.Width = 93;
            // 
            // manager_Department
            // 
            this.manager_Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.manager_Department.DataPropertyName = "Manager";
            this.manager_Department.HeaderText = "Manager";
            this.manager_Department.Name = "manager_Department";
            this.manager_Department.Width = 82;
            // 
            // projects_Department
            // 
            this.projects_Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.projects_Department.DataPropertyName = "Projects";
            this.projects_Department.HeaderText = "Projects";
            this.projects_Department.Name = "projects_Department";
            this.projects_Department.Width = 76;
            // 
            // mgrstartdate_Department
            // 
            this.mgrstartdate_Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.mgrstartdate_Department.DataPropertyName = "MgrStartDate";
            this.mgrstartdate_Department.HeaderText = "MgrStartDate";
            this.mgrstartdate_Department.Name = "mgrstartdate_Department";
            this.mgrstartdate_Department.Width = 105;
            // 
            // tabPage_WorksOn
            // 
            this.tabPage_WorksOn.Controls.Add(this.button_DeleteWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.button_ModifyWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.button_AddWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.label_NameProjectWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.label_NumberProjectWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.label_NameEmployeeWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.label_SsnEmployeeWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.label_HoursWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.textBox_SsnEmployeeWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.textBox_NameEmployeeWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.textBox_NumberProjectWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.textBox_NameProjectWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.textBox_SsnEmployeeWorksOnOld);
            this.tabPage_WorksOn.Controls.Add(this.textBox_NumberProjectWorksOnOld);
            this.tabPage_WorksOn.Controls.Add(this.textBox_HoursWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.button_Reset_WorksOn);
            this.tabPage_WorksOn.Controls.Add(this.dataGridView_EmployeeWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.dataGridView_ProjectWorksOn);
            this.tabPage_WorksOn.Controls.Add(this.dataGridView_WorksOn);
            this.tabPage_WorksOn.Location = new System.Drawing.Point(4, 22);
            this.tabPage_WorksOn.Name = "tabPage_WorksOn";
            this.tabPage_WorksOn.Size = new System.Drawing.Size(1158, 534);
            this.tabPage_WorksOn.TabIndex = 4;
            this.tabPage_WorksOn.Text = "WorksOn";
            this.tabPage_WorksOn.UseVisualStyleBackColor = true;
            // 
            // button_DeleteWorksOn
            // 
            this.button_DeleteWorksOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteWorksOn.Location = new System.Drawing.Point(20, 239);
            this.button_DeleteWorksOn.Name = "button_DeleteWorksOn";
            this.button_DeleteWorksOn.Size = new System.Drawing.Size(190, 36);
            this.button_DeleteWorksOn.TabIndex = 39;
            this.button_DeleteWorksOn.Text = "Delete WorksOn";
            this.button_DeleteWorksOn.UseVisualStyleBackColor = true;
            this.button_DeleteWorksOn.Click += new System.EventHandler(this.button_DeleteWorksOn_Click);
            // 
            // button_ModifyWorksOn
            // 
            this.button_ModifyWorksOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ModifyWorksOn.Location = new System.Drawing.Point(20, 197);
            this.button_ModifyWorksOn.Name = "button_ModifyWorksOn";
            this.button_ModifyWorksOn.Size = new System.Drawing.Size(190, 36);
            this.button_ModifyWorksOn.TabIndex = 38;
            this.button_ModifyWorksOn.Text = "Modify WorksOn";
            this.button_ModifyWorksOn.UseVisualStyleBackColor = true;
            this.button_ModifyWorksOn.Click += new System.EventHandler(this.button_ModifyWorksOn_Click);
            // 
            // button_AddWorksOn
            // 
            this.button_AddWorksOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddWorksOn.Location = new System.Drawing.Point(20, 155);
            this.button_AddWorksOn.Name = "button_AddWorksOn";
            this.button_AddWorksOn.Size = new System.Drawing.Size(190, 36);
            this.button_AddWorksOn.TabIndex = 37;
            this.button_AddWorksOn.Text = "Add WorksOn";
            this.button_AddWorksOn.UseVisualStyleBackColor = true;
            this.button_AddWorksOn.Click += new System.EventHandler(this.button_AddWorksOn_Click);
            // 
            // label_NameProjectWorksOn
            // 
            this.label_NameProjectWorksOn.AutoSize = true;
            this.label_NameProjectWorksOn.Location = new System.Drawing.Point(648, 107);
            this.label_NameProjectWorksOn.Name = "label_NameProjectWorksOn";
            this.label_NameProjectWorksOn.Size = new System.Drawing.Size(41, 15);
            this.label_NameProjectWorksOn.TabIndex = 36;
            this.label_NameProjectWorksOn.Text = "Name";
            // 
            // label_NumberProjectWorksOn
            // 
            this.label_NumberProjectWorksOn.AutoSize = true;
            this.label_NumberProjectWorksOn.Location = new System.Drawing.Point(542, 107);
            this.label_NumberProjectWorksOn.Name = "label_NumberProjectWorksOn";
            this.label_NumberProjectWorksOn.Size = new System.Drawing.Size(52, 15);
            this.label_NumberProjectWorksOn.TabIndex = 35;
            this.label_NumberProjectWorksOn.Text = "Number";
            // 
            // label_NameEmployeeWorksOn
            // 
            this.label_NameEmployeeWorksOn.AutoSize = true;
            this.label_NameEmployeeWorksOn.Location = new System.Drawing.Point(324, 106);
            this.label_NameEmployeeWorksOn.Name = "label_NameEmployeeWorksOn";
            this.label_NameEmployeeWorksOn.Size = new System.Drawing.Size(41, 15);
            this.label_NameEmployeeWorksOn.TabIndex = 34;
            this.label_NameEmployeeWorksOn.Text = "Name";
            // 
            // label_SsnEmployeeWorksOn
            // 
            this.label_SsnEmployeeWorksOn.AutoSize = true;
            this.label_SsnEmployeeWorksOn.Location = new System.Drawing.Point(218, 106);
            this.label_SsnEmployeeWorksOn.Name = "label_SsnEmployeeWorksOn";
            this.label_SsnEmployeeWorksOn.Size = new System.Drawing.Size(28, 15);
            this.label_SsnEmployeeWorksOn.TabIndex = 33;
            this.label_SsnEmployeeWorksOn.Text = "Ssn";
            // 
            // label_HoursWorksOn
            // 
            this.label_HoursWorksOn.AutoSize = true;
            this.label_HoursWorksOn.Location = new System.Drawing.Point(107, 107);
            this.label_HoursWorksOn.Name = "label_HoursWorksOn";
            this.label_HoursWorksOn.Size = new System.Drawing.Size(40, 15);
            this.label_HoursWorksOn.TabIndex = 32;
            this.label_HoursWorksOn.Text = "Hours";
            // 
            // textBox_SsnEmployeeWorksOn
            // 
            this.textBox_SsnEmployeeWorksOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SsnEmployeeWorksOn.Location = new System.Drawing.Point(221, 122);
            this.textBox_SsnEmployeeWorksOn.Name = "textBox_SsnEmployeeWorksOn";
            this.textBox_SsnEmployeeWorksOn.ReadOnly = true;
            this.textBox_SsnEmployeeWorksOn.Size = new System.Drawing.Size(100, 27);
            this.textBox_SsnEmployeeWorksOn.TabIndex = 31;
            // 
            // textBox_NameEmployeeWorksOn
            // 
            this.textBox_NameEmployeeWorksOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NameEmployeeWorksOn.Location = new System.Drawing.Point(327, 122);
            this.textBox_NameEmployeeWorksOn.Name = "textBox_NameEmployeeWorksOn";
            this.textBox_NameEmployeeWorksOn.ReadOnly = true;
            this.textBox_NameEmployeeWorksOn.Size = new System.Drawing.Size(201, 27);
            this.textBox_NameEmployeeWorksOn.TabIndex = 30;
            // 
            // textBox_NumberProjectWorksOn
            // 
            this.textBox_NumberProjectWorksOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumberProjectWorksOn.Location = new System.Drawing.Point(545, 122);
            this.textBox_NumberProjectWorksOn.Name = "textBox_NumberProjectWorksOn";
            this.textBox_NumberProjectWorksOn.ReadOnly = true;
            this.textBox_NumberProjectWorksOn.Size = new System.Drawing.Size(100, 27);
            this.textBox_NumberProjectWorksOn.TabIndex = 29;
            // 
            // textBox_NameProjectWorksOn
            // 
            this.textBox_NameProjectWorksOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NameProjectWorksOn.Location = new System.Drawing.Point(651, 123);
            this.textBox_NameProjectWorksOn.Name = "textBox_NameProjectWorksOn";
            this.textBox_NameProjectWorksOn.ReadOnly = true;
            this.textBox_NameProjectWorksOn.Size = new System.Drawing.Size(149, 27);
            this.textBox_NameProjectWorksOn.TabIndex = 28;
            // 
            // textBox_SsnEmployeeWorksOnOld
            // 
            this.textBox_SsnEmployeeWorksOnOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SsnEmployeeWorksOnOld.Location = new System.Drawing.Point(221, 77);
            this.textBox_SsnEmployeeWorksOnOld.Name = "textBox_SsnEmployeeWorksOnOld";
            this.textBox_SsnEmployeeWorksOnOld.ReadOnly = true;
            this.textBox_SsnEmployeeWorksOnOld.Size = new System.Drawing.Size(100, 27);
            this.textBox_SsnEmployeeWorksOnOld.TabIndex = 27;
            this.textBox_SsnEmployeeWorksOnOld.Visible = false;
            // 
            // textBox_NumberProjectWorksOnOld
            // 
            this.textBox_NumberProjectWorksOnOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumberProjectWorksOnOld.Location = new System.Drawing.Point(544, 77);
            this.textBox_NumberProjectWorksOnOld.Name = "textBox_NumberProjectWorksOnOld";
            this.textBox_NumberProjectWorksOnOld.ReadOnly = true;
            this.textBox_NumberProjectWorksOnOld.Size = new System.Drawing.Size(100, 27);
            this.textBox_NumberProjectWorksOnOld.TabIndex = 26;
            this.textBox_NumberProjectWorksOnOld.Visible = false;
            // 
            // textBox_HoursWorksOn
            // 
            this.textBox_HoursWorksOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_HoursWorksOn.Location = new System.Drawing.Point(110, 123);
            this.textBox_HoursWorksOn.Name = "textBox_HoursWorksOn";
            this.textBox_HoursWorksOn.Size = new System.Drawing.Size(100, 27);
            this.textBox_HoursWorksOn.TabIndex = 25;
            this.textBox_HoursWorksOn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HoursWorksOn_KeyPress);
            // 
            // button_Reset_WorksOn
            // 
            this.button_Reset_WorksOn.Location = new System.Drawing.Point(8, 502);
            this.button_Reset_WorksOn.Name = "button_Reset_WorksOn";
            this.button_Reset_WorksOn.Size = new System.Drawing.Size(48, 23);
            this.button_Reset_WorksOn.TabIndex = 24;
            this.button_Reset_WorksOn.Text = "Reset";
            this.button_Reset_WorksOn.UseVisualStyleBackColor = true;
            this.button_Reset_WorksOn.Click += new System.EventHandler(this.button_Reset_WorksOn_Click);
            // 
            // dataGridView_EmployeeWorksOn
            // 
            this.dataGridView_EmployeeWorksOn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EmployeeWorksOn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssnEmployee,
            this.fnameEmployee,
            this.lnameEmployee});
            this.dataGridView_EmployeeWorksOn.Location = new System.Drawing.Point(221, 154);
            this.dataGridView_EmployeeWorksOn.Name = "dataGridView_EmployeeWorksOn";
            this.dataGridView_EmployeeWorksOn.RowHeadersWidth = 43;
            this.dataGridView_EmployeeWorksOn.Size = new System.Drawing.Size(307, 380);
            this.dataGridView_EmployeeWorksOn.TabIndex = 2;
            this.dataGridView_EmployeeWorksOn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_EmployeeWorksOn_CellClick);
            // 
            // ssnEmployee
            // 
            this.ssnEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ssnEmployee.HeaderText = "Ssn";
            this.ssnEmployee.Name = "ssnEmployee";
            this.ssnEmployee.Width = 53;
            // 
            // fnameEmployee
            // 
            this.fnameEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fnameEmployee.HeaderText = "First name";
            this.fnameEmployee.Name = "fnameEmployee";
            // 
            // lnameEmployee
            // 
            this.lnameEmployee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lnameEmployee.HeaderText = "Last name";
            this.lnameEmployee.Name = "lnameEmployee";
            // 
            // dataGridView_ProjectWorksOn
            // 
            this.dataGridView_ProjectWorksOn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ProjectWorksOn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberProject,
            this.nameProject});
            this.dataGridView_ProjectWorksOn.Location = new System.Drawing.Point(544, 154);
            this.dataGridView_ProjectWorksOn.Name = "dataGridView_ProjectWorksOn";
            this.dataGridView_ProjectWorksOn.RowHeadersWidth = 43;
            this.dataGridView_ProjectWorksOn.Size = new System.Drawing.Size(256, 380);
            this.dataGridView_ProjectWorksOn.TabIndex = 1;
            this.dataGridView_ProjectWorksOn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ProjectWorksOn_CellClick);
            // 
            // numberProject
            // 
            this.numberProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberProject.HeaderText = "Number";
            this.numberProject.Name = "numberProject";
            this.numberProject.Width = 77;
            // 
            // nameProject
            // 
            this.nameProject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameProject.HeaderText = "Name";
            this.nameProject.Name = "nameProject";
            // 
            // dataGridView_WorksOn
            // 
            this.dataGridView_WorksOn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_WorksOn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hours_WorksOn,
            this.employee_WorksOn,
            this.project_WorksOn});
            this.dataGridView_WorksOn.Location = new System.Drawing.Point(815, 0);
            this.dataGridView_WorksOn.Name = "dataGridView_WorksOn";
            this.dataGridView_WorksOn.RowHeadersWidth = 43;
            this.dataGridView_WorksOn.Size = new System.Drawing.Size(343, 534);
            this.dataGridView_WorksOn.TabIndex = 0;
            this.dataGridView_WorksOn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_WorksOn_CellClick);
            // 
            // hours_WorksOn
            // 
            this.hours_WorksOn.DataPropertyName = "Hours";
            this.hours_WorksOn.HeaderText = "Hours";
            this.hours_WorksOn.Name = "hours_WorksOn";
            this.hours_WorksOn.Width = 105;
            // 
            // employee_WorksOn
            // 
            this.employee_WorksOn.DataPropertyName = "Employee";
            this.employee_WorksOn.HeaderText = "Employee";
            this.employee_WorksOn.Name = "employee_WorksOn";
            this.employee_WorksOn.Width = 105;
            // 
            // project_WorksOn
            // 
            this.project_WorksOn.DataPropertyName = "Project";
            this.project_WorksOn.HeaderText = "Project";
            this.project_WorksOn.Name = "project_WorksOn";
            this.project_WorksOn.Width = 105;
            // 
            // tabPage_WorksFor
            // 
            this.tabPage_WorksFor.Controls.Add(this.label_ND2);
            this.tabPage_WorksFor.Controls.Add(this.label_ND1);
            this.tabPage_WorksFor.Controls.Add(this.button_SaveWorksFor);
            this.tabPage_WorksFor.Controls.Add(this.button_Reset_WorksFor);
            this.tabPage_WorksFor.Controls.Add(this.textBox_NumberDepartmentWorksFor);
            this.tabPage_WorksFor.Controls.Add(this.label_EmployeesWorksFor);
            this.tabPage_WorksFor.Controls.Add(this.label_DepartmentWorksFor);
            this.tabPage_WorksFor.Controls.Add(this.label_EmployeeWorksFor);
            this.tabPage_WorksFor.Controls.Add(this.dataGridView_EmployeeWorksFor);
            this.tabPage_WorksFor.Controls.Add(this.dataGridView_EmployeesWorksFor);
            this.tabPage_WorksFor.Controls.Add(this.dataGridView_DepartmentWorksFor);
            this.tabPage_WorksFor.Location = new System.Drawing.Point(4, 22);
            this.tabPage_WorksFor.Name = "tabPage_WorksFor";
            this.tabPage_WorksFor.Size = new System.Drawing.Size(1158, 534);
            this.tabPage_WorksFor.TabIndex = 9;
            this.tabPage_WorksFor.Text = "WorksFor";
            this.tabPage_WorksFor.UseVisualStyleBackColor = true;
            // 
            // label_ND2
            // 
            this.label_ND2.AutoSize = true;
            this.label_ND2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ND2.Location = new System.Drawing.Point(411, 74);
            this.label_ND2.Name = "label_ND2";
            this.label_ND2.Size = new System.Drawing.Size(347, 17);
            this.label_ND2.TabIndex = 28;
            this.label_ND2.Text = "- Chọn một đối tượng trong bảng EMPLOYEES để xóa";
            // 
            // label_ND1
            // 
            this.label_ND1.AutoSize = true;
            this.label_ND1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ND1.Location = new System.Drawing.Point(411, 49);
            this.label_ND1.Name = "label_ND1";
            this.label_ND1.Size = new System.Drawing.Size(347, 17);
            this.label_ND1.TabIndex = 27;
            this.label_ND1.Text = "- Chọn một đối tượng trong bảng EMPLOYEE để thêm";
            // 
            // button_SaveWorksFor
            // 
            this.button_SaveWorksFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveWorksFor.Location = new System.Drawing.Point(539, 172);
            this.button_SaveWorksFor.Name = "button_SaveWorksFor";
            this.button_SaveWorksFor.Size = new System.Drawing.Size(75, 32);
            this.button_SaveWorksFor.TabIndex = 26;
            this.button_SaveWorksFor.Text = "Save";
            this.button_SaveWorksFor.UseVisualStyleBackColor = true;
            this.button_SaveWorksFor.Click += new System.EventHandler(this.button_SaveWorksFor_Click);
            // 
            // button_Reset_WorksFor
            // 
            this.button_Reset_WorksFor.Location = new System.Drawing.Point(8, 502);
            this.button_Reset_WorksFor.Name = "button_Reset_WorksFor";
            this.button_Reset_WorksFor.Size = new System.Drawing.Size(48, 23);
            this.button_Reset_WorksFor.TabIndex = 25;
            this.button_Reset_WorksFor.Text = "Reset";
            this.button_Reset_WorksFor.UseVisualStyleBackColor = true;
            this.button_Reset_WorksFor.Click += new System.EventHandler(this.button_Reset_WorksFor_Click);
            // 
            // textBox_NumberDepartmentWorksFor
            // 
            this.textBox_NumberDepartmentWorksFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_NumberDepartmentWorksFor.Location = new System.Drawing.Point(1047, 43);
            this.textBox_NumberDepartmentWorksFor.Name = "textBox_NumberDepartmentWorksFor";
            this.textBox_NumberDepartmentWorksFor.ReadOnly = true;
            this.textBox_NumberDepartmentWorksFor.Size = new System.Drawing.Size(100, 27);
            this.textBox_NumberDepartmentWorksFor.TabIndex = 6;
            this.textBox_NumberDepartmentWorksFor.Visible = false;
            // 
            // label_EmployeesWorksFor
            // 
            this.label_EmployeesWorksFor.AutoSize = true;
            this.label_EmployeesWorksFor.Location = new System.Drawing.Point(421, 194);
            this.label_EmployeesWorksFor.Name = "label_EmployeesWorksFor";
            this.label_EmployeesWorksFor.Size = new System.Drawing.Size(68, 15);
            this.label_EmployeesWorksFor.TabIndex = 5;
            this.label_EmployeesWorksFor.Text = "Employees";
            // 
            // label_DepartmentWorksFor
            // 
            this.label_DepartmentWorksFor.AutoSize = true;
            this.label_DepartmentWorksFor.Location = new System.Drawing.Point(750, 27);
            this.label_DepartmentWorksFor.Name = "label_DepartmentWorksFor";
            this.label_DepartmentWorksFor.Size = new System.Drawing.Size(72, 15);
            this.label_DepartmentWorksFor.TabIndex = 4;
            this.label_DepartmentWorksFor.Text = "Department";
            // 
            // label_EmployeeWorksFor
            // 
            this.label_EmployeeWorksFor.AutoSize = true;
            this.label_EmployeeWorksFor.Location = new System.Drawing.Point(343, 27);
            this.label_EmployeeWorksFor.Name = "label_EmployeeWorksFor";
            this.label_EmployeeWorksFor.Size = new System.Drawing.Size(62, 15);
            this.label_EmployeeWorksFor.TabIndex = 3;
            this.label_EmployeeWorksFor.Text = "Employee";
            // 
            // dataGridView_EmployeeWorksFor
            // 
            this.dataGridView_EmployeeWorksFor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EmployeeWorksFor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssnEmployeeWorksFor,
            this.fnameEmployeeWorksFor,
            this.lnameEmployeeWorksFor});
            this.dataGridView_EmployeeWorksFor.Location = new System.Drawing.Point(95, 43);
            this.dataGridView_EmployeeWorksFor.Name = "dataGridView_EmployeeWorksFor";
            this.dataGridView_EmployeeWorksFor.RowHeadersWidth = 43;
            this.dataGridView_EmployeeWorksFor.Size = new System.Drawing.Size(301, 491);
            this.dataGridView_EmployeeWorksFor.TabIndex = 2;
            this.dataGridView_EmployeeWorksFor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_EmployeeWorksFor_CellClick);
            // 
            // ssnEmployeeWorksFor
            // 
            this.ssnEmployeeWorksFor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ssnEmployeeWorksFor.HeaderText = "Ssn";
            this.ssnEmployeeWorksFor.Name = "ssnEmployeeWorksFor";
            this.ssnEmployeeWorksFor.Width = 53;
            // 
            // fnameEmployeeWorksFor
            // 
            this.fnameEmployeeWorksFor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fnameEmployeeWorksFor.HeaderText = "First name";
            this.fnameEmployeeWorksFor.Name = "fnameEmployeeWorksFor";
            // 
            // lnameEmployeeWorksFor
            // 
            this.lnameEmployeeWorksFor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lnameEmployeeWorksFor.HeaderText = "Last name";
            this.lnameEmployeeWorksFor.Name = "lnameEmployeeWorksFor";
            // 
            // dataGridView_EmployeesWorksFor
            // 
            this.dataGridView_EmployeesWorksFor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EmployeesWorksFor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssnEmployeesWorksFor,
            this.fnameEmployeesWorksFor,
            this.lnameEmployeesWorksFor});
            this.dataGridView_EmployeesWorksFor.Location = new System.Drawing.Point(424, 210);
            this.dataGridView_EmployeesWorksFor.Name = "dataGridView_EmployeesWorksFor";
            this.dataGridView_EmployeesWorksFor.RowHeadersWidth = 43;
            this.dataGridView_EmployeesWorksFor.Size = new System.Drawing.Size(301, 324);
            this.dataGridView_EmployeesWorksFor.TabIndex = 1;
            this.dataGridView_EmployeesWorksFor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_EmployeesWorksFor_CellClick);
            // 
            // ssnEmployeesWorksFor
            // 
            this.ssnEmployeesWorksFor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ssnEmployeesWorksFor.HeaderText = "Ssn";
            this.ssnEmployeesWorksFor.Name = "ssnEmployeesWorksFor";
            this.ssnEmployeesWorksFor.Width = 53;
            // 
            // fnameEmployeesWorksFor
            // 
            this.fnameEmployeesWorksFor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fnameEmployeesWorksFor.HeaderText = "First name";
            this.fnameEmployeesWorksFor.Name = "fnameEmployeesWorksFor";
            // 
            // lnameEmployeesWorksFor
            // 
            this.lnameEmployeesWorksFor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lnameEmployeesWorksFor.HeaderText = "Last name";
            this.lnameEmployeesWorksFor.Name = "lnameEmployeesWorksFor";
            // 
            // dataGridView_DepartmentWorksFor
            // 
            this.dataGridView_DepartmentWorksFor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DepartmentWorksFor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDepartmentWorksFor,
            this.nameDepartmentWorksFor});
            this.dataGridView_DepartmentWorksFor.Location = new System.Drawing.Point(753, 43);
            this.dataGridView_DepartmentWorksFor.Name = "dataGridView_DepartmentWorksFor";
            this.dataGridView_DepartmentWorksFor.RowHeadersWidth = 43;
            this.dataGridView_DepartmentWorksFor.Size = new System.Drawing.Size(288, 491);
            this.dataGridView_DepartmentWorksFor.TabIndex = 0;
            this.dataGridView_DepartmentWorksFor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DepartmentWorksFor_CellClick);
            // 
            // numberDepartmentWorksFor
            // 
            this.numberDepartmentWorksFor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberDepartmentWorksFor.HeaderText = "Number";
            this.numberDepartmentWorksFor.Name = "numberDepartmentWorksFor";
            this.numberDepartmentWorksFor.Width = 77;
            // 
            // nameDepartmentWorksFor
            // 
            this.nameDepartmentWorksFor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDepartmentWorksFor.HeaderText = "Name";
            this.nameDepartmentWorksFor.Name = "nameDepartmentWorksFor";
            // 
            // tabPage_Supervisor
            // 
            this.tabPage_Supervisor.Controls.Add(this.label_ND4);
            this.tabPage_Supervisor.Controls.Add(this.label2);
            this.tabPage_Supervisor.Controls.Add(this.label_ND3);
            this.tabPage_Supervisor.Controls.Add(this.button_SaveSupervisor);
            this.tabPage_Supervisor.Controls.Add(this.label_SupervisorSupervisor);
            this.tabPage_Supervisor.Controls.Add(this.label_EmployeesSupervisor);
            this.tabPage_Supervisor.Controls.Add(this.label_EmployeeSupervisor);
            this.tabPage_Supervisor.Controls.Add(this.textBox_SsnSupervisorSupervisor);
            this.tabPage_Supervisor.Controls.Add(this.button1);
            this.tabPage_Supervisor.Controls.Add(this.dataGridView_SuperviseesSupervisor);
            this.tabPage_Supervisor.Controls.Add(this.dataGridView_EmployeeSupervisor);
            this.tabPage_Supervisor.Controls.Add(this.dataGridView_SupervisorSupervisor);
            this.tabPage_Supervisor.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Supervisor.Name = "tabPage_Supervisor";
            this.tabPage_Supervisor.Size = new System.Drawing.Size(1158, 534);
            this.tabPage_Supervisor.TabIndex = 10;
            this.tabPage_Supervisor.Text = "Supervisor";
            this.tabPage_Supervisor.UseVisualStyleBackColor = true;
            // 
            // label_ND4
            // 
            this.label_ND4.AutoSize = true;
            this.label_ND4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ND4.Location = new System.Drawing.Point(405, 100);
            this.label_ND4.Name = "label_ND4";
            this.label_ND4.Size = new System.Drawing.Size(358, 17);
            this.label_ND4.TabIndex = 34;
            this.label_ND4.Text = "- Chọn một đối tượng trong bảng SUPERVISEES để xóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 33;
            // 
            // label_ND3
            // 
            this.label_ND3.AutoSize = true;
            this.label_ND3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ND3.Location = new System.Drawing.Point(405, 75);
            this.label_ND3.Name = "label_ND3";
            this.label_ND3.Size = new System.Drawing.Size(347, 17);
            this.label_ND3.TabIndex = 32;
            this.label_ND3.Text = "- Chọn một đối tượng trong bảng EMPLOYEE để thêm";
            // 
            // button_SaveSupervisor
            // 
            this.button_SaveSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveSupervisor.Location = new System.Drawing.Point(525, 168);
            this.button_SaveSupervisor.Name = "button_SaveSupervisor";
            this.button_SaveSupervisor.Size = new System.Drawing.Size(75, 32);
            this.button_SaveSupervisor.TabIndex = 31;
            this.button_SaveSupervisor.Text = "Save";
            this.button_SaveSupervisor.UseVisualStyleBackColor = true;
            this.button_SaveSupervisor.Click += new System.EventHandler(this.button_SaveSupervisor_Click);
            // 
            // label_SupervisorSupervisor
            // 
            this.label_SupervisorSupervisor.AutoSize = true;
            this.label_SupervisorSupervisor.Location = new System.Drawing.Point(743, 36);
            this.label_SupervisorSupervisor.Name = "label_SupervisorSupervisor";
            this.label_SupervisorSupervisor.Size = new System.Drawing.Size(65, 15);
            this.label_SupervisorSupervisor.TabIndex = 30;
            this.label_SupervisorSupervisor.Text = "Supervisor";
            // 
            // label_EmployeesSupervisor
            // 
            this.label_EmployeesSupervisor.AutoSize = true;
            this.label_EmployeesSupervisor.Location = new System.Drawing.Point(417, 190);
            this.label_EmployeesSupervisor.Name = "label_EmployeesSupervisor";
            this.label_EmployeesSupervisor.Size = new System.Drawing.Size(74, 15);
            this.label_EmployeesSupervisor.TabIndex = 29;
            this.label_EmployeesSupervisor.Text = "Supervisees";
            // 
            // label_EmployeeSupervisor
            // 
            this.label_EmployeeSupervisor.AutoSize = true;
            this.label_EmployeeSupervisor.Location = new System.Drawing.Point(339, 36);
            this.label_EmployeeSupervisor.Name = "label_EmployeeSupervisor";
            this.label_EmployeeSupervisor.Size = new System.Drawing.Size(62, 15);
            this.label_EmployeeSupervisor.TabIndex = 28;
            this.label_EmployeeSupervisor.Text = "Employee";
            // 
            // textBox_SsnSupervisorSupervisor
            // 
            this.textBox_SsnSupervisorSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SsnSupervisorSupervisor.Location = new System.Drawing.Point(1048, 52);
            this.textBox_SsnSupervisorSupervisor.Name = "textBox_SsnSupervisorSupervisor";
            this.textBox_SsnSupervisorSupervisor.ReadOnly = true;
            this.textBox_SsnSupervisorSupervisor.Size = new System.Drawing.Size(100, 27);
            this.textBox_SsnSupervisorSupervisor.TabIndex = 27;
            this.textBox_SsnSupervisorSupervisor.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 502);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView_SuperviseesSupervisor
            // 
            this.dataGridView_SuperviseesSupervisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SuperviseesSupervisor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssnSuperviseesSupervisor,
            this.fnameSuperviseesSupervisor,
            this.lnameSuperviseesSupervisor});
            this.dataGridView_SuperviseesSupervisor.Location = new System.Drawing.Point(420, 206);
            this.dataGridView_SuperviseesSupervisor.Name = "dataGridView_SuperviseesSupervisor";
            this.dataGridView_SuperviseesSupervisor.RowHeadersWidth = 43;
            this.dataGridView_SuperviseesSupervisor.Size = new System.Drawing.Size(296, 328);
            this.dataGridView_SuperviseesSupervisor.TabIndex = 2;
            this.dataGridView_SuperviseesSupervisor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SuperviseesSupervisor_CellClick);
            // 
            // ssnSuperviseesSupervisor
            // 
            this.ssnSuperviseesSupervisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ssnSuperviseesSupervisor.HeaderText = "Ssn";
            this.ssnSuperviseesSupervisor.Name = "ssnSuperviseesSupervisor";
            this.ssnSuperviseesSupervisor.Width = 53;
            // 
            // fnameSuperviseesSupervisor
            // 
            this.fnameSuperviseesSupervisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fnameSuperviseesSupervisor.HeaderText = "First name";
            this.fnameSuperviseesSupervisor.Name = "fnameSuperviseesSupervisor";
            // 
            // lnameSuperviseesSupervisor
            // 
            this.lnameSuperviseesSupervisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lnameSuperviseesSupervisor.HeaderText = "Last name";
            this.lnameSuperviseesSupervisor.Name = "lnameSuperviseesSupervisor";
            // 
            // dataGridView_EmployeeSupervisor
            // 
            this.dataGridView_EmployeeSupervisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EmployeeSupervisor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssnEmployeeSupervisor,
            this.fnameEmployeeSupervisor,
            this.lnameEmployeeSupervisor});
            this.dataGridView_EmployeeSupervisor.Location = new System.Drawing.Point(96, 52);
            this.dataGridView_EmployeeSupervisor.Name = "dataGridView_EmployeeSupervisor";
            this.dataGridView_EmployeeSupervisor.RowHeadersWidth = 43;
            this.dataGridView_EmployeeSupervisor.Size = new System.Drawing.Size(296, 482);
            this.dataGridView_EmployeeSupervisor.TabIndex = 1;
            this.dataGridView_EmployeeSupervisor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_EmployeeSupervisor_CellClick);
            // 
            // ssnEmployeeSupervisor
            // 
            this.ssnEmployeeSupervisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ssnEmployeeSupervisor.HeaderText = "Ssn";
            this.ssnEmployeeSupervisor.Name = "ssnEmployeeSupervisor";
            this.ssnEmployeeSupervisor.Width = 53;
            // 
            // fnameEmployeeSupervisor
            // 
            this.fnameEmployeeSupervisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fnameEmployeeSupervisor.HeaderText = "First name";
            this.fnameEmployeeSupervisor.Name = "fnameEmployeeSupervisor";
            // 
            // lnameEmployeeSupervisor
            // 
            this.lnameEmployeeSupervisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lnameEmployeeSupervisor.HeaderText = "Last name";
            this.lnameEmployeeSupervisor.Name = "lnameEmployeeSupervisor";
            // 
            // dataGridView_SupervisorSupervisor
            // 
            this.dataGridView_SupervisorSupervisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SupervisorSupervisor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssnSupervisorSupervisor,
            this.fnameSupervisorSupervisor,
            this.lnameSupervisorSupervisor});
            this.dataGridView_SupervisorSupervisor.Location = new System.Drawing.Point(746, 52);
            this.dataGridView_SupervisorSupervisor.Name = "dataGridView_SupervisorSupervisor";
            this.dataGridView_SupervisorSupervisor.RowHeadersWidth = 43;
            this.dataGridView_SupervisorSupervisor.Size = new System.Drawing.Size(296, 482);
            this.dataGridView_SupervisorSupervisor.TabIndex = 0;
            this.dataGridView_SupervisorSupervisor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SupervisorSupervisor_CellClick);
            // 
            // ssnSupervisorSupervisor
            // 
            this.ssnSupervisorSupervisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ssnSupervisorSupervisor.HeaderText = "Ssn";
            this.ssnSupervisorSupervisor.Name = "ssnSupervisorSupervisor";
            this.ssnSupervisorSupervisor.Width = 53;
            // 
            // fnameSupervisorSupervisor
            // 
            this.fnameSupervisorSupervisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fnameSupervisorSupervisor.HeaderText = "First name";
            this.fnameSupervisorSupervisor.Name = "fnameSupervisorSupervisor";
            // 
            // lnameSupervisorSupervisor
            // 
            this.lnameSupervisorSupervisor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lnameSupervisorSupervisor.HeaderText = "Last name";
            this.lnameSupervisorSupervisor.Name = "lnameSupervisorSupervisor";
            // 
            // tabPage_CauTruyVan1
            // 
            this.tabPage_CauTruyVan1.Controls.Add(this.dataGridView_CauTruyVan1);
            this.tabPage_CauTruyVan1.Controls.Add(this.label_CauTruyVan1);
            this.tabPage_CauTruyVan1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CauTruyVan1.Name = "tabPage_CauTruyVan1";
            this.tabPage_CauTruyVan1.Size = new System.Drawing.Size(1158, 534);
            this.tabPage_CauTruyVan1.TabIndex = 5;
            this.tabPage_CauTruyVan1.Text = "Câu truy vấn 1";
            this.tabPage_CauTruyVan1.UseVisualStyleBackColor = true;
            // 
            // dataGridView_CauTruyVan1
            // 
            this.dataGridView_CauTruyVan1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CauTruyVan1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssnEmployee_CTV1,
            this.fnameEmployee_CTV1,
            this.lnameEmployee_CTV1,
            this.minitEmployee_CTV1,
            this.genderEmployee_CTV1,
            this.addressEmployee_CTV1,
            this.birthdateEmployee_CTV1,
            this.salaryEmployee_CTV1,
            this.worksforEmployee_CTV1,
            this.managerEmployee_CTV1,
            this.worksonEmployee_CTV1,
            this.dependentsEmployee_CTV1,
            this.supervisorEmployee_CTV1,
            this.superviseesEmployee_CTV1});
            this.dataGridView_CauTruyVan1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView_CauTruyVan1.Name = "dataGridView_CauTruyVan1";
            this.dataGridView_CauTruyVan1.RowHeadersWidth = 43;
            this.dataGridView_CauTruyVan1.Size = new System.Drawing.Size(1158, 499);
            this.dataGridView_CauTruyVan1.TabIndex = 3;
            // 
            // ssnEmployee_CTV1
            // 
            this.ssnEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ssnEmployee_CTV1.HeaderText = "Ssn";
            this.ssnEmployee_CTV1.Name = "ssnEmployee_CTV1";
            this.ssnEmployee_CTV1.Width = 53;
            // 
            // fnameEmployee_CTV1
            // 
            this.fnameEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fnameEmployee_CTV1.HeaderText = "First name";
            this.fnameEmployee_CTV1.Name = "fnameEmployee_CTV1";
            this.fnameEmployee_CTV1.Width = 90;
            // 
            // lnameEmployee_CTV1
            // 
            this.lnameEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lnameEmployee_CTV1.HeaderText = "Last name";
            this.lnameEmployee_CTV1.Name = "lnameEmployee_CTV1";
            this.lnameEmployee_CTV1.Width = 90;
            // 
            // minitEmployee_CTV1
            // 
            this.minitEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.minitEmployee_CTV1.HeaderText = "MInit";
            this.minitEmployee_CTV1.Name = "minitEmployee_CTV1";
            this.minitEmployee_CTV1.Width = 59;
            // 
            // genderEmployee_CTV1
            // 
            this.genderEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.genderEmployee_CTV1.HeaderText = "Gender";
            this.genderEmployee_CTV1.Name = "genderEmployee_CTV1";
            this.genderEmployee_CTV1.Width = 73;
            // 
            // addressEmployee_CTV1
            // 
            this.addressEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addressEmployee_CTV1.HeaderText = "Address";
            this.addressEmployee_CTV1.Name = "addressEmployee_CTV1";
            this.addressEmployee_CTV1.Width = 76;
            // 
            // birthdateEmployee_CTV1
            // 
            this.birthdateEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.birthdateEmployee_CTV1.HeaderText = "BirthDate";
            this.birthdateEmployee_CTV1.Name = "birthdateEmployee_CTV1";
            this.birthdateEmployee_CTV1.Width = 83;
            // 
            // salaryEmployee_CTV1
            // 
            this.salaryEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salaryEmployee_CTV1.HeaderText = "Salary";
            this.salaryEmployee_CTV1.Name = "salaryEmployee_CTV1";
            this.salaryEmployee_CTV1.Width = 66;
            // 
            // worksforEmployee_CTV1
            // 
            this.worksforEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.worksforEmployee_CTV1.HeaderText = "WorksFor";
            this.worksforEmployee_CTV1.Name = "worksforEmployee_CTV1";
            this.worksforEmployee_CTV1.Width = 84;
            // 
            // managerEmployee_CTV1
            // 
            this.managerEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.managerEmployee_CTV1.HeaderText = "Manager";
            this.managerEmployee_CTV1.Name = "managerEmployee_CTV1";
            this.managerEmployee_CTV1.Width = 82;
            // 
            // worksonEmployee_CTV1
            // 
            this.worksonEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.worksonEmployee_CTV1.HeaderText = "WorksOn";
            this.worksonEmployee_CTV1.Name = "worksonEmployee_CTV1";
            this.worksonEmployee_CTV1.Width = 82;
            // 
            // dependentsEmployee_CTV1
            // 
            this.dependentsEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dependentsEmployee_CTV1.HeaderText = "Dependents";
            this.dependentsEmployee_CTV1.Name = "dependentsEmployee_CTV1";
            this.dependentsEmployee_CTV1.Width = 99;
            // 
            // supervisorEmployee_CTV1
            // 
            this.supervisorEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.supervisorEmployee_CTV1.HeaderText = "Supervisor";
            this.supervisorEmployee_CTV1.Name = "supervisorEmployee_CTV1";
            this.supervisorEmployee_CTV1.Width = 90;
            // 
            // superviseesEmployee_CTV1
            // 
            this.superviseesEmployee_CTV1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.superviseesEmployee_CTV1.HeaderText = "Supervisees";
            this.superviseesEmployee_CTV1.Name = "superviseesEmployee_CTV1";
            this.superviseesEmployee_CTV1.Width = 99;
            // 
            // label_CauTruyVan1
            // 
            this.label_CauTruyVan1.AutoSize = true;
            this.label_CauTruyVan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CauTruyVan1.Location = new System.Drawing.Point(8, 7);
            this.label_CauTruyVan1.Name = "label_CauTruyVan1";
            this.label_CauTruyVan1.Size = new System.Drawing.Size(557, 29);
            this.label_CauTruyVan1.TabIndex = 2;
            this.label_CauTruyVan1.Text = "Tìm tất cả những người làm thuê có giới tính là nam.";
            // 
            // tabPage_CauTruyVan2
            // 
            this.tabPage_CauTruyVan2.Controls.Add(this.dataGridView_CauTruyVan2);
            this.tabPage_CauTruyVan2.Controls.Add(this.label_CauTruyVan2);
            this.tabPage_CauTruyVan2.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CauTruyVan2.Name = "tabPage_CauTruyVan2";
            this.tabPage_CauTruyVan2.Size = new System.Drawing.Size(1158, 534);
            this.tabPage_CauTruyVan2.TabIndex = 6;
            this.tabPage_CauTruyVan2.Text = "Câu truy vấn 2";
            this.tabPage_CauTruyVan2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_CauTruyVan2
            // 
            this.dataGridView_CauTruyVan2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CauTruyVan2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssnEmployee_CTV2,
            this.fnameEmployee_CTV2,
            this.lnameEmployee_CTV2,
            this.minitEmployee_CTV2,
            this.genderEmployee_CTV2,
            this.addressEmployee_CTV2,
            this.birthdateEmployee_CTV2,
            this.salaryEmployee_CTV2,
            this.worksforEmployee_CTV2,
            this.managerEmployee_CTV2,
            this.worksonEmployee_CTV2,
            this.dependentsEmployee_CTV2,
            this.supervisorEMployee_CTV2,
            this.superviseesEmployee_CTV2});
            this.dataGridView_CauTruyVan2.Location = new System.Drawing.Point(0, 39);
            this.dataGridView_CauTruyVan2.Name = "dataGridView_CauTruyVan2";
            this.dataGridView_CauTruyVan2.RowHeadersWidth = 43;
            this.dataGridView_CauTruyVan2.Size = new System.Drawing.Size(1158, 499);
            this.dataGridView_CauTruyVan2.TabIndex = 4;
            // 
            // ssnEmployee_CTV2
            // 
            this.ssnEmployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ssnEmployee_CTV2.HeaderText = "Ssn";
            this.ssnEmployee_CTV2.Name = "ssnEmployee_CTV2";
            this.ssnEmployee_CTV2.Width = 53;
            // 
            // fnameEmployee_CTV2
            // 
            this.fnameEmployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fnameEmployee_CTV2.HeaderText = "First name";
            this.fnameEmployee_CTV2.Name = "fnameEmployee_CTV2";
            this.fnameEmployee_CTV2.Width = 90;
            // 
            // lnameEmployee_CTV2
            // 
            this.lnameEmployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lnameEmployee_CTV2.HeaderText = "Last name";
            this.lnameEmployee_CTV2.Name = "lnameEmployee_CTV2";
            this.lnameEmployee_CTV2.Width = 90;
            // 
            // minitEmployee_CTV2
            // 
            this.minitEmployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.minitEmployee_CTV2.HeaderText = "MInit";
            this.minitEmployee_CTV2.Name = "minitEmployee_CTV2";
            this.minitEmployee_CTV2.Width = 59;
            // 
            // genderEmployee_CTV2
            // 
            this.genderEmployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.genderEmployee_CTV2.HeaderText = "Gender";
            this.genderEmployee_CTV2.Name = "genderEmployee_CTV2";
            this.genderEmployee_CTV2.Width = 73;
            // 
            // addressEmployee_CTV2
            // 
            this.addressEmployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addressEmployee_CTV2.HeaderText = "Address";
            this.addressEmployee_CTV2.Name = "addressEmployee_CTV2";
            this.addressEmployee_CTV2.Width = 76;
            // 
            // birthdateEmployee_CTV2
            // 
            this.birthdateEmployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.birthdateEmployee_CTV2.HeaderText = "BirthDate";
            this.birthdateEmployee_CTV2.Name = "birthdateEmployee_CTV2";
            this.birthdateEmployee_CTV2.Width = 83;
            // 
            // salaryEmployee_CTV2
            // 
            this.salaryEmployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salaryEmployee_CTV2.HeaderText = "Salary";
            this.salaryEmployee_CTV2.Name = "salaryEmployee_CTV2";
            this.salaryEmployee_CTV2.Width = 66;
            // 
            // worksforEmployee_CTV2
            // 
            this.worksforEmployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.worksforEmployee_CTV2.HeaderText = "WorksFor";
            this.worksforEmployee_CTV2.Name = "worksforEmployee_CTV2";
            this.worksforEmployee_CTV2.Width = 84;
            // 
            // managerEmployee_CTV2
            // 
            this.managerEmployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.managerEmployee_CTV2.HeaderText = "Manager";
            this.managerEmployee_CTV2.Name = "managerEmployee_CTV2";
            this.managerEmployee_CTV2.Width = 82;
            // 
            // worksonEmployee_CTV2
            // 
            this.worksonEmployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.worksonEmployee_CTV2.HeaderText = "WorksOn";
            this.worksonEmployee_CTV2.Name = "worksonEmployee_CTV2";
            this.worksonEmployee_CTV2.Width = 82;
            // 
            // dependentsEmployee_CTV2
            // 
            this.dependentsEmployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dependentsEmployee_CTV2.HeaderText = "Dependents";
            this.dependentsEmployee_CTV2.Name = "dependentsEmployee_CTV2";
            this.dependentsEmployee_CTV2.Width = 99;
            // 
            // supervisorEMployee_CTV2
            // 
            this.supervisorEMployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.supervisorEMployee_CTV2.HeaderText = "Supervisor";
            this.supervisorEMployee_CTV2.Name = "supervisorEMployee_CTV2";
            this.supervisorEMployee_CTV2.Width = 90;
            // 
            // superviseesEmployee_CTV2
            // 
            this.superviseesEmployee_CTV2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.superviseesEmployee_CTV2.HeaderText = "Supervisees";
            this.superviseesEmployee_CTV2.Name = "superviseesEmployee_CTV2";
            this.superviseesEmployee_CTV2.Width = 99;
            // 
            // label_CauTruyVan2
            // 
            this.label_CauTruyVan2.AutoSize = true;
            this.label_CauTruyVan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CauTruyVan2.Location = new System.Drawing.Point(8, 9);
            this.label_CauTruyVan2.Name = "label_CauTruyVan2";
            this.label_CauTruyVan2.Size = new System.Drawing.Size(883, 29);
            this.label_CauTruyVan2.TabIndex = 3;
            this.label_CauTruyVan2.Text = "Tìm tất cả những người làm thuê đã làm việc cho ban ngành có tên có chữ T ở đầu.";
            // 
            // tabPage_CauTruyVan3
            // 
            this.tabPage_CauTruyVan3.Controls.Add(this.dataGridView_CauTruyVan3);
            this.tabPage_CauTruyVan3.Controls.Add(this.label_CauTruyVan3);
            this.tabPage_CauTruyVan3.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CauTruyVan3.Name = "tabPage_CauTruyVan3";
            this.tabPage_CauTruyVan3.Size = new System.Drawing.Size(1158, 534);
            this.tabPage_CauTruyVan3.TabIndex = 7;
            this.tabPage_CauTruyVan3.Text = "Câu truy vấn 3";
            this.tabPage_CauTruyVan3.UseVisualStyleBackColor = true;
            // 
            // dataGridView_CauTruyVan3
            // 
            this.dataGridView_CauTruyVan3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CauTruyVan3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssnEmployee_CTV3,
            this.fnameEmployee_CTV3,
            this.lnameEmployee_CTV3,
            this.minitEmployee_CTV3,
            this.genderEmployee_CTV3,
            this.addressEmployee_CTV3,
            this.birthdateEmployee_CTV3,
            this.salaryEmployee_CTV3,
            this.worksforEmployee_CTV3,
            this.managerEmployee_CTV3,
            this.worksonEmployee_CTV3,
            this.dependentsEmployee_CTV3,
            this.supervisorEmployee_CTV3,
            this.superviseesEmployee_CTV3});
            this.dataGridView_CauTruyVan3.Location = new System.Drawing.Point(0, 33);
            this.dataGridView_CauTruyVan3.Name = "dataGridView_CauTruyVan3";
            this.dataGridView_CauTruyVan3.RowHeadersWidth = 43;
            this.dataGridView_CauTruyVan3.Size = new System.Drawing.Size(1158, 499);
            this.dataGridView_CauTruyVan3.TabIndex = 6;
            // 
            // ssnEmployee_CTV3
            // 
            this.ssnEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ssnEmployee_CTV3.HeaderText = "Ssn";
            this.ssnEmployee_CTV3.Name = "ssnEmployee_CTV3";
            this.ssnEmployee_CTV3.Width = 53;
            // 
            // fnameEmployee_CTV3
            // 
            this.fnameEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fnameEmployee_CTV3.HeaderText = "First name";
            this.fnameEmployee_CTV3.Name = "fnameEmployee_CTV3";
            this.fnameEmployee_CTV3.Width = 90;
            // 
            // lnameEmployee_CTV3
            // 
            this.lnameEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lnameEmployee_CTV3.HeaderText = "Last name";
            this.lnameEmployee_CTV3.Name = "lnameEmployee_CTV3";
            this.lnameEmployee_CTV3.Width = 90;
            // 
            // minitEmployee_CTV3
            // 
            this.minitEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.minitEmployee_CTV3.HeaderText = "MInit";
            this.minitEmployee_CTV3.Name = "minitEmployee_CTV3";
            this.minitEmployee_CTV3.Width = 59;
            // 
            // genderEmployee_CTV3
            // 
            this.genderEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.genderEmployee_CTV3.HeaderText = "Gender";
            this.genderEmployee_CTV3.Name = "genderEmployee_CTV3";
            this.genderEmployee_CTV3.Width = 73;
            // 
            // addressEmployee_CTV3
            // 
            this.addressEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addressEmployee_CTV3.HeaderText = "Address";
            this.addressEmployee_CTV3.Name = "addressEmployee_CTV3";
            this.addressEmployee_CTV3.Width = 76;
            // 
            // birthdateEmployee_CTV3
            // 
            this.birthdateEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.birthdateEmployee_CTV3.HeaderText = "BirthDate";
            this.birthdateEmployee_CTV3.Name = "birthdateEmployee_CTV3";
            this.birthdateEmployee_CTV3.Width = 83;
            // 
            // salaryEmployee_CTV3
            // 
            this.salaryEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salaryEmployee_CTV3.HeaderText = "Salary";
            this.salaryEmployee_CTV3.Name = "salaryEmployee_CTV3";
            this.salaryEmployee_CTV3.Width = 66;
            // 
            // worksforEmployee_CTV3
            // 
            this.worksforEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.worksforEmployee_CTV3.HeaderText = "WorksFor";
            this.worksforEmployee_CTV3.Name = "worksforEmployee_CTV3";
            this.worksforEmployee_CTV3.Width = 84;
            // 
            // managerEmployee_CTV3
            // 
            this.managerEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.managerEmployee_CTV3.HeaderText = "Manager";
            this.managerEmployee_CTV3.Name = "managerEmployee_CTV3";
            this.managerEmployee_CTV3.Width = 82;
            // 
            // worksonEmployee_CTV3
            // 
            this.worksonEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.worksonEmployee_CTV3.HeaderText = "WorksOn";
            this.worksonEmployee_CTV3.Name = "worksonEmployee_CTV3";
            this.worksonEmployee_CTV3.Width = 82;
            // 
            // dependentsEmployee_CTV3
            // 
            this.dependentsEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dependentsEmployee_CTV3.HeaderText = "Dependents";
            this.dependentsEmployee_CTV3.Name = "dependentsEmployee_CTV3";
            this.dependentsEmployee_CTV3.Width = 99;
            // 
            // supervisorEmployee_CTV3
            // 
            this.supervisorEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.supervisorEmployee_CTV3.HeaderText = "Supervisor";
            this.supervisorEmployee_CTV3.Name = "supervisorEmployee_CTV3";
            this.supervisorEmployee_CTV3.Width = 90;
            // 
            // superviseesEmployee_CTV3
            // 
            this.superviseesEmployee_CTV3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.superviseesEmployee_CTV3.HeaderText = "Supervisees";
            this.superviseesEmployee_CTV3.Name = "superviseesEmployee_CTV3";
            this.superviseesEmployee_CTV3.Width = 99;
            // 
            // label_CauTruyVan3
            // 
            this.label_CauTruyVan3.AutoSize = true;
            this.label_CauTruyVan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CauTruyVan3.Location = new System.Drawing.Point(8, 3);
            this.label_CauTruyVan3.Name = "label_CauTruyVan3";
            this.label_CauTruyVan3.Size = new System.Drawing.Size(1084, 29);
            this.label_CauTruyVan3.TabIndex = 5;
            this.label_CauTruyVan3.Text = "Tìm tất cả những người làm thuê đã làm cho dự án có tên chứa chữ “A” và có thời g" +
    "ian làm việc là <10h";
            // 
            // tabPage_CauTruyVan4
            // 
            this.tabPage_CauTruyVan4.Controls.Add(this.dataGridView_CauTruyVan4);
            this.tabPage_CauTruyVan4.Controls.Add(this.label_CauTruyVan4);
            this.tabPage_CauTruyVan4.Location = new System.Drawing.Point(4, 22);
            this.tabPage_CauTruyVan4.Name = "tabPage_CauTruyVan4";
            this.tabPage_CauTruyVan4.Size = new System.Drawing.Size(1158, 534);
            this.tabPage_CauTruyVan4.TabIndex = 8;
            this.tabPage_CauTruyVan4.Text = "Câu truy vấn 4";
            this.tabPage_CauTruyVan4.UseVisualStyleBackColor = true;
            // 
            // dataGridView_CauTruyVan4
            // 
            this.dataGridView_CauTruyVan4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CauTruyVan4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberProject_CTV4,
            this.nameProject_CTV4,
            this.locationProject_CTV4,
            this.controlledbyProject_CTV4,
            this.worksonProject_CTV4});
            this.dataGridView_CauTruyVan4.Location = new System.Drawing.Point(0, 33);
            this.dataGridView_CauTruyVan4.Name = "dataGridView_CauTruyVan4";
            this.dataGridView_CauTruyVan4.RowHeadersWidth = 43;
            this.dataGridView_CauTruyVan4.Size = new System.Drawing.Size(1158, 499);
            this.dataGridView_CauTruyVan4.TabIndex = 8;
            // 
            // numberProject_CTV4
            // 
            this.numberProject_CTV4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberProject_CTV4.HeaderText = "Number";
            this.numberProject_CTV4.Name = "numberProject_CTV4";
            // 
            // nameProject_CTV4
            // 
            this.nameProject_CTV4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameProject_CTV4.HeaderText = "Name";
            this.nameProject_CTV4.Name = "nameProject_CTV4";
            // 
            // locationProject_CTV4
            // 
            this.locationProject_CTV4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.locationProject_CTV4.HeaderText = "Location";
            this.locationProject_CTV4.Name = "locationProject_CTV4";
            // 
            // controlledbyProject_CTV4
            // 
            this.controlledbyProject_CTV4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.controlledbyProject_CTV4.HeaderText = "ControlledBy";
            this.controlledbyProject_CTV4.Name = "controlledbyProject_CTV4";
            // 
            // worksonProject_CTV4
            // 
            this.worksonProject_CTV4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.worksonProject_CTV4.HeaderText = "WorksOn";
            this.worksonProject_CTV4.Name = "worksonProject_CTV4";
            // 
            // label_CauTruyVan4
            // 
            this.label_CauTruyVan4.AutoSize = true;
            this.label_CauTruyVan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CauTruyVan4.Location = new System.Drawing.Point(8, 3);
            this.label_CauTruyVan4.Name = "label_CauTruyVan4";
            this.label_CauTruyVan4.Size = new System.Drawing.Size(785, 29);
            this.label_CauTruyVan4.TabIndex = 7;
            this.label_CauTruyVan4.Text = "Tìm tất cả các công việc được thực hiện bởi dự án có địa điểm là Houston";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1158, 534);
            this.tabPage1.TabIndex = 11;
            this.tabPage1.Text = "Thông tin nhóm Illumiate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.09901F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(295, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHÓM ILLUMINATE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trần Quốc Thắng - 4501104220";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trần Quốc Thắng - 4501104220";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Trần Quốc Thắng - 4501104220";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Trần Quốc Thắng - 4501104220";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 560);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab05-CompanyManager | Nhóm Illuminate";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Employee.ResumeLayout(false);
            this.tabPage_Employee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).EndInit();
            this.tabPage_Dependent.ResumeLayout(false);
            this.tabPage_Dependent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DependentOf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Dependent)).EndInit();
            this.tabPage_Project.ResumeLayout(false);
            this.tabPage_Project.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ControlledBy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Project)).EndInit();
            this.tabPage_Department.ResumeLayout(false);
            this.tabPage_Department.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Manager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Department)).EndInit();
            this.tabPage_WorksOn.ResumeLayout(false);
            this.tabPage_WorksOn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeWorksOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ProjectWorksOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_WorksOn)).EndInit();
            this.tabPage_WorksFor.ResumeLayout(false);
            this.tabPage_WorksFor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeWorksFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeesWorksFor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DepartmentWorksFor)).EndInit();
            this.tabPage_Supervisor.ResumeLayout(false);
            this.tabPage_Supervisor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SuperviseesSupervisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeSupervisor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SupervisorSupervisor)).EndInit();
            this.tabPage_CauTruyVan1.ResumeLayout(false);
            this.tabPage_CauTruyVan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauTruyVan1)).EndInit();
            this.tabPage_CauTruyVan2.ResumeLayout(false);
            this.tabPage_CauTruyVan2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauTruyVan2)).EndInit();
            this.tabPage_CauTruyVan3.ResumeLayout(false);
            this.tabPage_CauTruyVan3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauTruyVan3)).EndInit();
            this.tabPage_CauTruyVan4.ResumeLayout(false);
            this.tabPage_CauTruyVan4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauTruyVan4)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Employee;
        private System.Windows.Forms.DataGridView dataGridView_Employee;
        private System.Windows.Forms.TabPage tabPage_Dependent;
        private System.Windows.Forms.DataGridView dataGridView_Dependent;
        private System.Windows.Forms.Label label_GenderEmployee;
        private System.Windows.Forms.Label label_SalaryEmployee;
        private System.Windows.Forms.Label label_BirthDateEmployee;
        private System.Windows.Forms.Label label_AddressEmployee;
        private System.Windows.Forms.Label label_LNameEmployee;
        private System.Windows.Forms.Label label_MInitEmployee;
        private System.Windows.Forms.Label label_FNameEmployee;
        private System.Windows.Forms.Label label_SsnEmployee;
        private System.Windows.Forms.TextBox textBox_FNameEmployee;
        private System.Windows.Forms.TextBox textBox_LNameEmployee;
        private System.Windows.Forms.TextBox textBox_MInitEmployee;
        private System.Windows.Forms.TextBox textBox_BirthDateEmployee;
        private System.Windows.Forms.TextBox textBox_AddressEmployee;
        private System.Windows.Forms.TextBox textBox_SalaryEmployee;
        private System.Windows.Forms.TextBox textBox_SsnEmployee;
        private System.Windows.Forms.Button button_DeleteEmployee;
        private System.Windows.Forms.Button button_ModifyEmployee;
        private System.Windows.Forms.Button button_AddEmployee;
        private System.Windows.Forms.Label label_RelationshipDependent;
        private System.Windows.Forms.Label label_BirthDateDependent;
        private System.Windows.Forms.Label label_GenderDependent;
        private System.Windows.Forms.Label label_NameDependent;
        private System.Windows.Forms.TextBox textBox_BirthDateDependent;
        private System.Windows.Forms.TextBox textBox_NameDependent;
        private System.Windows.Forms.Button button_AddDependent;
        private System.Windows.Forms.Button button_DeleteDependent;
        private System.Windows.Forms.Button button_ModifyDependent;
        private System.Windows.Forms.TabPage tabPage_Project;
        private System.Windows.Forms.DataGridView dataGridView_Project;
        private System.Windows.Forms.Label label_LocationProject;
        private System.Windows.Forms.Label label_NameProject;
        private System.Windows.Forms.Label label_NumberProject;
        private System.Windows.Forms.TextBox textBox_NameProject;
        private System.Windows.Forms.TextBox textBox_NumberProject;
        private System.Windows.Forms.Button button_DeleteProject;
        private System.Windows.Forms.Button button_ModifyProject;
        private System.Windows.Forms.Button button_AddProject;
        private System.Windows.Forms.Label label_DependentOf;
        private System.Windows.Forms.TextBox textBox_SsnDependentOf;
        private System.Windows.Forms.TabPage tabPage_Department;
        private System.Windows.Forms.TextBox textBox_LocationsDepartment;
        private System.Windows.Forms.TextBox textBox_NameDepartment;
        private System.Windows.Forms.TextBox textBox_NumberDepartment;
        private System.Windows.Forms.Label label_LocationsDepartment;
        private System.Windows.Forms.Label label_NameDepartment;
        private System.Windows.Forms.Label label_NumberDepartment;
        private System.Windows.Forms.DataGridView dataGridView_Department;
        private System.Windows.Forms.Button button_DeleteDepartment;
        private System.Windows.Forms.Button button_ModifyDepartment;
        private System.Windows.Forms.Button button_AddDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_Dependent;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender_Dependent;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate_Dependent;
        private System.Windows.Forms.DataGridViewTextBoxColumn relationship_Dependent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dependentof_Denpedent;
        private System.Windows.Forms.TabPage tabPage_WorksOn;
        private System.Windows.Forms.DataGridView dataGridView_WorksOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours_WorksOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_WorksOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn project_WorksOn;
        private System.Windows.Forms.Button button_Reset_Employee;
        private System.Windows.Forms.Button button_Reset_Dependent;
        private System.Windows.Forms.Button button_Reset_Project;
        private System.Windows.Forms.Button button_Reset_Department;
        private System.Windows.Forms.ComboBox comboBox_RelationshipDependent;
        private System.Windows.Forms.Label label_NameDependentOf;
        private System.Windows.Forms.Label label_SsnDependentOf;
        private System.Windows.Forms.TextBox textBox_NameDependentOf;
        private System.Windows.Forms.DataGridView dataGridView_DependentOf;
        private System.Windows.Forms.TextBox textBox_RelationshipDependentOld;
        private System.Windows.Forms.TextBox textBox_BirthDateDependentOld;
        private System.Windows.Forms.TextBox textBox_NameDependentOld;
        private System.Windows.Forms.TextBox textBox_GenderDependentOld;
        private System.Windows.Forms.DataGridView dataGridView_ControlledBy;
        private System.Windows.Forms.Label label_controlledby_DepartmetProject;
        private System.Windows.Forms.Label label_NumberControlledBy;
        private System.Windows.Forms.Label label_NameControlledBy;
        private System.Windows.Forms.TextBox textBox_NumberControlledBy;
        private System.Windows.Forms.TextBox textBox_NameControlledBy;
        private System.Windows.Forms.TextBox textBox_NumberControlledByOld;
        private System.Windows.Forms.TextBox textBox_SsnDependentOfOld;
        private System.Windows.Forms.ComboBox comboBox_LocationProject;
        private System.Windows.Forms.DataGridView dataGridView_Manager;
        private System.Windows.Forms.TextBox textBox_SsnManagerOld;
        private System.Windows.Forms.Label label_NameManager;
        private System.Windows.Forms.Label label_SsnManager;
        private System.Windows.Forms.TextBox textBox_SsnManager;
        private System.Windows.Forms.TextBox textBox_NameManager;
        private System.Windows.Forms.TextBox textBox_MgrStartDate;
        private System.Windows.Forms.Label label_MgrStartDateManager;
        private System.Windows.Forms.TabPage tabPage_CauTruyVan1;
        private System.Windows.Forms.TabPage tabPage_CauTruyVan2;
        private System.Windows.Forms.TabPage tabPage_CauTruyVan3;
        private System.Windows.Forms.TabPage tabPage_CauTruyVan4;
        private System.Windows.Forms.DataGridView dataGridView_CauTruyVan1;
        private System.Windows.Forms.Label label_CauTruyVan1;
        private System.Windows.Forms.Label label_CauTruyVan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssn_DependentOf;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName_DependentOf;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName_DependentOf;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn location_Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlledby_Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn workson_Project;
        private System.Windows.Forms.DataGridViewTextBoxColumn dnumber_DepartmentProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dname_DepartmentProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn number_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn locations_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn employees_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn manager_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn projects_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgrstartdate_Department;
        private System.Windows.Forms.DataGridView dataGridView_EmployeeWorksOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameEmployee;
        private System.Windows.Forms.DataGridView dataGridView_ProjectWorksOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberProject;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProject;
        private System.Windows.Forms.Button button_Reset_WorksOn;
        private System.Windows.Forms.Label label_NameProjectWorksOn;
        private System.Windows.Forms.Label label_NumberProjectWorksOn;
        private System.Windows.Forms.Label label_NameEmployeeWorksOn;
        private System.Windows.Forms.Label label_SsnEmployeeWorksOn;
        private System.Windows.Forms.Label label_HoursWorksOn;
        private System.Windows.Forms.TextBox textBox_SsnEmployeeWorksOn;
        private System.Windows.Forms.TextBox textBox_NameEmployeeWorksOn;
        private System.Windows.Forms.TextBox textBox_NumberProjectWorksOn;
        private System.Windows.Forms.TextBox textBox_NameProjectWorksOn;
        private System.Windows.Forms.TextBox textBox_SsnEmployeeWorksOnOld;
        private System.Windows.Forms.TextBox textBox_NumberProjectWorksOnOld;
        private System.Windows.Forms.TextBox textBox_HoursWorksOn;
        private System.Windows.Forms.Button button_DeleteWorksOn;
        private System.Windows.Forms.Button button_ModifyWorksOn;
        private System.Windows.Forms.Button button_AddWorksOn;
        private System.Windows.Forms.ComboBox comboBox_GenderEmployee;
        private System.Windows.Forms.ComboBox comboBox_GenderDependent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnEmployee_CTV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameEmployee_CTV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameEmployee_CTV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn minitEmployee_CTV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderEmployee_CTV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressEmployee_CTV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateEmployee_CTV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryEmployee_CTV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn worksforEmployee_CTV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerEmployee_CTV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn worksonEmployee_CTV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dependentsEmployee_CTV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorEmployee_CTV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn superviseesEmployee_CTV1;
        private System.Windows.Forms.DataGridView dataGridView_CauTruyVan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnEmployee_CTV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameEmployee_CTV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameEmployee_CTV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn minitEmployee_CTV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderEmployee_CTV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressEmployee_CTV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateEmployee_CTV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryEmployee_CTV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn worksforEmployee_CTV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerEmployee_CTV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn worksonEmployee_CTV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dependentsEmployee_CTV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorEMployee_CTV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn superviseesEmployee_CTV2;
        private System.Windows.Forms.DataGridView dataGridView_CauTruyVan3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnEmployee_CTV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameEmployee_CTV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameEmployee_CTV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn minitEmployee_CTV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderEmployee_CTV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressEmployee_CTV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateEmployee_CTV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryEmployee_CTV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn worksforEmployee_CTV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerEmployee_CTV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn worksonEmployee_CTV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dependentsEmployee_CTV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorEmployee_CTV3;
        private System.Windows.Forms.DataGridViewTextBoxColumn superviseesEmployee_CTV3;
        private System.Windows.Forms.Label label_CauTruyVan3;
        private System.Windows.Forms.DataGridView dataGridView_CauTruyVan4;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberProject_CTV4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProject_CTV4;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationProject_CTV4;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlledbyProject_CTV4;
        private System.Windows.Forms.DataGridViewTextBoxColumn worksonProject_CTV4;
        private System.Windows.Forms.Label label_CauTruyVan4;
        private System.Windows.Forms.TabPage tabPage_WorksFor;
        private System.Windows.Forms.TabPage tabPage_Supervisor;
        private System.Windows.Forms.DataGridView dataGridView_EmployeeWorksFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnEmployeeWorksFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameEmployeeWorksFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameEmployeeWorksFor;
        private System.Windows.Forms.DataGridView dataGridView_EmployeesWorksFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnEmployeesWorksFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameEmployeesWorksFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameEmployeesWorksFor;
        private System.Windows.Forms.DataGridView dataGridView_DepartmentWorksFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDepartmentWorksFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDepartmentWorksFor;
        private System.Windows.Forms.Label label_EmployeesWorksFor;
        private System.Windows.Forms.Label label_DepartmentWorksFor;
        private System.Windows.Forms.Label label_EmployeeWorksFor;
        private System.Windows.Forms.TextBox textBox_NumberDepartmentWorksFor;
        private System.Windows.Forms.Button button_Reset_WorksFor;
        private System.Windows.Forms.Button button_SaveWorksFor;
        private System.Windows.Forms.Label label_ND2;
        private System.Windows.Forms.Label label_ND1;
        private System.Windows.Forms.DataGridView dataGridView_SupervisorSupervisor;
        private System.Windows.Forms.DataGridView dataGridView_SuperviseesSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnSuperviseesSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameSuperviseesSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameSuperviseesSupervisor;
        private System.Windows.Forms.DataGridView dataGridView_EmployeeSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnEmployeeSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameEmployeeSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameEmployeeSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssnSupervisorSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameSupervisorSupervisor;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameSupervisorSupervisor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_SsnSupervisorSupervisor;
        private System.Windows.Forms.Label label_SupervisorSupervisor;
        private System.Windows.Forms.Label label_EmployeesSupervisor;
        private System.Windows.Forms.Label label_EmployeeSupervisor;
        private System.Windows.Forms.Button button_SaveSupervisor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_ND3;
        private System.Windows.Forms.Label label_ND4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssn_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn fname_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn lname_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn minit_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn salary_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn worksfor_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn manager_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn workson_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dependents_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisor_Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisees_Employee;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}