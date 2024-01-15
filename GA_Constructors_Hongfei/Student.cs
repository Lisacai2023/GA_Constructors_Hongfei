using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Constructors_Hongfei
{
    public class Student
    {
        //Create field in Student class
        string _name;
        int _studentID;
        int _grade;

        //Create Constructiors with parameters
        public Student(string name, int studentID, int grade) 
        {
            this._name = name;
            this._studentID = studentID;
            this._grade = grade;
        }

        //Overloading Constructors
        public Student(string name, int studentID)
        {
            this._name = name;
            this._studentID = studentID;
            this._grade = 3;
        }

        //Properties for name, studentID, grade
        public string Name
        {
            get { return _name; }
            set { _name =value; }
        }
        public int StudentID
        {
            get { return _studentID; }
            set { _studentID = value; }
        }

        public int Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }


    }
}
