﻿// <auto-generated />
using FlyApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FlyApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191022144957_AddUserModelToDb")]
    partial class AddUserModelToDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ChangeDetector.SkipDetectChanges", "true")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
#pragma warning restore 612, 618
        }
    }
}
