﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWorldService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        public string GetData(string value)
        {
            return "This is the value you passed in " + value + ".";
        }

        public CompositeType GetObjectModel(string id)
        {
            CompositeType composite = new CompositeType();
            composite.StringValue = id;
            composite.BoolValue = true;
            return composite;
        }

        public string SayHello()
        {
            return "Hello world from REST API";
        }
    }
}