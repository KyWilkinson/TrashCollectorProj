using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TrashCollector.Data.Migrations;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]
        public int employeeId { get; set; }
        public double zipCode { get; set; }
        

    }
}
