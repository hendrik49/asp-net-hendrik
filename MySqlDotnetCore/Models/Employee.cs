using System;
using System.ComponentModel.DataAnnotations;

namespace MySqlDotnetCore.Models
{
    public partial class Employee
    {
        public int id { get; set; }
        public string employee_id { set; get; }
        public string department_id { set; get; }
        public String name { set; get; }
        public String address { set; get; }
        public decimal salary { set; get; }
        public DateTime birthdate { set; get; }
    }
}