using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaMulana2Randomizer.Core.Attributes
{
    public class ShouldRandomize : System.Attribute
    {
        private bool _shouldRandomize;
        public ShouldRandomize(bool shouldRandomize)
        {
            _shouldRandomize = shouldRandomize;
        }
    }
}
