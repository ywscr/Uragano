﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Uragano.Abstractions;
using Uragano.Core;
using Uragano.DynamicProxy.Interceptor;
using Uragano.Remoting;

namespace Sample.WebApi
{
    public class Test2Interceptor : InterceptorAbstract
    {
        public override async Task<ResultMessage> Intercept(IInterceptorContext context)
        {
            Console.WriteLine("---------------->Interceptor2");
            return await context.Next();
        }
    }
}
