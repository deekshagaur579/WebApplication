//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestResult
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public string TestCase { get; set; }
        public string Name { get; set; }
        public string TranName { get; set; }
        public string Result { get; set; }
        public string Msg { get; set; }
        public System.DateTime TestStartTime { get; set; }
        public Nullable<System.DateTime> TestEndTime { get; set; }
    }
}
