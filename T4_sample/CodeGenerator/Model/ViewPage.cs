using CodeGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Template
{
    partial class ViewPageTemp : Interface
    {
        public string DBName { get; set; }
        public string Namespace { get; set; }
        public string ClassName { get; set; }
        public string DataAccessContext { get; set; }
        public string ModelName { get; set; }
        public bool IsHavePicUpload { get; set; }

        public ViewPageTemp(BaseModel m)
        {
            this.DBName = m.DBName;
            this.Namespace = m.Namespace;
            this.DataAccessContext = m.DataAccessContext;
            this.ClassName = m.ClassName;
            this.ModelName = m.ModelName;
            this.IsHavePicUpload = IsHavePicUpload;
        }
    }
}
