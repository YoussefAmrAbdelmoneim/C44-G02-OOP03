using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {
        #region attributes
        private int id;
        private string? model;
        private double speed;
        #endregion
        #region properties
        public string? Model
        {
            get { return model; }
            set { model = value; }
        }
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion
        #region constructor
        public Car(int id, string? model, double speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed;
            Console.WriteLine("1st ctor");
        }
        public Car(int id, string? model):this(id,model,290)
        {
            Console.WriteLine("2nd ctor");
        }
        public Car(int id) : this(id,"Audi", 190)
        {
            Console.WriteLine("3rd ctor");
        }
        #endregion
    }
}
