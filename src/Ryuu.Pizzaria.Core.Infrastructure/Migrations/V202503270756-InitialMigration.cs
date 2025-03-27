using FluentMigrator;

namespace Ryuu.Pizzaria.Core.Infrastructure.Migrations;

[Migration(202503270756)]
public class InitialMigration : Migration
{
    public override void Up()
    {
        Create.Table("users")
            .WithColumn("id").AsGuid().PrimaryKey().Indexed()
            .WithColumn("name").AsString(120).NotNullable()
            .WithColumn("email").AsString(250).NotNullable().Unique()
            .WithColumn("password_hash").AsString(255).NotNullable()
            .WithColumn("phone_number").AsString(80).Nullable()
            .WithColumn("cpf").AsString(14).NotNullable().Unique()
            .WithColumn("verified").AsBoolean().WithDefaultValue(false).Indexed()
            .WithColumn("verification_code").AsString(255).Nullable()
            .WithColumn("birth_date").AsDateTime2().NotNullable()
            .WithColumn("created_at").AsDateTime().NotNullable().WithDefault(SystemMethods.CurrentUTCDateTime)
            .WithColumn("updated_at").AsDateTime().Nullable();
    }

    public override void Down()
    {
        Delete.Table("users").IfExists();
    }
}