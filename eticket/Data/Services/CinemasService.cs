using eticket.Data.Base;
using eticket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eticket.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
