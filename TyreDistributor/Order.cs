using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TyreDistributor
{
    public  class Order
    {
        /// <summary>
        /// Adding the Tyre to Line
        /// </summary>
        /// <param name="tyre"></param>
        /// <param name="Qty"></param>
        /// <returns></returns>
        public Line AddLine(Tyre tyre, int Qty)
        {
            var line = new Line() { Tyre = tyre, Quantity = Qty };
            return line;
        }
    }


}

