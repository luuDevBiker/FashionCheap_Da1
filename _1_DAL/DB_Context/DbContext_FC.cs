using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;


namespace DAL_DataAccessLayers.DBContex_FC
{
    public class DbContext_FC : DbContext
    {

        //1. Kế thừa 1 cái phương thức OnConfiguring của lớp cha
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(

                    //<<<<<<< HEAD
                    "Data Source = DESKTOP-NVB7S6L; Initial Catalog = Db_Cheap; Persist Security Info = True; User ID = kieu96; Password = 123");
                //======="
                // "Data Source=DESKTOP-NVB7S6L;Initial Catalog=DA_FashionCheap;Persist Security Info=True;User ID=kieu96;Password=123");
                //>>>>>>> 2d9d9432cf77a78215193eb0df320c121d008921

                // thay đường dẫ Data ở đây
            }
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        //Khi cấu hình đổi tên DATABASE mà các bạn muốn nó tạo ra
        //        optionsBuilder.UseSqlServer(
        //            "Data Source=desktop-nvb7s6l;Initial Catalog=DB_FashionsCheap;Persist Security Info=True;User ID=kieu96;Password=123");
        //    }
        //}

        //khai báo bảng
        public DbSet<PRODUCTS> Productses { get; set; }
        public DbSet<PRODUCTS_VARIANTS> ProductsVariantses { get; set; }
        public DbSet<PRODUCTS_OPTIONS> ProductsOptionses { get; set; }
        public DbSet<OPTIONS> Optionses { get; set; }
        public DbSet<OPTIONS_VALUES> OptionsValueses { get; set; }
        public DbSet<VARIANTS_VALUES> VariantsValueses { get; set; }
        public DbSet<ORDERS> Orderses { get; set; }
        public DbSet<ORDER_DETAILS> OrderDetailses { get; set; }
        public DbSet<IMAGES_PRODUCTS> ImagesProductses { get; set; }
        public DbSet<CUSTOMERS> Customerss { get; set; }
        public DbSet<EMPLOYEES> Employeeses { get; set; }
        public DbSet<ROLES_EMPLOYEE> RolesEmployees { get; set; }
        public DbSet<ROLES> Roleses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {// Gọi các API từ đối tượng entity để xây dựng bảng Product
            base.OnModelCreating(modelBuilder);

            ////Bảng PRODUCTS
            modelBuilder.Entity<PRODUCTS>(entity =>
            {
                entity.ToTable("PRODUCTS");
                entity.HasKey(p => p.id_Product);
                entity.Property(e => e.products_Name).HasMaxLength(50);
            });
            // bảng Option
            modelBuilder.Entity<OPTIONS>(entity =>
            {
                entity.ToTable("OPTIONS");
                entity.HasKey(p => p.id_Option);
                entity.Property(e => e.option_Name).HasMaxLength(50);
            });
            // bảng Products_OPtion
            modelBuilder.Entity<PRODUCTS_OPTIONS>(entity =>
            {
                entity.ToTable("PRODUCTS_OPTIONS");
                entity.HasKey(p => new { p.id_Product, p.id_Option });

                entity.HasOne(p => p.Products)
                    .WithMany(c => c.ProductsOptionses)
                    .HasForeignKey(c => c.id_Product)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(p => p.Optionses)
                    .WithMany(c => c.OptionsesProductses)
                    .HasForeignKey(c => c.id_Option)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
            // bảng Option_Values
            modelBuilder.Entity<OPTIONS_VALUES>(entity =>
            {
                entity.ToTable("OPTIONS_VALUES");
                entity.HasKey(p => p.id_Values);
                entity.HasOne(p => p.Options)
                    .WithMany(c => c.OptionsValueses)
                    .HasForeignKey(c => c.id_Option)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
            // Bảng PRODUCTS_VARIANTS
            modelBuilder.Entity<PRODUCTS_VARIANTS>(entity =>
            {
                entity.ToTable("PRODUCTS_VARIANTS");
                entity.HasKey(p => p.id_Variant);
                entity.HasOne(p => p.Products)
                    .WithMany(c => c.ProductsVariantses)
                    .HasForeignKey(c => c.id_Product)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<VARIANTS_VALUES>(entity =>
            {
                entity.ToTable("VARIANTS_VALUES");
                entity.HasKey(p => new { p.id_Product, p.id_Variant, p.id_Option, p.id_Values });
                //noi bang PRoducts_Variants
                entity.HasOne<PRODUCTS_VARIANTS>(p => p.ProductsVariants)
                    .WithMany(c => c.VariantValues)
                    .HasForeignKey(d => d.id_Variant)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                // noi bang PROducts_option
                entity.HasOne<PRODUCTS_OPTIONS>(p => p.ProductsOptions)
                    .WithMany(c => c.ProductOPtionses)
                    .HasForeignKey(c => new { c.id_Product, c.id_Option })
                    .OnDelete(DeleteBehavior.ClientSetNull);
                // noi bang OPTION_VALUES
                entity.HasOne<OPTIONS_VALUES>(i => i.OptionsValues)
                    .WithMany(c => c.OptionValueses)
                    .HasForeignKey(c => c.id_Values).OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<CUSTOMERS>(entity =>
            {
                entity.ToTable("CUSTOMERS");
                entity.HasKey(e => e.id_Customer);

            });

            modelBuilder.Entity<EMPLOYEES>(entity =>
            {
                entity.ToTable("EMPLOYEES");
                entity.HasKey(e => e.id_Employee);

            });

            modelBuilder.Entity<IMAGES_PRODUCTS>(entity =>
            {
                entity.ToTable("IMAGES_PRODUCTS");
                entity.HasKey(e => e.id_Image);
                entity.HasOne(p => p.ProductVariants)
                .WithMany(p => p.ImageProductses)
                .HasForeignKey(p => p.id_variant)
                .OnDelete(DeleteBehavior.ClientSetNull);

            });
            modelBuilder.Entity<ORDERS>(entity =>
            {
                entity.ToTable("ORDERS");
                entity.HasKey(e => e.id_Order);

                entity.HasOne<EMPLOYEES>(d => d.Employees)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.id_Employee);

                entity.HasOne<CUSTOMERS>(d => d.Customers)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.id_Customer);
            });

            modelBuilder.Entity<ORDER_DETAILS>(entity =>
            {
                entity.ToTable("ORDERS_DETAILS");
                entity.HasKey(p => new { p.id_Order, p.id_Product, p.id_Variant });
                entity.HasOne<ORDERS>(d => d.Orders)
                    .WithMany(p => p.OrDerDetailses)
                    .HasForeignKey(d => d.id_Order)
                    .OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne<PRODUCTS_VARIANTS>(d => d.ProductVariants)
                    .WithMany(c => c.OrderDetailses)
                    .HasForeignKey(d => d.id_Variant)
                    .OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne<PRODUCTS>(d => d.Products)
                    .WithMany(c => c.OrderDetailses)
                    .HasForeignKey(d => d.id_Product)
                    .OnDelete(DeleteBehavior.ClientSetNull);

            });
            modelBuilder.Entity<ROLES_EMPLOYEE>(entity =>
            {
                entity.ToTable("ROLES_EMPLOYEE");
                entity.HasNoKey();
                entity.HasOne<ROLES>(d => d.Roleses)
                    .WithMany()
                    .HasForeignKey(d => d.id_Roles);

                entity.HasOne<EMPLOYEES>(d => d.Employees)
                    .WithMany()
                    .HasForeignKey(d => d.id_Employee);
            });
            modelBuilder.Entity<ROLES>(entity =>
            {
                entity.ToTable("ROLES");
                entity.HasKey(c => c.id_roles);
            });


        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Hang>(entity =>
        //    {

        //        entity.HasKey(p => new { p.MaHang }); // thiết lập 2  khóa chính
        //        //entity.HasOne(e => e.MaNV)//thiết lập khóa ngoại
        //        //    .WithMany()
        //        //    .HasForeignKey("MaNV");// đặt tên cột khóa ngoại
        //    });
        //    modelBuilder.Entity<KhachHang>(entity =>
        //    {
        //        entity.HasKey(p => p.DienThoai);
        //        entity.HasOne<NhanVien>(p => p.MaNV)
        //            .WithMany(p=>p.MaNV)
        //            .HasForeignKey(c=>c.MaNV);
        //    });
        //    modelBuilder.Entity<NhanVien>(entity =>
        //    {
        //        entity.ToTable("NHANVIEN1");
        //    });

        //}
    }
}
