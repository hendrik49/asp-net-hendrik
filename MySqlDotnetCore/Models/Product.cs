using System;
using System.ComponentModel.DataAnnotations;

namespace MySqlDotnetCore.Models
{
    public partial class Product
    {
        [Key]
        public int seq_Id { get; set; }
        public String Product_Code { set; get; }
        public String Product_Category_Code { set; get; }
        public String Product_Type_Code { set; get; }
        public String Product_Name { set; get; }
        public String Product_Description { set; get; }
        public String Status { set; get; }
        public DateTime Create_Date { set; get; }
        public DateTime Update_Date { set; get; }
        public bool Is_Deleted { set; get; }
 
    }
}