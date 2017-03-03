using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService1" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        

  
            public Employee GetEmployee(int Id)
        {
            Employee employee = new Employee();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("getPlaces", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = Id;
                cmd.Parameters.Add(parameterId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employee.Id = Convert.ToInt32(reader["PlaceID"]);
                    employee.Name = reader["PlaceName"].ToString();
                   
                }
            }
            return employee;
        }

            public void SaveEmployee(Employee emp)
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("SavePlaces", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter parameterId = new SqlParameter
                    {
                        ParameterName = "@Id",
                        Value = emp.Id
                    };
                    cmd.Parameters.Add(parameterId);

                    SqlParameter parameterName = new SqlParameter
                    {
                        ParameterName = "@Name",
                        Value = emp.Name
                    };
                    cmd.Parameters.Add(parameterName);
                   con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        } }

