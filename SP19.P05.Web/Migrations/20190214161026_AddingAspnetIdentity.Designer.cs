﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SP19.P05.Web.Data;

namespace SP19.P05.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190214161026_AddingAspnetIdentity")]
    partial class AddingAspnetIdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<int>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Authorization.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(32);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "6e1bd55e-88dc-437c-a2a1-befdf4bc7388",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "f819a640-05de-44fb-afb9-0737937bab28",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "28d0b44c-44fa-4ff8-b899-2a6b39b181d1",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = 4,
                            ConcurrencyStamp = "3625f5a5-48c7-4576-b995-5dc7c5c40bbf",
                            Name = "Server",
                            NormalizedName = "SERVER"
                        });
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Authorization.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(1024);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("Phone")
                        .HasMaxLength(16);

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Customers.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("SP19.P04.Web.Features.LineItems.LineItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(128);

                    b.Property<int>("ReceiptId");

                    b.HasKey("Id");

                    b.HasIndex("ReceiptId");

                    b.ToTable("LineItem");
                });

            modelBuilder.Entity("SP19.P04.Web.Features.LineItems.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(512);

                    b.Property<int>("MenuId");

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("PictureUrl")
                        .HasMaxLength(1024);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(38,16)");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.ToTable("MenuItem");
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Menus.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Payments.PaymentOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<string>("Nickname")
                        .HasMaxLength(16);

                    b.Property<string>("TokenizedCardReference")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("PaymentOption");
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Payments.Receipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthNumber")
                        .HasMaxLength(16);

                    b.Property<DateTimeOffset>("DateOfPaymentUtc");

                    b.Property<int>("PaymentOptionId");

                    b.Property<string>("ReferenceNumber")
                        .HasMaxLength(16);

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(38,16)");

                    b.HasKey("Id");

                    b.HasIndex("PaymentOptionId");

                    b.ToTable("Receipt");
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Tables.CustomerTableBill", b =>
                {
                    b.Property<int>("TableBillId");

                    b.Property<int>("CustomerId");

                    b.HasKey("TableBillId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("CustomerTableBill");
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Tables.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("NumberOfSeats");

                    b.HasKey("Id");

                    b.ToTable("Table");
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Tables.TableBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset?>("EndDateUtc");

                    b.Property<DateTimeOffset>("StartDateUtc");

                    b.Property<int>("TableId");

                    b.HasKey("Id");

                    b.HasIndex("TableId");

                    b.ToTable("TableBill");
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Tables.TableFoodItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("Discount")
                        .HasColumnType("decimal(38,16)");

                    b.Property<int>("MenuItemId");

                    b.Property<long>("QuantityOrdered");

                    b.Property<int>("TableBillId");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("TableBillId");

                    b.ToTable("TableFoodItem");
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Authorization.UserRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<int>");

                    b.Property<int?>("RoleId1");

                    b.Property<int?>("UserId1");

                    b.HasIndex("RoleId1");

                    b.HasIndex("UserId1");

                    b.HasDiscriminator().HasValue("UserRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.Authorization.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.Authorization.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.Authorization.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.Authorization.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SP19.P04.Web.Features.Authorization.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.Authorization.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Customers.Customer", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.Authorization.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("SP19.P04.Web.Features.Shared.Address", "MailingAddress", b1 =>
                        {
                            b1.Property<int>("CustomerId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .HasMaxLength(64);

                            b1.Property<string>("Line1")
                                .HasMaxLength(64);

                            b1.Property<string>("Line2")
                                .HasMaxLength(64);

                            b1.Property<string>("State")
                                .HasMaxLength(2);

                            b1.Property<string>("ZipCode")
                                .HasMaxLength(5);

                            b1.HasKey("CustomerId");

                            b1.ToTable("Customer");

                            b1.HasOne("SP19.P04.Web.Features.Customers.Customer")
                                .WithOne("MailingAddress")
                                .HasForeignKey("SP19.P04.Web.Features.Shared.Address", "CustomerId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("SP19.P04.Web.Features.LineItems.LineItem", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.Payments.Receipt", "Receipt")
                        .WithMany("LineItems")
                        .HasForeignKey("ReceiptId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SP19.P04.Web.Features.LineItems.MenuItem", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.Menus.Menu", "Menu")
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Payments.PaymentOption", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.Customers.Customer", "Customer")
                        .WithMany("PaymentOptions")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("SP19.P04.Web.Features.Shared.Address", "BillingAddress", b1 =>
                        {
                            b1.Property<int>("PaymentOptionId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("City")
                                .HasMaxLength(64);

                            b1.Property<string>("Line1")
                                .HasMaxLength(64);

                            b1.Property<string>("Line2")
                                .HasMaxLength(64);

                            b1.Property<string>("State")
                                .HasMaxLength(2);

                            b1.Property<string>("ZipCode")
                                .HasMaxLength(5);

                            b1.HasKey("PaymentOptionId");

                            b1.ToTable("PaymentOption");

                            b1.HasOne("SP19.P04.Web.Features.Payments.PaymentOption")
                                .WithOne("BillingAddress")
                                .HasForeignKey("SP19.P04.Web.Features.Shared.Address", "PaymentOptionId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Payments.Receipt", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.Payments.PaymentOption", "PaymentOption")
                        .WithMany()
                        .HasForeignKey("PaymentOptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Tables.CustomerTableBill", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.Customers.Customer", "Customer")
                        .WithMany("TableBills")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SP19.P04.Web.Features.Tables.TableBill", "TableBill")
                        .WithMany("Customers")
                        .HasForeignKey("TableBillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Tables.TableBill", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.Tables.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Tables.TableFoodItem", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.LineItems.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SP19.P04.Web.Features.Tables.TableBill", "TableBill")
                        .WithMany("TableFoodItems")
                        .HasForeignKey("TableBillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SP19.P04.Web.Features.Authorization.UserRole", b =>
                {
                    b.HasOne("SP19.P04.Web.Features.Authorization.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId1");

                    b.HasOne("SP19.P04.Web.Features.Authorization.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId1");
                });
#pragma warning restore 612, 618
        }
    }
}