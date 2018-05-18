﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace PSS.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public override void Init()
        {
            //添加一个身份验证事件
            this.PostAuthenticateRequest += WebApiApplication_PostAuthenticateRequest;
            base.Init();
        }

        void WebApiApplication_PostAuthenticateRequest(object sender, EventArgs e)
        {
            //设置会话[session]的行为为可读写
            HttpContext.Current.SetSessionStateBehavior(System.Web.SessionState.SessionStateBehavior.Required);
        }
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
