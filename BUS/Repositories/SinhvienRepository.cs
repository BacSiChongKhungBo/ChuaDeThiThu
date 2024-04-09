using DAL.Context;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Repositories
{
    internal class SinhvienRepository
    {
        DBContext context;
        public SinhvienRepository()
        {
            context = new DBContext();
        }

        public List<Sinhvien> GetAll()
        {
            return context.Sinhviens.ToList();
        }
    }
}
