using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._02DataStructure.Codes
{
    public interface IAngle
    {
        void MoveTo(int degree, int minutes, int seconds);
    }

    public struct Angle : IAngle
    {
        public int degree;
        //使得Angle类型可变，违反了编程指南
        public void MoveTo(int degree, int minutes, int seconds)
        {
            degree = degree;
        }
    }

    public class Program
    {
        static void Main()
        {
            var angle = new Angle();
            angle.degree = 25;
            Console.WriteLine(angle.degree); //result is 25

            //场景1
            //装箱, 复制了值对象的数据到堆上的内存地址
            object objAngle = angle;
            Console.WriteLine(((Angle)objAngle).degree); //result is 25

            //场景2
            //拆箱，修正了拆箱的值，但是传递给临时存储位置
            ((Angle)objAngle).MoveTo(26, 0, 0);
            Console.WriteLine(((Angle)objAngle).degree); //result is 25

            //场景3
            //装箱，修正了装箱的值，但是传递给引用位置
            ((IAngle)angle).MoveTo(26, 0, 0);
            Console.WriteLine(((Angle)angle).degree); //result is 25

            //场景4
            //引用变化，修正了引用指向的值
            ((IAngle)objAngle).MoveTo(26, 0, 0);
            Console.WriteLine(((Angle)objAngle).degree); //result is 26
        }
    }
}
