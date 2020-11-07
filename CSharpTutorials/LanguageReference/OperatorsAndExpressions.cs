using System;

namespace CSharpTutorials.LanguageReference
{
    /// <summary>
    /// C# 提供了许多运算符。 其中许多都受到内置类型的支持，可用于对这些类型的值执行基本操作。 这些运算符包括以下组：
    /// 算术运算符，将对数值操作数执行算术运算
    /// 比较运算符，将比较数值操作数
    /// 布尔逻辑运算符，将对 bool 操作数执行逻辑运算
    /// 位运算符和移位运算符，将对整数类型的操作数执行位运算或移位运算
    /// 相等运算符，将检查其操作数是否相等
    /// 通常可以重载这些运算符，也就是说，可以为用户定义类型的操作数指定运算符行为。
    /// </summary>
    public class OperatorsAndExpressions
    {
        #region 算数运算符

        public void Arithmetic()
        {
            int ia = 0, ib = 0, ic = 0;
            double  dc = 0f;

            ia++;//先使用ia再+1
            ++ia;//先+1再使用
            ib--;//同上
            --ib;
            ic = +ic;//原来的值
            ic = -ic;//相反数
            ic = ia * ib;//+，-，*，一致
            ic *= ia;//equals to ic=ic*ia. +，-，*，一致
            ic = ia / ib;//整除，四舍五入
            dc = (double)ia / ib;//输出小数
            dc = ib / dc;//输出小数
            ic = ia % ib;//equals to "a-(a-b)*b" 取余数,非0余数的符号与左侧操作数符号相同
            //下面表中展示了隐式转换的类型
            //sbyte	  short、int、long、float、double 或 decimal
            //byte    short、ushort、int、uint、long、ulong、float、double 或 decimal
            //short   int、long、float、double 或 decimal
            //ushort  int、uint、long、ulong、float、double 或 decimal。
            //int     long、float、double 或 decimal
            //uint    long、ulong、float、double 或 decimal
            //long    float、double 或 decimal
            //ulong   float、double 或 decimal
            //float   double

            //运算优先级
            //以下列表对优先级由高到低的顺序对算术运算符进行排序：
            //  后缀增量 x++和减量 x-- 运算符
            //  前缀增量 ++x 和减量--x 以及一元 +和 - 运算符
            //  乘法 *、/ 和 % 运算符
            //  加法 + 和 - 运算符
            //二元算数运算符是左结合运算符。
            //也就是说，具有相同优先级的运算符按从左至右的顺序计算。
            //使用括号() 更改由运算符优先级和关联性决定的计算顺序。

            //整数被零除引发 DivideByZeroException。

            //在使用已检查和未检查的语句时，可以使用 checked 和 unchecked 运算符来控制溢出检查上下文，
            //在该上下文中将计算一个表达式：
            //使用 float 和 double 类型的算术运算永远不会引发异常。
            //使用这些类型的算术运算的结果可能是表示无穷大和非数字的特殊值之一：
            int am = int.MaxValue;
            int b3 = 3;

            Console.WriteLine(unchecked(am + b3));  // output: -2147483646
            try
            {
                int dcheck = checked(am + b3);
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Overflow occurred when adding {am} to {b3}.");
            }

            //重点注意！！！！！！！
            //重点注意！！！！！！！
            //重点注意！！！！！！！
            //由于实数和浮点运算的浮点表达形式的常规限制，
            //在使用浮点类型的计算中可能会发生舍入误差。
            //也就是说，表达式得出的结果可能与预期的数学运算结果不同。
            //以下示例演示了几种此类情况：
            Console.WriteLine(.41f % .2f); // output: 0.00999999

            double ad = 0.1;
            double bd = 3 * ad;
            Console.WriteLine(bd == 0.3);   // output: False
            Console.WriteLine(bd - 0.3);    // output: 5.55111512312578E-17

            decimal c = 1 / 3.0m;
            decimal d = 3 * c;
            Console.WriteLine(d == 1.0m);  // output: False
            Console.WriteLine(d);          // output: 0.9999999999999999999999999999
        }

        #endregion
    }
}