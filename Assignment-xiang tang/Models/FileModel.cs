namespace Assignment_xiang_tang.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class FileModel : DbContext
    {
        public FileModel()
            : base("name=FileModel")
        {
        }

        public virtual DbSet<File> Files { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<File>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<File>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
