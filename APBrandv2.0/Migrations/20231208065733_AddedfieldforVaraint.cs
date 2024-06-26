using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APBrandv2._0.Migrations
{
    /// <inheritdoc />
    public partial class AddedfieldforVaraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Variant_Models_ModelID",
                table: "Variant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Variant",
                table: "Variant");

            migrationBuilder.RenameTable(
                name: "Variant",
                newName: "Variants");

            migrationBuilder.RenameIndex(
                name: "IX_Variant_ModelID",
                table: "Variants",
                newName: "IX_Variants_ModelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Variants",
                table: "Variants",
                column: "VariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Variants_Models_ModelID",
                table: "Variants",
                column: "ModelID",
                principalTable: "Models",
                principalColumn: "ModelID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Variants_Models_ModelID",
                table: "Variants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Variants",
                table: "Variants");

            migrationBuilder.RenameTable(
                name: "Variants",
                newName: "Variant");

            migrationBuilder.RenameIndex(
                name: "IX_Variants_ModelID",
                table: "Variant",
                newName: "IX_Variant_ModelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Variant",
                table: "Variant",
                column: "VariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Variant_Models_ModelID",
                table: "Variant",
                column: "ModelID",
                principalTable: "Models",
                principalColumn: "ModelID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
