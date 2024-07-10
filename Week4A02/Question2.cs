// Question #2:
// You have been assigned to create a student management system for a small university. This university
// only has 10 students (for now😊). We need to store the following information, with the specified
// datatypes, related to a single student
// 1. Roll No (int)
// 2. Name (string)
// 3. CGPA (float)
// 4. Fee Submitted (bool)
// The program should run like this

using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Week4A02
{
    class Question2
    {
        static Student[] students = new Student[10];
        static int studentcount = 0;

        class Student
        {
            public int id { get; set; }
            public string name { get; set; }
            public float cgpa { get; set; }
            public bool feesubmitted { get; set; }

            public void addStudent(int id, string name, float cgpa, bool feesubmitted)
            {
                this.id = id;
                this.name = name;
                this.cgpa = cgpa;
                this.feesubmitted = feesubmitted;
            }
            public void PrintStudentDetails()
            {
                char check = 'y';

                if (feesubmitted)
                {
                    check = 'y';
                }
                else
                {

                    check = 'n';
                }
                Console.WriteLine("{0} \t {1} \t {2} \t {3}", id, name, cgpa, check);

            }
        }

        static void AddStudent()
        {
            char feestatus;
            Student student = new Student();
            Console.Write("Roll No: ");
            student.id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            student.name = Console.ReadLine();
            Console.Write("CGPA: ");
            student.cgpa = float.Parse(Console.ReadLine());
            Console.Write("Fees Submitted: ");
            feestatus = Convert.ToChar(Console.ReadLine());
            do
            {
                switch (Char.ToLower(feestatus))
                {
                    case 'y':
                        student.feesubmitted = true;
                        break;
                    case 'n':
                        student.feesubmitted = false;
                        break;
                    default:
                        Console.WriteLine("Enter valid input! Press y for Yes and n for No");
                        Console.Write("Fees Submitted: ");
                        feestatus = Convert.ToChar(Console.ReadLine());
                        break;

                }
            } while (feestatus != 'y' && feestatus != 'n');
            Console.WriteLine("Record Added!");
            if (studentcount <= 10)
            {
                students[studentcount] = student;
                studentcount++;
            }
            else
            {
                Console.WriteLine("Student Record less than 10");
            }

        }

        static void SearchStudent()
        {
            int rollno = 0;
            bool search = false;
            Console.WriteLine("-----Searching Record------");
            Console.Write("Enter Roll #: ");
            rollno = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentcount; i++)
            {
                if (students[i].id == rollno)
                {
                    Console.WriteLine("-----Record Found!-----");
                    students[i].PrintStudentDetails();
                    search = true;
                    break;
                }

            }
            if (search == false)
            {
                Console.WriteLine("------No Record Found-----");
            }


        }



        static void DeleteStudent()
        {
            int rollno;
            Console.WriteLine("-----Deleting Record------");
            Console.Write("Enter Roll #: ");
            rollno = int.Parse(Console.ReadLine());
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].id == rollno)
                {
                    Console.WriteLine("-----Record Found!-----");
                    int index = Array.IndexOf(students, students[i]);
                    Console.WriteLine("This", index);
                    break;
                }
                else
                {
                    Console.WriteLine("-----No Record Found!------");
                    break;

                }

            }
        }

        static void UpdateStudent()
        {
            char updatefeestatus;
            int rollno;
            Console.WriteLine("-----Updating Record------");
            Console.Write("Enter Roll #: ");
            rollno = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentcount; i++)
            {
                if (students[i].id == rollno)
                {
                    Console.WriteLine("-----Record Found!-----");
                    Console.Write("Roll No: ");
                    students[i].id = int.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    students[i].name = Console.ReadLine();
                    Console.Write("CGPA: ");
                    students[i].cgpa = float.Parse(Console.ReadLine());
                    Console.Write("Fees Submitted: ");
                    updatefeestatus = Convert.ToChar(Console.ReadLine());
                    do
                    {
                        switch (Char.ToLower(updatefeestatus))
                        {
                            case 'y':
                                students[i].feesubmitted = true;
                                break;
                            case 'n':
                                students[i].feesubmitted = false;
                                break;
                            default:
                                Console.WriteLine("Enter valid input! Press y for Yes and n for No");
                                Console.Write("Fees Submitted: ");
                                updatefeestatus = Convert.ToChar(Console.ReadLine());
                                break;

                        }
                    } while (updatefeestatus != 'y' && updatefeestatus != 'n');
                    Console.WriteLine("------Record Updated!-----");
                    break;
                }
                else
                {
                    Console.WriteLine("-----No Record Found!------");
                    break;

                }

            }
        }

        static void PrintStudentList()
        {
            Console.WriteLine("-----Student List--------");
            Console.WriteLine("Roll # \t Name \t CGPA \t Fee Submitted");
            for (int i = 0; i < studentcount; i++)
            {
                students[i].PrintStudentDetails();
            }
        }

        static void Main(string[] args)
        {

            int input = 0;

            Console.WriteLine("Welcome to Student Management System....");
            do
            {
                Console.WriteLine("Select the corresponding menu option to proceed:");
                Console.WriteLine(" 1. Add New Student \n 2. Search Student by Roll # \n 3. Delete Student by Roll # \n 4. Update Student by Roll # \n 5. Print Student List \n 6. Exit Program");

                Console.Write("Menu option> ");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {

                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        SearchStudent();

                        break;
                    case 3:
                        DeleteStudent();
                        break;
                    case 4:
                        UpdateStudent();
                        break;
                    case 5:
                        PrintStudentList();
                        break;
                    case 6:
                        Console.WriteLine("Good Bye");
                        break;
                    default:
                        Console.WriteLine("Input Wrong: Please Enter right input");
                        break;

                }
            } while (input != 6);


        }



    }
}