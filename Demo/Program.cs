using Demo.Inheritance;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Class
            //Car C1;
            ////Declare For Reference From Type "Car"
            ////C1 is a reference Referring to Null
            ////This Reference Can Refer To an Instance From Type
            ////Car Or Any Type Inherit From Car
            ////CLR Will Allocate 4 bytes At Stack For Reference "C1"
            //C1 = new Car(10, "BMW" , 290);
            ////1. Allocate Required Bytes At Heap for Object
            ////2. Initialize Allocated Bytes With Default Value of its type
            ////3. Call User Defined Constructor [If Exists] ,if not Call Default Parameterless Constructor
            ////4. Assign Address Of Allocated Object To Reference "C1"
            #endregion
            #region Constructor-Chaining
            //Car C1 = new Car(10);
            //Console.WriteLine(C1);
            //Car C2 = new Car(20,"BYD");
            //Console.WriteLine(C2);
            //Car C3 = new Car(30,"BMW",250);
            //Console.WriteLine(C3);
            #endregion
            #region Inheritance
            //Parent parent = new Parent(1,2);
            //parent.X = 10;
            //parent.Y = 20;
            //Console.WriteLine(parent);
            //Console.WriteLine(parent.Product());
            //parent.MyFun();

            //Child Child = new Child(1, 2,3);
            //Child.X = 10;
            //Child.Y = 20;
            //Child.Z = 30;
            //Console.WriteLine(Child);
            //Console.WriteLine(Child.Product());
            //Child.MyFun();
            #endregion
        }
    }
}
