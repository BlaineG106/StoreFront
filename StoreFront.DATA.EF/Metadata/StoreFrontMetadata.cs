using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreFront.DATA.EF//Metadata
{
    //It will be required on the font end if you do it that way, but they should match.  If you have data in the DB, you will want to complete ALL instances of that field (manually in SQL SERVER MANAGEMENT STUDIO), then update it to NOT allow nulls.  
    //Once done with that, you can open your edmx, right click in the blank space.Select Update Model From database(go to the refresh tab in the dialog box) select tables, then the affirmative button in that box.When it is done - Build the EDMX.Your DB and EF Models will be synched at that time. (make sure you do add the [Required] for that property in your metadata.

    //class StoreFrontMetadata
    //{
    //}

    #region Categories Metadata
    public class CategoriesMetadata
    {
        //public int CategoryID { get; set; }
        [Display(Name = "Category Name")]
        [Required(ErrorMessage = "* Category Name is required *")]
        [StringLength(20, ErrorMessage = "* Category Name must be 20 characters or less *")]
        public string CategoryName { get; set; }
    }

    [MetadataType(typeof(CategoriesMetadata))]
    public partial class Categories { }
    #endregion

    #region Departments Metadata
    public class DepartmentsMetadata
    {
        //public int DepartmentID { get; set; }
        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "* Department Name is required *")]
        [StringLength(50, ErrorMessage = "* Department Name must be 50 characters or less *")]
        public string DepartmentName { get; set; }
    }

    [MetadataType(typeof(DepartmentsMetadata))]
    public partial class Departments { }
    #endregion

    #region Employee Metadata
    public class EmployeesMetadata
    {
       //public int EmployeeID { get; set; }
        [Display(Name = "First Name")]
        [StringLength(50, ErrorMessage = "* First Name must be 50 characters or less *")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(50, ErrorMessage = "* Last Name must be 50 characters or less *")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "* DepartmentID is required *")]
        public int DepartmentID { get; set; }

        [Display(Name = "Reports To")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public Nullable<int> DirectReportTo { get; set; }
    }

    [MetadataType(typeof(EmployeesMetadata))]
    public partial class Employees { }
    #endregion

    #region Products Metadata
    public class ProductsMetadata
    {
        //public int ProductID { get; set; }
        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "* Product Name is required *")]
        public string ProductName { get; set; }

        [Display(Name = "Category")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public Nullable<int> CategoryID { get; set; }

        [Required(ErrorMessage = "* Price is required *")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }

        [Display(Name = "Status")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public Nullable<int> StatusID { get; set; }

        [Display(Name = "")]
        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string ProductImagePath { get; set; }

        [DisplayFormat(NullDisplayText = "[-N/A-]")]
        public string Description { get; set; }
    }

    [MetadataType(typeof(ProductsMetadata))]
    public partial class Products { }
    #endregion

    #region Statuses Metadata
    public class StatusesMetadata
    {
        //public int StatusID { get; set; }
        [Display(Name = "Status Name")]
        public string StatusName { get; set; }

    }

    [MetadataType(typeof(StatusesMetadata))]
    public partial class Statuses { }
    #endregion
}
