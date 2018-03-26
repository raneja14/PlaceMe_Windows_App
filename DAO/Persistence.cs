using System;
using System.Collections.Generic;
using NHibernate.Criterion;
using System.Collections;

namespace Placement_Application.DAO
{
    public interface Persistence
    {
        bool save(Object obj);

        bool update(Object obj);

        bool delete(Object obj);

        IList findByCriteria(DetachedCriteria criteria);

        IList findByCriteria(DetachedCriteria criteria, int maxResults);

        bool saveOrUpdate(Object obj);

        bool bulkInsert(IList<Object> coll);

        bool truncateTable<T>();

        bool nativeQuery(string sql);

        bool bulkUpdate(IList<Object> coll);

        bool bulkDelete(IList<Object> coll);
    }
}
