using DataAccess.Dao;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class IdiomaMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_NAME = "NAME";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_IDIOMA_PR" };

            var id = (Idioma)entity;
            operation.AddVarcharParam(DB_COL_NAME, id.Name);
            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_IDIOMA_PR" };

            var id = (Idioma)entity;
            operation.AddVarcharParam(DB_COL_NAME, id.Name);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_IDIOMA_PR" };
            return operation;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var idioma = BuildObject(row);
                lstResults.Add(idioma);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var idioma = new Usuario
            {
                Name = GetStringValue(row, DB_COL_NAME)
            };

            return idioma;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
