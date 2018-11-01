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

        /// <summary>
        /// Insert Operation and return inserted Id
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tableData"></param>
        public int Insert<T> (T value)
        {
            return Convert.ToInt32(dataContext.Insert(value));
        }

        /// <summary>
        /// Select Operation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <returns></returns>
        public List<T> Select<T>(string query)
        {
            List<T> outputList = null;
            outputList = dataContext.Query<T>(query).ToList<T>();
            return outputList;
        }

        /// <summary>
        /// Update Operation
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tableName"></param>
        /// <param name="Id"></param>
        /// <returns></returns>
        public int update<T>(T tableName, int Id)
        {
            int flag = 0;
            flag = dataContext.Update(tableName, Id);
            return flag;
        }

    }
}
