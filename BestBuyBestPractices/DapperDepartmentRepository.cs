using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyBestPractices
{
    public class DapperDepartmentRepository : IDepartmentRepository  // make public so can be viewed in other 
    {
        private readonly IDbConnection _connection;  // IDB connection to query
        //Constructor  so no one else can change it
        public DapperDepartmentRepository(IDbConnection connection)// field
        {
            _connection = connection; // parameterized constructor that makes pass in connection to (database-IDBConnection connection)
        }
        public IEnumerable<Department> GetAllDepartments()// Method to query
        {
            return _connection.Query<Department>("SELECT * FROM Departments;");//( skdfj) is telling it to select all departments from departments table in SQl Bestby
        }     // querying database! Department part of database

        public void InsertDepartment(string newDepartmentName)
        {
            _connection.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentName);",
         new { departmentName = newDepartmentName });// new   connects parameter to value name  departmentName
        }
    }
}
