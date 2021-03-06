﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RecipesCore;
using System;
using System.Collections.Generic;

namespace RecipesCore.Migrations
{
    [DbContext(typeof(RecipesContext))]
    [Migration("20171024135147_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("RecipesCore.Models.Recipe", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<List<string>>("Categories");

                    b.Property<TimeSpan>("CookTime");

                    b.Property<string>("Description");

                    b.Property<string>("Directions");

                    b.Property<List<string>>("Ingredients");

                    b.Property<string>("Name");

                    b.Property<TimeSpan>("PreparationTime");

                    b.Property<double>("Rating");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });
#pragma warning restore 612, 618
        }
    }
}
