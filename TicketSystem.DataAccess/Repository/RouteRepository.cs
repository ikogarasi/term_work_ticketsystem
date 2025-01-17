﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.DataAccess.Data;
using TicketSystem.DataAccess.Repository.IRepository;
using TicketSystem.Models;

namespace TicketSystem.DataAccess.Repository
{
    public class RouteRepository : Repository<RouteModel>, IRouteRepository
    {
        private readonly ApplicationDbContext _db;
    
        public RouteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<RouteModel> GetRoutesFromId(List<Guid> id)
        {
            List<RouteModel> routes = new List<RouteModel>();
            foreach (var item in id)
            {
                routes.Add(_db.Routes.FirstOrDefault(i => i.Id == item));
            }

            return routes;
        }

        public void Update(RouteModel obj)
        {
            var routeFromDb = _db.Routes.FirstOrDefault(i => i.Id == obj.Id);
            if (routeFromDb != null)
            {
                foreach (PropertyInfo prop in typeof(RouteModel).GetProperties())
                {
                    if (prop.GetValue(obj) != null)
                    {
                        prop.SetValue(routeFromDb, prop.GetValue(obj, null));
                    }
                }
            }
        }
    }
}
