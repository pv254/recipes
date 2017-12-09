﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RecipesCore;
using System;

namespace RecipesCore.Migrations
{
    [DbContext(typeof(RecipesContext))]
    [Migration("20171209014231_LogDateTime")]
    partial class LogDateTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("RecipesCore.Models.ActionLogRecord", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Action");

                    b.Property<DateTime>("Date");

                    b.Property<long?>("RecipeId");

                    b.Property<string>("RecommendationAlgorithmIdentifier");

                    b.Property<long?>("RecommendedRecipeId");

                    b.Property<string>("Referer");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.HasIndex("RecommendedRecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("ActionLog");
                });

            modelBuilder.Entity("RecipesCore.Models.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<long>("Priority");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("RecipesCore.Models.FellowCooks", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("FollowedUserId");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("FollowedUserId");

                    b.HasIndex("UserId");

                    b.ToTable("FellowCooks");
                });

            modelBuilder.Entity("RecipesCore.Models.Ingredient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Importance");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("RecipesCore.Models.Recipe", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<int>("Calories");

                    b.Property<long?>("CategoryId");

                    b.Property<TimeSpan>("CookTime");

                    b.Property<string>("Description");

                    b.Property<string>("Directions");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Name");

                    b.Property<TimeSpan>("PreparationTime");

                    b.Property<double>("Rating");

                    b.Property<int>("Servings");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("RecipesCore.Models.RecipeDone", b =>
                {
                    b.Property<long>("RecipeId");

                    b.Property<long>("UserId");

                    b.HasKey("RecipeId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("RecipeDone");
                });

            modelBuilder.Entity("RecipesCore.Models.RecipeIngredient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("IngredientId");

                    b.Property<string>("Measure");

                    b.Property<string>("Name");

                    b.Property<string>("Quantity");

                    b.Property<long?>("RecipeId");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeIngredients");
                });

            modelBuilder.Entity("RecipesCore.Models.RecipeRatings", b =>
                {
                    b.Property<long>("RecipeId");

                    b.Property<long>("UserId");

                    b.Property<int>("Rating");

                    b.HasKey("RecipeId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("RecipeRatings");
                });

            modelBuilder.Entity("RecipesCore.Models.RecipeSeen", b =>
                {
                    b.Property<long>("RecipeId");

                    b.Property<long>("UserId");

                    b.HasKey("RecipeId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("RecipeSeen");
                });

            modelBuilder.Entity("RecipesCore.Models.TfIdfElement", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Term");

                    b.Property<double>("TfIdf");

                    b.Property<long?>("TfIdfModelId");

                    b.HasKey("Id");

                    b.HasIndex("TfIdfModelId");

                    b.ToTable("TfIdfElement");
                });

            modelBuilder.Entity("RecipesCore.Models.TfIdfModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("RecipeId");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("TfIdfModels");
                });

            modelBuilder.Entity("RecipesCore.Models.User", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.Property<bool>("Vegan");

                    b.Property<bool>("Vegetarian");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RecipesCore.Models.UserAllergie", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("IngredientId");

                    b.Property<long?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.HasIndex("UserId");

                    b.ToTable("UserAllergies");
                });

            modelBuilder.Entity("RecipesCore.Models.ActionLogRecord", b =>
                {
                    b.HasOne("RecipesCore.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId");

                    b.HasOne("RecipesCore.Models.Recipe", "RecommendedRecipe")
                        .WithMany()
                        .HasForeignKey("RecommendedRecipeId");

                    b.HasOne("RecipesCore.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RecipesCore.Models.FellowCooks", b =>
                {
                    b.HasOne("RecipesCore.Models.User", "FollowedUser")
                        .WithMany()
                        .HasForeignKey("FollowedUserId");

                    b.HasOne("RecipesCore.Models.User", "User")
                        .WithMany("FellowCooks")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RecipesCore.Models.Recipe", b =>
                {
                    b.HasOne("RecipesCore.Models.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("RecipesCore.Models.RecipeDone", b =>
                {
                    b.HasOne("RecipesCore.Models.Recipe", "Recipe")
                        .WithMany("DoneBy")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RecipesCore.Models.User", "User")
                        .WithMany("RecipesDone")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RecipesCore.Models.RecipeIngredient", b =>
                {
                    b.HasOne("RecipesCore.Models.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId");

                    b.HasOne("RecipesCore.Models.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("RecipesCore.Models.RecipeRatings", b =>
                {
                    b.HasOne("RecipesCore.Models.Recipe", "Recipe")
                        .WithMany("RecipesRatings")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RecipesCore.Models.User", "User")
                        .WithMany("RecipesRatings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RecipesCore.Models.RecipeSeen", b =>
                {
                    b.HasOne("RecipesCore.Models.Recipe", "Recipe")
                        .WithMany("SeenBy")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RecipesCore.Models.User", "User")
                        .WithMany("RecipesSeen")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RecipesCore.Models.TfIdfElement", b =>
                {
                    b.HasOne("RecipesCore.Models.TfIdfModel")
                        .WithMany("Elements")
                        .HasForeignKey("TfIdfModelId");
                });

            modelBuilder.Entity("RecipesCore.Models.TfIdfModel", b =>
                {
                    b.HasOne("RecipesCore.Models.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("RecipesCore.Models.UserAllergie", b =>
                {
                    b.HasOne("RecipesCore.Models.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientId");

                    b.HasOne("RecipesCore.Models.User", "User")
                        .WithMany("Allergies")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
