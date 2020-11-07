using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CSharpTutorials.LanguageReference
{
    /// <summary>
    /// 关键字是预定义的保留标识符，对编译器有特殊意义。
    /// 除非前面有 @ 前缀，否则不能在程序中用作标识符。
    /// 例如，@if 是有效标识符，而 if 则不是，因为 if 是关键字。
    /// </summary>
    public class KeyWord
    {
        #region 修饰符

        //修饰符是面向 方法/类 的关键字，指示谁可以修改类型和类型成员。修饰符允许或阻止程序的某些部分被其他部分修改。
        //abstract    抽象 抽象方法就是没有实现的，抽象类不能被实例化，只能被继承。
        //async       异步 使用async修饰符可指定方法，lambda表达式或匿名方法是异步的     
        //const       常量 使用 const 关键字来声明某个常量字段或常量局部变量。常量字段和常量局部变量不是变量并且不能修改。
        //event       事件 event 关键字用于声明发布服务器类中的事件。
        //extern      外部 extern 修饰符用于声明在外部实现的方法。 通常与 DllImport 特性一起使用
        //new         新建 在用作声明修饰符时，new 关键字可以显式隐藏从基类继承的成员。 隐藏继承的成员时，该成员的派生版本将替换基类版本。  
        //override    重写 扩展或修改继承的方法、属性、索引器或事件的抽象或虚拟实现需要 override 修饰符。
        //partial     部分 多个类由位于不同位置，可能是不同人负责同一个类的不同部分
        //readonly    只读 在字段声明中，readonly 指示只能在声明期间或在同一个类的构造函数中向字段赋值。
        //sealed      密封 应用于某个类时，sealed 修饰符可阻止其他类继承自该类。
        //static      静态 使用 static 修饰符可声明属于类型本身而不是属于特定对象的静态成员。即没有实例状态
        //unsafe      不安全 unsafe 关键字表示不安全上下文，该上下文是任何涉及指针的操作所必需的。
        //virtual     虚拟 只用于方法，告诉子类，此方法可以被override，但非强制
        //volatile    异变 volatile 关键字指示一个字段可以由多个同时执行的线程修改。 

        //访问修饰符
        //public      Public修饰符允许同一程序集或另一个程序集中的程序的任何部分访问类型及其成员。
        //private     Private修饰符可限制程序的其他部分访问类型及其成员。只有相同类或结构中的代码才能访问它。
        //internal    internal修饰符允许同一程序集中的其他程序代码访问类型或其成员。如果未指定修饰符，则这是默认的访问修饰符。
        //protected   Protected修饰符允许同一类或从该类派生的类中的代码访问该类型或其成员。

        #endregion

        #region 语句关键字

        //选择语句
        //if
        //else
        //switch
        //case
        //迭代语句
        //do
        //for
        //foreach
        //in
        //while
        //跳转语句
        //break
        //continue
        //default
        //goto
        //return
        //yield
        //异常处理语句
        //throw
        //try
        //catch
        //finally
        //其他
        //checked     checked 关键字用于对整型类型算术运算和转换显式启用溢出检查。
        //unchecked   unchecked 关键字用于取消整型类型的算术运算和转换的溢出检查。溢出部分如果删除 unchecked 环境，会发生编译错误
        //fixed       fixed 语句可防止垃圾回收器重新定位可移动的变量。 fixed 语句仅允许存在于不安全的上下文中。
        //lock        lock 语句获取给定对象的互斥lock，执行语句块，然后释放lock。持有lock时，持有lock的线程可以再次获取并释放lock。阻止任何其他线程获取 lock 并等待释放 lock。

        #endregion

        #region 方法参数

        //params      使用 params 关键字可以指定采用数目可变的参数的方法参数。 参数类型必须是一维数组。
        //ref         ref 关键字指示按引用传递的值。在方法的参数列表中使用 ref 关键字时，它指示参数按引用传递，而非按值传递。
        //in|out      in 关键字通过引用传递参数。 它让形参成为实参的别名，这必须是变量。 换而言之，对形参执行的任何操作都是对实参执行的。
        //            out类似于 in 关键字，只不过 in 不允许通过调用方法来修改参数值。
        //            传递到 ref 或 in 形参的实参必须先经过初始化，然后才能传递。 这与 out 形参不同，在传递之前，不需要显式初始化该形参的实参。

        #endregion

        #region 命名空间关键字

        //using         
        //. operator    
        //:: operator   
        //extern alias  有时你可能不得不引用具有相同的完全限定类型名称的程序集的两个版本。
        //              例如，可能需要在同一应用程序中使用某程序集的两个或多个版本。
        //              在 Visual Studio 中向项目添加 grid.dll 和 grid20.dll 的引用。
        //              打开“属性”选项卡，并将别名从“全局”分别更改为“GridV1”和“GridV2”。
        //              extern alias GridV1;  
        //              extern alias GridV2;
        //              using Class1V1 = GridV1::Namespace.Class1;
        //              using Class1V2 = GridV2::Namespace.Class1;

        #endregion

        #region 类型测试关键字

        //is            is 运算符检查表达式的结果是否与给定类型兼容，
        //例子
        private static readonly int[] TestSet = { 100271, 234335, 342439, 999683 };
        private readonly IEnumerable<int> _primes = TestSet.Where(n => Factor(n).ToList() is var factors
                                                                       && factors.Count == 2
                                                                       && factors.Contains(1)
                                                                       && factors.Contains(n));

        private static IEnumerable<int> Factor(int number)
        {
            var max = (int)Math.Sqrt(number);
            for (var i = 1; i <= max; i++)
            {
                if (number % i != 0) continue;
                yield return i;
                if (i != number / i)
                {
                    yield return number / i;
                }
            }
        }

        #endregion

        #region 泛型类型关键字

        //where         约束告知编译器类型参数必须具备的功能。 在没有任何约束的情况下，类型参数可以是任何类型。
        //where T : struct 类型参数必须是不可为 null 的值类型。 有关可为 null 的值类型的信息，请参阅可为 null 的值类型。 由于所有值类型都具有可访问的无参数构造函数，因此 struct 约束表示 new() 约束，并且不能与 new() 约束结合使用。 struct 约束也不能与 unmanaged 约束结合使用。
        //where T : class 类型参数必须是引用类型。 此约束还应用于任何类、接口、委托或数组类型。 在 C#8.0 或更高版本中的可为 null 上下文中，T 必须是不可为 null 的引用类型。
        //where T : class?	类型参数必须是可为 null 或不可为 null 的引用类型。 此约束还应用于任何类、接口、委托或数组类型。
        //where T : notnull 类型参数必须是不可为 null 的类型。 参数可以是 C# 8.0 或更高版本中的不可为 null 的引用类型，也可以是不可为 null 的值类型。
        //where T : unmanaged 类型参数必须是不可为 null 的非托管类型。 unmanaged 约束表示 struct 约束，且不能与 struct 约束或 new() 约束结合使用。
        //where T : new() 类型参数必须具有公共无参数构造函数。 与其他约束一起使用时，new() 约束必须最后指定。 new() 约束不能与 struct 和 unmanaged 约束结合使用。
        //where T : <base class name>	类型参数必须是指定的基类或派生自指定的基类。 在 C# 8.0 及更高版本中的可为 null 上下文中，T 必须是从指定基类派生的不可为 null 的引用类型。
        //where T : <base class name>?	类型参数必须是指定的基类或派生自指定的基类。 在 C# 8.0 及更高版本中的可为 null 上下文中，T 可以是从指定基类派生的可为 null 或不可为 null 的类型。
        //where T : <interface name>	类型参数必须是指定的接口或实现指定的接口。 可指定多个接口约束。 约束接口也可以是泛型。 在 C# 8.0 及更高版本中的可为 null 上下文中，T 必须是实现指定接口的不可为 null 的类型。
        //where T : <interface name>?	类型参数必须是指定的接口或实现指定的接口。 可指定多个接口约束。 约束接口也可以是泛型。 在 C# 8.0 中的可为 null 上下文中，T 可以是可为 null 的引用类型、不可为 null 的引用类型或值类型。 T 不能是可为 null 的值类型。
        //where T : U 为 T 提供的类型参数必须是为 U 提供的参数或派生自为 U 提供的参数。 在可为 null 的上下文中，如果 U 是不可为 null 的引用类型，T 必须是不可为 null 的引用类型。 如果 U 是可为 null 的引用类型，则 T 可以是可为 null 的引用类型，也可以是不可为 null 的引用类型。

        private class ItemFactory<T> where T : new()
        {
            public T GetNewItem()
            {
                return new T();
            }
        }

        #endregion

        #region 访问关键字

        //base          base 关键字用于从派生类中访问基类的成员：调用基类上已被其他方法重写的方法。指定创建派生类实例时应调用的基类构造函数。

        //this          this 关键字指代类的当前实例，还可用作扩展方法的第一个参数的修饰符。
        private class Employee
        {
            private readonly string _name;
            private readonly string _alias;
            public decimal Salary { get; } = 3000.00m;
            // Constructor:
            public Employee(string name, string alias)
            {
                // Use this to qualify the fields, name and alias:
                this._name = name;
                this._alias = alias;
            }
            // Printing method:
            public void PrintEmployee()
            {
                Console.WriteLine("Name: {0}\nAlias: {1}", _name, _alias);
                // Passing the object to the CalcTax method by using this:
                Console.WriteLine("Taxes: {0:C}", Tax.CalcTax(this));
            }
        }

        private class Tax
        {
            public static decimal CalcTax(Employee e)
            {
                return 0.08m * e.Salary;
            }
        }

        #endregion

        #region 文本关键字

        //null          null 关键字是表示不引用任何对象的空引用的文字值。
        //bool          .NET System.Boolean 结构类型的别名，它表示一个布尔值，可为 true 或 false。
        //default       default 关键字有两种用法：
        public static void DefaultExampleMethod(int caseSwitch)
        {
            //指定 switch 语句中的默认标签。
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            //作为 default 默认运算符或文本生成类型的默认值
            Console.WriteLine(default(int));  // output: 0
            Console.WriteLine(default(object) == null);  // output: True
        }

        #endregion

        #region 上下文关键字

        //add           定义一个自定义事件访问器，客户端代码订阅事件时会调用该访问器。
        //remove        定义一个自定义事件访问器，客户端代码取消订阅事件时会调用该访问器。
        //async         指示修改后的方法、lambda表达式或匿名方法是异步的。
        //await         挂起异步方法，直到等待的任务完成。
        //dynamic       定义一个引用类型，实现发生绕过编译时类型检查的操作。
        //get           为属性或索引器定义 访问器 方法。
        //set           为属性或索引器定义访问器方法。
        //global        未以其他方式命名的全局命名空间的别名。
        //partial       在整个同一编译单元内定义分部类、结构和接口。
        //value         用于设置访问器和添加或删除事件处理程序。
        //var           使编译器能够确定在方法作用域中声明的变量类型。
        //when          指定 catch 块的筛选条件或 switch 语句的 case 标签。
        public static async Task<string> MakeRequest()
        {
            var client = new HttpClient();
            var streamTask = client.GetStringAsync("https://localHost:10000");
            try
            {
                var responseText = await streamTask;
                return responseText;
            }
            catch (HttpRequestException e) when (e.Message.Contains("301"))
            {
                return "Site Moved";
            }
            catch (HttpRequestException e) when (e.Message.Contains("404"))
            {
                return "Page Not Found";
            }
            catch (HttpRequestException e)
            {
                return e.Message;
            }
        }
        //where         将约束添加到泛型声明。 （另请参阅 where）。
        //yield         在迭代器块中使用，用于向枚举数对象返回值或用于表示迭代结束。
        private static void YieldExample()
        {
            // Display powers of 2 up to the exponent of 8:
            foreach (var i in Power(2, 8))
            {
                Console.Write("{0} ", i);
            }
        }

        public static IEnumerable<int> Power(int number, int exponent)
        {
            var result = 1;

            for (var i = 0; i < exponent; i++)
            {
                result *= number;
                yield return result;
            }
        }

        #endregion

        #region Query keywords 查询关键字

        private static void QueryExample()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //from          from指定将运行查询或子查询的数据源。表示源序列中每个元素的本地范围变量。
            //where         where用于指定将在查询表达式中返回数据源中的哪些元素。
            //select        指定在执行查询时产生的值的类型。 
            var lowerNumbers = from num in numbers
                               where num < 5
                               select num;
            //group         根据指定的键值对查询结果分组。返回一个 IGrouping<TKey,TElement> 对象序列，这些对象包含零个或更多与该组的键值匹配的项。
            var students = new List<Student>
            {
                new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 72, 81, 60}},
                new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
                new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {99, 89, 91, 95}},
                new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {72, 81, 65, 84}},
                new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {97, 89, 85, 82}}
            };
            var booleanGroupQuery =
                from student in students
                group student by student.Scores.Average() >= 80
                into gradesApart//大于80一组，小于80一组分为两组
                where gradesApart.Key == true//选出及格的一组
                select gradesApart.Count(); //统计及格的一组的人数
            //orderby       根据元素类型的默认比较器对查询结果进行升序或降序排序。
            string[] fruits = { "cherry", "apple", "blueberry" };
            IEnumerable<string> sortAscendingQuery =
                from fruit in fruits
                orderby fruit //"ascending" is default
                select fruit;
            IEnumerable<string> sortDescendingQuery =
                from w in fruits
                orderby w descending //descending    
                select w;
            //let           引入区域变量，在查询表达式中存储子表达式结果。
            string[] strings =
            {
                "A penny saved is a penny earned.",
                "The early bird catches the worm.",
                "The pen is mightier than the sword."
            };
            var earlyBirdQuery =
                from sentence in strings
                let words = sentence.Split(' ')
                from word in words
                let w = word.ToLower()
                where w[0] == 'a' || w[0] == 'e'
                                  || w[0] == 'i'
                                  || w[0] == 'o'
                                  || w[0] == 'u'
                select word;

            //join          基于两个指定匹配条件间的相等比较而联接两个数据源。
            //in	        join 子句中的上下文关键字。
            //on            join 子句中的上下文关键字。
            //equals        join 子句中的上下文关键字。
            //https://docs.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/join-clause
        }
        internal class Student
        {
            public string First { get; internal set; }
            public string Last { get; internal set; }
            public int ID { get; internal set; }
            public List<int> Scores { get; internal set; }
        }

        #endregion
    }
}