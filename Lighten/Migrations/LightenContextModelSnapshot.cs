// <auto-genePriced />
using Lighten.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lighten.Migrations
{
    [DbContext(typeof(LightenContext))]
    partial class LightenContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lighten.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStPricegy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LightModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LightCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LightType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("nvarchar(max)");
                    
                    b.HasKey("Id");

                    b.ToTable("Products");
                });
            
            modelBuilder.Entity("Lighten.Models.YourProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStPricegy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LightModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LightCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LightType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("nvarchar(max)");
                    
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("YourProducts");
                });

            modelBuilder.Entity("Lighten.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStPricegy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");
                    
                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });


            modelBuilder.Entity("Lighten.Models.Authenticate", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStPricegy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("LoginUser")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Password")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("Id");

                b.ToTable("Authenticate");
            });

            modelBuilder.Entity("Lighten.Models.Authenticate", b =>
            {
                b.HasOne("Lighten.Models.YourProducts", "YourProducts")
                    .WithMany()
                    .HasForeignKey("UserId");
            });


#pragma warning restore 612, 618
        }
    }
}
