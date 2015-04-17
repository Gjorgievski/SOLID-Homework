﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
    public interface IFactoryBase
    {

        int StartShift();

        int CloseShift();

        int StartProductionLane();

        int StopProductionLane();

        int ProduceHeadLamps();


    }
}
