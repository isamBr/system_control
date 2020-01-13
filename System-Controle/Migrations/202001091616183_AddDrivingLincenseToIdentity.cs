﻿namespace System_Controle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDrivingLincenseToIdentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DrivingLincense", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DrivingLincense");
        }
    }
}
