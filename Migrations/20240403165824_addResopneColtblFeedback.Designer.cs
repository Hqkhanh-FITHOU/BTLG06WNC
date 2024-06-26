﻿// <auto-generated />
using System;
using BTLG06WNC;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BTLG06WNC.Migrations
{
    [DbContext(typeof(DbG06wncContext))]
    [Migration("20240403165824_addResopneColtblFeedback")]
    partial class addResopneColtblFeedback
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BTLG06WNC.Account", b =>
                {
                    b.Property<int>("IAccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("iAccountID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IAccountId"));

                    b.Property<DateTime?>("DBirthofdate")
                        .HasColumnType("datetime")
                        .HasColumnName("dBirthofdate");

                    b.Property<int?>("IRoleId")
                        .HasColumnType("int")
                        .HasColumnName("iRoleID");

                    b.Property<string>("SAvatar")
                        .HasColumnType("ntext")
                        .HasColumnName("sAvatar");

                    b.Property<string>("SEmail")
                        .HasColumnType("ntext")
                        .HasColumnName("sEmail");

                    b.Property<string>("SName")
                        .HasColumnType("ntext")
                        .HasColumnName("sName");

                    b.Property<string>("SPassword")
                        .HasColumnType("ntext")
                        .HasColumnName("sPassword");

                    b.Property<string>("SPhone")
                        .HasColumnType("ntext")
                        .HasColumnName("sPhone");

                    b.HasKey("IAccountId")
                        .HasName("PK__Account__B681F016745C5B38");

                    b.HasIndex("IRoleId");

                    b.ToTable("Account", (string)null);
                });

            modelBuilder.Entity("BTLG06WNC.Category", b =>
                {
                    b.Property<int>("ICategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("iCategoryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ICategoryId"));

                    b.Property<string>("STitle")
                        .IsRequired()
                        .HasColumnType("ntext")
                        .HasColumnName("sTitle");

                    b.HasKey("ICategoryId")
                        .HasName("PK__Category__342A082C87DBF986");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("BTLG06WNC.Content", b =>
                {
                    b.Property<int>("IContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("iContentID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IContentId"));

                    b.Property<DateTime?>("DCreatedate")
                        .HasColumnType("datetime")
                        .HasColumnName("dCreatedate");

                    b.Property<int?>("ICategoryId")
                        .HasColumnType("int")
                        .HasColumnName("iCategoryID");

                    b.Property<string>("SImage")
                        .HasColumnType("ntext")
                        .HasColumnName("sImage");

                    b.Property<string>("SMainbody")
                        .HasColumnType("ntext")
                        .HasColumnName("sMainbody");

                    b.Property<string>("SSource")
                        .HasColumnType("ntext")
                        .HasColumnName("sSource");

                    b.Property<string>("STitle")
                        .HasColumnType("ntext")
                        .HasColumnName("sTitle");

                    b.HasKey("IContentId")
                        .HasName("PK__Content__7FB67E4EBC14F5C3");

                    b.HasIndex("ICategoryId");

                    b.ToTable("Content", (string)null);
                });

            modelBuilder.Entity("BTLG06WNC.Feedback", b =>
                {
                    b.Property<int>("IFeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("iFeedbackID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IFeedbackId"));

                    b.Property<int?>("IAccountId")
                        .HasColumnType("int")
                        .HasColumnName("iAccountID");

                    b.Property<DateTime?>("IFeedbackdate")
                        .HasColumnType("datetime")
                        .HasColumnName("iFeedbackdate");

                    b.Property<string>("SContent")
                        .HasColumnType("ntext")
                        .HasColumnName("sContent");

                    b.Property<string>("SResponse")
                        .HasColumnType("ntext")
                        .HasColumnName("sResponse");

                    b.HasKey("IFeedbackId")
                        .HasName("PK__Feedback__4A6AA8F7BD98F518");

                    b.HasIndex("IAccountId");

                    b.ToTable("Feedback", (string)null);
                });

            modelBuilder.Entity("BTLG06WNC.FileCategory", b =>
                {
                    b.Property<int>("IFileCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("iFileCategoryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IFileCategoryId"));

                    b.Property<string>("STitle")
                        .HasColumnType("ntext")
                        .HasColumnName("sTitle");

                    b.HasKey("IFileCategoryId")
                        .HasName("PK__FileCate__7B6F2EC200F8AA71");

                    b.ToTable("FileCategory", (string)null);
                });

            modelBuilder.Entity("BTLG06WNC.ResourceFile", b =>
                {
                    b.Property<int>("IResourceFileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("iResourceFileID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IResourceFileId"));

                    b.Property<DateTime?>("DUploaddate")
                        .HasColumnType("datetime")
                        .HasColumnName("dUploaddate");

                    b.Property<int>("ICategoryId")
                        .HasColumnType("int")
                        .HasColumnName("iCategoryID");

                    b.Property<string>("SDescription")
                        .IsRequired()
                        .HasColumnType("ntext")
                        .HasColumnName("sDescription");

                    b.Property<string>("SFilename")
                        .HasColumnType("ntext")
                        .HasColumnName("sFilename");

                    b.HasKey("IResourceFileId")
                        .HasName("PK__Resource__9F0924CD60D1C77E");

                    b.HasIndex("ICategoryId");

                    b.ToTable("ResourceFile", (string)null);
                });

            modelBuilder.Entity("BTLG06WNC.Role", b =>
                {
                    b.Property<int>("IRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("iRoleID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IRoleId"));

                    b.Property<string>("SRolename")
                        .HasColumnType("ntext")
                        .HasColumnName("sRolename");

                    b.HasKey("IRoleId")
                        .HasName("PK__Roles__D69F8CBE3AA3D277");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BTLG06WNC.Account", b =>
                {
                    b.HasOne("BTLG06WNC.Role", "IRole")
                        .WithMany("Accounts")
                        .HasForeignKey("IRoleId")
                        .HasConstraintName("FK_RolesAccount");

                    b.Navigation("IRole");
                });

            modelBuilder.Entity("BTLG06WNC.Content", b =>
                {
                    b.HasOne("BTLG06WNC.Category", "ICategory")
                        .WithMany("Contents")
                        .HasForeignKey("ICategoryId")
                        .HasConstraintName("FK_CategoryContent");

                    b.Navigation("ICategory");
                });

            modelBuilder.Entity("BTLG06WNC.Feedback", b =>
                {
                    b.HasOne("BTLG06WNC.Account", "IAccount")
                        .WithMany("Feedbacks")
                        .HasForeignKey("IAccountId")
                        .HasConstraintName("FK_FeedbackAccount");

                    b.Navigation("IAccount");
                });

            modelBuilder.Entity("BTLG06WNC.ResourceFile", b =>
                {
                    b.HasOne("BTLG06WNC.FileCategory", "ICategory")
                        .WithMany("ResourceFiles")
                        .HasForeignKey("ICategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_FileCategoryResourceFile");

                    b.Navigation("ICategory");
                });

            modelBuilder.Entity("BTLG06WNC.Account", b =>
                {
                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("BTLG06WNC.Category", b =>
                {
                    b.Navigation("Contents");
                });

            modelBuilder.Entity("BTLG06WNC.FileCategory", b =>
                {
                    b.Navigation("ResourceFiles");
                });

            modelBuilder.Entity("BTLG06WNC.Role", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
