﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Myapp.Data;

#nullable disable

namespace MyApp.Migrations
{
    [DbContext(typeof(MyappDbContext))]
    partial class MyappDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Myapp.Models.employee", b =>
                {
                    b.Property<decimal>("Nr_Personne")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Activer")
                        .HasColumnType("bit");

                    b.Property<int>("Matricule")
                        .HasColumnType("int");

                    b.Property<string>("Nom_Groupe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom_Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Nr_Groupe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Technicien")
                        .HasColumnType("bit");

                    b.HasKey("Nr_Personne");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
