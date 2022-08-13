using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Library.Models
{
    public partial class OJT_MANAGEMENT_PRN211_Vs2Context : DbContext
    {
        public OJT_MANAGEMENT_PRN211_Vs2Context()
        {
        }

        public OJT_MANAGEMENT_PRN211_Vs2Context(DbContextOptions<OJT_MANAGEMENT_PRN211_Vs2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAccount> TblAccounts { get; set; }
        public virtual DbSet<TblCompany> TblCompanies { get; set; }
        public virtual DbSet<TblJob> TblJobs { get; set; }
        public virtual DbSet<TblMajor> TblMajors { get; set; }
        public virtual DbSet<TblRegisterJob> TblRegisterJobs { get; set; }
        public virtual DbSet<TblSemester> TblSemesters { get; set; }
        public virtual DbSet<TblStudent> TblStudents { get; set; }
        public virtual DbSet<TblStudentSemester> TblStudentSemesters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server =(local); database = OJT_MANAGEMENT_PRN211_Vs2;uid=sa;pwd=12345;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblAccount>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__tblAccou__F3DBC573480365E0");

                entity.ToTable("tblAccount");

                entity.Property(e => e.Username)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.IsAdmin).HasColumnName("isAdmin");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<TblCompany>(entity =>
            {
                entity.HasKey(e => e.TaxCode)
                    .HasName("PK__tblCompa__D97858A7D56D85AD");

                entity.ToTable("tblCompany");

                entity.HasIndex(e => e.Username, "UQ__tblCompa__F3DBC57214222047")
                    .IsUnique();

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("taxCode");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .HasColumnName("address");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(100)
                    .HasColumnName("companyName");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithOne(p => p.TblCompany)
                    .HasForeignKey<TblCompany>(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_account");
            });

            modelBuilder.Entity<TblJob>(entity =>
            {
                entity.HasKey(e => e.JobCode)
                    .HasName("PK__tblJob__5B60E0DDA98ACA26");

                entity.ToTable("tblJob");

                entity.Property(e => e.JobCode).HasColumnName("jobCode");

                entity.Property(e => e.AdminConfirm).HasColumnName("admin_Confirm");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnType("date")
                    .HasColumnName("expirationDate");

                entity.Property(e => e.JobDescription)
                    .HasMaxLength(300)
                    .HasColumnName("jobDescription");

                entity.Property(e => e.JobName)
                    .HasMaxLength(50)
                    .HasColumnName("jobName");

                entity.Property(e => e.MajorCode).HasColumnName("majorCode");

                entity.Property(e => e.NumberInterns).HasColumnName("numberInterns");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TaxCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("taxCode");

                entity.HasOne(d => d.MajorCodeNavigation)
                    .WithMany(p => p.TblJobs)
                    .HasForeignKey(d => d.MajorCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_job_major");

                entity.HasOne(d => d.TaxCodeNavigation)
                    .WithMany(p => p.TblJobs)
                    .HasForeignKey(d => d.TaxCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_company_job");
            });

            modelBuilder.Entity<TblMajor>(entity =>
            {
                entity.HasKey(e => e.MajorCode)
                    .HasName("PK__tblMajor__E397B9AD55D4510D");

                entity.ToTable("tblMajor");

                entity.Property(e => e.MajorCode).HasColumnName("majorCode");

                entity.Property(e => e.MajorName)
                    .HasMaxLength(100)
                    .HasColumnName("majorName");
            });

            modelBuilder.Entity<TblRegisterJob>(entity =>
            {
                entity.HasKey(e => new { e.StudentCode, e.JobCode })
                    .HasName("PK__tblRegis__8D41E13AADAD3D52");

                entity.ToTable("tblRegister_Job");

                entity.Property(e => e.StudentCode)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("studentCode");

                entity.Property(e => e.JobCode).HasColumnName("jobCode");

                entity.Property(e => e.Aspiration).HasColumnName("aspiration");

                entity.Property(e => e.Comment)
                    .HasMaxLength(200)
                    .HasColumnName("comment");

                entity.Property(e => e.Grade).HasColumnName("grade");

                entity.Property(e => e.IsCompanyConfirm).HasColumnName("isCompanyConfirm");

                entity.Property(e => e.IsPass).HasColumnName("is_Pass");

                entity.Property(e => e.StudentConfirm).HasColumnName("student_Confirm");

                entity.HasOne(d => d.JobCodeNavigation)
                    .WithMany(p => p.TblRegisterJobs)
                    .HasForeignKey(d => d.JobCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_registerJob_job");

                entity.HasOne(d => d.StudentCodeNavigation)
                    .WithMany(p => p.TblRegisterJobs)
                    .HasForeignKey(d => d.StudentCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_registerJob_student");
            });

            modelBuilder.Entity<TblSemester>(entity =>
            {
                entity.HasKey(e => e.SemesterId)
                    .HasName("PK__tblSemes__F2F37EA794E208E7");

                entity.ToTable("tblSemester");

                entity.Property(e => e.SemesterId).HasColumnName("semesterID");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("endDate");

                entity.Property(e => e.SemesterName)
                    .HasMaxLength(50)
                    .HasColumnName("semesterName");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");
            });

            modelBuilder.Entity<TblStudent>(entity =>
            {
                entity.HasKey(e => e.StudentCode)
                    .HasName("PK__tblStude__48F7EF379EC3379C");

                entity.ToTable("tblStudent");

                entity.HasIndex(e => e.Username, "UQ__tblStude__F3DBC5725FF96A1F")
                    .IsUnique();

                entity.Property(e => e.StudentCode)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("studentCode");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .HasColumnName("address");

                entity.Property(e => e.BirthOfDate)
                    .HasColumnType("date")
                    .HasColumnName("birthOfDate");

                entity.Property(e => e.Credit).HasColumnName("credit");

                entity.Property(e => e.Gender).HasColumnName("gender");

                entity.Property(e => e.IsIntern).HasColumnName("is_Intern");

                entity.Property(e => e.Majorname)
                    .HasMaxLength(100)
                    .HasColumnName("majorname");

                entity.Property(e => e.StudentName)
                    .HasMaxLength(50)
                    .HasColumnName("studentName");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithOne(p => p.TblStudent)
                    .HasForeignKey<TblStudent>(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_student_account");
            });

            modelBuilder.Entity<TblStudentSemester>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__tblStude__D825197E5FA4966B");

                entity.ToTable("tblStudent_Semester");

                entity.Property(e => e.RecordId).HasColumnName("recordID");

                entity.Property(e => e.SemesterId).HasColumnName("semesterID");

                entity.Property(e => e.StudentCode)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("studentCode");

                entity.HasOne(d => d.Semester)
                    .WithMany(p => p.TblStudentSemesters)
                    .HasForeignKey(d => d.SemesterId)
                    .HasConstraintName("FK_studentSemester_Semester");

                entity.HasOne(d => d.StudentCodeNavigation)
                    .WithMany(p => p.TblStudentSemesters)
                    .HasForeignKey(d => d.StudentCode)
                    .HasConstraintName("FK_studentSemester_Student");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
