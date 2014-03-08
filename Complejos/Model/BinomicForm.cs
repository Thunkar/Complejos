using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complejos
{
    class BinomicForm: INotifyPropertyChanged
    {
        private double x;
        private double y;

        public double X {
            get {
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
        

        public BinomicForm(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public BinomicForm()
        {
            this.x = 0.0;
            this.y = 0.0;
        }

        public double Module()
        {

            return Math.Sqrt(this.X * this.X + this.Y * this.Y);
        }
        public double Arg()
        {
            double Arg = Math.Atan2(this.Y, this.X);
            return Arg;
        }
        public void convertFromExp(ExpForm ze)
        {
            this.X = ze.RealPart();
            this.Y = ze.ImPart();
        }
        public String toString()
        {
            return this.x + " + i" + this.y;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
