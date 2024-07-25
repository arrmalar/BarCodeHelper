using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BarCodeHelper.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    SerialNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.SerialNumber);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BarCodes",
                columns: table => new
                {
                    BarCodeNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductSerialNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BarCodes", x => new { x.BarCodeNumber, x.ProductSerialNumber });
                    table.ForeignKey(
                        name: "FK_BarCodes_Products_ProductSerialNumber",
                        column: x => x.ProductSerialNumber,
                        principalTable: "Products",
                        principalColumn: "SerialNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "SerialNumber", "Name" },
                values: new object[,]
                {
                    { "049cf805-b2ee-4c7e-a030-bbac161de6e5", "Flatbread" },
                    { "04af8d76-eb42-4725-afc7-c5ddc8d73d60", "Soda Bread" },
                    { "05daacbb-43f8-4849-b028-fcdd82ec0a8b", "Pumpernickel" },
                    { "079eea0b-8cd4-48c3-ab32-0cf02889c0a7", "Polenta" },
                    { "0b492b6b-45dd-4531-b42c-debe3e7f0589", "Multigrain Bread" },
                    { "0c8ce729-87c7-411f-a18f-59e9eb4c4e81", "Biscuits" },
                    { "138f7b4f-b40e-4c1e-b95a-6fdf287175cd", "Spaghetti" },
                    { "144ddb97-7c1f-49e3-8466-7876e38695a6", "Orzo" },
                    { "17d27e1f-32d2-4c59-aefb-07c3025e108b", "Bread" },
                    { "1bd4d114-d00f-449b-b5ee-3d08cc36d797", "Cornstarch" },
                    { "1fa77ee2-7a39-4e85-a721-5ed52b934f39", "Oatmeal" },
                    { "24927812-8a60-409e-b1dc-3e298c6d05d5", "Granola" },
                    { "271f0ad8-361e-45ff-be36-e3c577570ed9", "Jasmine Rice" },
                    { "2a1d5aec-cd8c-41d9-bcfc-c67163e144f2", "Brown Bread" },
                    { "2b1a6bc2-0fe8-47b0-88b7-9bb0677d9064", "Rotini" },
                    { "2c1b2f58-f83a-4def-8e45-286deb744df6", "Bran Flakes" },
                    { "2c3a677f-e764-4462-8c9d-0a4f6d9cf9c3", "Sushi Rice" },
                    { "332cf18f-cec1-4503-bddf-ebab9f5bd525", "Capellini" },
                    { "358aecf5-f743-49f4-969d-6fb1f55c941a", "Rigatoni" },
                    { "3594ad3e-3160-4c24-b97d-54f3f202ca8c", "Ziti" },
                    { "39f963bc-a409-430f-af5a-a1c7ee030b4a", "Whole Wheat Flour" },
                    { "3ae77e75-cdfb-4520-b662-510b503048ab", "Angel Hair Pasta" },
                    { "3b014a61-4c5d-438d-b883-203cebe6e742", "Rice" },
                    { "3c026a69-42c7-426f-b12c-da2ac88ff564", "Tortilla" },
                    { "3c6c99cb-c83a-45b0-a86b-995d2324ee54", "Shells" },
                    { "3f689e6c-8c7a-4d86-9c4d-90dcb1337d24", "Flour" },
                    { "4031259d-d59f-4a40-8b47-63c0ab8fa409", "Brown Rice" },
                    { "40d24eb8-8673-4ea2-964f-1ad2b7332513", "Buckwheat" },
                    { "43570467-d334-4bcb-a0bf-d7ed4d1ac0d7", "Muesli" },
                    { "44dd9331-b9c2-4458-95d1-9b9315f33e7e", "Pasta" },
                    { "4576c6d7-d8a7-4036-b2f0-ec43d9641cca", "Sourdough Bread" },
                    { "499365c3-5336-4b70-bb43-5b3fdf205bc1", "Sugar" },
                    { "4d5b521e-6542-4958-ad4f-2900f7745cb4", "Cannelloni" },
                    { "4e6f4613-e43e-4961-b7b6-a3f568c4ea02", "Gnocchi" },
                    { "4ef167e7-8119-4d75-ac7e-9df940c02795", "Gemelli" },
                    { "519a6566-1612-4c10-a4c2-6255e64c8d5b", "Wheat Bran" },
                    { "531df2cb-12a6-42b6-a853-70a2efed167d", "Yeast" },
                    { "532a31a0-1f81-4731-98de-2ea997dd2b6a", "Graham Crackers" },
                    { "562faef1-5b01-4a01-993d-19a0b531d74f", "Breadcrumbs" },
                    { "56d7600b-ab98-4796-ab9b-320bcda29494", "Arborio Rice" },
                    { "575129e3-f061-4019-a35e-87e49faaebfd", "Cornmeal" },
                    { "57c2f668-6955-4aa1-b613-418bf8330293", "White Bread" },
                    { "5b34109c-f14b-4a9b-9e0f-e7064c8d0999", "Grits" },
                    { "5db4f238-beb8-4ef7-b3f7-1cac143d5231", "Radiatori" },
                    { "60b7e24b-1a2b-4c2f-bc51-e04884f2ca0b", "Linguine" },
                    { "62868d5e-1ee7-4347-bea4-b44b02aeda37", "Rice Cakes" },
                    { "694d498e-4cc3-4128-9f1d-5863a36021cd", "Campanelle" },
                    { "6a96f313-85a4-4c45-912c-0d29bad4b93d", "Quinoa" },
                    { "6c696257-d188-4eab-8668-2736d13272d3", "Salt" },
                    { "6c799845-4961-42a4-a6ef-2e18a67c2d1d", "Fettuccine" },
                    { "6e36c849-5df1-431d-9c96-3d2b3a183db3", "Ciabatta" },
                    { "72a3384f-232f-4c8b-b428-3c0b65b7a69d", "Wild Rice" },
                    { "73313076-3992-4283-b4da-f8452dc1c786", "Muffins" },
                    { "750131ec-782e-45fe-b4cb-1498eeb4680c", "Rye Flour" },
                    { "753c38bc-96b0-4120-853e-751a6807d964", "Instant Rice" },
                    { "7ee8cb0c-66f8-446c-a762-e3cc6f26a74b", "Udon Noodles" },
                    { "82550f47-0654-4c15-98f8-d3b1c07f3218", "Rice Noodles" },
                    { "83507059-9824-4493-a106-2117d597f169", "Strozzapreti" },
                    { "85fb797b-f151-4d25-938a-abbb6ce19dc7", "Macaroni" },
                    { "87d17432-19bb-4dfd-9ef6-534c257cc135", "Tortellini" },
                    { "8e54c8c6-4a60-4711-b9d1-c475823a60a6", "Pita Bread" },
                    { "8ff16a0c-542d-4d77-a241-5ada6d0c50a6", "Pretzels" },
                    { "9213db9a-4c12-4303-9f41-2ec577491e14", "Bucatini" },
                    { "94f9f0c2-09e6-4465-994e-930a3b31d1b2", "Quick Oats" },
                    { "971703a5-7970-4036-bb0b-edf92561b224", "Crackers" },
                    { "97cd1047-ed57-412d-aaa6-454fe3049d01", "Ramen Noodles" },
                    { "99c6677f-dca1-4eb7-8343-b92133994c52", "Brioche" },
                    { "9a73d116-5ea5-44af-910d-38f674ef4cd8", "Barley" },
                    { "9c6c36ee-0c6b-4267-87f2-f05869b027e5", "Corn Tortilla" },
                    { "9e293bac-87ae-4640-8615-25c0d4db99b1", "Potato Bread" },
                    { "a55de878-85e8-436c-8a0c-fe8142d3e67d", "Soba Noodles" },
                    { "aa68c625-7e92-4d25-8c4d-2e488e51379d", "Basmati Rice" },
                    { "af6bbe15-625b-49c2-8f5f-d9d3b408b252", "Glutinous Rice" },
                    { "b326df00-333b-4d01-8831-1b2a5773beb7", "Naan" },
                    { "b6f3f9d0-4c02-40b1-8dc6-b46b1bb8a8c3", "Acini di Pepe" },
                    { "bf911ffd-bb01-469d-b952-b95c397e3bb3", "Cavatappi" },
                    { "c36d9e08-9fda-4b32-b72f-21dbd64d8084", "Farfalle" },
                    { "c38d4a40-f04f-44f5-a38f-085cec693f44", "Doughnuts" },
                    { "c59e4856-1472-43f2-b252-c7fcb628ad58", "Panko" },
                    { "c78d6782-603b-4f0b-acb6-3e2178ab1272", "Wonton Wrappers" },
                    { "cccbd66c-7d8e-41bf-af20-b78150568ada", "Cornbread" },
                    { "ce7d78f0-1066-4efb-8f51-3e766e5df8a7", "Bagels" },
                    { "d2433c1f-51d0-414f-a102-95f4ce587143", "Rolls" },
                    { "dda52673-b64c-4620-b2dd-f7acf4d11e24", "Rye Bread" },
                    { "de522c98-1a37-44cd-ac1e-fb4dc3770e2b", "Anelli" },
                    { "e0c7eedf-d3ee-495c-8905-c2823ea12e42", "Challah" },
                    { "e2019486-9d42-4638-8d56-ae21b7a3a768", "Baguette" },
                    { "e2c38a0d-4ada-4cf3-b7ba-e0c0282c7542", "Rolled Oats" },
                    { "e5f55cc1-25b4-4eb9-8206-a1be2b021a8a", "Manicotti" },
                    { "e609eccc-cd68-47f3-90e8-6a7de95dedac", "Kaiser Rolls" },
                    { "eb8e4bf7-1a15-4373-b77d-2d11059449db", "Steel-Cut Oats" },
                    { "ed9efa14-7b33-4eca-9d83-919fea5b2d70", "Lasagna Noodles" },
                    { "ef703618-b890-46e5-abfa-98d80eed6546", "Oats" },
                    { "f3d28a97-1227-49f2-b21e-7750cf1e9ffc", "Couscous" },
                    { "f44e4e66-0367-410e-a258-169d6725cd95", "Semolina" },
                    { "f48f4606-277c-49b1-b5da-53e2556a2c9f", "Ditalini" },
                    { "f7777267-2ff7-4e71-91e0-30d685e992b8", "Focaccia" },
                    { "fc2d091e-9018-47f2-b38c-f5564f560129", "Millet" },
                    { "fc523f29-798a-405e-9eae-64deed9af1b3", "English Muffins" },
                    { "fdad55a6-e3ee-4598-a35d-35520182dd47", "Croissants" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BarCodes_ProductSerialNumber",
                table: "BarCodes",
                column: "ProductSerialNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BarCodes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
