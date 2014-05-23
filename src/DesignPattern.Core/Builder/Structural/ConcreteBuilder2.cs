using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Core.Builder.Structural
{
    public class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("Part X");
        }

        public override void BuildPartB()
        {
            _product.Add("Part Y");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
}
