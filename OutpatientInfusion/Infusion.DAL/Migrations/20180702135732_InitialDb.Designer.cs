﻿// <auto-generated />
using System;
using Infusion.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infusion.DAL.Migrations
{
    [DbContext(typeof(EFInfusionDbContext))]
    [Migration("20180702135732_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Infusion.Common.Entities.Dept", b =>
                {
                    b.Property<int>("DeptId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptName");

                    b.Property<string>("DeptNo")
                        .HasColumnType("varchar(64)");

                    b.Property<bool>("IsDel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Memo")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("SpellCode")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<string>("WbCode")
                        .HasColumnType("varchar(32)");

                    b.HasKey("DeptId");

                    b.ToTable("Dept");
                });

            modelBuilder.Entity("Infusion.Common.Entities.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime");

                    b.Property<string>("EmpName")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("EmpNo")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("EmpType")
                        .HasColumnType("char(1)");

                    b.Property<string>("IdNo")
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("IsDel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Memo")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("Sex")
                        .HasColumnType("char(1)");

                    b.Property<string>("SpellCode")
                        .HasColumnType("varchar(16)");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<string>("WbCode")
                        .HasColumnType("varchar(16)");

                    b.HasKey("EmpId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Infusion.Common.Entities.InfusionBadnessEvent", b =>
                {
                    b.Property<int>("BnId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InfusionId")
                        .HasColumnType("int");

                    b.Property<string>("Memo")
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<string>("RecorderId")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("RecorderName")
                        .HasColumnType("varchar(32)");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DATETIME")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("VARCHAR(32)");

                    b.HasKey("BnId");

                    b.ToTable("InfusionBadnessEvent");
                });

            modelBuilder.Entity("Infusion.Common.Entities.InfusionDept", b =>
                {
                    b.Property<int>("RdId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DeptName")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("DeptNo")
                        .HasColumnType("varchar(32)");

                    b.Property<bool>("IsDel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Memo")
                        .HasColumnType("varchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.HasKey("RdId");

                    b.HasIndex("RoomId");

                    b.ToTable("InfusionDept");
                });

            modelBuilder.Entity("Infusion.Common.Entities.InfusionPatient", b =>
                {
                    b.Property<int>("InfusionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime?>("AuditTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Auditor")
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("CancelTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Canceler")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("CardNo")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("ChartNo")
                        .HasColumnType("varchar(16)");

                    b.Property<DateTime?>("CheckInTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Checkiner")
                        .HasColumnType("varchar(64)");

                    b.Property<bool?>("Child")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ConfigTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Configer")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("DeptNo")
                        .HasColumnType("varchar(16)");

                    b.Property<bool?>("DischargeMedication")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<bool?>("Emg")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Ender")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("MedUsageNo")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Memo")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("PrescriptionNo")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("PtName")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("QueueNo")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("Receipt")
                        .HasColumnType("varchar(64)");

                    b.Property<int?>("RoomId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("SeatId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .HasColumnType("char(1)");

                    b.Property<bool?>("SpecialDrug")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Starter")
                        .HasColumnType("varchar(64)");

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.Property<string>("VisitNo")
                        .HasColumnType("varchar(16)");

                    b.HasKey("InfusionId");

                    b.ToTable("InfusionPatient");
                });

            modelBuilder.Entity("Infusion.Common.Entities.InfusionPnDetail", b =>
                {
                    b.Property<int>("IpdId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Advise")
                        .HasColumnType("varchar(32)");

                    b.Property<int?>("ChargeNo")
                        .HasColumnType("int");

                    b.Property<string>("DoctorNo")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("DrugCode")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<string>("DrugDepartmentName")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<int>("DrugDose")
                        .HasColumnType("int");

                    b.Property<string>("DrugDoseUnit")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("DrugName")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<int>("DrugNum")
                        .HasColumnType("int");

                    b.Property<string>("DrugStandard")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<int?>("ExecQty")
                        .HasColumnType("int");

                    b.Property<string>("FrequencyNo")
                        .HasColumnType("varchar(32)");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int?>("InfusionId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsCharge")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSkinTest")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("KeepTime")
                        .HasColumnType("datetime");

                    b.Property<string>("Memo")
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime?>("PrescriptionDate")
                        .HasColumnType("datetime");

                    b.Property<string>("PrescriptionNo")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<int>("RecordStatus")
                        .HasColumnType("int");

                    b.Property<string>("SeqNo")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<string>("SkinTestResult")
                        .HasColumnType("varchar(128)");

                    b.Property<int?>("TotComposeQty")
                        .HasColumnType("int");

                    b.Property<int?>("TotQty")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser");

                    b.Property<string>("UsageNo")
                        .HasColumnType("varchar(32)");

                    b.HasKey("IpdId");

                    b.ToTable("InfusionPnDetail");
                });

            modelBuilder.Entity("Infusion.Common.Entities.InfusionPrintSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Memo")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("PrintSetCode")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<string>("PrintSetName")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.HasKey("Id");

                    b.ToTable("InfusionPrintSet");
                });

            modelBuilder.Entity("Infusion.Common.Entities.InfusionRoom", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Memo")
                        .HasColumnType("varchar(max)");

                    b.Property<bool?>("Mode")
                        .HasColumnType("bit");

                    b.Property<decimal?>("PrescriptionDays")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("RoomCode")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("RoomName")
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.HasKey("RoomId");

                    b.ToTable("InfusionRoom");
                });

            modelBuilder.Entity("Infusion.Common.Entities.InfusionSeat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("Child")
                        .HasColumnType("smallint");

                    b.Property<int?>("InfusionId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDel");

                    b.Property<string>("Memo")
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<short?>("Plus")
                        .HasColumnType("smallint");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.Property<short?>("Special")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("VARCHAR(32)");

                    b.Property<short?>("Used")
                        .HasColumnType("smallint");

                    b.Property<short?>("Valid")
                        .HasColumnType("smallint");

                    b.HasKey("SeatId");

                    b.ToTable("InfusionSeat");
                });

            modelBuilder.Entity("Infusion.Common.Entities.InfusionSpecialDrug", b =>
                {
                    b.Property<int>("IsdId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("DrugCode")
                        .HasColumnType("varchar(16)");

                    b.Property<string>("DrugName")
                        .HasColumnType("varchar(64)");

                    b.Property<string>("DrugSpec")
                        .HasColumnType("varchar(64)");

                    b.Property<bool>("IsDel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Memo")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("OriginPlace")
                        .HasColumnType("varchar(64)");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.HasKey("IsdId");

                    b.ToTable("InfusionSpecialDrug");
                });

            modelBuilder.Entity("Infusion.Common.Entities.InfusionUsage", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Memo")
                        .HasColumnType("varchar(max)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.Property<string>("UsageName")
                        .HasColumnType("varchar(32)");

                    b.Property<string>("UsageNo")
                        .HasColumnType("varchar(16)");

                    b.HasKey("ItemId");

                    b.HasIndex("RoomId");

                    b.ToTable("InfusionUsage");
                });

            modelBuilder.Entity("Infusion.Common.Entities.Pharmacy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Isdel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Memo")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("PharmacyCode")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<string>("PharmacyName")
                        .IsRequired()
                        .HasColumnType("varchar(64)");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasColumnType("varchar(32)");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Pharmacy");
                });

            modelBuilder.Entity("Infusion.Common.Entities.InfusionDept", b =>
                {
                    b.HasOne("Infusion.Common.Entities.InfusionRoom", "InfusionRoom")
                        .WithMany("InfusionDepts")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infusion.Common.Entities.InfusionUsage", b =>
                {
                    b.HasOne("Infusion.Common.Entities.InfusionRoom", "InfusionRoom")
                        .WithMany("InfusionUsages")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Infusion.Common.Entities.Pharmacy", b =>
                {
                    b.HasOne("Infusion.Common.Entities.InfusionRoom", "InfusionRoom")
                        .WithMany("Pharmacys")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
