using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakladakDemo
{
    public class Truck
    {
        public int MaxLoad { get; }
        public int ActualLoad { get; private set; }

        public Truck(int maxLoad)
        {
            MaxLoad = maxLoad;
        }

        public int Load(int loadWeight)
        {
            int loaded = Math.Min(loadWeight, MaxLoad - ActualLoad);
            ActualLoad += loaded; 
            return loaded;            
        }

        public bool UnLoad(int loadWeight)
        {
            if(ActualLoad >= loadWeight)
            {
                ActualLoad -= loadWeight;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
