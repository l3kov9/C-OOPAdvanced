using System;

namespace _03.Ferrari
{
    public abstract class Car 
        : ICar,IDriver
    {
        private string model;
        private string name;

        protected Car(string model, string name)
        {
            this.Model = model;
            this.Name = name;
        }

        public string Model
        {
            get => this.model;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"{nameof(Model)} must not be empty.");
                }
                this.model = value;
            }
        }

        public string Name
        {
            get => this.name;
            set => this.name = value;
        }

        public virtual void UseBrakes()
        {
            Console.WriteLine("Brakes");
        }

        public virtual void PushTheGas()
        {
            Console.WriteLine("Go go go...");
        }


        public override string ToString()
        {
            return $"{GetType().Name} {this.Model}{Environment.NewLine}Driver: {this.Name}";
        }
    }
}
