//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TP_OH_IIT_2020_API
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuizTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuizTable()
        {
            this.QuestionsTables = new HashSet<QuestionsTable>();
            this.QuizAttempts = new HashSet<QuizAttempt>();
        }
    
        public int quizID { get; set; }
        public string quizName { get; set; }
        public string quizDescription { get; set; }
        public Nullable<int> quizCredits { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionsTable> QuestionsTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuizAttempt> QuizAttempts { get; set; }
    }
}
