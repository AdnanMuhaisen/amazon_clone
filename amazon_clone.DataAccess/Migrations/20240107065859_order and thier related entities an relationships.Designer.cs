﻿// <auto-generated />
using amazon_clone.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace amazon_clone.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240107065859_order and thier related entities an relationships")]
    partial class orderandthierrelatedentitiesanrelationships
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("amazon_clone.Models.Models.ClothSize", b =>
                {
                    b.Property<int>("SizeID")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.HasKey("SizeID");

                    b.ToTable("tbl_ClothesSizes", (string)null);
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ClothesSizes", b =>
                {
                    b.Property<int>("ClothesProductID")
                        .HasColumnType("int");

                    b.Property<int>("ClothesSizeID")
                        .HasColumnType("int");

                    b.HasKey("ClothesProductID", "ClothesSizeID");

                    b.HasIndex("ClothesSizeID");

                    b.ToTable("ClothesSizes");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<DateTime>("OrderDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderStatusStatusID")
                        .HasColumnType("int");

                    b.Property<int>("ShippingDetailsID")
                        .HasColumnType("int");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.HasKey("OrderID");

                    b.HasIndex("OrderStatusStatusID");

                    b.HasIndex("ShippingDetailsID")
                        .IsUnique();

                    b.ToTable("tbl_Orders", (string)null);
                });

            modelBuilder.Entity("amazon_clone.Models.Models.OrderStatus", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusID"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("tbl_OrderStatuses", (string)null);
                });

            modelBuilder.Entity("amazon_clone.Models.Models.PersonGender", b =>
                {
                    b.Property<int>("GenderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenderID"));

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("GenderID");

                    b.ToTable("tbl_Genders", (string)null);
                });

            modelBuilder.Entity("amazon_clone.Models.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("DeleteDate")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoryID");

                    b.ToTable("tbl_Products", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ProductCategory", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("tbl_ProductCategories", (string)null);
                });

            modelBuilder.Entity("amazon_clone.Models.Models.PromoCode", b =>
                {
                    b.Property<int>("CodeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CodeID"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ForQuantity")
                        .HasColumnType("int");

                    b.HasKey("CodeID");

                    b.ToTable("tbl_PromoCodes", (string)null);
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ShippingDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PinCode")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("tbl_ShippingDetails", (string)null);
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCartID"));

                    b.Property<int>("PromoCodeID")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartID");

                    b.HasIndex("PromoCodeID");

                    b.ToTable("tbl_ShoppingCarts", (string)null);
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ShoppingCartProduct", b =>
                {
                    b.Property<int>("CustomerProductID")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("CustomerProductID", "ShoppingCartID");

                    b.HasIndex("ShoppingCartID");

                    b.ToTable("tbl_ShoppingCartProduct", (string)null);
                });

            modelBuilder.Entity("amazon_clone.Models.Models.WishList", b =>
                {
                    b.Property<int>("WishListID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WishListID"));

                    b.HasKey("WishListID");

                    b.ToTable("tbl_WishLists", (string)null);
                });

            modelBuilder.Entity("amazon_clone.Models.Models.WishListProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ListID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ListID");

                    b.HasIndex("ProductID");

                    b.ToTable("tbl_WishListsProducts", (string)null);
                });

            modelBuilder.Entity("amazon_clone.Models.Models.CustomerProduct", b =>
                {
                    b.HasBaseType("amazon_clone.Models.Models.Product");

                    b.Property<int>("CustomerProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerProductID"));

                    b.ToTable("tbl_CustomerProducts", (string)null);
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ClothesProduct", b =>
                {
                    b.HasBaseType("amazon_clone.Models.Models.CustomerProduct");

                    b.Property<int>("ClothesProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClothesProductID"));

                    b.Property<int>("TargetGenderID")
                        .HasColumnType("int");

                    b.HasIndex("TargetGenderID");

                    b.ToTable("tbl_ClothesProducts", (string)null);
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ClothSize", b =>
                {
                    b.OwnsOne("amazon_clone.Models.Models.CreationDetails", "SizeCreationDetails", b1 =>
                        {
                            b1.Property<int>("ClothSizeSizeID")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("datetime2");

                            b1.HasKey("ClothSizeSizeID");

                            b1.ToTable("tbl_ClothesSizes");

                            b1.WithOwner()
                                .HasForeignKey("ClothSizeSizeID");
                        });

                    b.Navigation("SizeCreationDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ClothesSizes", b =>
                {
                    b.HasOne("amazon_clone.Models.Models.ClothesProduct", "ClothesProduct")
                        .WithMany("ClothesSizes")
                        .HasForeignKey("ClothesProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("amazon_clone.Models.Models.ClothSize", "ClothesSize")
                        .WithMany("ClothesSizes")
                        .HasForeignKey("ClothesSizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClothesProduct");

                    b.Navigation("ClothesSize");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.Order", b =>
                {
                    b.HasOne("amazon_clone.Models.Models.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("amazon_clone.Models.Models.ShippingDetails", "ShippingDetails")
                        .WithOne("Order")
                        .HasForeignKey("amazon_clone.Models.Models.Order", "ShippingDetailsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("amazon_clone.Models.Models.CreationDetails", "CreationDetails", b1 =>
                        {
                            b1.Property<int>("OrderID")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("datetime2");

                            b1.HasKey("OrderID");

                            b1.ToTable("tbl_Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderID");
                        });

                    b.Navigation("CreationDetails")
                        .IsRequired();

                    b.Navigation("OrderStatus");

                    b.Navigation("ShippingDetails");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.OrderStatus", b =>
                {
                    b.OwnsOne("amazon_clone.Models.Models.CreationDetails", "CreationDetails", b1 =>
                        {
                            b1.Property<int>("OrderStatusStatusID")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("datetime2");

                            b1.HasKey("OrderStatusStatusID");

                            b1.ToTable("tbl_OrderStatuses");

                            b1.WithOwner()
                                .HasForeignKey("OrderStatusStatusID");
                        });

                    b.Navigation("CreationDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("amazon_clone.Models.Models.Product", b =>
                {
                    b.HasOne("amazon_clone.Models.Models.ProductCategory", "Category")
                        .WithMany("CategoryProducts")
                        .HasForeignKey("CategoryID");

                    b.OwnsOne("amazon_clone.Models.Models.CreationDetails", "ProductCreationDetails", b1 =>
                        {
                            b1.Property<int>("ProductID")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("datetime2");

                            b1.HasKey("ProductID");

                            b1.ToTable("tbl_Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductID");
                        });

                    b.Navigation("Category");

                    b.Navigation("ProductCreationDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ProductCategory", b =>
                {
                    b.OwnsOne("amazon_clone.Models.Models.CreationDetails", "CategoryCreationDetails", b1 =>
                        {
                            b1.Property<int>("ProductCategoryCategoryID")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("datetime2");

                            b1.HasKey("ProductCategoryCategoryID");

                            b1.ToTable("tbl_ProductCategories");

                            b1.WithOwner()
                                .HasForeignKey("ProductCategoryCategoryID");
                        });

                    b.Navigation("CategoryCreationDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("amazon_clone.Models.Models.PromoCode", b =>
                {
                    b.OwnsOne("amazon_clone.Models.Models.CreationDetails", "CreationDetails", b1 =>
                        {
                            b1.Property<int>("PromoCodeCodeID")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("datetime2");

                            b1.HasKey("PromoCodeCodeID");

                            b1.ToTable("tbl_PromoCodes");

                            b1.WithOwner()
                                .HasForeignKey("PromoCodeCodeID");
                        });

                    b.Navigation("CreationDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ShippingDetails", b =>
                {
                    b.OwnsOne("amazon_clone.Models.Models.CreationDetails", "CreationDetails", b1 =>
                        {
                            b1.Property<int>("ShippingDetailsID")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("datetime2");

                            b1.HasKey("ShippingDetailsID");

                            b1.ToTable("tbl_ShippingDetails");

                            b1.WithOwner()
                                .HasForeignKey("ShippingDetailsID");
                        });

                    b.Navigation("CreationDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ShoppingCart", b =>
                {
                    b.HasOne("amazon_clone.Models.Models.PromoCode", "CartPromoCode")
                        .WithMany("ShoppingCarts")
                        .HasForeignKey("PromoCodeID");

                    b.OwnsOne("amazon_clone.Models.Models.CreationDetails", "CreationDetails", b1 =>
                        {
                            b1.Property<int>("ShoppingCartID")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("datetime2");

                            b1.HasKey("ShoppingCartID");

                            b1.ToTable("tbl_ShoppingCarts");

                            b1.WithOwner()
                                .HasForeignKey("ShoppingCartID");
                        });

                    b.Navigation("CartPromoCode");

                    b.Navigation("CreationDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ShoppingCartProduct", b =>
                {
                    b.HasOne("amazon_clone.Models.Models.CustomerProduct", "CustomerProduct")
                        .WithMany("ShoppingCartsProducts")
                        .HasForeignKey("CustomerProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("amazon_clone.Models.Models.ShoppingCart", "ShoppingCart")
                        .WithMany("ShoppingCartsProducts")
                        .HasForeignKey("ShoppingCartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerProduct");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.WishList", b =>
                {
                    b.OwnsOne("amazon_clone.Models.Models.CreationDetails", "CreationDetails", b1 =>
                        {
                            b1.Property<int>("WishListID")
                                .HasColumnType("int");

                            b1.Property<DateTime>("CreatedAt")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("UpdatedAt")
                                .HasColumnType("datetime2");

                            b1.HasKey("WishListID");

                            b1.ToTable("tbl_WishLists");

                            b1.WithOwner()
                                .HasForeignKey("WishListID");
                        });

                    b.Navigation("CreationDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("amazon_clone.Models.Models.WishListProduct", b =>
                {
                    b.HasOne("amazon_clone.Models.Models.WishList", "WishList")
                        .WithMany("WishListsProducts")
                        .HasForeignKey("ListID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("amazon_clone.Models.Models.CustomerProduct", "CustomerProduct")
                        .WithMany("WishListsProducts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerProduct");

                    b.Navigation("WishList");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.CustomerProduct", b =>
                {
                    b.HasOne("amazon_clone.Models.Models.Product", null)
                        .WithOne()
                        .HasForeignKey("amazon_clone.Models.Models.CustomerProduct", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ClothesProduct", b =>
                {
                    b.HasOne("amazon_clone.Models.Models.CustomerProduct", null)
                        .WithOne()
                        .HasForeignKey("amazon_clone.Models.Models.ClothesProduct", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("amazon_clone.Models.Models.PersonGender", "TargetGender")
                        .WithMany("ClothesProducts")
                        .HasForeignKey("TargetGenderID");

                    b.Navigation("TargetGender");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ClothSize", b =>
                {
                    b.Navigation("ClothesSizes");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.PersonGender", b =>
                {
                    b.Navigation("ClothesProducts");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ProductCategory", b =>
                {
                    b.Navigation("CategoryProducts");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.PromoCode", b =>
                {
                    b.Navigation("ShoppingCarts");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ShippingDetails", b =>
                {
                    b.Navigation("Order")
                        .IsRequired();
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ShoppingCart", b =>
                {
                    b.Navigation("ShoppingCartsProducts");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.WishList", b =>
                {
                    b.Navigation("WishListsProducts");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.CustomerProduct", b =>
                {
                    b.Navigation("ShoppingCartsProducts");

                    b.Navigation("WishListsProducts");
                });

            modelBuilder.Entity("amazon_clone.Models.Models.ClothesProduct", b =>
                {
                    b.Navigation("ClothesSizes");
                });
#pragma warning restore 612, 618
        }
    }
}
