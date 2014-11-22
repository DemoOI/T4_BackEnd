using CodeGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Template
{
    partial class ViewIndexTemp : Interface
    {
        public string Namespace { get; set; }
        public string ClassName { get; set; }
        public string DataAccessContext { get; set; }
        public string ModelName { get; set; }

        public ViewIndexTemp(BaseModel m)
        {
            this.Namespace = m.Namespace;
            this.DataAccessContext = m.DataAccessContext;
            this.ClassName = m.ClassName;
            this.ModelName = m.ModelName;
        }
    }
}
