
namespace Q306524RiaServicesValidation.Web {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // Implements application logic using the TestEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public class TestDomainService : LinqToEntitiesDomainService<TestEntities> {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'TestTable' query.
        public IQueryable<TestTable> GetTestTable() {
            return this.ObjectContext.TestTable;
        }

        public void InsertTestTable(TestTable testTable) {
            if((testTable.EntityState != EntityState.Detached)) {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(testTable, EntityState.Added);
            } else {
                this.ObjectContext.TestTable.AddObject(testTable);
            }
        }

        public void UpdateTestTable(TestTable currentTestTable) {
            this.ObjectContext.TestTable.AttachAsModified(currentTestTable, this.ChangeSet.GetOriginal(currentTestTable));
        }

        public void DeleteTestTable(TestTable testTable) {
            if((testTable.EntityState == EntityState.Detached)) {
                this.ObjectContext.TestTable.Attach(testTable);
            }
            this.ObjectContext.TestTable.DeleteObject(testTable);
        }
    }
}


