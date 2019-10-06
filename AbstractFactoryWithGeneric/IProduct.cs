using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryWithGeneric
{

    // abstract product
       public interface IProduct<TFactory>
        {
            void Operate();
        }

}
