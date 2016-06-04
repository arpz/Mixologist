using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixologist
{
    class calculate
    {

        public float calcNic(float bottleSize, float baseNicStrength, float desiredNicStrength)
        {
            float nicAmount = new float();
            nicAmount = (desiredNicStrength / baseNicStrength) * bottleSize;
            return nicAmount;
        }
    }
}
