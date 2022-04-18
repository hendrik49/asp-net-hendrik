using System;
using System.ComponentModel.DataAnnotations;

namespace MySqlDotnetCore.Models
{
    public partial class ProductCategory
    {
        [Key]
        public int seqId { get; set; }
        public String Product_Category_Code { set; get; }
        public String Category_Name { set; get; }
        public String Category_Description { set; get; }
        public String Status { set; get; }
        public DateTime Create_Date { set; get; }
        public DateTime Update_Date { set; get; }
 
    }
}