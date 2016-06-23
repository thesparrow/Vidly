using Vidly.Models;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.MembershipTypes", "SignUpFee", c => c.Short(nullable: false));
            //DropColumn("dbo.MembershipTypes", "SignUpType");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRates) VALUES (1,0,0,0)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRates) VALUES (2,30,1,10)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRates) VALUES (3,90,3,15)");
            Sql("INSERT INTO MembershipTypes(Id, SignUpFee, DurationInMonths, DiscountRates) VALUES (4,300,12,20)");

        }
        
        public override void Down()
        {
            DropTable("dbo.MembershipTypes");
        }
    }
}
