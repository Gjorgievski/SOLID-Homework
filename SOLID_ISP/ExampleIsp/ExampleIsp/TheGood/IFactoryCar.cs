using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleIsp.TheGood
{
    public interface IFactoryCar:IFactoryBase
    {

        int ProduceBody();

        int ProduceEngine();

        int ProduceGears();

        
        int ProduceElectronics();

        /// <summary>
        /// Produce tanks for the car
        /// </summary>
        /// <returns></returns>
        int ProduceTank();

        //the painters
        int Paint(int paintColour);

    }
}
