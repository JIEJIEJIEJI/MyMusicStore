namespace MycDeno1.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MycDeno1.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MycDeno1.Models.MovieDBContext context)
        {
            context.Database.ExecuteSqlCommand("delete movies");
            var m1 = new Movie()
            {
                Titile = "����������IV",
                ReleaseDate = DateTime.Parse("2019-2-2"),
                Genre = "3D ����  ������",
                Price = 50.00M
            };
            var m2 = new Movie()
            {
                Titile = "��������",
                ReleaseDate = DateTime.Parse("2019-1-2"),
                Genre = "3D ����  ������",
                Price = 20.00M
            };
            var m3 = new Movie()
            {
                Titile = "���ӻ�����",
                ReleaseDate = DateTime.Parse("2018-12-12"),
                Genre = "3D ����  ������",
                Price = 30.00M
            };
            var m4 = new Movie()
            {
                Titile = "�����ع�4",
                ReleaseDate = DateTime.Parse("2018-12-16"),
                Genre = "����  ����",
                Price = 20.00M
            };
            var m5 = new Movie()
            {
                Titile = "��Һ�������ػ���",
                ReleaseDate = DateTime.Parse("2018-1-1"),
                Genre = "����  ������",
                Price = 20.00M
            };
            context.Movies.Add(m1);
            context.Movies.Add(m2);
            context.Movies.Add(m3);
            context.Movies.Add(m4);
            context.Movies.Add(m5);
            context.SaveChanges();

        }
    }
}
