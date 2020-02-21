namespace TimeSheetSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Entry : DbContext
    {
        public Entry()
            : base("name=ConnectionForContext")
        {
        }

        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Post>()
                .HasMany(e => e.Members)
                .WithRequired(e => e.Post)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Post>()
                .HasMany(e => e.Roles)
                .WithMany(e => e.Posts)
                .Map(m => m.ToTable("RolePost").MapLeftKey("PostID").MapRightKey("RoleID"));

            modelBuilder.Entity<Role>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Tasks)
                .WithMany(e => e.Roles)
                .Map(m => m.ToTable("RoleTask").MapLeftKey("RoleID").MapRightKey("TaskID"));

            modelBuilder.Entity<Task>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Members)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);
        }
    }
}
