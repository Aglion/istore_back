﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using istore_api.src.Infrastructure.Data;

#nullable disable

namespace istore_api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240422081226_email_req")]
    partial class email_req
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("istore_api.src.Domain.Models.BlogTopic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.DeviceModel", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("ProductCategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.HasIndex("ProductCategoryName");

                    b.ToTable("DeviceModels");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.InitialRegistration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("InitialRegistrations");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<string>("CommunicationMethod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("TotalSum")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.OrderProduct", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductConfigurationId")
                        .HasColumnType("uuid");

                    b.Property<int>("Count")
                        .HasColumnType("integer");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uuid");

                    b.HasKey("OrderId", "ProductConfigurationId");

                    b.HasIndex("ProductConfigurationId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DeviceModelName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DeviceModelName");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.ProductCategory", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.ProductCharacteristic", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Hex")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Values")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCharacteristics");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.ProductConfigCharacteristic", b =>
                {
                    b.Property<Guid>("ProductCharacteristicId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductConfigurationId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ProductCharacteristicId", "ProductConfigurationId");

                    b.HasIndex("ProductConfigurationId");

                    b.ToTable("ProductConfigCharacteristics");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.ProductConfiguration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductConfigurations");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.PromoCode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateExpiration")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.ToTable("PromoCodes");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<long?>("ChatId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RestoreCode")
                        .HasColumnType("text");

                    b.Property<DateTime?>("RestoreCodeValidBefore")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<DateTime?>("TokenValidBefore")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("WasPasswordResetRequest")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Token")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.DeviceModel", b =>
                {
                    b.HasOne("istore_api.src.Domain.Models.ProductCategory", "ProductCategory")
                        .WithMany("DeviceModels")
                        .HasForeignKey("ProductCategoryName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.OrderProduct", b =>
                {
                    b.HasOne("istore_api.src.Domain.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("istore_api.src.Domain.Models.ProductConfiguration", "ProductConfiguration")
                        .WithMany()
                        .HasForeignKey("ProductConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("istore_api.src.Domain.Models.Product", null)
                        .WithMany("Orders")
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("ProductConfiguration");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.Product", b =>
                {
                    b.HasOne("istore_api.src.Domain.Models.DeviceModel", "DeviceModel")
                        .WithMany("Products")
                        .HasForeignKey("DeviceModelName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeviceModel");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.ProductCharacteristic", b =>
                {
                    b.HasOne("istore_api.src.Domain.Models.Product", "Product")
                        .WithMany("ProductCharacteristics")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.ProductConfigCharacteristic", b =>
                {
                    b.HasOne("istore_api.src.Domain.Models.ProductCharacteristic", "ProductCharacteristic")
                        .WithMany("ProductConfigCharacteristics")
                        .HasForeignKey("ProductCharacteristicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("istore_api.src.Domain.Models.ProductConfiguration", "ProductConfiguration")
                        .WithMany("Characteristics")
                        .HasForeignKey("ProductConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCharacteristic");

                    b.Navigation("ProductConfiguration");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.ProductConfiguration", b =>
                {
                    b.HasOne("istore_api.src.Domain.Models.Product", "Product")
                        .WithMany("ProductConfigurations")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.DeviceModel", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.Order", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.Product", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("ProductCharacteristics");

                    b.Navigation("ProductConfigurations");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.ProductCategory", b =>
                {
                    b.Navigation("DeviceModels");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.ProductCharacteristic", b =>
                {
                    b.Navigation("ProductConfigCharacteristics");
                });

            modelBuilder.Entity("istore_api.src.Domain.Models.ProductConfiguration", b =>
                {
                    b.Navigation("Characteristics");
                });
#pragma warning restore 612, 618
        }
    }
}
