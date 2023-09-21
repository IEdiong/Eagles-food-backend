﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eagles_food_backend.Data;

#nullable disable

namespace eagles_food_backend.Migrations
{
    [DbContext(typeof(LunchDbContext))]
    partial class LunchDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("eagles_food_backend.Domains.Models.Lunch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_deleted")
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("Note")
                        .HasColumnType("text")
                        .HasColumnName("note");

                    b.Property<int?>("OrgId")
                        .HasColumnType("int")
                        .HasColumnName("org_id");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<int?>("ReceiverId")
                        .HasColumnType("int")
                        .HasColumnName("receiver_id");

                    b.Property<bool?>("Redeemed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("redeemed")
                        .HasDefaultValueSql("'0'");

                    b.Property<int?>("SenderId")
                        .HasColumnType("int")
                        .HasColumnName("sender_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "OrgId" }, "org_id");

                    b.HasIndex(new[] { "ReceiverId" }, "receiver_id");

                    b.HasIndex(new[] { "SenderId" }, "sender_id");

                    b.ToTable("lunches", (string)null);
                });

            modelBuilder.Entity("eagles_food_backend.Domains.Models.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CurrencyCode")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)")
                        .HasColumnName("currency_code");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_deleted")
                        .HasDefaultValueSql("'0'");

                    b.Property<decimal>("LunchPrice")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("lunch_price");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.ToTable("organizations", (string)null);
                });

            modelBuilder.Entity("eagles_food_backend.Domains.Models.OrganizationInvite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_deleted")
                        .HasDefaultValueSql("'0'");

                    b.Property<int?>("OrgId")
                        .HasColumnType("int")
                        .HasColumnName("org_id");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("token");

                    b.Property<DateTime>("Ttl")
                        .HasColumnType("datetime")
                        .HasColumnName("ttl");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "OrgId" }, "org_id")
                        .HasDatabaseName("org_id1");

                    b.ToTable("organization_invites", (string)null);
                });

            modelBuilder.Entity("eagles_food_backend.Domains.Models.OrganizationLunchWallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<decimal>("Balance")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("balance");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_deleted")
                        .HasDefaultValueSql("'0'");

                    b.Property<int?>("OrgId")
                        .HasColumnType("int")
                        .HasColumnName("org_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "OrgId" }, "org_id")
                        .HasDatabaseName("org_id2");

                    b.ToTable("organization_lunch_wallets", (string)null);
                });

            modelBuilder.Entity("eagles_food_backend.Domains.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("BankCode")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("bank_code");

                    b.Property<string>("BankName")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("bank_name");

                    b.Property<string>("BankNumber")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("bank_number");

                    b.Property<string>("BankRegion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("bank_region");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Currency")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)")
                        .HasColumnName("currency");

                    b.Property<string>("CurrencyCode")
                        .HasMaxLength(4)
                        .HasColumnType("varchar(4)")
                        .HasColumnName("currency_code");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("first_name");

                    b.Property<bool?>("IsAdmin")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_admin");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_deleted")
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("last_name");

                    b.Property<int?>("LunchCreditBalance")
                        .HasColumnType("int")
                        .HasColumnName("lunch_credit_balance");

                    b.Property<int?>("OrgId")
                        .HasColumnType("int")
                        .HasColumnName("org_id");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password_hash");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone");

                    b.Property<string>("ProfilePic")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("profile_pic");

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("refresh_token");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Email" }, "email")
                        .IsUnique();

                    b.HasIndex(new[] { "OrgId" }, "org_id")
                        .HasDatabaseName("org_id3");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("eagles_food_backend.Domains.Models.Withdrawal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)")
                        .HasColumnName("amount");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<bool?>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("is_deleted")
                        .HasDefaultValueSql("'0'");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("enum('redeemed','not_redeemed')")
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "UserId" }, "user_id");

                    b.ToTable("withdrawals", (string)null);
                });

            modelBuilder.Entity("eagles_food_backend.Domains.Models.Lunch", b =>
                {
                    b.HasOne("eagles_food_backend.Domains.Models.Organization", "Org")
                        .WithMany("Lunches")
                        .HasForeignKey("OrgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("lunches_ibfk_1");

                    b.HasOne("eagles_food_backend.Domains.Models.User", "Receiver")
                        .WithMany("LunchReceivers")
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("lunches_ibfk_3");

                    b.HasOne("eagles_food_backend.Domains.Models.User", "Sender")
                        .WithMany("LunchSenders")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("lunches_ibfk_2");

                    b.Navigation("Org");

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("eagles_food_backend.Domains.Models.OrganizationInvite", b =>
                {
                    b.HasOne("eagles_food_backend.Domains.Models.Organization", "Org")
                        .WithMany("OrganizationInvites")
                        .HasForeignKey("OrgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("organization_invites_ibfk_1");

                    b.Navigation("Org");
                });

            modelBuilder.Entity("eagles_food_backend.Domains.Models.OrganizationLunchWallet", b =>
                {
                    b.HasOne("eagles_food_backend.Domains.Models.Organization", "Org")
                        .WithMany("OrganizationLunchWallets")
                        .HasForeignKey("OrgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("organization_lunch_wallets_ibfk_1");

                    b.Navigation("Org");
                });

            modelBuilder.Entity("eagles_food_backend.Domains.Models.User", b =>
                {
                    b.HasOne("eagles_food_backend.Domains.Models.Organization", "Org")
                        .WithMany("Users")
                        .HasForeignKey("OrgId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("users_ibfk_1");

                    b.Navigation("Org");
                });

            modelBuilder.Entity("eagles_food_backend.Domains.Models.Withdrawal", b =>
                {
                    b.HasOne("eagles_food_backend.Domains.Models.User", "User")
                        .WithMany("Withdrawals")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("withdrawals_ibfk_1");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eagles_food_backend.Domains.Models.Organization", b =>
                {
                    b.Navigation("Lunches");

                    b.Navigation("OrganizationInvites");

                    b.Navigation("OrganizationLunchWallets");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("eagles_food_backend.Domains.Models.User", b =>
                {
                    b.Navigation("LunchReceivers");

                    b.Navigation("LunchSenders");

                    b.Navigation("Withdrawals");
                });
#pragma warning restore 612, 618
        }
    }
}
