using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complejos.Model
{
    class Sqrt: INotifyPropertyChanged
    {
        private double arg1;
        private double m;
        private double arg;
        private double x;
        private double x1;
        private double y;
        private double y1;
        public double X{
            get{
                return this.x;
            }
            set {
                this.x = value;
                NotifyPropertyChanged("X");
            }
        }
        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
                NotifyPropertyChanged("Y");
            }
        }
        public double Y1
        {
            get
            {
                return this.y1;
            }
            set
            {
                this.y1 = value;
                NotifyPropertyChanged("Y1");
            }
        }
        public double A
        {
            get
            {
                return this.arg;
            }
            set
            {
                this.arg = value;
                NotifyPropertyChanged("A");
            }
        }
        public double M
        {
            get
            {
                return this.m;
            }
            set
            {
                this.m = value;
                NotifyPropertyChanged("M");
            }
        }
        public double X1
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
                NotifyPropertyChanged("X1");
            }
        }
        public double A1
        {
            get
            {
                return this.arg1;
            }
            set
            {
                this.arg1 = value;
                NotifyPropertyChanged("A1");
            }
        }

        public Sqrt()
        {
            this.m = 0;
            this.arg = 0;
            this.arg1 = 0;
        }

        public void Update(ExpForm Z)
        {
            this.M = Math.Sqrt(Z.M);
            this.A = Z.A/2;
            this.A1 = (Z.A/2) + Math.PI;
            this.X = this.M * Math.Cos(this.A);
            this.Y = this.M * Math.Sin(this.A);
            this.Y1 = this.M * Math.Sin(this.A1);
            this.X1 = this.M * Math.Cos(A1);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
