﻿// <auto-generated />
using System;
using APBrandv2._0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APBrandv2._0.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APBrandv2._0.Models.Brand", b =>
                {
                    b.Property<Guid>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrandDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryofOrigin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Founder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Headquarterslocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebsiteUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearFounded")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("APBrandv2._0.Models.Model", b =>
                {
                    b.Property<Guid>("ModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BrandID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModelID");

                    b.HasIndex("BrandID");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("APBrandv2._0.Models.Review", b =>
                {
                    b.Property<Guid>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("VariantId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewID");

                    b.HasIndex("VariantId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("APBrandv2._0.Models.Variant", b =>
                {
                    b.Property<Guid>("VariantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Battery")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BodyRatio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("COMMS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Display")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Features")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MISC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainCamera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Memory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ModelID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ModelID1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Network")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platform")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ReviewID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SelfieCamera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tests")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VariantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VariantId");

                    b.HasIndex("ModelID");

                    b.HasIndex("ModelID1");

                    b.HasIndex("ReviewID");

                    b.ToTable("Variants");
                });

            modelBuilder.Entity("APBrandv2._0.Models.Model", b =>
                {
                    b.HasOne("APBrandv2._0.Models.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("APBrandv2._0.Models.Review", b =>
                {
                    b.HasOne("APBrandv2._0.Models.Variant", "Variant")
                        .WithMany("Reviews")
                        .HasForeignKey("VariantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Variant");
                });

            modelBuilder.Entity("APBrandv2._0.Models.Variant", b =>
                {
                    b.HasOne("APBrandv2._0.Models.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("APBrandv2._0.Models.Model", null)
                        .WithMany("Variants")
                        .HasForeignKey("ModelID1");

                    b.HasOne("APBrandv2._0.Models.Review", null)
                        .WithMany("Variants")
                        .HasForeignKey("ReviewID");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("APBrandv2._0.Models.Brand", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("APBrandv2._0.Models.Model", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("APBrandv2._0.Models.Review", b =>
                {
                    b.Navigation("Variants");
                });

            modelBuilder.Entity("APBrandv2._0.Models.Variant", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}