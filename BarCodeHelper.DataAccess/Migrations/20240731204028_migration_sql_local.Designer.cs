﻿// <auto-generated />
using System;
using BarCodeHelper.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BarCodeHelper.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240731204028_migration_sql_local")]
    partial class migration_sql_local
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BarCodeHelper.Models.BarCode", b =>
                {
                    b.Property<string>("BarCodeNumber")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(0);

                    b.Property<string>("ProductSerialNumber")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.HasKey("BarCodeNumber", "ProductSerialNumber");

                    b.HasIndex("ProductSerialNumber");

                    b.ToTable("BarCodes");
                });

            modelBuilder.Entity("BarCodeHelper.Models.Product", b =>
                {
                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SerialNumber");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            SerialNumber = "37b42e77-2536-4b68-bb62-934ef0c4defd",
                            Category = 1,
                            Name = "Men's Swim Trunks"
                        },
                        new
                        {
                            SerialNumber = "f8177c12-172f-407e-aef8-4c71505b0715",
                            Category = 1,
                            Name = "Women's Bikini"
                        },
                        new
                        {
                            SerialNumber = "a90d8669-98d8-4a63-b65c-f8a090c99389",
                            Category = 1,
                            Name = "Unisex Rash Guard"
                        },
                        new
                        {
                            SerialNumber = "09efcdd5-2faf-4cc2-acf9-541d17618fb0",
                            Category = 1,
                            Name = "Kids' One-Piece Swimsuit"
                        },
                        new
                        {
                            SerialNumber = "4bb27f4a-d0ee-45cf-85e7-d9764b045060",
                            Category = 1,
                            Name = "Ladies' Tankini"
                        },
                        new
                        {
                            SerialNumber = "bca52821-9971-43ed-b7d1-715587254e4c",
                            Category = 1,
                            Name = "Board Shorts"
                        },
                        new
                        {
                            SerialNumber = "d0edeff7-4a8e-4cd5-8688-22a60ba87bef",
                            Category = 1,
                            Name = "Swim Briefs"
                        },
                        new
                        {
                            SerialNumber = "05384025-137c-4e02-978c-1cf4338181e0",
                            Category = 1,
                            Name = "High Waist Swim Bottoms"
                        },
                        new
                        {
                            SerialNumber = "0158ea5b-bc11-4e41-b4b4-a8477f121716",
                            Category = 1,
                            Name = "Sporty Swim Top"
                        },
                        new
                        {
                            SerialNumber = "eaa87cbf-b017-417e-9161-a713b49967ed",
                            Category = 1,
                            Name = "Triangle Bikini Top"
                        },
                        new
                        {
                            SerialNumber = "764196e3-277d-461f-8a85-92aa5d747405",
                            Category = 1,
                            Name = "Full Body Swimsuit"
                        },
                        new
                        {
                            SerialNumber = "c348a05a-127b-412b-a3bf-f4db1c872f05",
                            Category = 1,
                            Name = "Surf Swimwear"
                        },
                        new
                        {
                            SerialNumber = "da2716bf-f193-47e4-a7e4-c6692b1a3f74",
                            Category = 1,
                            Name = "Floral Bikini Set"
                        },
                        new
                        {
                            SerialNumber = "9f12f3b1-ba25-41dc-95cd-9b210e52ef44",
                            Category = 1,
                            Name = "Halter Swim Dress"
                        },
                        new
                        {
                            SerialNumber = "2157b6e0-cffc-4242-af45-251cd2a42a5e",
                            Category = 1,
                            Name = "Crochet Swimsuit"
                        },
                        new
                        {
                            SerialNumber = "0f4032d4-bf18-4ac9-a937-54157a654963",
                            Category = 1,
                            Name = "Push-up Bikini"
                        },
                        new
                        {
                            SerialNumber = "3a4e9582-cfae-4840-8ac5-4b352273cc27",
                            Category = 1,
                            Name = "Swimming Cap"
                        },
                        new
                        {
                            SerialNumber = "951af12e-b87e-4397-acb3-77531ab662fb",
                            Category = 1,
                            Name = "Swimming Goggles"
                        },
                        new
                        {
                            SerialNumber = "700e2834-d54f-47f4-8f2f-1d9dd7094697",
                            Category = 1,
                            Name = "Swimming Fins"
                        },
                        new
                        {
                            SerialNumber = "f8c40ee6-4455-4d83-a82f-2070f0448423",
                            Category = 1,
                            Name = "Swim Cap"
                        },
                        new
                        {
                            SerialNumber = "1b39e4c7-b250-45d9-b875-32af8c435c8d",
                            Category = 2,
                            Name = "Denim Jeans"
                        },
                        new
                        {
                            SerialNumber = "0433a28e-5188-46b2-a12d-71f33d991b67",
                            Category = 2,
                            Name = "Cargo Pants"
                        },
                        new
                        {
                            SerialNumber = "ddbe23ca-29ef-4c99-bade-0f32c5fdb0b5",
                            Category = 2,
                            Name = "Formal Trousers"
                        },
                        new
                        {
                            SerialNumber = "d20f4fa9-356f-4951-8942-c071b86d9102",
                            Category = 2,
                            Name = "Chinos"
                        },
                        new
                        {
                            SerialNumber = "ece251a2-1dfa-47dc-8230-5b94b088fca7",
                            Category = 2,
                            Name = "Jogger Pants"
                        },
                        new
                        {
                            SerialNumber = "4a7e151f-7574-459f-a07d-6c79fe1d0853",
                            Category = 2,
                            Name = "Capri Pants"
                        },
                        new
                        {
                            SerialNumber = "a8e5ebd8-c1cc-4f02-a79e-fbc4d64996d4",
                            Category = 2,
                            Name = "Corduroy Pants"
                        },
                        new
                        {
                            SerialNumber = "052b9da6-6ce1-44f4-90da-2b55a649d28f",
                            Category = 2,
                            Name = "Dress Pants"
                        },
                        new
                        {
                            SerialNumber = "c6a51696-d678-4331-8f60-6dd22608fb51",
                            Category = 2,
                            Name = "Slim Fit Jeans"
                        },
                        new
                        {
                            SerialNumber = "07547c18-c9b3-45ad-b1ec-534df83ca87b",
                            Category = 2,
                            Name = "Bootcut Jeans"
                        },
                        new
                        {
                            SerialNumber = "dca361da-7773-4d67-a18f-bc6590d9dcdd",
                            Category = 2,
                            Name = "Baggy Jeans"
                        },
                        new
                        {
                            SerialNumber = "3f2caa19-8ee2-4042-a66e-d57e09812527",
                            Category = 2,
                            Name = "Pleated Pants"
                        },
                        new
                        {
                            SerialNumber = "899c189a-7f65-4f45-abfe-0ee78c6a5955",
                            Category = 2,
                            Name = "Harem Pants"
                        },
                        new
                        {
                            SerialNumber = "ddd443e6-1e85-4f0b-b9f0-fb28d6f050b8",
                            Category = 2,
                            Name = "Stretch Leggings"
                        },
                        new
                        {
                            SerialNumber = "63fd77b0-4a8a-4ec9-b557-5b0411b3b85f",
                            Category = 2,
                            Name = "Palazzo Pants"
                        },
                        new
                        {
                            SerialNumber = "5ac850dc-5129-458e-9f71-99f8930d7a9e",
                            Category = 2,
                            Name = "Wide Leg Pants"
                        },
                        new
                        {
                            SerialNumber = "16c80af2-9d5d-4c29-92cd-2c0edb1d9f0c",
                            Category = 2,
                            Name = "Khaki Pants"
                        },
                        new
                        {
                            SerialNumber = "edb9d761-b835-4752-9494-5c4fcdadb88d",
                            Category = 2,
                            Name = "Yoga Pants"
                        },
                        new
                        {
                            SerialNumber = "de37a5c1-1616-4111-ae44-b10ebacd9df2",
                            Category = 2,
                            Name = "Work Pants"
                        },
                        new
                        {
                            SerialNumber = "7119b907-7054-4f4c-bf32-332d39c873e7",
                            Category = 2,
                            Name = "Sweatpants"
                        },
                        new
                        {
                            SerialNumber = "50bd4d5b-816a-4fc0-9795-e0ab957ae474",
                            Category = 3,
                            Name = "Men's Boxers"
                        },
                        new
                        {
                            SerialNumber = "94ff3b29-51a4-424f-8a92-de72e3d6a757",
                            Category = 3,
                            Name = "Women's Panties"
                        },
                        new
                        {
                            SerialNumber = "5d6db497-187a-4589-a921-67e1d2e10ae7",
                            Category = 3,
                            Name = "Men's Briefs"
                        },
                        new
                        {
                            SerialNumber = "ddfd1e4f-2d4c-4363-a8bd-cc08a3ebabf1",
                            Category = 3,
                            Name = "Women's Thong"
                        },
                        new
                        {
                            SerialNumber = "139cb5cf-ef24-4391-9d92-f01b3f5d70cd",
                            Category = 3,
                            Name = "Ladies' Bras"
                        },
                        new
                        {
                            SerialNumber = "581ca08a-86e9-4ecf-bf04-03434a92797d",
                            Category = 3,
                            Name = "Sports Bra"
                        },
                        new
                        {
                            SerialNumber = "01c6cd53-69d3-440d-b0f0-8d457d48379f",
                            Category = 3,
                            Name = "Men's Undershirt"
                        },
                        new
                        {
                            SerialNumber = "d6f2cbe1-560b-4960-81b0-3803dd4009e9",
                            Category = 3,
                            Name = "Women's Chemise"
                        },
                        new
                        {
                            SerialNumber = "a7d78690-708c-4677-a655-78aca29d6f61",
                            Category = 3,
                            Name = "Thermal Underwear"
                        },
                        new
                        {
                            SerialNumber = "49ab589f-f0ed-4915-9432-7d2cc3be1b18",
                            Category = 3,
                            Name = "Cotton Panties"
                        },
                        new
                        {
                            SerialNumber = "cef149c3-4cbc-4279-8034-ee3c2458ac1e",
                            Category = 3,
                            Name = "Lace Lingerie"
                        },
                        new
                        {
                            SerialNumber = "2b1c15f5-002f-44e1-8e4d-a6c238adb7da",
                            Category = 3,
                            Name = "Silk Boxers"
                        },
                        new
                        {
                            SerialNumber = "b0101087-3daf-4855-a223-25be32c36915",
                            Category = 3,
                            Name = "Padded Bra"
                        },
                        new
                        {
                            SerialNumber = "2a549e97-3b85-46ec-97bc-359f08be47bf",
                            Category = 3,
                            Name = "Nursing Bra"
                        },
                        new
                        {
                            SerialNumber = "9b811290-c051-4dc6-a4fc-742d6cc9e62b",
                            Category = 3,
                            Name = "Shapewear Bodysuit"
                        },
                        new
                        {
                            SerialNumber = "8bb115f6-a5cd-43f5-a8f9-1725e4174a2e",
                            Category = 3,
                            Name = "Men's Trunks"
                        },
                        new
                        {
                            SerialNumber = "ad1b8c13-dbee-450f-9dca-2eaf568e617b",
                            Category = 3,
                            Name = "Bikini Briefs"
                        },
                        new
                        {
                            SerialNumber = "2247b86f-7a19-4d29-9e8d-b41fefbaebc6",
                            Category = 3,
                            Name = "Long Underwear"
                        },
                        new
                        {
                            SerialNumber = "fec6bd7a-02aa-4a92-82f2-9c27d2cc95ea",
                            Category = 3,
                            Name = "Men's Compression Shorts"
                        },
                        new
                        {
                            SerialNumber = "aa8cdd5d-0336-4c70-9008-98bc83422836",
                            Category = 3,
                            Name = "Men's Athletic Supporter"
                        },
                        new
                        {
                            SerialNumber = "530c8dc5-89eb-4d40-b36b-f486138fa0c6",
                            Category = 4,
                            Name = "Graphic T-Shirt"
                        },
                        new
                        {
                            SerialNumber = "38408a02-8865-4b23-ba4a-766daf77391a",
                            Category = 4,
                            Name = "Plain White Tee"
                        },
                        new
                        {
                            SerialNumber = "a86a16b1-98bd-4574-9793-e4e5755ed1cd",
                            Category = 4,
                            Name = "V-Neck T-Shirt"
                        },
                        new
                        {
                            SerialNumber = "60903417-7486-47c7-9c8e-9deef20fb563",
                            Category = 4,
                            Name = "Crew Neck T-Shirt"
                        },
                        new
                        {
                            SerialNumber = "33cd66cd-009d-4dfa-9edc-d09992867213",
                            Category = 4,
                            Name = "Long Sleeve Tee"
                        },
                        new
                        {
                            SerialNumber = "6158dddc-998d-4a33-9fd9-5fae355262fd",
                            Category = 4,
                            Name = "Striped T-Shirt"
                        },
                        new
                        {
                            SerialNumber = "a4f8f790-17aa-4b40-9fb9-f520607be4c2",
                            Category = 4,
                            Name = "Pocket Tee"
                        },
                        new
                        {
                            SerialNumber = "00868bdf-6fd2-4cbd-80d2-4c411814f3f1",
                            Category = 4,
                            Name = "Henley Shirt"
                        },
                        new
                        {
                            SerialNumber = "f54efd63-ca9d-456c-967f-3096a17e8656",
                            Category = 4,
                            Name = "Polo Shirt"
                        },
                        new
                        {
                            SerialNumber = "92285164-5a3f-40ce-86f5-4a40048afe69",
                            Category = 4,
                            Name = "Raglan T-Shirt"
                        },
                        new
                        {
                            SerialNumber = "c1342c53-2a15-4b27-86af-3d41751e309c",
                            Category = 4,
                            Name = "Crop Top"
                        },
                        new
                        {
                            SerialNumber = "9f968557-9af8-4def-8274-444e659939a6",
                            Category = 4,
                            Name = "Tank Top"
                        },
                        new
                        {
                            SerialNumber = "5125abf2-a72b-4626-9109-5310dd9286e4",
                            Category = 4,
                            Name = "Baseball T-Shirt"
                        },
                        new
                        {
                            SerialNumber = "b7c7b463-01e4-421c-8438-43b7fdea3f6d",
                            Category = 4,
                            Name = "Muscle Tee"
                        },
                        new
                        {
                            SerialNumber = "071a9c92-4540-45b3-9224-eaf1847f8e69",
                            Category = 4,
                            Name = "Hooded T-Shirt"
                        },
                        new
                        {
                            SerialNumber = "93c7af49-3142-4f72-9ecb-450d6547b750",
                            Category = 4,
                            Name = "Sleeveless T-Shirt"
                        },
                        new
                        {
                            SerialNumber = "71b10e21-70e0-414f-8ad6-d35b5b5e0eee",
                            Category = 4,
                            Name = "Slim Fit T-Shirt"
                        },
                        new
                        {
                            SerialNumber = "c6878bd9-9446-4eb6-ab9c-3887c6bb424a",
                            Category = 4,
                            Name = "Graphic Hoodie"
                        },
                        new
                        {
                            SerialNumber = "6fb713f5-90c5-49bf-968f-62810fa424f4",
                            Category = 4,
                            Name = "Ringer Tee"
                        },
                        new
                        {
                            SerialNumber = "bcbf4f28-b975-4de5-a14c-6ca57637c357",
                            Category = 4,
                            Name = "Vintage Band Tee"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator().HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BarCodeHelper.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("BarCodeHelper.Models.BarCode", b =>
                {
                    b.HasOne("BarCodeHelper.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductSerialNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
