using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBeta.Entities
{
    public class Days
    {
        public int Num { get; set; }

        public ObservableCollection<Exercise> Exercises { get; set; } = new ObservableCollection<Exercise>();

    }
}
