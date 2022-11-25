using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineLearningLibrary.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    deptid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "201, 3"),
                    deptname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.deptid);
                });

            migrationBuilder.CreateTable(
                name: "instructors",
                columns: table => new
                {
                    instructorid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "2001, 3"),
                    fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    yrsOfExp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructors", x => x.instructorid);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "12, 2"),
                    fname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    phno = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.studentid);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    courseid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "10000, 3"),
                    coursename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    departmentdeptid = table.Column<int>(type: "int", nullable: false),
                    deptid = table.Column<int>(type: "int", nullable: false),
                    instructorid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.courseid);
                    table.ForeignKey(
                        name: "FK_Courses_departments_departmentdeptid",
                        column: x => x.departmentdeptid,
                        principalTable: "departments",
                        principalColumn: "deptid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_instructors_instructorid",
                        column: x => x.instructorid,
                        principalTable: "instructors",
                        principalColumn: "instructorid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookedcourses",
                columns: table => new
                {
                    bookingid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "3000, 1"),
                    dateofEnroll = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateofexp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    coursescourseid = table.Column<int>(type: "int", nullable: false),
                    courseid = table.Column<int>(type: "int", nullable: false),
                    studentsstudentid = table.Column<int>(type: "int", nullable: false),
                    stuid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookedcourses", x => x.bookingid);
                    table.ForeignKey(
                        name: "FK_Bookedcourses_Courses_coursescourseid",
                        column: x => x.coursescourseid,
                        principalTable: "Courses",
                        principalColumn: "courseid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookedcourses_Students_studentsstudentid",
                        column: x => x.studentsstudentid,
                        principalTable: "Students",
                        principalColumn: "studentid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookedcourses_coursescourseid",
                table: "Bookedcourses",
                column: "coursescourseid");

            migrationBuilder.CreateIndex(
                name: "IX_Bookedcourses_studentsstudentid",
                table: "Bookedcourses",
                column: "studentsstudentid");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_departmentdeptid",
                table: "Courses",
                column: "departmentdeptid");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_instructorid",
                table: "Courses",
                column: "instructorid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookedcourses");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "instructors");
        }
    }
}
