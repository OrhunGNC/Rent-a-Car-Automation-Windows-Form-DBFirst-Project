//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentaCar
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personel
    {
        public int personelID { get; set; }
        public string personelNameSurname { get; set; }
        public string personelPhone { get; set; }
        public string personelTitle { get; set; }
        public string personelMail { get; set; }
        public Nullable<decimal> personelWage { get; set; }
        public Nullable<int> branchID { get; set; }
    
        public virtual Branch Branch { get; set; }
    }
}
