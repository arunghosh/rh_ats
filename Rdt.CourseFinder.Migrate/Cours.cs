//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rdt.CourseFinder.Migrate
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cours
    {
        public int CouseId { get; set; }
        public string Name { get; set; }
        public string CourseType { get; set; }
        public int Duration { get; set; }
        public int Fees { get; set; }
        public int Currency { get; set; }
        public int InstitutionId { get; set; }
    
        public virtual Insitution Insitution { get; set; }
    }
}
