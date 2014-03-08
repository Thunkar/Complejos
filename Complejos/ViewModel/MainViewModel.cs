using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Complejos.Model;

namespace Complejos.ViewModel
{
    class MainViewModel
    {
        public static MainViewModel Current;
        public BinomicForm Binomic { get; set; }
        public ExpForm Exp { get; set; }
        public Sqrt Sqrt {get; set;}

        public MainViewModel()
        {
            Current = this;
            Binomic = new BinomicForm();
            Exp = new ExpForm();
            Sqrt = new Sqrt();
        }
    }
}
