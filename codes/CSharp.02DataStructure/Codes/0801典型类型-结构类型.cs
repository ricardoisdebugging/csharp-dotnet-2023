using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._02DataStructure.Codes
{
    struct Angle1
    {
        //Error: Backing field for automatically implemented property
        //'name' must be fully assigned before control is returned to the caller.
        //public Angle1()
        //{
            
        //}

        int _degree;
    }

    struct Angle2
    {
        //...
        //Error: Field cannot be initialized at the declaration time &&
        //A 'struct' with field initializers must include an explicitly declared constructor.
        //int _Degrees = 42;
        //...
    }

    struct Angle3
    {
        public Angle3(int degree)
        {
            Degree = degree;
        }
        int _degree;
        public int Degree
        { 
            get => _degree; 
            set => _degree = value;
        }

        //public Angle3(int degree)
        //{
        //    Degree = degree;
        //}
        //public int Degree { get; set; }

        //public Angle3(int degree)
        //{
        //    _degree = degree;
        //}
        //int _degree;
        //public int Degree { get { return _degree; } }
    }
}
