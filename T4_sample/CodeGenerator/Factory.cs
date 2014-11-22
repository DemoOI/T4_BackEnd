using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CodeGenerator.Template;

namespace CodeGenerator
{
    class Factory
    {
        private Model.BaseModel model;

        public Interface Interface { get; set; }


        public Factory(Model.BaseModel model)
        {
            switch (model.TypeName)  
            {
                case "DAL":
                    Interface = new DALTemp(model);
                break;
                case "BLL":
                    Interface = new BLLTemp(model);
                break;
                case "Controller":
                Interface = new ControllerTemp(model);
                break;
                case "ViewIndex":
                Interface = new ViewIndexTemp(model);
                break;
                case "ViewPage":
                Interface = new ViewPageTemp(model) { IsHavePicUpload = true };
                break;

            }
        }

    }
}
