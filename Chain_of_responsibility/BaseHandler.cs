﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    public abstract class BaseHandler : IHandler
    {
        protected IHandler _next;
        protected BaseHandler(IHandler next)
        {
            _next = next;
        }
        public abstract void Handle(RequestContext requestContext);
    }
}
