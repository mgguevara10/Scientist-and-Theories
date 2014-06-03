using Scientist.Data;
using Scientist.DataModels;
using Scientist.web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scientist.web.Adapters.Adapters
{
    public class DataTheoryAdapter : ITheoryAdapter
    {
        public List<Theory> GetAllTheories()
        {
            List<Theory> Theories = new List<Theory>();
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Theories = db.Theories.ToList();
            }
            return Theories;
        }
        public void AddTheory(Theory Theory)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                db.Theories.Add(Theory);
                db.SaveChanges();
            }
        }
        public void DeleteTheory(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Theory newTheory = db.Theories.Find(id);
                db.Theories.Remove(newTheory);
                db.SaveChanges();
            }
        }
    }
}