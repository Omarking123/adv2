//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace adv2
//{
//       class Employee : IComparable
//    {
//        public int Compare(object? x , object? y)
//        {
//            Employee X = (Employee)x;
//            Employee Y = (Employee)y;
//            return X.Name.CompareTo(Y.Name);
//        }
//    }
//    internal class Employee3 : IComparable
//    {
//        public int Id { get; set; }
//        public  string Name { get; set; }
//        public int Age { get; set; }
//        public  double Salary { get; set; }

//        public int CompareTo(object? other)
//        {
//            Employee E = (Employee) other;
//            return this.Age.CompareTo(E.Age);
//        }  
//        public override string ToString()
//        {
//            return $"{Id} {Name} , {Age} {Salary}";
//        }
//    }
//}
