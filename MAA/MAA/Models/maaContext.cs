using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MAA.Models
{
    public partial class MaaContext : DbContext
    {
        public virtual DbSet<Interest> Interest { get; set; }
        public virtual DbSet<MortgageApprovalApplication> MortgageApprovalApplication { get; set; }

        public MaaContext(DbContextOptions<MaaContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Interest>(entity =>
            {
                entity.ToTable("interest");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Rate).HasColumnName("rate");
            });

            modelBuilder.Entity<MortgageApprovalApplication>(entity =>
            {
                entity.ToTable("mortgage_approval_application");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreationDatetime)
                    .HasColumnName("creation_datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.InterestId).HasColumnName("interest_id");

                entity.Property(e => e.LoanAmount)
                    .HasColumnName("loan_amount")
                    .HasColumnType("money");

                entity.Property(e => e.MonthlyRepayment)
                    .HasColumnName("monthly_repayment")
                    .HasColumnType("money");

                entity.Property(e => e.TermOfLoan).HasColumnName("term_of_loan");

                entity.Property(e => e.ValueOfHome)
                    .HasColumnName("value_of_home")
                    .HasColumnType("money");
            });
        }
    }
}
