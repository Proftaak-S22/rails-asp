//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rails.App_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class VERBINDING
    {
        public int ID { get; set; }
        public Nullable<int> Sector_ID_Van { get; set; }
        public Nullable<int> Sector_ID_Naar { get; set; }
    
        public virtual SECTOR SECTOR { get; set; }
        public virtual SECTOR SECTOR1 { get; set; }
    }
}
