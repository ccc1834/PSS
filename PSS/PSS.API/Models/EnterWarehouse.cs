//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSS.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EnterWarehouse
    {
        public EnterWarehouse()
        {
            this.Enterrequest = new HashSet<Enterrequest>();
        }
    
        public int Eid { get; set; }
        public int Sid { get; set; }
        public System.DateTime Edate { get; set; }
        public decimal Eamount { get; set; }
        public int Stid { get; set; }
        public string Eremarks { get; set; }
        public int Gdid { get; set; }
        public int Ecount { get; set; }
        public int Estate { get; set; }
    
        public virtual ICollection<Enterrequest> Enterrequest { get; set; }
        public virtual Goods Goods { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}