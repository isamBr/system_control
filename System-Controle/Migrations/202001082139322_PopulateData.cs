namespace System_Controle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres ( Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Thriller')");
            Sql("INSERT INTO Genres ( Name) VALUES ('Family')");
            Sql("INSERT INTO Genres (Name) VALUES ('Romance')");
            Sql("INSERT INTO Genres (Name) VALUES ('Comedy')");
            Sql("Insert into MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) Values(1,0,0,0)");
            Sql("Insert into MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) Values(2,30,1,10)");
            Sql("Insert into MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) Values(3,90,3,15)");
            Sql("Insert into MembershipTypes (Id,SignUpFee,DurationInMonths,DiscountRate) Values(4,300,12,20)");
            Sql("Insert into Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock)Values('Hangover',5,'02/10/1999','02/10/1999',1)");
            Sql("Insert into Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock)Values('Die Hard',1,'02/10/1999','02/10/1999',1)");
            Sql("Insert into Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock)Values('The Terminator',1,'02/10/1999','02/10/1999',1)");
            Sql("Insert into Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock)Values('Toy Story',3,'02/10/1999','02/10/1999',1)");
            Sql("Insert into Movies (Name,GenreId,DateAdded,ReleaseDate,NumberInStock)Values('Titanic',4,'02/10/1999','02/10/1999',1)");
            Sql("UPDATE MembershipTypes SET Name = 'Pay as You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
