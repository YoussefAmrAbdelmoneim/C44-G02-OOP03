using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Inheritance
{
    internal class Parent
    {

        #region Properties
        public int X { get; set; }
        public int Y { get; set; }
        #endregion
        #region Constructor
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }
        #endregion
        #region Methods
        public virtual int Product()
        {
            return X * Y;
        }
        public override string ToString()
        {
            return $"X={X} , Y={Y}";
        }
        public void MyFun()
        {
            Console.WriteLine("Iam Parent");
        }
        #endregion
    }
}
