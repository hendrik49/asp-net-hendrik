using System;
using System.ComponentModel.DataAnnotations;

namespace MySqlDotnetCore.Models
{
    public partial class ProductType
    {

        public ProductType()
        {
            this.Create_Date = DateTime.Now;    
        }

        [Key]
        public int seq_Id { get; set; }
        public String Product_Category_Code { set; get; }
        public String Product_Type_Code { set; get; }
        public String Type_Name { set; get; }
        public String Type_Description { set; get; }
        public String Status { set; get; }
        public DateTime Create_Date { set; get; }
        public DateTime Update_Date { set; get; }
        public bool Is_Deleted { set; get; }
 
    }
}