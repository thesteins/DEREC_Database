

using FluentMigrator;

namespace DEREC_Database.Migrations.R00001
{
	[Migration(1)]
	public class M00001_CreateEmployeeTable : Migration
	{
		private const string AssocSchema = "assoc";
		public override void Up()
		{
			Create.Table("employee").InSchema(AssocSchema)
				.WithColumn("id").AsInt64().Identity().NotNullable().PrimaryKey()
				.WithColumn("emp_no").AsInt32().NotNullable()
				.WithColumn("district").AsString(2).NotNullable()
				.WithColumn("first_name").AsString(30).Nullable()

		}

		public override void Down()
		{
			if (Schema.Schema(AssocSchema).Table("employee").Exists())
			{
				Delete.Table("employee").InSchema(AssocSchema);
			}
		}
	}
}