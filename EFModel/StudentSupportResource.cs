//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class StudentSupportResource
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public int SchoolId { get; set; }
    
        public virtual School School { get; set; }
    }
}