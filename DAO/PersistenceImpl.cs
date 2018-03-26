using NHibernate;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using Placement_Application.Commons;
using System.Diagnostics;

namespace Placement_Application.DAO
{
    class PersistenceImpl : Persistence
    {
        public bool save(Object obj)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                    try
                    {
                        session.Save(obj);
                        transaction.Commit();
                        Utility.logFile(Utility.getCurrentMethodName(2) + Constant.PERSISTENCE_METHOD_SUCCESS,
                         null, Constant.LOGTYPE_INFO);
                        return true;
                    }
                    catch (GenericADOException ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
            }
            catch (Exception ex)
            {
                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                return false;
            }
        }

        public bool update(Object obj)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                    try
                    {
                        session.Update(obj);
                        transaction.Commit();
                        Utility.logFile(Utility.getCurrentMethodName(2) + Constant.PERSISTENCE_METHOD_SUCCESS,
                        null, Constant.LOGTYPE_INFO);
                        return true;
                    }
                    catch (GenericADOException ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
            }
            catch (Exception ex)
            {
                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                return false;
            }
        }

        public bool delete(Object obj)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                    try
                    {
                        session.Delete(obj);
                        transaction.Commit();
                        Utility.logFile(Utility.getCurrentMethodName(2) + Constant.PERSISTENCE_METHOD_SUCCESS,
                        null, Constant.LOGTYPE_INFO);
                        return true;
                    }
                    catch (GenericADOException ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
            }
            catch (Exception ex)
            {
                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                return false;
            }
        }

        public bool saveOrUpdate(Object obj)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                    try
                    {
                        session.SaveOrUpdate(obj);
                        transaction.Commit();
                        Utility.logFile(Utility.getCurrentMethodName(2) + Constant.PERSISTENCE_METHOD_SUCCESS,
                        null, Constant.LOGTYPE_INFO);
                        return true;
                    }
                    catch (GenericADOException ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
            }
            catch (Exception ex)
            {
                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                return false;
            }
        }

        public IList findByCriteria(DetachedCriteria criteria)
        {
            IList resultList = null;
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    resultList = criteria.GetExecutableCriteria(session).List();
                }
                Utility.logFile(Utility.getCurrentMethodName(2) + Constant.PERSISTENCE_METHOD_SUCCESS,
                    null, Constant.LOGTYPE_INFO);
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {

                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
            }
            catch (Exception ex)
            {
                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
            }
            return resultList;
        }

        public IList findByCriteria(DetachedCriteria criteria, int maxResults)
        {
            IList resultList = null;
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    resultList = criteria.GetExecutableCriteria(session)
                        .SetMaxResults(maxResults)
                        .List();
                }
                Utility.logFile(Utility.getCurrentMethodName(2) + Constant.PERSISTENCE_METHOD_SUCCESS,
                         null, Constant.LOGTYPE_INFO);
            }
            catch (Exception ex)
            {
                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
            }
            return resultList;
        }

        public bool bulkInsert(IList<Object> coll)
        {
            try
            {
                using (IStatelessSession statelessSession = NHibernateHelper.OpenStatelessSession())
                using (ITransaction transaction = statelessSession.BeginTransaction())
                    try
                    {
                        foreach (Object obj in coll)
                        {
                            statelessSession.Insert(obj);
                        }
                        transaction.Commit();
                        Utility.logFile(Utility.getCurrentMethodName(2) + Constant.PERSISTENCE_METHOD_SUCCESS,
                          null, Constant.LOGTYPE_INFO);
                        return true;
                    }
                    catch (GenericADOException ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
            }
            catch (Exception ex)
            {
                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                return false;
            }
        }

        public bool truncateTable<T>()
        {
            try
            {
                string table = NHibernateHelper.getMetaData<T>().TableName;

                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                    try
                    {
                        string deleteAll = string.Format("DELETE FROM {0}", table);
                        session.CreateSQLQuery(deleteAll).ExecuteUpdate();
                        transaction.Commit();
                        Utility.logFile(Utility.getCurrentMethodName(2) + Constant.PERSISTENCE_METHOD_SUCCESS,
                            null, Constant.LOGTYPE_INFO);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
            }
            catch (Exception ex)
            {
                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                return false;
            }
        }

        public bool nativeQuery(string sql)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                using (ITransaction transaction = session.BeginTransaction())
                    try
                    {
                        session.CreateSQLQuery(sql).ExecuteUpdate();
                        transaction.Commit();
                        Utility.logFile(Utility.getCurrentMethodName(2) + Constant.PERSISTENCE_METHOD_SUCCESS,
                           null, Constant.LOGTYPE_INFO);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
            }
            catch (Exception ex)
            {
                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                return false;
            }
        }

        public bool bulkUpdate(IList<object> coll)
        {
            try
            {
                using (IStatelessSession statelessSession = NHibernateHelper.OpenStatelessSession())
                using (ITransaction transaction = statelessSession.BeginTransaction())
                    try
                    {
                        foreach (Object obj in coll)
                        {
                            statelessSession.Update(obj);
                        }
                        transaction.Commit();
                        Utility.logFile(Utility.getCurrentMethodName(2) + Constant.PERSISTENCE_METHOD_SUCCESS,
                         null, Constant.LOGTYPE_INFO);
                        return true;
                    }
                    catch (GenericADOException ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
            }
            catch (Exception ex)
            {
                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                return false;
            }
        }

        public bool bulkDelete(IList<object> coll)
        {
            try
            {
                using (IStatelessSession statelessSession = NHibernateHelper.OpenStatelessSession())
                using (ITransaction transaction = statelessSession.BeginTransaction())
                    try
                    {
                        foreach (Object obj in coll)
                        {
                            statelessSession.Delete(obj);
                        }
                        transaction.Commit();
                        Utility.logFile(Utility.getCurrentMethodName(2) + Constant.PERSISTENCE_METHOD_SUCCESS,
                        null, Constant.LOGTYPE_INFO);
                        return true;
                    }
                    catch (GenericADOException ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                        return false;
                    }
            }
            catch (Exception ex)
            {
                Utility.logFile(ex.Message, ex.InnerException, Constant.LOGTYPE_ERROR);
                return false;
            }
        }
    }
}
