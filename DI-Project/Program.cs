using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_Project
{
    //interface IClassB
    //{
    //    void showText();
    //     void ActionB();
    //}
    //interface IClassC
    //{
    //     void ActionC();
    //}
    //class ClassC1 : IClassC
    //{
    //    public ClassC1() => Console.WriteLine("ClassC1 is created");
    //    public void ActionC()
    //    {
    //        Console.WriteLine("Action in C1");
    //    }
    //}

    //class ClassB1 : IClassB
    //{
    //    IClassC c_dependency;
    //    public ClassB1(IClassC classc)
    //    {
    //        c_dependency = classc;
    //        Console.WriteLine("ClassB1 is created");
    //    }
    //    public void ActionB()
    //    {
    //        Console.WriteLine("Action in B1");
    //        c_dependency.ActionC();
    //    }
    //    public void showText()
    //    {
    //        Console.WriteLine("Hihi B1");
    //    }
    //}
    //class ClassC : IClassC
    //{
    //    public ClassC() => Console.WriteLine("ClassC is created");
    //    public void ActionC() => Console.WriteLine("Action in ClassC");
    //}

    //class ClassB : IClassB
    //{
    //    IClassC c_dependency;
    //    public ClassB(IClassC classc)
    //    {
    //        c_dependency = classc;
    //        Console.WriteLine("ClassB is created");
    //    }
    //    public void ActionB()
    //    {
    //        Console.WriteLine("Action in ClassB");
    //        c_dependency.ActionC();

    //    }
    //    public void showText()
    //    {
    //        Console.WriteLine("Hihi B");
    //    }
    //}


    //class ClassA
    //{
    //    IClassB b_dependency;
    //    public ClassA(IClassB classb)
    //    {
    //        b_dependency = classb;
    //        Console.WriteLine("ClassA is created");
    //    }
    //    public void ActionA()
    //    {
    //        Console.WriteLine("Action in ClassA");
    //        b_dependency.ActionB();
    //        b_dependency.showText();
    //    }
    //}
    public interface IHorn
    {

        void Beep();
    }
    public class Car
    {
        IHorn horn;                                  // IHorn (Interface) là một Dependecy của Car
        public Car(IHorn horn) => this.horn = horn; // Inject từ hàm  tạo
        public void Beep() => horn.Beep();
    }
    public class HeavyHorn : IHorn
    {
        public void Beep() => Console.WriteLine("(kêu to lắm) BEEP BEEP BEEP ...");
    }

    public class LightHorn : IHorn
    {
        public void Beep() => Console.WriteLine("(kêu bé lắm) beep  bep  bep ...");
    }
    class Program
    {
        static void Main(string[] args)
        {
            //IClassC objectC = new ClassC1();
            //IClassB objectB = new ClassB(objectC);
            //ClassA objectA = new ClassA(objectB);

            //objectA.ActionA();
            Car car1 = new Car(new HeavyHorn());
            car1.Beep();                             // (kểu to lắm) BEEP BEEP BEEP ...

            Car car2 = new Car(new LightHorn());
            car2.Beep();
        }
    }
}
