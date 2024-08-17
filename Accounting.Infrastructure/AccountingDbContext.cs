using Accounting.Domain;
using Accounting.Domain.Domain;
using Microsoft.EntityFrameworkCore;

namespace Accounting.Infrastructure;

public class AccountingDbContext : DbContext
{
      // Constructor
      public AccountingDbContext(DbContextOptions<AccountingDbContext> options) : base(options)
      {
      }

      // DbSet Properties for each entity
      public DbSet<User> Users { get; set; }
      public DbSet<Role> Roles { get; set; }
      public DbSet<Account> Accounts { get; set; }
      public DbSet<Transaction> Transactions { get; set; }
      public DbSet<Journal> Journals { get; set; }
      public DbSet<JournalEntry> JournalEntries { get; set; }
      public DbSet<Vendor> Vendors { get; set; }
      public DbSet<Customer> Customers { get; set; }
      public DbSet<Invoice> Invoices { get; set; }
      public DbSet<InvoiceItem> InvoiceItems { get; set; }

      // Configuring the model and relationships
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
            base.OnModelCreating(modelBuilder);

            // User entity configuration
            modelBuilder.Entity<User>(entity =>
            {
                  entity.HasKey(e => e.UserId);
                  entity.Property(e => e.Username)
                        .IsRequired()
                        .HasMaxLength(100);

                  // TODO: Need to fix this.
                  // entity.HasMany(e => e.UserRoles)
                  //      .HasForeignKey(e => e.AccountId)
                  //     .OnDelete(DeleteBehavior.Restrict);
            });

            // Role entity configuration
            modelBuilder.Entity<Role>(entity =>
            {
                  entity.HasKey(e => e.RoleId);
                  entity.Property(e => e.RoleName)
                        .IsRequired()
                        .HasMaxLength(50);
            });

            // Account entity configuration
            modelBuilder.Entity<Account>(entity =>
            {
                  entity.HasKey(e => e.AccountId);
                  entity.Property(e => e.AccountName)
                        .IsRequired()
                        .HasMaxLength(200);

                  entity.Property(e => e.Balance)
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                  entity.Property(e => e.AccountCategoryId)
                        .IsRequired();
            });

            // Transaction entity configuration
            modelBuilder.Entity<Transaction>(entity =>
            {
                  entity.HasKey(e => e.TransactionId);
                  entity.Property(e => e.Amount)
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                  entity.Property(e => e.CreatedAt)
                        .IsRequired()
                        .HasColumnType("datetime");

                  entity.HasOne(e => e.Account)
                        .WithMany(a => a.Transactions)
                        .HasForeignKey(e => e.AccountId)
                        .OnDelete(DeleteBehavior.Restrict);
            });

            // Journal entity configuration
            modelBuilder.Entity<Journal>(entity =>
            {
                  entity.HasKey(e => e.JournalId);
                  entity.Property(e => e.Description)
                        .IsRequired()
                        .HasMaxLength(100);
            });

            // JournalEntry entity configuration
            modelBuilder.Entity<JournalEntry>(entity =>
            {
                  entity.HasKey(e => e.JournalEntryId);
                  entity.Property(e => e.CreatedAt)
                        .IsRequired()
                        .HasColumnType("datetime");

                  entity.HasOne(e => e.Journal)
                        .WithMany(j => j.JournalEntries)
                        .HasForeignKey(e => e.JournalId)
                        .OnDelete(DeleteBehavior.Restrict);

                  entity.HasOne(e => e.Account)
                        .WithMany(a => a.JournalEntries)
                        .HasForeignKey(e => e.AccountId)
                        .OnDelete(DeleteBehavior.Restrict);
            });

            // Vendor entity configuration
            modelBuilder.Entity<Vendor>(entity =>
            {
                  entity.HasKey(e => e.VendorId);
                  entity.Property(e => e.VendorName)
                        .IsRequired()
                        .HasMaxLength(200);

                  entity.Property(e => e.Email)
                        .HasMaxLength(100);

                  entity.Property(e => e.PhoneNumber)
                        .HasMaxLength(50);
            });

            // Customer entity configuration
            modelBuilder.Entity<Customer>(entity =>
            {
                  entity.HasKey(e => e.CustomerId);
                  entity.Property(e => e.CustomerName)
                        .IsRequired()
                        .HasMaxLength(200);

                  entity.Property(e => e.Email)
                        .HasMaxLength(100);

                  entity.Property(e => e.PhoneNumber)
                        .HasMaxLength(50);
            });

            // Invoice entity configuration
            modelBuilder.Entity<Invoice>(entity =>
            {
                  entity.HasKey(e => e.InvoiceId);
                  entity.Property(e => e.InvoiceDate)
                        .IsRequired()
                        .HasColumnType("datetime");

                  entity.HasOne(e => e.Customer)
                        .WithMany(c => c.Invoices)
                        .HasForeignKey(e => e.CustomerId)
                        .OnDelete(DeleteBehavior.Restrict);
            });

            // InvoiceItem entity configuration
            modelBuilder.Entity<InvoiceItem>(entity =>
            {
                  entity.HasKey(e => e.InvoiceItemId);
                  entity.Property(e => e.Description)
                        .IsRequired()
                        .HasMaxLength(500);

                  entity.Property(e => e.Quantity)
                        .IsRequired();

                  entity.Property(e => e.UnitPrice)
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                  entity.HasOne(e => e.Invoice)
                        .WithMany(i => i.InvoiceItems)
                        .HasForeignKey(e => e.InvoiceId)
                        .OnDelete(DeleteBehavior.Restrict);
            });

            // Additional configurations
            modelBuilder.Entity<Account>().HasIndex(a => a.AccountName).IsUnique();
            modelBuilder.Entity<Vendor>().HasIndex(v => v.Email).IsUnique();
            modelBuilder.Entity<Customer>().HasIndex(c => c.Email).IsUnique();
      }
}

