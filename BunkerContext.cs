using Bunker_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Bunker_API;

public partial class BunkerContext : DbContext
{
    public BunkerContext()
    {
    }

    public BunkerContext(DbContextOptions<BunkerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bag> Bags { get; set; }

    public virtual DbSet<Biology> Biologies { get; set; }

    public virtual DbSet<Bunker> Bunkers { get; set; }

    public virtual DbSet<Catastrophe> Catastrophes { get; set; }

    public virtual DbSet<Danger> Dangers { get; set; }

    public virtual DbSet<Fact> Facts { get; set; }

    public virtual DbSet<Health> Healths { get; set; }

    public virtual DbSet<Hobby> Hobbies { get; set; }

    public virtual DbSet<Profession> Professions { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Specialcondition> Specialconditions { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").SetBasePath(Directory.GetCurrentDirectory()).Build();

        optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bag>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bag_pkey");

            entity.ToTable("bag");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Biology>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("biology_pkey");

            entity.ToTable("biology");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Bunker>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bunker_pkey");

            entity.ToTable("bunker");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Catastrophe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("catastrophe_pkey");

            entity.ToTable("catastrophe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Danger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("danger_pkey");

            entity.ToTable("danger");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Fact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fact_pkey");

            entity.ToTable("fact");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
        });

        modelBuilder.Entity<Health>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("health_pkey");

            entity.ToTable("health");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Hobby>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hobby_pkey");

            entity.ToTable("hobby");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Profession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("profession_pkey");

            entity.ToTable("profession");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("room_pkey");

            entity.ToTable("room");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Isactive).HasColumnName("isactive");
        });

        modelBuilder.Entity<Specialcondition>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("specialconditions_pkey");

            entity.ToTable("specialconditions");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("User_pkey");

            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bagid)
                .ValueGeneratedOnAdd()
                .HasColumnName("bagid");
            entity.Property(e => e.Biologyid)
                .ValueGeneratedOnAdd()
                .HasColumnName("biologyid");
            entity.Property(e => e.Factid)
                .ValueGeneratedOnAdd()
                .HasColumnName("factid");
            entity.Property(e => e.Healthid)
                .ValueGeneratedOnAdd()
                .HasColumnName("healthid");
            entity.Property(e => e.Hobbyid)
                .ValueGeneratedOnAdd()
                .HasColumnName("hobbyid");
            entity.Property(e => e.Isadmin).HasColumnName("isadmin");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Professionid)
                .ValueGeneratedOnAdd()
                .HasColumnName("professionid");
            entity.Property(e => e.Roomid)
                .ValueGeneratedOnAdd()
                .HasColumnName("roomid");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
