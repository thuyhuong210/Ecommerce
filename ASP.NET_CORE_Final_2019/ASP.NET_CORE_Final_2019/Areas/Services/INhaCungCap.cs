﻿using ASP.NET_CORE_Final_2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_CORE_Final_2019.Areas.Services
{
    public interface INhaCungCap
    {
        IEnumerable<Nhacungcap> GetNhacungcaps { get; }
        Nhacungcap GetNhacungcap(int? Id);
        void Add(Nhacungcap _NhaCungCap);
        void Remove(int? Id);
        void Update(Nhacungcap _NhaCungCap);
    }
}
