using System;
using System.Collections.Generic;

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
            double dc = 0f;

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

        #region 布尔逻辑运算符

        //一元 !（逻辑非）运算符。
        public void Unary()
        {
            const bool passed = false;
            Console.WriteLine(!passed);  // output: True
            Console.WriteLine(!true);    // output: False
        }
        //二元 &（逻辑与）、|（逻辑或）和 ^（逻辑异或）运算符。 这些运算符 !!始终计算!! 两个操作数。
        public void Binary()
        {
            Console.WriteLine(true & true);    // output: True
            Console.WriteLine(true & false);   // output: False
            Console.WriteLine(false & true);   // output: False
            Console.WriteLine(false & false);  // output: False

            Console.WriteLine(true ^ true);    // output: False
            Console.WriteLine(true ^ false);   // output: True
            Console.WriteLine(false ^ true);   // output: True
            Console.WriteLine(false ^ false);  // output: False

            Console.WriteLine(true | true);    // output: True
            Console.WriteLine(true | false);   // output: True
            Console.WriteLine(false | true);   // output: True
            Console.WriteLine(false | false);  // output: False

        }
        //二元 &&（条件逻辑与）和 ||（条件逻辑或）运算符。 这些运算符 !!仅在必要时!! 才计算右侧操作数。
        public void Binary2()
        {
            Console.WriteLine(true && true);    // output: True
            Console.WriteLine(true && false);   // output: False
            Console.WriteLine(false && true);   // output: False
            Console.WriteLine(false && false);  // output: False

            Console.WriteLine(true || true);    // output: True
            Console.WriteLine(true || false);   // output: True
            Console.WriteLine(false || true);   // output: True
            Console.WriteLine(false || false);  // output: False

        }
        #endregion

        #region 位运算符和移位运算符

        //一元 ~（按位求补）运算符
        public void UnaryOperator()
        {
            const uint bitwiseComplementBefore = 0b_0000_1111_0000_1111_0000_1111_0000_1100;
            const uint bitwiseComplement = ~bitwiseComplementBefore;
            Console.WriteLine(Convert.ToString(bitwiseComplement, toBase: 2));
            // Output:
            // 11110000111100001111000011110011

        }
        //二进制 <<（向左移位）和 >>（向右移位）移位运算符
        public void BinaryShiftOperators()
        {
            const uint leftShiftBefore = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
            Console.WriteLine($"Before: {Convert.ToString(leftShiftBefore, toBase: 2)}");

            const uint leftShift = leftShiftBefore << 4;
            Console.WriteLine($"After:  {Convert.ToString(leftShift, toBase: 2)}");
            // Output:
            // Before: 11001001000000000000000000010001
            // After:  10010000000000000000000100010000

            const uint rightShiftBefore = 0b_1001;
            Console.WriteLine($"Before: {Convert.ToString(rightShiftBefore, toBase: 2),4}");

            const uint rightShift = rightShiftBefore >> 2;
            Console.WriteLine($"After:  {Convert.ToString(rightShift, toBase: 2),4}");
            // Output:
            // Before: 1001
            // After:    10
        }
        //二进制 &（逻辑 AND）、|（逻辑 OR）和 ^（逻辑异或）运算符
        public void BinaryOperators()
        {
            //逻辑与运算符 &
            const uint logicalAndA = 0b_1111_1000;
            const uint logicalAndB = 0b_1001_1101;
            const uint logicalAndC = logicalAndA & logicalAndB;
            Console.WriteLine(Convert.ToString(logicalAndC, toBase: 2));
            // Output:
            // 10011000

            //逻辑异或运算符 ^
            const uint logicalOrA = 0b_1010_0000;
            const uint logicalOrB = 0b_1001_0001;
            const uint logicalOrC = logicalOrA | logicalOrB;
            Console.WriteLine(Convert.ToString(logicalOrC, toBase: 2));
            // Output:
            // 10110001

            //逻辑或运算符 |
            const uint logicalExclusiveOrA = 0b_1111_1000;
            const uint logicalExclusiveOrB = 0b_0001_1100;
            const uint logicalExclusiveOrC = logicalExclusiveOrA ^ logicalExclusiveOrB;
            Console.WriteLine(Convert.ToString(logicalExclusiveOrC, toBase: 2));
            // Output:
            // 11100100
        }

        public void CompoundAssignment()
        {
            uint a = 0b_1111_1000;
            a &= 0b_1001_1101;
            Display(a);  // output: 10011000

            a |= 0b_0011_0001;
            Display(a);  // output: 10111001

            a ^= 0b_1000_0000;
            Display(a);  // output:   111001

            a <<= 2;
            Display(a);  // output: 11100100

            a >>= 4;
            Display(a);  // output:     1110

            void Display(uint x) => Console.WriteLine($"{Convert.ToString(x, toBase: 2),8}");

        }
        #endregion

        #region 相等运算符
        public void Equal()
        {
            //值类型的相等性
            int a = 1 + 2 + 3;
            int b = 6;
            Console.WriteLine(a == b);  // output: True

            char c1 = 'a';
            char c2 = 'A';
            Console.WriteLine(c1 == c2);  // output: False
            Console.WriteLine(c1 == char.ToLower(c2));  // output: True

            //引用类型的相等性

            var ac = new MyClass(1);
            var bc = new MyClass(1);
            var cc = ac;
            Console.WriteLine(ac == bc);  // output: False
            Console.WriteLine(ac == cc);  // output: True

            //记录类型相等性

            //字符串相等性
            string s1 = "hello!";
            string s2 = "HeLLo!";
            Console.WriteLine(s1 == s2.ToLower());  // output: True

            string s3 = "Hello!";
            Console.WriteLine(s1 == s3);  // output: False

            //委托相等
            Action da = () => Console.WriteLine("da");

            Action db = da + da;
            Action dc = da + da;
            Console.WriteLine(object.ReferenceEquals(db, dc));  // output: False
            Console.WriteLine(db == dc);  // output: True

            Action da2 = () => Console.WriteLine("da2");
            Action db2 = () => Console.WriteLine("da2");
            //通过计算语义上相同的 Lambda 表达式生成的委托不相等
            Console.WriteLine(da2 == db2);  // output: False
            Console.WriteLine(da2 + db2 == da2 + db2);  // output: True
            Console.WriteLine(db2 + da2 == da2 + db2);  // output: False

        }

        //不等运算符 !=
        public void NotEqual()
        {
            //值
            int a = 1 + 1 + 2 + 3;
            int b = 6;
            Console.WriteLine(a != b);  // output: True

            string s1 = "Hello";
            string s2 = "Hello";
            Console.WriteLine(s1 != s2);  // output: False

            //对象
            object o1 = 1;
            object o2 = 1;
            Console.WriteLine(o1 != o2);  // output: True
        }
        public class MyClass
        {
            private int id;

            public MyClass(int id) => this.id = id;
        }


        #endregion

        #region 比较运算符

        

        #endregion
    }
}