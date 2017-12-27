using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //【3】创建委托对象，关联“具体方法”
            CalculatorDelegate objCal = new CalculatorDelegate(Add);
            //【4】通过委托调用方法，而不是直接使用方法
            int result = objCal(8, 23);
            Console.WriteLine("8+23={0}", result);

            objCal -= Add;//断开当前委托对象所关联的方法
            objCal += Sub;//重新指向一个新的方法

            result = objCal(8, 23);
            Console.WriteLine("8-23={0}", result);
            Console.ReadLine();
        }

        //【2】根据委托定义一个“具体方法”实现加法功能
        static int Add(int a,int b)
        {
            return a + b;
        }
        // 【2】根据委托定义一个“具体方法”实现减法功能
        static int Sub(int a, int b)
        {
            return a - b;
        }

    }

    //【1】声明委托（定义一个函数原型：返回值+参数类型和个数）
    public delegate int CalculatorDelegate(int a, int b);
}
