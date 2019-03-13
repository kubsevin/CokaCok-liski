namespace CokaCokİliski
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class UniversiteContext : DbContext
    {
        // Your context has been configured to use a 'UniversiteContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CokaCokİliski.UniversiteContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'UniversiteContext' 
        // connection string in the application configuration file.
        public UniversiteContext()
            : base("name=UniversiteContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual DbSet<Egitmen> Egitmenler { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    [Table("Ogrenci")]
    public class Ogrenci
    {
        public Ogrenci()
        {
            this.Egitmenler = new HashSet<Egitmen>();
        }
        [Key]
        public int OgrenciId { get; set; }
        public string OgrenciName { get; set; }
        public string OgrenciSurName { get; set; }
        public virtual ICollection<Egitmen> Egitmenler { get; set; }

        public override string ToString()
        {
            return this.OgrenciName + ' ' + this.OgrenciSurName;
        }
    }
    [Table("Egitmen")]
    public class Egitmen
    {
        public Egitmen()
        {
            this.Ogrenciler = new HashSet<Ogrenci>();
        }
        [Key]
        public int EgitmenId { get; set; }
        public string EgitmenName { get; set; }
        public string EgitmenSurName { get; set; }


        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}