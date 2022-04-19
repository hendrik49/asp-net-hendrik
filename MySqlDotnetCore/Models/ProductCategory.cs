using System;
using System.ComponentModel.DataAnnotations;

namespace MySqlDotnetCore.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            this.Create_Date =  DateTime.Now;
        }

        [Key]
        public int seq_Id { get; set; }
        public String Product_Category_Code { set; get; }
        public String Category_Name { set; get; }
        public String Category_Description { set; get; }
        public String Status { set; get; }
        public DateTime Create_Date { set; get; }
        public DateTime Update_Date { set; get; }
        public bool Is_Deleted { set; get; }
 
    }
}