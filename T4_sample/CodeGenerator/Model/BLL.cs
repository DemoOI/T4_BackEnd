using CodeGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Template
{
    partial class BLLTemp : Interface
    {
        public string Namespace { get; set; }
        public string ClassName { get; set; }
        public string DataAccessContext { get; set; }
        public string ModelName { get; set; }

        public BLLTemp(BaseModel m)
        {
            this.Namespace = m.Namespace;
            this.DataAccessContext = m.DataAccessContext;
            this.ClassName = m.ClassName;
            this.ModelName = m.ModelName;
        }
    }
}
