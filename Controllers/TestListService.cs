using GridSample.Data;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GridSample.Controllers
{
    public class TestListService : ComponentBase
    {

        private readonly MainDbContext db;


        public TestListService(MainDbContext db)
        {
            this.db = db;
        }

        public List<TestList> GetTestLists()
        {
            var result = db.TestLists.ToList();
            return result;
        }
        public TestList GetTestById(int id)
        {
            TestList test = db.TestLists.SingleOrDefault(t => t.Id == id);
            if (test == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            
            return test;


        }

        public string CreateTest(TestList ob)
        {
            db.TestLists.Add(ob);
            db.SaveChanges();
            return "Test successfully creadted";
        }
        

        public string UpdateTest(TestList test)
        {

            //var result = db.TestLists.SingleOrDefault(t => t.Id == testid);

            //result.TestId = test.TestId;
            //result.TestName = test.TestName;
            //result.CategoryName = test.CategoryName;
            //result.TestPrice = test.TestPrice;
            //result.TestShortName = test.TestShortName;
            //result.CurrentlyPerforming = test.CurrentlyPerforming;


            db.TestLists.Update(test);
            db.SaveChanges();
            return "Test updated";


        }

        public string DeleteTest(TestList ob)
        {
            db.TestLists.Remove(ob);
            db.SaveChanges();

            return "deleted successfully";
        }


    }
}
