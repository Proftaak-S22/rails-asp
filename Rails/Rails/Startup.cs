﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rails.Startup))]
namespace Rails
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
