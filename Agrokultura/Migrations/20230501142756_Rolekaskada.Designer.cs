﻿// <auto-generated />
using System;
using Agrokultura.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Agrokultura.Migrations
{
    [DbContext(typeof(AgroContext))]
    [Migration("20230501142756_Rolekaskada")]
    partial class Rolekaskada
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Agrokultura.Models.Chore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5000)")
                        .HasColumnName("description");

                    b.Property<double?>("Duration")
                        .HasColumnType("float")
                        .HasColumnName("duration");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK__chore__3213E83F1CB3BDDD");

                    b.ToTable("chore", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.ChorePerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ChoreId")
                        .HasColumnType("int")
                        .HasColumnName("chore_id");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5000)")
                        .HasColumnName("description");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int")
                        .HasColumnName("order_status_id");

                    b.Property<int>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("person_id");

                    b.HasKey("Id")
                        .HasName("PK__chore_pe__3213E83F7148C5FF");

                    b.HasIndex("ChoreId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("PersonId");

                    b.ToTable("chore_person", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.ChoreStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK__chore_st__3213E83FAD3F0B0E");

                    b.ToTable("chore_status", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int")
                        .HasColumnName("country_id");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("postal_code");

                    b.HasKey("Id")
                        .HasName("PK__city__3213E83F0FBAFC12");

                    b.HasIndex("CountryId");

                    b.ToTable("city", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BeneficiaryId")
                        .HasColumnType("int")
                        .HasColumnName("beneficiary_id");

                    b.Property<string>("DateOfConclusion")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("date_of_conclusion");

                    b.Property<string>("DateOfExpiration")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("date_of_expiration");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int")
                        .HasColumnName("provider_id");

                    b.HasKey("Id")
                        .HasName("PK__contract__3213E83F65AEF21C");

                    b.HasIndex("BeneficiaryId");

                    b.HasIndex("ProviderId");

                    b.ToTable("contract", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.ContractPlot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ContractId")
                        .HasColumnType("int")
                        .HasColumnName("contract_id");

                    b.Property<int?>("PlotId")
                        .HasColumnType("int")
                        .HasColumnName("plot_id");

                    b.HasKey("Id")
                        .HasName("PK__contract__3213E83F21D8BA34");

                    b.HasIndex("ContractId");

                    b.HasIndex("PlotId");

                    b.ToTable("contract_plot", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK__country__3213E83FE9403171");

                    b.ToTable("country", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.GoodsType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK__goods_ty__3213E83FCF7F9773");

                    b.ToTable("goods_type", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.Ground", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5000)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK__ground__3213E83FFFF90794");

                    b.ToTable("ground", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.IncomeAndExpense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("AmountOfGoods")
                        .HasColumnType("float")
                        .HasColumnName("amount_of_goods");

                    b.Property<double?>("AmountOfPlants")
                        .HasColumnType("float")
                        .HasColumnName("amount_of_plants");

                    b.Property<string>("DateOfPlanting")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("date_of_planting");

                    b.Property<string>("EndDateOfPlanting")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("end_date_of_planting");

                    b.Property<int?>("PlantId")
                        .HasColumnType("int")
                        .HasColumnName("plant_id");

                    b.Property<int?>("PlotId")
                        .HasColumnType("int")
                        .HasColumnName("plot_id");

                    b.Property<double?>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.HasKey("Id")
                        .HasName("PK__income_a__3213E83F01D52852");

                    b.HasIndex("PlantId");

                    b.HasIndex("PlotId");

                    b.ToTable("income_and_expenses", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("AmountOfGoods")
                        .HasColumnType("float")
                        .HasColumnName("amount_of_goods");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int")
                        .HasColumnName("order_status_id");

                    b.Property<int>("PlantId")
                        .HasColumnType("int")
                        .HasColumnName("plant_id");

                    b.HasKey("Id")
                        .HasName("PK__order__3213E83FEB6A7775");

                    b.HasIndex("CustomerId");

                    b.HasIndex("OrderStatusId");

                    b.HasIndex("PlantId");

                    b.ToTable("order", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.OrderStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK__order_st__3213E83F8D778D95");

                    b.ToTable("order_status", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("adress");

                    b.Property<int?>("CityId")
                        .HasColumnType("int")
                        .HasColumnName("city_id");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("full_name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("phone_number");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.HasKey("Id")
                        .HasName("PK__person__3213E83FC6A192CC");

                    b.HasIndex("CityId");

                    b.HasIndex("RoleId");

                    b.ToTable("person", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double?>("AmountOfGoods")
                        .HasColumnType("float")
                        .HasColumnName("amount_of_goods");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5000)")
                        .HasColumnName("description");

                    b.Property<int?>("GoodsTypeId")
                        .HasColumnType("int")
                        .HasColumnName("goods_type_id");

                    b.Property<int?>("ManufacturerId")
                        .HasColumnType("int")
                        .HasColumnName("manufacturer_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("name");

                    b.Property<int?>("PlantTypeId")
                        .HasColumnType("int")
                        .HasColumnName("plant_type_id");

                    b.Property<double?>("Price")
                        .HasColumnType("float")
                        .HasColumnName("price");

                    b.Property<string>("SubspeciesName")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("subspecies_name");

                    b.HasKey("Id")
                        .HasName("PK__plant__3213E83FA4C407E4");

                    b.HasIndex("GoodsTypeId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("PlantTypeId");

                    b.ToTable("plant", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.PlantType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5000)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK__plant_ty__3213E83FD20B8659");

                    b.ToTable("plant_type", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.Plot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Coordinates")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("coordinates");

                    b.Property<string>("Corners")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("corners");

                    b.Property<int?>("GroundId")
                        .HasColumnType("int")
                        .HasColumnName("ground_id");

                    b.Property<string>("Longitudes")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("longitudes");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int")
                        .HasColumnName("owner_id");

                    b.Property<int?>("TerrainId")
                        .HasColumnType("int")
                        .HasColumnName("terrain_id");

                    b.HasKey("Id")
                        .HasName("PK__plot__3213E83F0E997AF4");

                    b.HasIndex("GroundId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("TerrainId");

                    b.ToTable("plot", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5000)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PK__role__3213E83FA722BBF2");

                    b.ToTable("role", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.Terrain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GroundSlope")
                        .HasColumnType("int")
                        .HasColumnName("ground_slope");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.Property<string>("SunPersence")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("sun_persence");

                    b.HasKey("Id")
                        .HasName("PK__terrain__3213E83F7D46155D");

                    b.ToTable("terrain", (string)null);
                });

            modelBuilder.Entity("Agrokultura.Models.ChorePerson", b =>
                {
                    b.HasOne("Agrokultura.Models.Chore", "Chore")
                        .WithMany("ChorePeople")
                        .HasForeignKey("ChoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__chore_per__chore__5812160E");

                    b.HasOne("Agrokultura.Models.OrderStatus", "OrderStatus")
                        .WithMany("ChorePeople")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__chore_per__order__59063A47");

                    b.HasOne("Agrokultura.Models.Person", "Person")
                        .WithMany("ChorePeople")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__chore_per__perso__59FA5E80");

                    b.Navigation("Chore");

                    b.Navigation("OrderStatus");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Agrokultura.Models.City", b =>
                {
                    b.HasOne("Agrokultura.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__city__country_id__5AEE82B9");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Agrokultura.Models.Contract", b =>
                {
                    b.HasOne("Agrokultura.Models.Person", "Beneficiary")
                        .WithMany("ContractBeneficiaries")
                        .HasForeignKey("BeneficiaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__contract__benefi__5BE2A6F2");

                    b.HasOne("Agrokultura.Models.Person", "Provider")
                        .WithMany("ContractProviders")
                        .HasForeignKey("ProviderId")
                        .IsRequired()
                        .HasConstraintName("FK__contract__provid__5CD6CB2B");

                    b.Navigation("Beneficiary");

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("Agrokultura.Models.ContractPlot", b =>
                {
                    b.HasOne("Agrokultura.Models.Contract", "Contract")
                        .WithMany("ContractPlots")
                        .HasForeignKey("ContractId")
                        .HasConstraintName("FK__contract___contr__5DCAEF64");

                    b.HasOne("Agrokultura.Models.Plot", "Plot")
                        .WithMany("ContractPlots")
                        .HasForeignKey("PlotId")
                        .HasConstraintName("FK__contract___plot___5EBF139D");

                    b.Navigation("Contract");

                    b.Navigation("Plot");
                });

            modelBuilder.Entity("Agrokultura.Models.IncomeAndExpense", b =>
                {
                    b.HasOne("Agrokultura.Models.Plant", "Plant")
                        .WithMany("IncomeAndExpenses")
                        .HasForeignKey("PlantId")
                        .HasConstraintName("FK__income_an__plant__5FB337D6");

                    b.HasOne("Agrokultura.Models.Plot", "Plot")
                        .WithMany("IncomeAndExpenses")
                        .HasForeignKey("PlotId")
                        .HasConstraintName("FK__income_an__plot___60A75C0F");

                    b.Navigation("Plant");

                    b.Navigation("Plot");
                });

            modelBuilder.Entity("Agrokultura.Models.Order", b =>
                {
                    b.HasOne("Agrokultura.Models.Person", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__order__customer___619B8048");

                    b.HasOne("Agrokultura.Models.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__order__order_sta__628FA481");

                    b.HasOne("Agrokultura.Models.Plant", "Plant")
                        .WithMany("Orders")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__order__plant_id__6383C8BA");

                    b.Navigation("Customer");

                    b.Navigation("OrderStatus");

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("Agrokultura.Models.Person", b =>
                {
                    b.HasOne("Agrokultura.Models.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId")
                        .HasConstraintName("FK__person__city_id__6477ECF3");

                    b.HasOne("Agrokultura.Models.Role", "Role")
                        .WithMany("People")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK__person__role_id__656C112C");

                    b.Navigation("City");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Agrokultura.Models.Plant", b =>
                {
                    b.HasOne("Agrokultura.Models.GoodsType", "GoodsType")
                        .WithMany("Plants")
                        .HasForeignKey("GoodsTypeId")
                        .HasConstraintName("FK__plant__goods_typ__66603565");

                    b.HasOne("Agrokultura.Models.Person", "Manufacturer")
                        .WithMany("Plants")
                        .HasForeignKey("ManufacturerId")
                        .HasConstraintName("FK__plant__manufactu__6754599E");

                    b.HasOne("Agrokultura.Models.PlantType", "PlantType")
                        .WithMany("Plants")
                        .HasForeignKey("PlantTypeId")
                        .HasConstraintName("FK__plant__plant_typ__68487DD7");

                    b.Navigation("GoodsType");

                    b.Navigation("Manufacturer");

                    b.Navigation("PlantType");
                });

            modelBuilder.Entity("Agrokultura.Models.Plot", b =>
                {
                    b.HasOne("Agrokultura.Models.Ground", "Ground")
                        .WithMany("Plots")
                        .HasForeignKey("GroundId")
                        .HasConstraintName("FK__plot__ground_id__693CA210");

                    b.HasOne("Agrokultura.Models.Person", "Owner")
                        .WithMany("Plots")
                        .HasForeignKey("OwnerId")
                        .HasConstraintName("FK__plot__owner_id__6A30C649");

                    b.HasOne("Agrokultura.Models.Terrain", "Terrain")
                        .WithMany("Plots")
                        .HasForeignKey("TerrainId")
                        .HasConstraintName("FK__plot__terrain_id__6B24EA82");

                    b.Navigation("Ground");

                    b.Navigation("Owner");

                    b.Navigation("Terrain");
                });

            modelBuilder.Entity("Agrokultura.Models.Chore", b =>
                {
                    b.Navigation("ChorePeople");
                });

            modelBuilder.Entity("Agrokultura.Models.City", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("Agrokultura.Models.Contract", b =>
                {
                    b.Navigation("ContractPlots");
                });

            modelBuilder.Entity("Agrokultura.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Agrokultura.Models.GoodsType", b =>
                {
                    b.Navigation("Plants");
                });

            modelBuilder.Entity("Agrokultura.Models.Ground", b =>
                {
                    b.Navigation("Plots");
                });

            modelBuilder.Entity("Agrokultura.Models.OrderStatus", b =>
                {
                    b.Navigation("ChorePeople");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Agrokultura.Models.Person", b =>
                {
                    b.Navigation("ChorePeople");

                    b.Navigation("ContractBeneficiaries");

                    b.Navigation("ContractProviders");

                    b.Navigation("Orders");

                    b.Navigation("Plants");

                    b.Navigation("Plots");
                });

            modelBuilder.Entity("Agrokultura.Models.Plant", b =>
                {
                    b.Navigation("IncomeAndExpenses");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Agrokultura.Models.PlantType", b =>
                {
                    b.Navigation("Plants");
                });

            modelBuilder.Entity("Agrokultura.Models.Plot", b =>
                {
                    b.Navigation("ContractPlots");

                    b.Navigation("IncomeAndExpenses");
                });

            modelBuilder.Entity("Agrokultura.Models.Role", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("Agrokultura.Models.Terrain", b =>
                {
                    b.Navigation("Plots");
                });
#pragma warning restore 612, 618
        }
    }
}
