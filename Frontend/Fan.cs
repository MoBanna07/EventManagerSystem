//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fan
    {
        public string National_ID { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Birth_Date { get; set; }
        public string Address { get; set; }
        public string Phone_No { get; set; }
        public Nullable<bool> Status { get; set; }
        public string username { get; set; }
    
        public virtual SystemUser SystemUser { get; set; }
    }
}