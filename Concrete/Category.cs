using DependencyInjectionDatabaseExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDatabaseExample.Concrete
{
    public class Category : BaseItem
    {
        public string Name { get; set; }
        public List<Product> Product { get; set; }
    }
}
