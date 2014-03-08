using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complejos
{
    class ExpForm: INotifyPropertyChanged
    {

        private double m;
        private double a;

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

        public double A
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
                NotifyPropertyChanged("A");
            }
        }

        public ExpForm(double m, double a)
        {
            this.m = m;
            this.a = a;
        }
        public ExpForm()
        {
            this.m = 0.0;
            this.a = 0.0;
        }

        public double RealPart()
        {
            return this.M * Math.Cos(this.A);
        }
        public double ImPart()
        {
            return this.M * Math.Sin(this.A);
        }

        public void convertFromBinomic(BinomicForm zb)
        {
            this.M = zb.Module();
            this.A = zb.Arg();
        }
        public String toString()
        {
            return (this.m + "*e^i(" + this.a + ")");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string property){
            if(PropertyChanged!=null)
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
