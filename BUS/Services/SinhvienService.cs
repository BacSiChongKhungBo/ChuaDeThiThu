using BUS.Repositories;
using DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SinhvienService
    {
        SinhvienRepository repos;
        public SinhvienService()
        {
            repos = new SinhvienRepository();
        }

        public List<Sinhvien> GetSinhviens()
        {
            return repos.GetAll();
        }
    }
}
