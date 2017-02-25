using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Carmel.Models;

namespace Carmel.Migrations
{
    [DbContext(typeof(CatalogContext))]
    partial class CatalogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Carmel.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatorName");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("Carmel.Models.ComponentTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ComponentId");

                    b.Property<string>("cTag");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId");

                    b.ToTable("ComponentTag");
                });

            modelBuilder.Entity("Carmel.Models.Gist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("SampleId");

                    b.Property<string>("Url");

                    b.Property<bool>("isPrivate");

                    b.HasKey("Id");

                    b.HasIndex("SampleId");

                    b.ToTable("Gist");
                });

            modelBuilder.Entity("Carmel.Models.Sample", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ComponentId");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId");

                    b.ToTable("Samples");
                });

            modelBuilder.Entity("Carmel.Models.SampleTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("SampleId");

                    b.Property<string>("sTag");

                    b.HasKey("Id");

                    b.HasIndex("SampleId");

                    b.ToTable("SampleTag");
                });

            modelBuilder.Entity("Carmel.Models.ComponentTag", b =>
                {
                    b.HasOne("Carmel.Models.Component")
                        .WithMany("ComponentTags")
                        .HasForeignKey("ComponentId");
                });

            modelBuilder.Entity("Carmel.Models.Gist", b =>
                {
                    b.HasOne("Carmel.Models.Sample")
                        .WithMany("gists")
                        .HasForeignKey("SampleId");
                });

            modelBuilder.Entity("Carmel.Models.Sample", b =>
                {
                    b.HasOne("Carmel.Models.Component")
                        .WithMany("Samples")
                        .HasForeignKey("ComponentId");
                });

            modelBuilder.Entity("Carmel.Models.SampleTag", b =>
                {
                    b.HasOne("Carmel.Models.Sample")
                        .WithMany("sampleTags")
                        .HasForeignKey("SampleId");
                });
        }
    }
}
