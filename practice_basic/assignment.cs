using SampleFrameWorkWeek2.practical;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SampleADOWeek3
{
    class assignment
    {
        static string STRCONNECTION = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        static SqlConnection con = new SqlConnection(STRCONNECTION);
        static void Main(string[] args)
        {

            //insertRecord();
            //deleteUsingConnected();
            //EmpDeptJoin();
            //readCSV();
            //dbTolist();
            // findEmp();
            // insertRecordUsingStoredProc();

        }

        private static void dbTolist()
        {
            string query = "select * from employee";
            List<Employee> emp = new List<Employee>();
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employee empNew = new Employee();
                    empNew.empId = (int)reader["EmpId"];
                    empNew.empName = reader["EmpName"].ToString();
                    empNew.empAddress = reader["EmpAddress"].ToString();
                    empNew.empSalary = Convert.ToInt32(reader["EmpSalary"]);
                    empNew.deptId = (int)reader["DeptId"];
                    empNew.mgrId = (int)reader["MgrId"];

                    emp.Add(empNew);

                }
                foreach (var item in emp)
                {
                    Console.WriteLine($"{item.empName} from {item.empAddress} has salary of {item.empSalary}");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void insertRecordUsingStoredProc()
        {
            string query = "InsertEmployee";
            int empId = 0;
            SqlCommand sqlCmd = new SqlCommand(query, con);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            string name = Utilities.Prompt("Enter the name");
            string address = Utilities.Prompt("Enter the address");
            int salary = Utilities.GetNumber("Enter the salary");
            int deptid = Utilities.GetNumber("Enter the deptID");
            int mgrid = Utilities.GetNumber("Enter the MgrId");
            sqlCmd.Parameters.AddWithValue("@empName", name);
            sqlCmd.Parameters.AddWithValue("@empAddress", address);
            sqlCmd.Parameters.AddWithValue("@empSalary", salary);
            sqlCmd.Parameters.AddWithValue("@deptId", deptid);
            sqlCmd.Parameters.AddWithValue("@mgrId", 1004);
            sqlCmd.Parameters.AddWithValue("@empId", empId);

            sqlCmd.Parameters[5].Direction = ParameterDirection.Output;
            try
            {
                con.Open();
                sqlCmd.ExecuteNonQuery();
                empId = Convert.ToInt32(sqlCmd.Parameters[5].Value);
                Console.WriteLine("The empid of added is " + empId);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private static void findEmp()
        {
            string query = "select * from employee";
            string name = Utilities.Prompt("Enter the name you want to search");
            SqlDataAdapter adp = new SqlDataAdapter(query, con);
            DataSet disModel = new DataSet("Records");
            SqlCommandBuilder builder = new SqlCommandBuilder(adp);
            adp.Fill(disModel);
            foreach (DataRow item in disModel.Tables[0].Rows)
            {
                if (item[1].ToString() == name)
                {
                    Console.WriteLine(item[0]);
                }
            }
        }

        private static void readCSV()
        {
            const string fileName = "D:/Prajit_3328/dot net/CompleteDotnetTraining/SampleFrameWorkWeek2/Customer.csv";
            var Lines = File.ReadAllLines(fileName);
            List<String> str = new List<string>();
            foreach (var item in Lines)
            {
                var line = item.Split(',');
                for (int i = 0; i < Lines.Length; i++)
                {
                    str.Add(line[i]);
                }

            }
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
        }

        private static void EmpDeptJoin()
        {
            string query = "SELECT empname, department.DeptName FROM Department INNER JOIN employee ON department.DEPTID = Employee.DEPTID";
            SqlCommand sqlCommand = new SqlCommand(query, con);

            try
            {
                con.Open();
                var reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["EmpName"]} - {reader["deptname"]}");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private static void deleteUsingConnected()
        {

            int id = Utilities.GetNumber("Enter the ID you want to delete");
            string query = $"delete from employee where empid = {id}";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private static void insertRecord()
        {
            string name = Utilities.Prompt("Enter the name");
            string address = Utilities.Prompt("Enter the address");
            int salary = Utilities.GetNumber("Enter the salary");
            int deptid = Utilities.GetNumber("Enter the deptID");
            int mgrid = Utilities.GetNumber("Enter the MgrId");
            string query = $"insert into employee values ('{name}','{address}','{salary}','{deptid}','{mgrid}')";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}