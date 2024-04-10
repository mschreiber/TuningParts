﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TuningPartsApp.persistence;

#nullable disable

namespace TuningPartsApp.Migrations
{
    [DbContext(typeof(TuningPartsDbContext))]
    partial class TuningPartsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("TuningPartsApp.models.Brand", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Founder")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6b761548-e654-4a48-8ef0-bb9d5e62cfaf"),
                            Description = "The coolest motor bike",
                            Founder = "Hr Ducati",
                            Name = "Ducati"
                        },
                        new
                        {
                            Id = new Guid("8d8bde88-0035-42c8-af59-97abebd26f45"),
                            Description = "Iconic American motorcycle manufacturer",
                            Founder = "William S. Harley and Arthur Davidson",
                            Name = "Harley-Davidson"
                        },
                        new
                        {
                            Id = new Guid("54b9c9d6-2007-45eb-80a1-e5958e8170f4"),
                            Description = "Japanese multinational conglomerate",
                            Founder = "Soichiro Honda",
                            Name = "Honda"
                        },
                        new
                        {
                            Id = new Guid("c7d98550-7f9b-4365-b862-148b6723a6f2"),
                            Description = "Japanese multinational corporation known for motorcycles, heavy equipment, aerospace and defense equipment, rolling stock and ships.",
                            Founder = "Shozo Kawasaki",
                            Name = "Kawasaki"
                        },
                        new
                        {
                            Id = new Guid("4998c894-a8dc-4ab8-82d9-c8b8ae204f1f"),
                            Description = "German multinational company which currently produces luxury automobiles and motorcycles.",
                            Founder = "Franz Josef Popp, Karl Rapp, and Camillo Castiglioni",
                            Name = "BMW Motorrad"
                        },
                        new
                        {
                            Id = new Guid("ca1ec02a-5b48-4aff-8e48-f618a7577627"),
                            Description = "Japanese multinational corporation headquartered in Minami-ku, Hamamatsu, Japan.",
                            Founder = "Michio Suzuki",
                            Name = "Suzuki"
                        },
                        new
                        {
                            Id = new Guid("6cb4144c-d4e5-4298-8330-1b21d0c2d5e5"),
                            Description = "Japanese multinational corporation headquartered in Iwata, Shizuoka, Japan.",
                            Founder = "Torakusu Yamaha",
                            Name = "Yamaha"
                        },
                        new
                        {
                            Id = new Guid("54df43e4-aa1c-4bcc-aa70-8c9c45a56be3"),
                            Description = "British motorcycle manufacturing company, based originally in Coventry and then in Meriden.",
                            Founder = "John Bloor",
                            Name = "Triumph"
                        },
                        new
                        {
                            Id = new Guid("a180584a-8c54-407a-a2e4-1786bb952eab"),
                            Description = "Italian motorcycle company, one of the marques owned by Piaggio.",
                            Founder = "Alberto Beggio",
                            Name = "Aprilia"
                        },
                        new
                        {
                            Id = new Guid("f5c281a1-af56-4b1b-811d-8c65f52eb056"),
                            Description = "American brand of motorcycles originally produced from 1901 to 1953 in Springfield, Massachusetts, United States.",
                            Founder = "George M. Hendee, Oscar Hedstrom",
                            Name = "Indian Motorcycle"
                        });
                });

            modelBuilder.Entity("TuningPartsApp.models.Model", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("BrandId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Production_Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("TuningPartsApp.models.Model", b =>
                {
                    b.HasOne("TuningPartsApp.models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId");

                    b.Navigation("Brand");
                });
#pragma warning restore 612, 618
        }
    }
}
