using System;

namespace T1907M_NXH.Practial
{
    public class Clynder
    {
        protected double radius;
        protected double height;
        protected double basearea;
        protected double lateralarea;
        protected double totalarea;
        protected double volume;

        public Clynder()
        {
        }

        public Clynder(double radius, double height, double basearea, double lateralarea, double totalarea,
            double volume)
        {
            this.radius = radius;
            this.height = height;
            this.basearea = basearea;
            this.lateralarea = lateralarea;
            this.totalarea = totalarea;
            this.volume = volume;
        }

        public double Radius
        {
            get => radius;
            set => radius = value;
        }

        public double Height
        {
            get => height;
            set => height = value;
        }

        public double Basearea
        {
            get => basearea;
            set => basearea = value;
        }

        public double Lateralarea
        {
            get => lateralarea;
            set => lateralarea = value;
        }

        public double Totalarea
        {
            get => totalarea;
            set => totalarea = value;
        }

        public double Volume
        {
            get => volume;
            set => volume = value;
        }

        public void Process(double radius, double height)
        {
            Basearea = radius * radius * Math.PI;
            Lateralarea = 2 * Math.PI * radius * height;
            Totalarea = 2 * Math.PI * radius * (height + radius);
            Volume = Math.PI * radius * radius * height;
        }

        public void Result(double radius, double height)
        {
            Console.WriteLine("Clynder Characteristics ");
            Console.WriteLine("Radius :" + radius + "Height" + height);
            Console.WriteLine("BaseArea : " + Math.Round(Basearea, 2) + " LateralArea : " + Math.Round(Lateralarea, 2) +
                              " TotalArea : " + Math.Round(Totalarea, 2) +
                              " Volume : " + Math.Round(Volume, 2));
        }
    }
}