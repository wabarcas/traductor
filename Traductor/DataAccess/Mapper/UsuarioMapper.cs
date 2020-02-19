using DataAccess.Dao;
using Entities_POJO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
        public class UsuarioMapper : EntityMapper, ISqlStaments, IObjectMapper
        {
            private const string DB_COL_ID = "ID";
            private const string DB_COL_NAME = "NAME";


            public SqlOperation GetCreateStatement(BaseEntity entity)
            {
                var operation = new SqlOperation { ProcedureName = "CRE_UUSARIO_PR" };

                var us = (Usuario)entity;
                operation.AddVarcharParam(DB_COL_ID, us.Id);
                operation.AddVarcharParam(DB_COL_NAME, us.Name);
                return operation;
            }


            public SqlOperation GetRetriveStatement(BaseEntity entity)
            {
                var operation = new SqlOperation { ProcedureName = "RET_USUARIO_PR" };

                var us = (Usuario)entity;
                operation.AddVarcharParam(DB_COL_ID, us.Id);

                return operation;
            }

            public SqlOperation GetRetriveAllStatement()
            {
                var operation = new SqlOperation { ProcedureName = "RET_ALL_USUARIO_PR" };
                return operation;
            }

            public SqlOperation GetUpdateStatement(BaseEntity entity)
            {
                var operation = new SqlOperation { ProcedureName = "UPD_USUARIO_PR" };

                var us = (Usuario)entity;
                operation.AddVarcharParam(DB_COL_NAME, us.Name);

                return operation;
            }

            public SqlOperation GetDeleteStatement(BaseEntity entity)
            {
                var operation = new SqlOperation { ProcedureName = "DEL_USUARIO_PR" };

                var us = (Usuario)entity;
                operation.AddVarcharParam(DB_COL_ID, us.Id);
                return operation;
            }

            public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
            {
                var lstResults = new List<BaseEntity>();

                foreach (var row in lstRows)
                {
                    var usuario = BuildObject(row);
                    lstResults.Add(usuario);
                }

                return lstResults;
            }

            public BaseEntity BuildObject(Dictionary<string, object> row)
            {
                var usuario = new Usuario
                {
                    Id = GetStringValue(row, DB_COL_ID),
                    Name = GetStringValue(row, DB_COL_NAME)
                };

                return usuario;
            }
        }
    }
