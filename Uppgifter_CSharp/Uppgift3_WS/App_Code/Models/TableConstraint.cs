using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class TableConstraint
    {
        public TableConstraint() { }
        public string TableConstraintCatalog { get; set; }
        public string Name { get; set; }
        public string TableCatalog { get; set; }
    }
}
