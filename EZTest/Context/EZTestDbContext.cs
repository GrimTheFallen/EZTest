using EZTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EZTest.Context
{
    public class EZTestDbContext : DbContext
    {
        public EZTestDbContext()
           : base("EZTestDbContext")
        {

        }

        public DbSet<Answer> Answers { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Institution> Institutions{ get; set; }
        public DbSet<InstitutionType> InstitutionTypes { get; set;}
        public DbSet<Question> Questions { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectType> SubjectTypes { get; set; }
        public DbSet<SubjectQuestion> SubjectQuestions { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherInstitution> TeacherInstitutions { get; set; }
        public DbSet<TeacherSubject> TeacherSubjects { get; set; }
        public DbSet<Test> Tests{ get; set; }
        public DbSet<TestQuestion> TestQuestions { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

       // public System.Data.Entity.DbSet<EZTest.Models.Test> Tests { get; set; }
    }
}