using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hxTest.Business.Common
{
    public abstract class PersistibleEntity<T>
    {
        public T Id { get; set; }
    }
}
