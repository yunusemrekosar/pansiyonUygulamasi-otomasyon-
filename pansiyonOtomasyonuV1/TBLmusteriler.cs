//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pansiyonOtomasyonuV1
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLmusteriler
    {
        public int musteriID { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string telNu { get; set; }
        public string cinsiyet { get; set; }
        public string mail { get; set; }
        public string tcKimlikNu { get; set; }
        public Nullable<int> odaUcreti { get; set; }
        public string odaNu { get; set; }
        public Nullable<System.DateTime> girisTarihi { get; set; }
        public Nullable<System.DateTime> cikisTarihi { get; set; }
    }
}