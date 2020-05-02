using BasicManage.Entities;
using BasicManage.Tool;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicManage.Areas.UserArea.LogicL
{
    public class OverView
    {
        private readonly MyDBContext mdb;
        PublicUtil putil;
        public OverView(MyDBContext _context)
        {
            mdb = _context;
            putil = new PublicUtil();
        }
    }
}