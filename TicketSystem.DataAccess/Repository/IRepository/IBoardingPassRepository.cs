﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem.DataAccess.Repository.IRepository
{
    public interface IBoardingPassRepository : IRepository<BoardingPassModel>
    {
        void Update(BoardingPassModel obj);
    }
}
