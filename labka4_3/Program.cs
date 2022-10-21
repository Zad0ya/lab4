using System.Diagnostics;

namespace Labka4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class3_1 class1 = new Class3_1();
            class1.Name = "class1";
            Class3_2 class2 = new Class3_2();
            class2.Name = "class2";
            Class3_3 class3 = new Class3_3();
            class3.Name = "class3";
            Class3_4 class4 = new Class3_4();
            class4.Name = "class4";
            Debug.WriteLine(class1.Name + " " + class2.Name + " " + class3.Name + " " + class4.Name);
        }
    }
}