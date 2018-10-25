using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.DB.DataContext
{
    public class TemplateRepositoryBase
    {
        internal PetaPoco.Database dataContext;

        public TemplateRepositoryBase()
        {
            dataContext = new PetaPoco.Database("TemplateDB");
        }

        public int Insert<T> (T value)
        {
            return Convert.ToInt32(dataContext.Insert(value));
        }
    }
}
