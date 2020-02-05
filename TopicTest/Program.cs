using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//一、public访问修饰符
/*
namespace RectangleApplication
{
    class Rectangle
    {
        public double length;
        public double width;
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度：{0}", length);
            Console.WriteLine("宽度：{0}", width);
            Console.WriteLine("面积：{0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4.5;
            r.width = 3.5;
            r.Display();
            Console.ReadLine();
        }
    }
}
*/

//二、private访问修饰符
/*
namespace RectangleApplication
{
    class Rectangle
    {
        private double length;
        private double width;

        public void Acceptdetails()
        {
            Console.WriteLine("请输入长度:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入宽度:");
            width = Convert.ToDouble(Console.ReadLine());
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度：{0}", length);
            Console.WriteLine("宽度：{0}", width);
            Console.WriteLine("面积：{0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
*/

//三、Protected访问修饰符
//Protected 访问修饰符允许子类访问它的基类的成员变量和成员函数。这样有助于实现继承。

//四、Internal访问修饰符
//Internal 访问说明符允许一个类将其成员变量和成员函数暴露给当前程序中的其他函数和对象。
//换句话说，带有 internal 访问修饰符的任何成员可以被定义在该成员所定义的应用程序内的任何类或方法访问
/*
namespace RectangleApplication
{
    class Rectangle
    {
        internal double length;
        internal double width;
        
        double GetArea()//如果没有指定访问修饰符，则使用类成员的默认访问修饰符，即为 private。
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度：{0}", length);
            Console.WriteLine("宽度：{0}", width);
            Console.WriteLine("面积：{0}", GetArea());
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.length = 4;
            r.width = 3;
            r.Display();
            Console.ReadLine();
        }
    }
}
*/

//C# 中调用方法(1)
/*
namespace CalculatorApplication
{
    class NumberMainpulator
    {
        public int FindMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;
            NumberMainpulator n = new NumberMainpulator();
            ret = n.FindMax(a, b);
            Console.WriteLine("最大值是：{0}", ret);
            Console.ReadLine();
        }
    }
}
*/

//C# 中调用方法(2)
/*namespace CalculatorApplication
{
    class NumberMainpulator
    {
        public int FindMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            int ret;
            NumberMainpulator n = new NumberMainpulator();
            ret = n.FindMax(a, b);
            Console.WriteLine("最大值是：{0}", ret);
            Console.ReadLine();
        }
    }
}
*/

//参数传递-按值传递
/*
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void swap(int x, int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();

            int a = 100;
            int b = 200;

            Console.WriteLine("在交换之前，a 的值： {0}", a);
            Console.WriteLine("在交换之前，b 的值： {0}", b);

            // 调用函数来交换值
            n.swap(a, b);

            Console.WriteLine("在交换之后，a 的值： {0}", a);
            Console.WriteLine("在交换之后，b 的值： {0}", b);

            Console.ReadLine();
        }
    }
}
*/

//参数传递-按引用传递参数
/*
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void swap(ref int x, ref int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 100;
            int b = 200;
            Console.WriteLine("在交换之前，a 的值： {0}", a);
            Console.WriteLine("在交换之前，b 的值： {0}", b);

            n.swap(ref a, ref b);

            Console.WriteLine("在交换之前，a 的值： {0}", a);
            Console.WriteLine("在交换之前，b 的值： {0}", b);
            Console.ReadLine();
        }
    }
}
*/

//参数传递-按输出传递参数（1）
//return 语句可用于只从函数中返回一个值。但是，可以使用 输出参数 来从函数中返回两个值。
//输出参数会把方法输出的数据赋给自己，其他方面与引用参数相似。
/*
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }

        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a = 100;

            Console.WriteLine("在方法调用之前，a的值：{0}", a);
            n.getValue(out a);
            Console.WriteLine("在方法调用之后，a的值：{0}", a);
            Console.ReadLine();
        }
    }
}
*/
//参数传递-按输出传递参数（2）
//提供给输出参数的变量不需要赋值。当需要从一个参数没有指定初始值的方法中返回值时，输出参数特别有用。
//请看下面的实例，来理解这一点：
/*
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void getValues(out int x, out int y)
        {
            Console.WriteLine("请输入第一个值：");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个值：");
            y = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a, b;
            n.getValues(out a, out b);
            Console.WriteLine("在方法调用之后，a的值：{0}", a);
            Console.WriteLine("在方法调用之后，b的值：{0}", b);
            Console.ReadLine();
        }
    }
}
*/

//C# 可空类型（Nullable）
/*
namespace CalculatorApplication
{
    class NullablesAtShow
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14159;
            bool? boolval = new bool?();

            Console.WriteLine("显示可空类型的值：{0}，{1}，{2}，{3}", num1, num2, num3, num4);//显示可空类型的值：，45，，3.14159 
            Console.WriteLine("一个可空的布尔值： {0}", boolval);
            Console.ReadLine();
        }
    }
}
*/

//Null 合并运算符（ ?? ）
//用于定义可空类型和引用类型的默认值。
//Null合并运算符为类型转换定义了一个预设值，以防可空类型的值为Null。
//Null 合并运算符把操作数类型隐式转换为另一个可空（或不可空）的值类型的操作数的类型
//如果第一个操作数的值为 null，则运算符返回第二个操作数的值，否则返回第一个操作数的值。
/*
namespace CalculatorApplication
{
    class NullablesAtShow
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 3.14159; //我擦咧，规则这么奇葩，什么鬼咧，去掉问号会报错
            double num3;
            num3 = num1 ?? 5.34;//num1为空，所以返回5.34
            Console.WriteLine("num3 的值： {0}", num3);
            num3 = num2 ?? 5.34;//num2不为空，返回3.15159
            Console.WriteLine("num3 的值： {0}", num3);
            Console.ReadLine();
        
            //结果
            //    num3 的值： 5.34
            //    num3 的值： 3.14157
            
        }
    }
}
*/

//一维数组
/*
namespace TestArray
{
    class testArray
    {
        public void testArray_1()
        {
            double[] balance = new double[10];//可以通过使用索引号赋值给一个单独的数组元素
            balance[0] = 4500.0;
            Console.WriteLine(balance[0]);
            Console.WriteLine(balance[9]);//当创建一个数组时，C# 编译器会根据数组类型隐式初始化每个数组元素为一个默认值。例如，int 数组的所有元素都会被初始化为 0。
            double[] test = { 2340.0, 4523.69, 3421.0 };//可以在声明数组的同时给数组赋值
            Console.WriteLine(test[1]);
            int[] marks_1 = new int[5] { 99, 98, 92, 97, 95 };//可以创建并初始化一个数组
            Console.WriteLine(marks_1[1]);
            int[] marks_2 = new int[] { 1, 2, 3, 4, 5, 6 };//可以省略数组的大小
            Console.WriteLine(marks_2[5]);
            int[] marks_3 = new int[] { 99, 98, 92, 97, 95 };
            int[] score = marks_3;//可以赋值一个数组变量到另一个目标数组变量中
            Console.WriteLine(score[2]);
        }
        public void testArray_2()
        {
            int[] n = new int[10];
            int i, j;
            for (i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            Console.WriteLine("=====testArray_2=====");
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}]:{1}", j, n[j]);
            }
        }
        public void testArray_3()//foreach用法
        {
            int[] n = new int[10];
            for(int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }
            Console.WriteLine("=====testArray_3=====");
            foreach (int j in n)//体会下
            {
                int i = j - 100;
                Console.WriteLine("Element[{0}]:{1}", i, j);
            }
        }
    }
    class ExecuteArraytest
    {
        static void Main(string[] args)
        {
            testArray t = new testArray();
            t.testArray_1();
            t.testArray_2();
            t.testArray_3();
            Console.ReadLine();
        }
    }
}
*/
//字符串
/*
namespace TestString
{
    class testString
    {
        public void testString_1()
        {
            //字符串，字符串连接
            //使用字符串串联运算符（ + ）
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";
            string fullname = fname + lname;
            Console.WriteLine("Full Name : {0}", fullname);
            //通过使用 string 构造函数
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);
            //方法返回字符串
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join(" ", sarray);
            Console.WriteLine("message: {0}", message);
            //用于转化值的格式化方法
            //通过格式化方法来转换一个值或对象为它的字符串表示形式
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);//Message: Message sent at 17:58 on 2012年10月10日

            //结果
            //Full Name: RowanAtkinson
            //Greetings: Hello
            //Message: Hello From Tutorials Point
            //Message: Message sent at 17:58 on Wednesday, 10 October 2012
        }
        public void testString_2()
        {
            //比较字符串
            string str1 = "This is test1";
            string str2 = "This is test2";
            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal!");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal!");
            }
        }
        public void testString_3()
        {
            //字符串包含字符串
            string str = "This is a string test";
            if (str.Contains("string"))
            {
                Console.WriteLine("The sequence 'string' is found");
            }
            if (str.Contains("test"))
            {
                Console.WriteLine("The sequence 'test' is found");
            }
        }
        public void testString_4()
        {
            //获取子字符串
            string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23);//从0位置算起，San Pedro
            Console.WriteLine(substr);
        }
        public void testString_5()
        {
            //连接字符串
            string[] starray = new string[] { "Down the way nights are dark",
                "And the sun shines daily on the mountain top",
                "I took a trip on a sailing ship",
                "And when I reached Jamaica",
                "I made a stop"
            };
            string str = String.Join("\n", starray);
            Console.WriteLine(str);
        }
        public void testStringFormat()
        {
            //C# string.Format格式化日期
            //来自网站：https://www.runoob.com/csharp/csharp-string.html
            DateTime dt = new DateTime(2017, 4, 1, 13, 16, 32, 108);
            string chat;
            chat = string.Format("{0:y yy yyy yyyy}", dt);//17 17 2017 2017
            Console.WriteLine(chat);
            chat = string.Format("{0:M MM MMM MMMM}", dt);//4  04 四月 四月
            Console.WriteLine(chat);
            chat = string.Format("{0:d dd ddd dddd}", dt);//1  01 周六 星期六
            Console.WriteLine(chat);
            chat = string.Format("{0:t tt}", dt);//下 下午
            Console.WriteLine(chat);
            chat = string.Format("{0:H HH}", dt);//13 13
            Console.WriteLine(chat);
            chat = string.Format("{0:h hh}", dt);//1  01
            Console.WriteLine(chat);
            chat = string.Format("{0:m mm}", dt);//16 16
            Console.WriteLine(chat);
            chat = string.Format("{0:s ss}", dt);//32 32
            Console.WriteLine(chat);
            chat = string.Format("{0:F FF FFF FFFF FFFFF FFFFFF FFFFFFF}", dt);//1 1  108 108  108   108    108
            Console.WriteLine(chat);
            chat = string.Format("{0:f ff fff ffff fffff ffffff fffffff}", dt);//1 10 108 1080 10800 108000 1080000
            Console.WriteLine(chat);
            chat = string.Format("{0:z zz zzz}", dt);//+8 +08 +08:00
            Console.WriteLine(chat);
            chat = string.Format("{0:yyyy/MM/dd HH:mm:ss.fff}", dt);  //2017/04/01 13:16:32.108
            Console.WriteLine(chat);
            chat = string.Format("{0:yyyy/MM/dd dddd}", dt);      //2017/04/01 星期六
            Console.WriteLine(chat);
            chat = string.Format("{0:yyyy/MM/dd dddd tt hh:mm}", dt); //2017/04/01 星期六 下午 01:16
            Console.WriteLine(chat);
            chat = string.Format("{0:yyyyMMdd}", dt);         //20170401
            Console.WriteLine(chat);
            chat = string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", dt); //2017-04-01 13:16:32.108
            Console.WriteLine(chat);
            //*.ToStrin()也可以实现相同效果
            Console.WriteLine("=======*.ToString()也可以实现相同效果======");
            Console.WriteLine(dt.ToString("yyyy/MM/dd HH:mm:ss.fff")); //2017/04/01 13:16:32.108
            Console.WriteLine(dt.ToString("yyyy/MM/dd dddd"));      //2017/04/01 星期六
            Console.WriteLine(dt.ToString("yyyy/MM/dd dddd tt hh:mm")); //2017/04/01 星期六 下午 01:16
            Console.WriteLine(dt.ToString("yyyyMMdd"));         //20170401
            Console.WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss.fff"));　//2017-04-01 13:16:32.108
        }
    }

    class ExecTestString
    {
        static void Main(string[] args)
        {
            testString t = new testString();
            t.testString_1();
            t.testString_2();
            t.testString_3();
            t.testString_4();
            t.testString_5();
            t.testStringFormat();
            Console.ReadKey();
        }
    }
}
*/

//结构体
/*
结构和类的适用场合分析：
1、当堆栈的空间很有限，且有大量的逻辑对象时，创建类要比创建结构好一些；
2、对于点、矩形和颜色这样的轻量对象，假如要声明一个含有许多个颜色对象的数组，则CLR需要为每个对象分配内存，在这种情况下，使用结构的成本较低；
3、在表现抽象和多级别的对象层次时，类是最好的选择，因为结构不支持继承。
4、大多数情况下，目标类型只是含有一些数据，或者以数据为主。
*/
/*
struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;
};

struct Books_2
{
    private string title;
    private string author;
    private string subject;
    private int book_id;
    public void getValues(string t, string a, string s, int id)
    {
        title = t;
        author = a;
        subject = s;
        book_id = id;
    }
    public void display()
    {
        Console.WriteLine("Title:{0}", title);
        Console.WriteLine("Author:{0}", author);
        Console.WriteLine("Subject:{0}", subject);
        Console.WriteLine("Book_id:{0}", book_id);
    }
}

namespace TestStruct
{
    public class testStruct
    {
        public void testStruct_1()
        {
            Books Book1;
            Books Book2;
            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;

            // book 2 详述
            Book2.title = "Telecom Billing";
            Book2.author = "Zara Ali";
            Book2.subject = "Telecom Billing Tutorial";
            Book2.book_id = 6495700;

            // 打印 Book1 信息
            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

            // 打印 Book2 信息
            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);
        }
        public void testStruct_2()
        {
            Books_2 Book1 = new Books_2();
            Books_2 Book2 = new Books_2();
            Book1.getValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);
            Book2.getValues("Telecom Billing","Zara Ali", "Telecom Billing Tutorial", 6495700);
            Book1.display();
            Book2.display();
        }
    }
    class ExecuteStruct
    {
        static void Main(string[] args)
        {
            testStruct t = new testStruct();
            t.testStruct_1();
            t.testStruct_2();
            Console.ReadKey();
        }
    } 
}
*/

//枚举
/*
namespace TestEnum
{
    class testEnum
    {
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat};
        static void Main(string[] args)
        {
            int x = (int)Day.Sun;
            int y = (int)Day.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);
            Console.ReadKey();
        }
    }
}
*/

//C#类（class）
//类的默认访问标识符是 internal，成员的默认访问标识符是 private
//成员函数和封装示例如下
/*
namespace BoxApplication
{
    class Box
    {
        private double length;// 长度
        private double breadth;// 宽度
        private double height;// 高度
        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }
        public double getVolume()
        {
            return length * breadth * height;
        }
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            double volume;

            box1.setLength(6.0);
            box1.setBreadth(7.0);
            box1.setHeight(5.0);

            box2.setLength(12.0);
            box2.setBreadth(13.0);
            box2.setHeight(10.0);
            // Box1 的体积
            volume = box1.getVolume();
            Console.WriteLine("Box1 的体积： {0}", volume);

            // Box2 的体积
            volume = box2.getVolume();
            Console.WriteLine("Box2 的体积： {0}", volume);

            Console.ReadKey();
        }
    }
}
*/

//类的构造函数
//(1)
//类的 构造函数 是类的一个特殊的成员函数，当创建类的新对象时执行。
//构造函数的名称与类的名称完全相同，它没有任何返回类型。
//(2)
//默认的构造函数没有任何参数。但是如果你需要一个带有参数的构造函数可以有参数，这种构造函数叫做参数化构造函数。
//这种技术可以帮助你在创建对象的同时给对象赋初始值.
/*
namespace LineApplication
{
    class Line
    {
        private double length;
        public Line()
        {
            Console.WriteLine("对象1已创建");
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
    }
    class Line_2
    {
        private double length;
        public Line_2(double len)
        {
            Console.WriteLine("对象2已创建，length = {0}", len);
            length = len;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
    }
    class ExecuteClass
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            line.setLength(6.0);
            Console.WriteLine("线条1的长度：{0}", line.getLength());

            Line_2 line_2 = new Line_2(10.0);//参数化构造函数
            line_2.setLength(10.0);
            Console.WriteLine("线条2的长度：{0}", line_2.getLength());

            Console.ReadLine();
        }
    }
}
*/

//类的析构函数
//析构函数的名称是在类的名称前加上一个波浪形（~）作为前缀，它不返回值，也不带任何参数。
//析构函数用于在结束程序（比如关闭文件、释放内存等）之前释放资源。析构函数不能继承或重载。
/*
namespace LineApplication
{
    class Line
    {
        private double length;   // 线条的长度
        public Line()  // 构造函数
        {
            Console.WriteLine("对象已创建");
        }
        ~Line() //析构函数
        {
            Console.WriteLine("对象已删除");
        }

        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)
        {
            Line line = new Line();
            // 设置线条长度
            line.setLength(6.0);
            Console.WriteLine("线条的长度： {0}", line.getLength());
            Console.ReadLine();
            
            //运行结果：
            //对象已创建
            //线条的长度： 6
            //对象已删除
        }
    }
}
*/

//C# 类的静态成员
//当我们声明一个类成员为静态时，意味着无论有多少个类的对象被创建，只会有一个该静态成员的副本。
//关键字 static 意味着类中只有一个该成员的实例。
//静态变量用于定义常量，因为它们的值可以通过直接调用类而不需要创建类的实例来获取
//静态变量可在成员函数或类的定义外部进行初始化。你也可以在类的定义内部初始化静态变量。
//也可以把一个成员函数声明为 static。这样的函数只能访问静态变量。
//（这句话重要，见示例）静态函数在对象被创建之前就已经存在。
/*
namespace StaticVarApplication
{
    class StaticVar
    {
        public static int num;
        public void count()
        {
            num++;
        }
        public int getNum()
        {
            return num;
        }
        public static int getNum_static()
        {
            return num;
        }
    }
    class StaticTester
    {
        static void Main(string[] args)
        {
            StaticVar s1 = new StaticVar();
            StaticVar s2 = new StaticVar();
            s1.count();
            s1.count();
            s1.count();
            s2.count();
            s2.count();
            s2.count();
            Console.WriteLine("s1 的变量 num： {0}", s1.getNum());
            Console.WriteLine("s2 的变量 num： {0}", s2.getNum());
            Console.WriteLine("s2 的变量 num： {0}", StaticVar.getNum_static());
            Console.ReadKey();
        }
    }
}
*/
//基类和派生类
/*
namespace InheritanceApplication
{
    class shape
    {
        protected int width;
        protected int height;
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
    }
    //派生类
    class Rectangle : shape
    {
        public int getArea()
        {
            return (width * height);
        }
    }
    class RectangleTester
    {
        static void Main(string[] args)
        {
            Rectangle Rect = new Rectangle();

            Rect.setWidth(5);
            Rect.setHeight(7);

            // 打印对象的面积
            Console.WriteLine("总面积： {0}", Rect.getArea());
            Console.ReadKey();
        }
    }
}
*/

//C# 继承
//https://www.runoob.com/csharp/csharp-inheritance.html

namespace TopicTest
{
    class Program
    {
        static void Main_____test(string[] args)
        {
            /* 开启C#世界 */
            Console.WriteLine("Hello World");





            //test 4
            /*
            int a = 10;
            do
            {
                Console.WriteLine("a = {0}", a);
                a++;
            } while (a < 20);
            */

            //test 3
            /*
            int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            foreach (int element in fibarray)
            {
                System.Console.WriteLine(element);
            }
            System.Console.WriteLine();

            //类似foreach 循环
            for (int i = 0; i < fibarray.Length; i++)
            {
                System.Console.WriteLine(fibarray[i]);
            }
            System.Console.WriteLine();

            //设置集合中元素的计算器
            int count = 0;
            foreach (int element in fibarray)
            {
                count += 1;
                System.Console.WriteLine("Element #{0}:{1}", count, element);
            }
            System.Console.WriteLine("Number of elements in the array:{0}", count);
            */

            //test 2
            /*
            int num;
            num = Convert.ToInt32(Console.ReadLine());// Console.ReadLine() 只接受字符串格式的数据
            Console.WriteLine(num);
            */

            //test 1
            /*
            int a = 45;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;
            Console.WriteLine(a.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());
            */

            Console.ReadKey();
        }

    }
}
