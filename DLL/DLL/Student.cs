using System;

namespace DLL
{
    class Student : IComparable
    {
        private string name;
        private int id;

        public Student()
        {

        }

        public Student(String name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public int ID
        {
            set
            {
                id = value;
            }

            get
            {
                return id;
            }
        }

        public String Name
        {
            set
            {
                name = value;
            }

            get
            {
                return name;
            }
        }

        
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Student other = obj as Student;
            if (other != null)
                return this.id.CompareTo(other.id);
            else
                throw new ArgumentException("Object is not an ID");
        }
    }
}