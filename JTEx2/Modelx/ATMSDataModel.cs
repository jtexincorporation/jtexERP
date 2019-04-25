namespace Modelx
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ATMSDataModel : DbContext
    {
        public ATMSDataModel()
            : base("name=ATMSDataModel")
        {
        }

        public virtual DbSet<C__EFMigrationsHistory> C__EFMigrationsHistory { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleStatu> ArticleStatus { get; set; }
        public virtual DbSet<AspNetRoleClaim> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<File> Files { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<LoginSecurity> LoginSecurities { get; set; }
        public virtual DbSet<POid> POids { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Size> Sizes { get; set; }
        public virtual DbSet<ArticleBarcode> ArticleBarcodes { get; set; }
        public virtual DbSet<folderPath> folderPaths { get; set; }
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .Property(e => e.StyleNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Comp)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Article>()
                .Property(e => e.PicturePath)
                .IsUnicode(false);

            modelBuilder.Entity<Article>()
                .HasMany(e => e.ArticleStatus)
                .WithRequired(e => e.Article)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Article>()
                .HasMany(e => e.PurchaseOrders)
                .WithRequired(e => e.Article)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetRoleClaims)
                .WithRequired(e => e.AspNetRole)
                .HasForeignKey(e => e.RoleId);

            modelBuilder.Entity<AspNetRole>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUser>()
                .HasMany(e => e.AspNetUserTokens)
                .WithRequired(e => e.AspNetUser)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<Brand>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Articles)
                .WithRequired(e => e.Brand1)
                .HasForeignKey(e => e.Brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.contact)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.web)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.PurchaseOrders)
                .WithRequired(e => e.Client1)
                .HasForeignKey(e => e.client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Color>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .HasMany(e => e.Articles)
                .WithRequired(e => e.Color1)
                .HasForeignKey(e => e.Color)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.Articles)
                .WithOptional(e => e.Currency1)
                .HasForeignKey(e => e.Currency);

            modelBuilder.Entity<File>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<File>()
                .Property(e => e.SourcePath)
                .IsUnicode(false);

            modelBuilder.Entity<File>()
                .Property(e => e.DestinationPath)
                .IsUnicode(false);

            modelBuilder.Entity<File>()
                .Property(e => e.FileType)
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Articles)
                .WithRequired(e => e.Gender1)
                .HasForeignKey(e => e.Gender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Season>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Season>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Season>()
                .HasMany(e => e.PurchaseOrders)
                .WithOptional(e => e.Season1)
                .HasForeignKey(e => e.season);

            modelBuilder.Entity<Size>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Size>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Size>()
                .HasMany(e => e.Articles)
                .WithOptional(e => e.Size)
                .HasForeignKey(e => e.Currency);

            modelBuilder.Entity<Size>()
                .HasMany(e => e.ArticleBarcodes)
                .WithRequired(e => e.Size)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PurchaseOrder>()
                .Property(e => e.doc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PurchaseOrder>()
                .Property(e => e.id)
                .HasPrecision(18, 0);
        }
    }
}
