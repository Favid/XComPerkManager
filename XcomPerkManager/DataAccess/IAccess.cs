using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XcomPerkManager.DataModels;

namespace XcomPerkManager.DataAccess
{
    public interface IAccess<TObject, TModel>
        where TObject : class, ISoldierClassElement
        where TModel : class, IModel
    {
        XDocument document { get; set; }
        string fullPath { get; set; }

        TModel create(string internalClassName);
        TModel get(string internalClassName);
        List<TModel> getAll();
        TModel update(string internalClassName, TObject dataObject);
        TModel delete(string internalClassName);
    }
}
