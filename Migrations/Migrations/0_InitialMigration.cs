using FluentMigrator;

namespace Migrations.Migrations
{
    [Migration(202000)]
    public class _0_InitialMigration : Migration
    {
        public override void Up()
        {
            // Create.Table()
            Create.Column("TestColumn2").OnTable("TestTable").AsString(1000).Nullable();
        }

        public override void Down()
        {
            // Delete.Table()
            Delete.Column("TestColumn2").FromTable("TestTable");
        }
    }
}
