using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using XcomPerkManager.DataModels;

namespace XcomPerkManager.DataAccess
{
    public abstract class AbstractAccess<TObject, TModel> : IAccess<TObject, TModel>
        where TObject : class, ISoldierClassElement
        where TModel : class, IModel, new()
    {
        public XDocument document { get; set; }
        public string fullPath { get; set; }

        public AbstractAccess()
        {
            string currentDir = Environment.CurrentDirectory;
            DirectoryInfo directory = new DirectoryInfo(currentDir);
            DirectoryInfo root = directory.Parent.Parent;
            fullPath = Path.Combine(root.FullName, "SavedSoldiers.xml");

            document = XDocument.Load(fullPath);
        }

        public virtual TModel create(string internalClassName)
        {
            throw new NotImplementedException();
        }

        public virtual TModel get(string internalClassName)
        {
            throw new NotImplementedException();
        }

        public virtual List<TModel> getAll()
        {
            throw new NotImplementedException();
        }

        public virtual TModel update(string internalClassName, TObject dataObject)
        {
            throw new NotImplementedException();
        }

        public virtual TModel delete(string internalClassName)
        {
            throw new NotImplementedException();
        }
    }
}
