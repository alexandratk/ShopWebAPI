using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedOn", "DateOfBirth", "FullName", "RegistrationDate" },
                values: new object[,]
                {
                    { new Guid("2e282f47-7d38-47b3-84ec-ad21988ea4d5"), new DateTime(2025, 3, 7, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new DateTime(1992, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael Brown", new DateTime(2025, 3, 7, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894) },
                    { new Guid("683b171e-34a9-4baf-bb67-e96d3a5a2379"), new DateTime(2025, 2, 15, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Doe", new DateTime(2025, 2, 15, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894) },
                    { new Guid("a1d8219b-8b96-4e2f-941b-1a440b1bca37"), new DateTime(2025, 3, 2, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new DateTime(2000, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily Davis", new DateTime(2025, 3, 2, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894) },
                    { new Guid("c2ce3b4f-3290-44bc-a0b0-c8b09e17c4b8"), new DateTime(2025, 2, 20, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new DateTime(1985, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alice Smith", new DateTime(2025, 2, 20, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894) },
                    { new Guid("c84ebbc4-22fe-461b-beaf-cab6f0ae9876"), new DateTime(2025, 2, 25, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new DateTime(1995, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert Johnson", new DateTime(2025, 2, 25, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894) }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("0173d3c3-d6fe-4faf-aa06-e9075013e3c9"), new DateTime(2025, 3, 1, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Category 9" },
                    { new Guid("1e4b431b-2866-48c2-9b33-0b69afaec5a8"), new DateTime(2025, 2, 27, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Category 10" },
                    { new Guid("5d4857ab-8075-4e78-baad-4ed50531ea57"), new DateTime(2025, 3, 17, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Category 1" },
                    { new Guid("6b7879c0-0b10-42ef-b5e1-ab09ab444a86"), new DateTime(2025, 3, 15, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Category 2" },
                    { new Guid("6cf7b38f-873d-4a8e-b84f-19c62748dac6"), new DateTime(2025, 3, 13, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Category 3" },
                    { new Guid("78c27bc3-e25b-4133-ae9f-0286edcd39b6"), new DateTime(2025, 3, 7, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Category 6" },
                    { new Guid("ba100768-9308-4bb3-a697-6576675e4063"), new DateTime(2025, 3, 9, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Category 5" },
                    { new Guid("e031aa4c-219f-4acd-a02e-f66d76f9ce90"), new DateTime(2025, 3, 3, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Category 8" },
                    { new Guid("e835f150-f353-4661-bbd6-eff22b5b0e86"), new DateTime(2025, 3, 5, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Category 7" },
                    { new Guid("eaa56e75-60d5-439a-b86b-1f6a50405462"), new DateTime(2025, 3, 11, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Category 4" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "CreatedOn", "Name", "Price", "ProductCategoryId" },
                values: new object[,]
                {
                    { new Guid("086d0ccc-a574-4127-9acb-ad7df0256f38"), "ART-008", new DateTime(2025, 3, 6, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 8", 775m, new Guid("e835f150-f353-4661-bbd6-eff22b5b0e86") },
                    { new Guid("0edb8354-6bb1-4ab4-b53d-d7a9f6f40aa6"), "ART-001", new DateTime(2025, 3, 17, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 1", 47m, new Guid("1e4b431b-2866-48c2-9b33-0b69afaec5a8") },
                    { new Guid("1833123c-160b-49fd-aba4-4e0b766cafbb"), "ART-009", new DateTime(2025, 3, 5, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 9", 147m, new Guid("e835f150-f353-4661-bbd6-eff22b5b0e86") },
                    { new Guid("284802e7-88a8-4f59-b8ad-c7b0a9c19446"), "ART-005", new DateTime(2025, 3, 11, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 5", 347m, new Guid("6b7879c0-0b10-42ef-b5e1-ab09ab444a86") },
                    { new Guid("40f93792-881b-4904-a809-12f6ddc3fdeb"), "ART-004", new DateTime(2025, 3, 12, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 4", 861m, new Guid("6cf7b38f-873d-4a8e-b84f-19c62748dac6") },
                    { new Guid("417f415b-ce26-4a91-a803-c38aa8d68389"), "ART-012", new DateTime(2025, 2, 28, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 12", 505m, new Guid("eaa56e75-60d5-439a-b86b-1f6a50405462") },
                    { new Guid("4883f8e4-fc17-434c-adaf-c5874f6d7064"), "ART-006", new DateTime(2025, 3, 9, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 6", 680m, new Guid("eaa56e75-60d5-439a-b86b-1f6a50405462") },
                    { new Guid("529ef17d-4820-4f1e-966f-01a9cd79822b"), "ART-020", new DateTime(2025, 2, 16, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 20", 262m, new Guid("5d4857ab-8075-4e78-baad-4ed50531ea57") },
                    { new Guid("76321a92-1bd3-4131-a86b-7dfe7253da20"), "ART-014", new DateTime(2025, 2, 25, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 14", 414m, new Guid("6b7879c0-0b10-42ef-b5e1-ab09ab444a86") },
                    { new Guid("79f38b24-3c16-4cca-b3bc-e16c8c14e5ed"), "ART-011", new DateTime(2025, 3, 2, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 11", 576m, new Guid("e835f150-f353-4661-bbd6-eff22b5b0e86") },
                    { new Guid("8a498516-6265-46f2-816d-86f9c1a16810"), "ART-018", new DateTime(2025, 2, 19, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 18", 965m, new Guid("5d4857ab-8075-4e78-baad-4ed50531ea57") },
                    { new Guid("93e28956-aa2d-408c-b9d4-3cae0b5939e1"), "ART-010", new DateTime(2025, 3, 3, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 10", 397m, new Guid("1e4b431b-2866-48c2-9b33-0b69afaec5a8") },
                    { new Guid("a33b8292-81d5-429a-916e-319a82a44f2a"), "ART-003", new DateTime(2025, 3, 14, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 3", 891m, new Guid("e031aa4c-219f-4acd-a02e-f66d76f9ce90") },
                    { new Guid("a86a542c-5185-46d4-916d-896ee753b8d1"), "ART-013", new DateTime(2025, 2, 27, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 13", 665m, new Guid("ba100768-9308-4bb3-a697-6576675e4063") },
                    { new Guid("b71d2aed-e8bf-4d63-a0dd-e692f2541c57"), "ART-016", new DateTime(2025, 2, 22, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 16", 766m, new Guid("e031aa4c-219f-4acd-a02e-f66d76f9ce90") },
                    { new Guid("c8a00379-72bd-4b3f-bdc1-33011a301bf2"), "ART-002", new DateTime(2025, 3, 15, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 2", 870m, new Guid("0173d3c3-d6fe-4faf-aa06-e9075013e3c9") },
                    { new Guid("d358dbe3-920d-4734-acd7-c6d2059e37b8"), "ART-007", new DateTime(2025, 3, 8, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 7", 679m, new Guid("eaa56e75-60d5-439a-b86b-1f6a50405462") },
                    { new Guid("edd592b3-75fd-4590-ae81-27c771771113"), "ART-017", new DateTime(2025, 2, 21, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 17", 583m, new Guid("6cf7b38f-873d-4a8e-b84f-19c62748dac6") },
                    { new Guid("f91a3488-4a14-488c-b1a9-b33af61568a8"), "ART-019", new DateTime(2025, 2, 18, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 19", 373m, new Guid("e031aa4c-219f-4acd-a02e-f66d76f9ce90") },
                    { new Guid("fc415153-2e0c-4d0d-934a-5a985c36dfe4"), "ART-015", new DateTime(2025, 2, 24, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), "Product 15", 709m, new Guid("1e4b431b-2866-48c2-9b33-0b69afaec5a8") }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "Id", "CreatedOn", "CustomerId", "TotalAmount" },
                values: new object[,]
                {
                    { new Guid("010d2413-6993-4930-a79a-a9a2fae8b1f7"), new DateTime(2025, 3, 7, 9, 57, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("c84ebbc4-22fe-461b-beaf-cab6f0ae9876"), 138m },
                    { new Guid("0667cf5b-b971-4c30-82bf-99aed5286ab7"), new DateTime(2025, 3, 2, 14, 45, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("a1d8219b-8b96-4e2f-941b-1a440b1bca37"), 245m },
                    { new Guid("0b0346cf-db7a-4f80-ace6-66898b4d789c"), new DateTime(2025, 2, 24, 14, 45, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("a1d8219b-8b96-4e2f-941b-1a440b1bca37"), 1922m },
                    { new Guid("1141551d-201b-41af-a57e-772d1d0c0c65"), new DateTime(2025, 3, 8, 14, 45, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("683b171e-34a9-4baf-bb67-e96d3a5a2379"), 1729m },
                    { new Guid("15f2a50c-440c-42b1-8678-66ceb746dc96"), new DateTime(2025, 2, 13, 19, 33, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("c84ebbc4-22fe-461b-beaf-cab6f0ae9876"), 855m },
                    { new Guid("2a07be41-186e-4283-8a48-9d6032cac3a9"), new DateTime(2025, 3, 12, 5, 9, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("c84ebbc4-22fe-461b-beaf-cab6f0ae9876"), 1470m },
                    { new Guid("2aa9087a-9a85-405c-bf48-684e972bcef7"), new DateTime(2025, 2, 21, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("c2ce3b4f-3290-44bc-a0b0-c8b09e17c4b8"), 998m },
                    { new Guid("2e324283-0466-49c0-ada5-35bcfa7c3e65"), new DateTime(2025, 2, 17, 9, 57, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("683b171e-34a9-4baf-bb67-e96d3a5a2379"), 466m },
                    { new Guid("3cb9fa77-8bd6-45c0-94d3-f46da677b4a4"), new DateTime(2025, 2, 23, 9, 57, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("2e282f47-7d38-47b3-84ec-ad21988ea4d5"), 257m },
                    { new Guid("3ec2ee8d-b6ba-47ab-9e5e-7e7113201344"), new DateTime(2025, 3, 14, 14, 45, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("a1d8219b-8b96-4e2f-941b-1a440b1bca37"), 1266m },
                    { new Guid("44da26d8-e242-4e2d-9c41-dc8a385f4404"), new DateTime(2025, 3, 9, 19, 33, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("683b171e-34a9-4baf-bb67-e96d3a5a2379"), 245m },
                    { new Guid("460866b2-b5c9-437b-9d6c-6e7df53e8fc3"), new DateTime(2025, 3, 6, 5, 9, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("683b171e-34a9-4baf-bb67-e96d3a5a2379"), 519m },
                    { new Guid("51a8c3c3-9b8a-4389-9416-28b472a89c44"), new DateTime(2025, 2, 28, 5, 9, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("a1d8219b-8b96-4e2f-941b-1a440b1bca37"), 1753m },
                    { new Guid("5c209ffb-a106-4818-9d30-ad14f7ba4d53"), new DateTime(2025, 3, 5, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("2e282f47-7d38-47b3-84ec-ad21988ea4d5"), 1010m },
                    { new Guid("5c569ae9-6534-4f0e-8d3c-477f86c0812f"), new DateTime(2025, 3, 3, 19, 33, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("a1d8219b-8b96-4e2f-941b-1a440b1bca37"), 1170m },
                    { new Guid("5ef053b8-8c29-4dd2-938b-683b5950a77d"), new DateTime(2025, 2, 22, 5, 9, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("c2ce3b4f-3290-44bc-a0b0-c8b09e17c4b8"), 1277m },
                    { new Guid("6361b982-2196-4111-b586-14b6fc88f484"), new DateTime(2025, 2, 10, 5, 9, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("a1d8219b-8b96-4e2f-941b-1a440b1bca37"), 1032m },
                    { new Guid("65f0f6d9-d22c-48e4-964d-841f72f472af"), new DateTime(2025, 2, 12, 14, 45, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("a1d8219b-8b96-4e2f-941b-1a440b1bca37"), 214m },
                    { new Guid("6e5767d4-68cd-45fd-8eac-19cd1bc19556"), new DateTime(2025, 3, 1, 9, 57, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("a1d8219b-8b96-4e2f-941b-1a440b1bca37"), 997m },
                    { new Guid("72e389c0-fedc-4835-a772-bcd3b5e6b6ee"), new DateTime(2025, 2, 15, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("c2ce3b4f-3290-44bc-a0b0-c8b09e17c4b8"), 1138m },
                    { new Guid("7abbde62-94f0-4655-8d4d-dd1b08c951d1"), new DateTime(2025, 2, 19, 19, 33, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("683b171e-34a9-4baf-bb67-e96d3a5a2379"), 1267m },
                    { new Guid("94d7925c-d43c-4d65-859d-9424174a0e50"), new DateTime(2025, 3, 11, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("c2ce3b4f-3290-44bc-a0b0-c8b09e17c4b8"), 519m },
                    { new Guid("b57b1484-7040-483a-86ec-54f8cfee048b"), new DateTime(2025, 3, 15, 19, 33, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("c2ce3b4f-3290-44bc-a0b0-c8b09e17c4b8"), 52m },
                    { new Guid("c8b96401-871e-4491-9bfd-0629f1075c6c"), new DateTime(2025, 2, 27, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("a1d8219b-8b96-4e2f-941b-1a440b1bca37"), 1427m },
                    { new Guid("d77ca18b-8bc5-49e6-b0c4-0f50b240aab4"), new DateTime(2025, 2, 11, 9, 57, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("683b171e-34a9-4baf-bb67-e96d3a5a2379"), 1968m },
                    { new Guid("e543bf0d-9132-4961-a3f9-b4a6e77f7ca0"), new DateTime(2025, 3, 13, 9, 57, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("2e282f47-7d38-47b3-84ec-ad21988ea4d5"), 373m },
                    { new Guid("eee01811-16dd-4551-8fce-37ab808f4ae9"), new DateTime(2025, 2, 25, 19, 33, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("683b171e-34a9-4baf-bb67-e96d3a5a2379"), 492m },
                    { new Guid("ef7cc315-71b0-4585-9d01-d4de7b6157b0"), new DateTime(2025, 2, 18, 14, 45, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("683b171e-34a9-4baf-bb67-e96d3a5a2379"), 1535m },
                    { new Guid("f0f11cf7-37ee-498b-a915-a0e137a52c98"), new DateTime(2025, 3, 17, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("c84ebbc4-22fe-461b-beaf-cab6f0ae9876"), 1745m },
                    { new Guid("f6f2d0d5-aa80-4fbd-9446-08045dc7ede9"), new DateTime(2025, 2, 16, 5, 9, 58, 793, DateTimeKind.Utc).AddTicks(8895), new Guid("2e282f47-7d38-47b3-84ec-ad21988ea4d5"), 874m }
                });

            migrationBuilder.InsertData(
                table: "PurchaseItems",
                columns: new[] { "Id", "CreatedOn", "ProductId", "PurchaseId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("003521ec-eb9f-4b05-9f36-c5ac9cc0ac0e"), new DateTime(2025, 3, 10, 15, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("284802e7-88a8-4f59-b8ad-c7b0a9c19446"), new Guid("f6f2d0d5-aa80-4fbd-9446-08045dc7ede9"), 4 },
                    { new Guid("036ef20c-2758-48a1-a903-a452295642a4"), new DateTime(2025, 3, 13, 21, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("529ef17d-4820-4f1e-966f-01a9cd79822b"), new Guid("5c569ae9-6534-4f0e-8d3c-477f86c0812f"), 2 },
                    { new Guid("04f917a8-d970-4ca5-881f-cc14067982ff"), new DateTime(2025, 3, 15, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("d358dbe3-920d-4734-acd7-c6d2059e37b8"), new Guid("1141551d-201b-41af-a57e-772d1d0c0c65"), 4 },
                    { new Guid("0c5b1384-45d9-47f1-8fd9-734bb6a09eec"), new DateTime(2025, 3, 10, 3, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("529ef17d-4820-4f1e-966f-01a9cd79822b"), new Guid("65f0f6d9-d22c-48e4-964d-841f72f472af"), 4 },
                    { new Guid("1017806a-0312-4170-9320-d596d58c3ee4"), new DateTime(2025, 3, 12, 21, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("40f93792-881b-4904-a809-12f6ddc3fdeb"), new Guid("51a8c3c3-9b8a-4389-9416-28b472a89c44"), 4 },
                    { new Guid("14af603f-037d-4031-a995-cf1830c3f9ad"), new DateTime(2025, 3, 16, 9, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("4883f8e4-fc17-434c-adaf-c5874f6d7064"), new Guid("3ec2ee8d-b6ba-47ab-9e5e-7e7113201344"), 2 },
                    { new Guid("1d7c9e54-6ae2-4fe0-aded-b9545e5a3f41"), new DateTime(2025, 3, 13, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("4883f8e4-fc17-434c-adaf-c5874f6d7064"), new Guid("51a8c3c3-9b8a-4389-9416-28b472a89c44"), 4 },
                    { new Guid("2a7f8575-a05f-4c29-841e-718f5062d71d"), new DateTime(2025, 3, 11, 9, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("79f38b24-3c16-4cca-b3bc-e16c8c14e5ed"), new Guid("2aa9087a-9a85-405c-bf48-684e972bcef7"), 2 },
                    { new Guid("30b7ab69-44f6-4fbc-8e69-4606d562fa11"), new DateTime(2025, 3, 13, 3, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("d358dbe3-920d-4734-acd7-c6d2059e37b8"), new Guid("6e5767d4-68cd-45fd-8eac-19cd1bc19556"), 2 },
                    { new Guid("3b792e60-178b-4888-a3ac-f54738152263"), new DateTime(2025, 3, 12, 15, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("d358dbe3-920d-4734-acd7-c6d2059e37b8"), new Guid("c8b96401-871e-4491-9bfd-0629f1075c6c"), 3 },
                    { new Guid("3ca93f37-8a97-498c-9aab-b7d4f7ec6efb"), new DateTime(2025, 3, 12, 18, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("edd592b3-75fd-4590-ae81-27c771771113"), new Guid("c8b96401-871e-4491-9bfd-0629f1075c6c"), 4 },
                    { new Guid("3ffe6bb9-be49-4f86-ac99-2fcc19ef6cf4"), new DateTime(2025, 3, 16, 3, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("a86a542c-5185-46d4-916d-896ee753b8d1"), new Guid("e543bf0d-9132-4961-a3f9-b4a6e77f7ca0"), 2 },
                    { new Guid("46a56d59-6a7e-423f-a2c0-3cdb15774f43"), new DateTime(2025, 3, 13, 9, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("086d0ccc-a574-4127-9acb-ad7df0256f38"), new Guid("6e5767d4-68cd-45fd-8eac-19cd1bc19556"), 2 },
                    { new Guid("51a553f9-776a-4838-8ed1-687bdeba3dd6"), new DateTime(2025, 3, 15, 9, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("76321a92-1bd3-4131-a86b-7dfe7253da20"), new Guid("44da26d8-e242-4e2d-9c41-dc8a385f4404"), 4 },
                    { new Guid("51eaf886-6e25-4b4b-a471-0d63d0d20777"), new DateTime(2025, 3, 14, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("284802e7-88a8-4f59-b8ad-c7b0a9c19446"), new Guid("5c209ffb-a106-4818-9d30-ad14f7ba4d53"), 2 },
                    { new Guid("6058902f-8364-4808-9b22-5e4bd7070792"), new DateTime(2025, 3, 11, 15, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("529ef17d-4820-4f1e-966f-01a9cd79822b"), new Guid("5ef053b8-8c29-4dd2-938b-683b5950a77d"), 1 },
                    { new Guid("6215245d-8c6a-4874-841f-ffb551d751ff"), new DateTime(2025, 3, 11, 6, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("0edb8354-6bb1-4ab4-b53d-d7a9f6f40aa6"), new Guid("7abbde62-94f0-4655-8d4d-dd1b08c951d1"), 2 },
                    { new Guid("630cd9cf-ce25-412e-871e-fb24596f209c"), new DateTime(2025, 3, 14, 21, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("417f415b-ce26-4a91-a803-c38aa8d68389"), new Guid("1141551d-201b-41af-a57e-772d1d0c0c65"), 3 },
                    { new Guid("6549e886-2042-4490-a94d-32d57440f839"), new DateTime(2025, 3, 15, 18, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("fc415153-2e0c-4d0d-934a-5a985c36dfe4"), new Guid("2a07be41-186e-4283-8a48-9d6032cac3a9"), 4 },
                    { new Guid("677134a7-9da0-4289-baf3-cb1b2c4e599a"), new DateTime(2025, 3, 9, 18, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("a86a542c-5185-46d4-916d-896ee753b8d1"), new Guid("d77ca18b-8bc5-49e6-b0c4-0f50b240aab4"), 1 },
                    { new Guid("698f7b42-121e-463f-aa4c-6f4ce29203ec"), new DateTime(2025, 3, 14, 6, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("0edb8354-6bb1-4ab4-b53d-d7a9f6f40aa6"), new Guid("460866b2-b5c9-437b-9d6c-6e7df53e8fc3"), 2 },
                    { new Guid("70d61416-8a63-44ac-bd25-831d62eb414b"), new DateTime(2025, 3, 10, 21, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("40f93792-881b-4904-a809-12f6ddc3fdeb"), new Guid("2e324283-0466-49c0-ada5-35bcfa7c3e65"), 4 },
                    { new Guid("73a41ad0-ceb3-4f28-89e6-51ce98199880"), new DateTime(2025, 3, 14, 3, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("f91a3488-4a14-488c-b1a9-b33af61568a8"), new Guid("5c209ffb-a106-4818-9d30-ad14f7ba4d53"), 2 },
                    { new Guid("75e20fee-e464-4ff2-997b-9dbce315a023"), new DateTime(2025, 3, 10, 9, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("529ef17d-4820-4f1e-966f-01a9cd79822b"), new Guid("72e389c0-fedc-4835-a772-bcd3b5e6b6ee"), 4 },
                    { new Guid("770da579-ab9e-4003-831b-121f49e8d578"), new DateTime(2025, 3, 10, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("b71d2aed-e8bf-4d63-a0dd-e692f2541c57"), new Guid("72e389c0-fedc-4835-a772-bcd3b5e6b6ee"), 1 },
                    { new Guid("7f26b7ad-f017-41ff-a41b-fc97cdc1f56e"), new DateTime(2025, 3, 16, 15, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("8a498516-6265-46f2-816d-86f9c1a16810"), new Guid("b57b1484-7040-483a-86ec-54f8cfee048b"), 3 },
                    { new Guid("7f92175b-ccc3-493a-848c-4a4800386106"), new DateTime(2025, 3, 12, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("417f415b-ce26-4a91-a803-c38aa8d68389"), new Guid("c8b96401-871e-4491-9bfd-0629f1075c6c"), 2 },
                    { new Guid("85a0d0ef-7a39-4e7b-b1f4-23e25f1c65b0"), new DateTime(2025, 3, 13, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("d358dbe3-920d-4734-acd7-c6d2059e37b8"), new Guid("0667cf5b-b971-4c30-82bf-99aed5286ab7"), 4 },
                    { new Guid("88d82175-7ae8-4b02-9eaf-9dbfd82f4ad9"), new DateTime(2025, 3, 12, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("a33b8292-81d5-429a-916e-319a82a44f2a"), new Guid("0b0346cf-db7a-4f80-ace6-66898b4d789c"), 1 },
                    { new Guid("8b14c7b9-4183-44a3-a439-a97be885817e"), new DateTime(2025, 3, 16, 6, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("b71d2aed-e8bf-4d63-a0dd-e692f2541c57"), new Guid("3ec2ee8d-b6ba-47ab-9e5e-7e7113201344"), 1 },
                    { new Guid("8c2727d1-eaf3-4b31-8d98-a118bfd8270a"), new DateTime(2025, 3, 11, 3, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("40f93792-881b-4904-a809-12f6ddc3fdeb"), new Guid("7abbde62-94f0-4655-8d4d-dd1b08c951d1"), 1 },
                    { new Guid("902aecfc-5051-433a-8bdf-cd55aad468ab"), new DateTime(2025, 3, 15, 15, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("0edb8354-6bb1-4ab4-b53d-d7a9f6f40aa6"), new Guid("2a07be41-186e-4283-8a48-9d6032cac3a9"), 4 },
                    { new Guid("9a2c1fdd-448f-4a40-82f6-c7a322d9052a"), new DateTime(2025, 3, 16, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("086d0ccc-a574-4127-9acb-ad7df0256f38"), new Guid("e543bf0d-9132-4961-a3f9-b4a6e77f7ca0"), 1 },
                    { new Guid("9da5aaf0-f750-4db5-86e3-f0cd48eb6191"), new DateTime(2025, 3, 15, 6, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("fc415153-2e0c-4d0d-934a-5a985c36dfe4"), new Guid("44da26d8-e242-4e2d-9c41-dc8a385f4404"), 4 },
                    { new Guid("a07f2a53-9841-454c-a335-1ad5f38546ac"), new DateTime(2025, 3, 9, 15, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("529ef17d-4820-4f1e-966f-01a9cd79822b"), new Guid("d77ca18b-8bc5-49e6-b0c4-0f50b240aab4"), 2 },
                    { new Guid("a0d67b99-6226-47c5-9f52-f8b7365b3fc7"), new DateTime(2025, 3, 10, 6, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("086d0ccc-a574-4127-9acb-ad7df0256f38"), new Guid("15f2a50c-440c-42b1-8678-66ceb746dc96"), 3 },
                    { new Guid("a10d9030-a905-475b-b65c-e09ef14306cc"), new DateTime(2025, 3, 16, 21, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("a33b8292-81d5-429a-916e-319a82a44f2a"), new Guid("f0f11cf7-37ee-498b-a915-a0e137a52c98"), 1 },
                    { new Guid("a1975d50-1cbb-4533-bc5d-36d4d5af3430"), new DateTime(2025, 3, 12, 6, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("0edb8354-6bb1-4ab4-b53d-d7a9f6f40aa6"), new Guid("eee01811-16dd-4551-8fce-37ab808f4ae9"), 2 },
                    { new Guid("a36ebb73-471c-487f-9411-bf3b87030644"), new DateTime(2025, 3, 14, 9, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("edd592b3-75fd-4590-ae81-27c771771113"), new Guid("460866b2-b5c9-437b-9d6c-6e7df53e8fc3"), 4 },
                    { new Guid("a904613d-9fe2-4283-afbf-b070d10b6c25"), new DateTime(2025, 3, 9, 21, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("8a498516-6265-46f2-816d-86f9c1a16810"), new Guid("d77ca18b-8bc5-49e6-b0c4-0f50b240aab4"), 3 },
                    { new Guid("aa55d486-ad0c-40cb-ad3d-7f01e7a6985f"), new DateTime(2025, 3, 11, 21, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("fc415153-2e0c-4d0d-934a-5a985c36dfe4"), new Guid("3cb9fa77-8bd6-45c0-94d3-f46da677b4a4"), 4 },
                    { new Guid("aaf1ffd0-0e09-4229-a4ee-466cabd8ecb2"), new DateTime(2025, 3, 13, 6, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("4883f8e4-fc17-434c-adaf-c5874f6d7064"), new Guid("6e5767d4-68cd-45fd-8eac-19cd1bc19556"), 4 },
                    { new Guid("b14e6669-16eb-46f9-9917-573f444dd5dc"), new DateTime(2025, 3, 10, 18, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("0edb8354-6bb1-4ab4-b53d-d7a9f6f40aa6"), new Guid("f6f2d0d5-aa80-4fbd-9446-08045dc7ede9"), 3 },
                    { new Guid("b66ac84e-b7b3-473c-9268-2e60de03f465"), new DateTime(2025, 3, 12, 9, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("fc415153-2e0c-4d0d-934a-5a985c36dfe4"), new Guid("eee01811-16dd-4551-8fce-37ab808f4ae9"), 4 },
                    { new Guid("b984e609-84c1-4f40-87d7-3083bd6e6d25"), new DateTime(2025, 3, 14, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("1833123c-160b-49fd-aba4-4e0b766cafbb"), new Guid("010d2413-6993-4930-a79a-a9a2fae8b1f7"), 2 },
                    { new Guid("b9aafec3-2053-45b8-9b3d-c49d088e50ff"), new DateTime(2025, 3, 11, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("a86a542c-5185-46d4-916d-896ee753b8d1"), new Guid("ef7cc315-71b0-4585-9d01-d4de7b6157b0"), 3 },
                    { new Guid("bec3204a-c0d6-4b68-92ef-99124d14eff0"), new DateTime(2025, 3, 9, 9, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("c8a00379-72bd-4b3f-bdc1-33011a301bf2"), new Guid("6361b982-2196-4111-b586-14b6fc88f484"), 3 },
                    { new Guid("c094c13b-ca5c-4683-9ded-45b5a113932d"), new DateTime(2025, 3, 12, 3, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("0edb8354-6bb1-4ab4-b53d-d7a9f6f40aa6"), new Guid("0b0346cf-db7a-4f80-ace6-66898b4d789c"), 2 },
                    { new Guid("c13098a1-7a65-4252-b25c-cad4cb454d0c"), new DateTime(2025, 3, 15, 21, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("a86a542c-5185-46d4-916d-896ee753b8d1"), new Guid("2a07be41-186e-4283-8a48-9d6032cac3a9"), 4 },
                    { new Guid("ca23d5cd-e09b-4de7-98f1-e1ca8a648381"), new DateTime(2025, 3, 14, 15, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("79f38b24-3c16-4cca-b3bc-e16c8c14e5ed"), new Guid("010d2413-6993-4930-a79a-a9a2fae8b1f7"), 2 },
                    { new Guid("d2c1149c-7ff3-49be-868b-88fa1a5ad342"), new DateTime(2025, 3, 16, 18, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("529ef17d-4820-4f1e-966f-01a9cd79822b"), new Guid("b57b1484-7040-483a-86ec-54f8cfee048b"), 4 },
                    { new Guid("d2ea3264-5146-4f2f-a823-2247ba254b3a"), new DateTime(2025, 3, 15, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("417f415b-ce26-4a91-a803-c38aa8d68389"), new Guid("94d7925c-d43c-4d65-859d-9424174a0e50"), 1 },
                    { new Guid("d3ce2a7d-79c6-4592-ba8b-bbff676eb54c"), new DateTime(2025, 3, 10, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("76321a92-1bd3-4131-a86b-7dfe7253da20"), new Guid("65f0f6d9-d22c-48e4-964d-841f72f472af"), 3 },
                    { new Guid("daeb7086-4548-48c0-a11e-b6d79f5377e4"), new DateTime(2025, 3, 15, 3, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("a86a542c-5185-46d4-916d-896ee753b8d1"), new Guid("44da26d8-e242-4e2d-9c41-dc8a385f4404"), 1 },
                    { new Guid("e4f6ba1c-c6a3-45bb-8a3f-62d2592e7251"), new DateTime(2025, 3, 13, 15, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("edd592b3-75fd-4590-ae81-27c771771113"), new Guid("0667cf5b-b971-4c30-82bf-99aed5286ab7"), 3 },
                    { new Guid("ed28623f-91a9-4209-bc9a-fc16503164a5"), new DateTime(2025, 3, 14, 18, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("529ef17d-4820-4f1e-966f-01a9cd79822b"), new Guid("1141551d-201b-41af-a57e-772d1d0c0c65"), 1 },
                    { new Guid("efedfa60-b01b-4681-91ed-e87f46ecf63a"), new DateTime(2025, 3, 11, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("edd592b3-75fd-4590-ae81-27c771771113"), new Guid("5ef053b8-8c29-4dd2-938b-683b5950a77d"), 3 },
                    { new Guid("f1b5b549-7314-453f-875f-e15e1fe9975e"), new DateTime(2025, 3, 13, 18, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("284802e7-88a8-4f59-b8ad-c7b0a9c19446"), new Guid("0667cf5b-b971-4c30-82bf-99aed5286ab7"), 2 },
                    { new Guid("f2eef213-8dc0-48f0-b152-b41e8fa09be5"), new DateTime(2025, 3, 17, 0, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("0edb8354-6bb1-4ab4-b53d-d7a9f6f40aa6"), new Guid("f0f11cf7-37ee-498b-a915-a0e137a52c98"), 3 },
                    { new Guid("f48c9e84-0dc6-4618-bb8d-6997e07f2df4"), new DateTime(2025, 3, 16, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("fc415153-2e0c-4d0d-934a-5a985c36dfe4"), new Guid("b57b1484-7040-483a-86ec-54f8cfee048b"), 3 },
                    { new Guid("f90a7535-5647-4c00-8756-3ca13adb2f8b"), new DateTime(2025, 3, 9, 12, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("93e28956-aa2d-408c-b9d4-3cae0b5939e1"), new Guid("6361b982-2196-4111-b586-14b6fc88f484"), 4 },
                    { new Guid("fd36486c-6d85-4a36-82a9-222b17417016"), new DateTime(2025, 3, 11, 18, 21, 58, 793, DateTimeKind.Utc).AddTicks(8894), new Guid("fc415153-2e0c-4d0d-934a-5a985c36dfe4"), new Guid("3cb9fa77-8bd6-45c0-94d3-f46da677b4a4"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("78c27bc3-e25b-4133-ae9f-0286edcd39b6"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("003521ec-eb9f-4b05-9f36-c5ac9cc0ac0e"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("036ef20c-2758-48a1-a903-a452295642a4"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("04f917a8-d970-4ca5-881f-cc14067982ff"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("0c5b1384-45d9-47f1-8fd9-734bb6a09eec"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("1017806a-0312-4170-9320-d596d58c3ee4"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("14af603f-037d-4031-a995-cf1830c3f9ad"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("1d7c9e54-6ae2-4fe0-aded-b9545e5a3f41"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("2a7f8575-a05f-4c29-841e-718f5062d71d"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("30b7ab69-44f6-4fbc-8e69-4606d562fa11"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("3b792e60-178b-4888-a3ac-f54738152263"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("3ca93f37-8a97-498c-9aab-b7d4f7ec6efb"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("3ffe6bb9-be49-4f86-ac99-2fcc19ef6cf4"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("46a56d59-6a7e-423f-a2c0-3cdb15774f43"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("51a553f9-776a-4838-8ed1-687bdeba3dd6"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("51eaf886-6e25-4b4b-a471-0d63d0d20777"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("6058902f-8364-4808-9b22-5e4bd7070792"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("6215245d-8c6a-4874-841f-ffb551d751ff"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("630cd9cf-ce25-412e-871e-fb24596f209c"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("6549e886-2042-4490-a94d-32d57440f839"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("677134a7-9da0-4289-baf3-cb1b2c4e599a"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("698f7b42-121e-463f-aa4c-6f4ce29203ec"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("70d61416-8a63-44ac-bd25-831d62eb414b"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("73a41ad0-ceb3-4f28-89e6-51ce98199880"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("75e20fee-e464-4ff2-997b-9dbce315a023"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("770da579-ab9e-4003-831b-121f49e8d578"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("7f26b7ad-f017-41ff-a41b-fc97cdc1f56e"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("7f92175b-ccc3-493a-848c-4a4800386106"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("85a0d0ef-7a39-4e7b-b1f4-23e25f1c65b0"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("88d82175-7ae8-4b02-9eaf-9dbfd82f4ad9"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("8b14c7b9-4183-44a3-a439-a97be885817e"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("8c2727d1-eaf3-4b31-8d98-a118bfd8270a"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("902aecfc-5051-433a-8bdf-cd55aad468ab"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("9a2c1fdd-448f-4a40-82f6-c7a322d9052a"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("9da5aaf0-f750-4db5-86e3-f0cd48eb6191"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("a07f2a53-9841-454c-a335-1ad5f38546ac"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("a0d67b99-6226-47c5-9f52-f8b7365b3fc7"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("a10d9030-a905-475b-b65c-e09ef14306cc"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("a1975d50-1cbb-4533-bc5d-36d4d5af3430"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("a36ebb73-471c-487f-9411-bf3b87030644"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("a904613d-9fe2-4283-afbf-b070d10b6c25"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("aa55d486-ad0c-40cb-ad3d-7f01e7a6985f"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("aaf1ffd0-0e09-4229-a4ee-466cabd8ecb2"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("b14e6669-16eb-46f9-9917-573f444dd5dc"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("b66ac84e-b7b3-473c-9268-2e60de03f465"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("b984e609-84c1-4f40-87d7-3083bd6e6d25"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("b9aafec3-2053-45b8-9b3d-c49d088e50ff"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("bec3204a-c0d6-4b68-92ef-99124d14eff0"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("c094c13b-ca5c-4683-9ded-45b5a113932d"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("c13098a1-7a65-4252-b25c-cad4cb454d0c"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("ca23d5cd-e09b-4de7-98f1-e1ca8a648381"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("d2c1149c-7ff3-49be-868b-88fa1a5ad342"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("d2ea3264-5146-4f2f-a823-2247ba254b3a"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("d3ce2a7d-79c6-4592-ba8b-bbff676eb54c"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("daeb7086-4548-48c0-a11e-b6d79f5377e4"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("e4f6ba1c-c6a3-45bb-8a3f-62d2592e7251"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("ed28623f-91a9-4209-bc9a-fc16503164a5"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("efedfa60-b01b-4681-91ed-e87f46ecf63a"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("f1b5b549-7314-453f-875f-e15e1fe9975e"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("f2eef213-8dc0-48f0-b152-b41e8fa09be5"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("f48c9e84-0dc6-4618-bb8d-6997e07f2df4"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("f90a7535-5647-4c00-8756-3ca13adb2f8b"));

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: new Guid("fd36486c-6d85-4a36-82a9-222b17417016"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("086d0ccc-a574-4127-9acb-ad7df0256f38"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0edb8354-6bb1-4ab4-b53d-d7a9f6f40aa6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1833123c-160b-49fd-aba4-4e0b766cafbb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("284802e7-88a8-4f59-b8ad-c7b0a9c19446"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("40f93792-881b-4904-a809-12f6ddc3fdeb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("417f415b-ce26-4a91-a803-c38aa8d68389"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4883f8e4-fc17-434c-adaf-c5874f6d7064"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("529ef17d-4820-4f1e-966f-01a9cd79822b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("76321a92-1bd3-4131-a86b-7dfe7253da20"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79f38b24-3c16-4cca-b3bc-e16c8c14e5ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a498516-6265-46f2-816d-86f9c1a16810"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("93e28956-aa2d-408c-b9d4-3cae0b5939e1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a33b8292-81d5-429a-916e-319a82a44f2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a86a542c-5185-46d4-916d-896ee753b8d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b71d2aed-e8bf-4d63-a0dd-e692f2541c57"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8a00379-72bd-4b3f-bdc1-33011a301bf2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d358dbe3-920d-4734-acd7-c6d2059e37b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("edd592b3-75fd-4590-ae81-27c771771113"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f91a3488-4a14-488c-b1a9-b33af61568a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fc415153-2e0c-4d0d-934a-5a985c36dfe4"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("010d2413-6993-4930-a79a-a9a2fae8b1f7"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("0667cf5b-b971-4c30-82bf-99aed5286ab7"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("0b0346cf-db7a-4f80-ace6-66898b4d789c"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("1141551d-201b-41af-a57e-772d1d0c0c65"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("15f2a50c-440c-42b1-8678-66ceb746dc96"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("2a07be41-186e-4283-8a48-9d6032cac3a9"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("2aa9087a-9a85-405c-bf48-684e972bcef7"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("2e324283-0466-49c0-ada5-35bcfa7c3e65"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("3cb9fa77-8bd6-45c0-94d3-f46da677b4a4"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("3ec2ee8d-b6ba-47ab-9e5e-7e7113201344"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("44da26d8-e242-4e2d-9c41-dc8a385f4404"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("460866b2-b5c9-437b-9d6c-6e7df53e8fc3"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("51a8c3c3-9b8a-4389-9416-28b472a89c44"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("5c209ffb-a106-4818-9d30-ad14f7ba4d53"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("5c569ae9-6534-4f0e-8d3c-477f86c0812f"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("5ef053b8-8c29-4dd2-938b-683b5950a77d"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("6361b982-2196-4111-b586-14b6fc88f484"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("65f0f6d9-d22c-48e4-964d-841f72f472af"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("6e5767d4-68cd-45fd-8eac-19cd1bc19556"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("72e389c0-fedc-4835-a772-bcd3b5e6b6ee"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("7abbde62-94f0-4655-8d4d-dd1b08c951d1"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("94d7925c-d43c-4d65-859d-9424174a0e50"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("b57b1484-7040-483a-86ec-54f8cfee048b"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("c8b96401-871e-4491-9bfd-0629f1075c6c"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("d77ca18b-8bc5-49e6-b0c4-0f50b240aab4"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("e543bf0d-9132-4961-a3f9-b4a6e77f7ca0"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("eee01811-16dd-4551-8fce-37ab808f4ae9"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("ef7cc315-71b0-4585-9d01-d4de7b6157b0"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("f0f11cf7-37ee-498b-a915-a0e137a52c98"));

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: new Guid("f6f2d0d5-aa80-4fbd-9446-08045dc7ede9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("2e282f47-7d38-47b3-84ec-ad21988ea4d5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("683b171e-34a9-4baf-bb67-e96d3a5a2379"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("a1d8219b-8b96-4e2f-941b-1a440b1bca37"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c2ce3b4f-3290-44bc-a0b0-c8b09e17c4b8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: new Guid("c84ebbc4-22fe-461b-beaf-cab6f0ae9876"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("0173d3c3-d6fe-4faf-aa06-e9075013e3c9"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("1e4b431b-2866-48c2-9b33-0b69afaec5a8"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("5d4857ab-8075-4e78-baad-4ed50531ea57"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("6b7879c0-0b10-42ef-b5e1-ab09ab444a86"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("6cf7b38f-873d-4a8e-b84f-19c62748dac6"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("ba100768-9308-4bb3-a697-6576675e4063"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("e031aa4c-219f-4acd-a02e-f66d76f9ce90"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("e835f150-f353-4661-bbd6-eff22b5b0e86"));

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: new Guid("eaa56e75-60d5-439a-b86b-1f6a50405462"));
        }
    }
}
