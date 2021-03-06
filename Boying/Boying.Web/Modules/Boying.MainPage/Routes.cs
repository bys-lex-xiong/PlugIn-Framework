﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Boying.Mvc.Routes;

namespace Boying.MainPage
{
    public class Routes : IRouteProvider
    {
        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new[] {
                new RouteDescriptor {
                    Route = new Route(
                        "{controller}/{action}",
                        new RouteValueDictionary {
                            { "area", "Boying.MainPage" },
                            { "controller", "Home" },
                            { "action", "Index" }
                        },
                        new RouteValueDictionary {
                            { "area", "Boying.MainPage" },
                            { "controller", "Home" },
                        },
                        new RouteValueDictionary {
                            { "area", "Boying.MainPage" },
                        },
                        new MvcRouteHandler())
                }
            };
        }

        public void GetRoutes(ICollection<RouteDescriptor> routes)
        {
            foreach (var route in GetRoutes())
            {
                routes.Add(route);
            }
        }
    }
}