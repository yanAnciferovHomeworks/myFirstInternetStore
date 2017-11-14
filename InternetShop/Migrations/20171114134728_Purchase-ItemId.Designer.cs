﻿// <auto-generated />
using InternetShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace InternetShop.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20171114134728_Purchase-ItemId")]
    partial class PurchaseItemId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InternetShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Img");

                    b.Property<string>("ItemName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("InternetShop.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("ItemId");

                    b.Property<string>("Text");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("InternetShop.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("Company");

                    b.Property<int>("Count");

                    b.Property<string>("Description");

                    b.Property<string>("Img");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("InternetShop.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("IsPrimary");

                    b.Property<int?>("ItemId");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("InternetShop.Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Addres");

                    b.Property<int>("ItemId");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("InternetShop.Models.Comment", b =>
                {
                    b.HasOne("InternetShop.Models.Item")
                        .WithMany("Comments")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternetShop.Models.Property", b =>
                {
                    b.HasOne("InternetShop.Models.Item")
                        .WithMany("Properties")
                        .HasForeignKey("ItemId");
                });
#pragma warning restore 612, 618
        }
    }
}
