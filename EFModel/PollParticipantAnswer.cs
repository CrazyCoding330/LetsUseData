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
    
    public partial class PollParticipantAnswer
    {
        public int PollAnswerId { get; set; }
        public int StudentId { get; set; }
        public int PollQuestionId { get; set; }
        public int PollGroupId { get; set; }
        public Nullable<int> PollOptionId { get; set; }
        public string TextAnswer { get; set; }
        public System.DateTime EnlistedDate { get; set; }
        public Nullable<int> ModuleObjectiveId { get; set; }
        public Nullable<int> CourseInstanceId { get; set; }
    
        public virtual CourseInstance CourseInstance { get; set; }
        public virtual ModuleObjective ModuleObjective { get; set; }
        public virtual PollGroup PollGroup { get; set; }
        public virtual PollQuestion PollQuestion { get; set; }
        public virtual Student Student { get; set; }
    }
}