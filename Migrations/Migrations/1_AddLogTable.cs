using FluentMigrator;

namespace Migrations.Migrations
{
    [Migration(202001)]
    public class AddLogTable : Migration
    {
        public override void Up()
        {
            Create.Table("Log")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Text").AsString();

            Execute.Sql("MY SQL QUERY");
        }

        public override void Down()
        {
            Delete.Table("Log");
        }
    }
}
