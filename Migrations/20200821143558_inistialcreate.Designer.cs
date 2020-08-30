﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using crm;

namespace crm.Migrations
{
    [DbContext(typeof(CrmDbcontext))]
    [Migration("20200821143558_inistialcreate")]
    partial class inistialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("crm.Model.Custemer", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("adresse")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastname")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<string>("phone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Custemers");
                });

            modelBuilder.Entity("crm.Model.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("Custemerid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Number")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OrderPlace")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Custemerid");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("crm.Model.OrdersLigne", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long?>("OrderId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<long?>("Productid")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Products_id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("OrderId");

                    b.HasIndex("Productid");

                    b.ToTable("OrdersLignes");
                });

            modelBuilder.Entity("crm.Model.Product", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("crm.Model.Order", b =>
                {
                    b.HasOne("crm.Model.Custemer", "Custemer")
                        .WithMany("Orders")
                        .HasForeignKey("Custemerid");
                });

            modelBuilder.Entity("crm.Model.OrdersLigne", b =>
                {
                    b.HasOne("crm.Model.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId");

                    b.HasOne("crm.Model.Product", "Product")
                        .WithMany("OrdersLignes")
                        .HasForeignKey("Productid");
                });
#pragma warning restore 612, 618
        }
    }
}