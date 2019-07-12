using Domain.Entities;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Diagnostics;
using System.Reflection;

namespace Domain
{
    public class Configuration
    {
        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(
                MsSqlConfiguration.MsSql2012.ConnectionString(c=>c.FromConnectionStringWithKey("DBConnection")))
                .ExposeConfiguration(cfg=> {
                    cfg.SetInterceptor( new SqlStatementInterceptor());
                     new SchemaExport(cfg).Execute(true, true, false); })
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<Store>())
                .BuildSessionFactory();                  
        }       
    }


    public class SqlStatementInterceptor : EmptyInterceptor
    {
        public override NHibernate.SqlCommand.SqlString OnPrepareStatement(NHibernate.SqlCommand.SqlString sql)
        {
            Console.WriteLine(sql.ToString());
            return sql;
        }
    }
}
