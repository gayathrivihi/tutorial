using DependencyInjctionDemo;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace DependencyInjectionDemo
{
    public class MyDepencyClass : IMyDependency
    {
        public void SendMessage(string message)
        {
            HttpResponse Context =null;
            Context.WriteAsync("message recieved:" + message);
        }
    }

}
