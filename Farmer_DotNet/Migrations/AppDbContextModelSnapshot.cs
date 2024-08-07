﻿// <auto-generated />
using System;
using Farmer_DotNet.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FarmerDotNet.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FarmerMarket", b =>
                {
                    b.Property<int>("MarketsFarmerId")
                        .HasColumnType("int");

                    b.Property<int>("MarketsMarketId")
                        .HasColumnType("int");

                    b.HasKey("MarketsFarmerId", "MarketsMarketId");

                    b.HasIndex("MarketsMarketId");

                    b.ToTable("FarmerMarket");
                });

            modelBuilder.Entity("FarmerProduct", b =>
                {
                    b.Property<int>("FarmersFarmerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("FarmersFarmerId", "ProductsProductId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("FarmerProduct");
                });

            modelBuilder.Entity("Farmer_DotNet.Model.Buyer", b =>
                {
                    b.Property<int>("BuyerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BuyerId"));

                    b.Property<string>("BContact")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MarketId")
                        .HasColumnType("int");

                    b.HasKey("BuyerId");

                    b.HasIndex("MarketId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Farmer_DotNet.Model.Farmer", b =>
                {
                    b.Property<int>("FarmerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FarmerId"));

                    b.Property<string>("FAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FMoNo")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FarmerId");

                    b.ToTable("Farmers");
                });

            modelBuilder.Entity("Farmer_DotNet.Model.Market", b =>
                {
                    b.Property<int>("MarketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarketId"));

                    b.Property<string>("MAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MContact")
                        .HasColumnType("int");

                    b.Property<string>("MEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarketId");

                    b.ToTable("Markets");
                });

            modelBuilder.Entity("Farmer_DotNet.Model.Product", b =>
                {
                    b.Property<int?>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ProductId"));

                    b.Property<double?>("AvgPrice")
                        .HasColumnType("float");

                    b.Property<int?>("BuyerId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double?>("HighPrice")
                        .HasColumnType("float");

                    b.Property<double?>("LowPrice")
                        .HasColumnType("float");

                    b.Property<string>("PName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("BuyerId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Farmer_DotNet.Model.Vehical", b =>
                {
                    b.Property<int>("VehicalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicalId"));

                    b.Property<int?>("FarmerId")
                        .HasColumnType("int");

                    b.Property<int?>("MarketId")
                        .HasColumnType("int");

                    b.Property<string>("VName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicalId");

                    b.HasIndex("FarmerId");

                    b.HasIndex("MarketId");

                    b.ToTable("Vehicals");
                });

            modelBuilder.Entity("MarketProduct", b =>
                {
                    b.Property<int>("MarketsMarketId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsProductId")
                        .HasColumnType("int");

                    b.HasKey("MarketsMarketId", "ProductsProductId");

                    b.HasIndex("ProductsProductId");

                    b.ToTable("MarketProduct");
                });

            modelBuilder.Entity("FarmerMarket", b =>
                {
                    b.HasOne("Farmer_DotNet.Model.Farmer", null)
                        .WithMany()
                        .HasForeignKey("MarketsFarmerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Farmer_DotNet.Model.Market", null)
                        .WithMany()
                        .HasForeignKey("MarketsMarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FarmerProduct", b =>
                {
                    b.HasOne("Farmer_DotNet.Model.Farmer", null)
                        .WithMany()
                        .HasForeignKey("FarmersFarmerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Farmer_DotNet.Model.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Farmer_DotNet.Model.Buyer", b =>
                {
                    b.HasOne("Farmer_DotNet.Model.Market", null)
                        .WithMany("Buyers")
                        .HasForeignKey("MarketId");
                });

            modelBuilder.Entity("Farmer_DotNet.Model.Product", b =>
                {
                    b.HasOne("Farmer_DotNet.Model.Buyer", null)
                        .WithMany("Products")
                        .HasForeignKey("BuyerId");
                });

            modelBuilder.Entity("Farmer_DotNet.Model.Vehical", b =>
                {
                    b.HasOne("Farmer_DotNet.Model.Farmer", null)
                        .WithMany("Vehicals")
                        .HasForeignKey("FarmerId");

                    b.HasOne("Farmer_DotNet.Model.Market", null)
                        .WithMany("Vehicals")
                        .HasForeignKey("MarketId");
                });

            modelBuilder.Entity("MarketProduct", b =>
                {
                    b.HasOne("Farmer_DotNet.Model.Market", null)
                        .WithMany()
                        .HasForeignKey("MarketsMarketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Farmer_DotNet.Model.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Farmer_DotNet.Model.Buyer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Farmer_DotNet.Model.Farmer", b =>
                {
                    b.Navigation("Vehicals");
                });

            modelBuilder.Entity("Farmer_DotNet.Model.Market", b =>
                {
                    b.Navigation("Buyers");

                    b.Navigation("Vehicals");
                });
#pragma warning restore 612, 618
        }
    }
}
