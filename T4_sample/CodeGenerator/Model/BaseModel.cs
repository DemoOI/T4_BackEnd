using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGenerator.Model
{
    public class BaseModel
    {
        public string DBName { get; set; }

        public string ProjectName { get; set; }

        public string Namespace { get; set; }

        public string ClassName { get; set; }

        public string DataAccessContext { get; set; }

        public string ModelName { get; set; }

        public string TypeName { get; set; }
    }
}
