/*
===============================================================================
                    EntitySpaces 2009 by EntitySpaces, LLC
             Persistence Layer and Business Objects for Microsoft .NET
             EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
                          http://www.entityspaces.net
===============================================================================
EntitySpaces Version : 2009.2.1214.0
EntitySpaces Driver  : SQL
Date Generated       : 2/2/2014 12:57:42 PM
===============================================================================
*/

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Text;
using System.Data;

using EntitySpaces.Interfaces;
using EntitySpaces.Core;
using u = CSA.UTILITY.MyUtility;


namespace BusinessObjects
{
    public enum WebMsgType
    {
        OK,
        ERR,
        WAR
    }

    public enum WebLogAction
    {
        LOGIN,
        LOGOUT,
        BADLOGIN,
        UIMSG,
        SYSTEM_ERROR,
        ACCESS_DENIED,
        CATCH_ERROR,
        EMAIL_ERROR,
        EMAIL_OK,
        INFO,
        AS400_FAILOVER
    }



    public partial class V5WebLogBO : esV5WebLogBO
    {
        public static void AddLog(string ip, WebMsgType type, string msg, WebLogAction action)
        {
            AddLog(ip, type, msg, action, string.Empty, string.Empty,false,string.Empty,string.Empty,string.Empty,0,false);
        }

        public static void AddLog(string ip, WebMsgType type, string msg, WebLogAction action, string user, string page, bool isAjax, string HTTP_REFERER, string HTTP_USER_AGENT, string HTTPS, int responseCode, bool isNotFound)
        {
            var l = new V5WebLogBO();
            l.AddNew();
            l.Type = type.ToString();
            l.Action = action.ToString();
            l.Ip = ip;
            l.Message = msg;
            l.User = user;
            l.Reported = false;
            l.IsAjax = isAjax;
            l.HttpReferer = u.Left(HTTP_REFERER,300);
            l.HttpUserAgent = u.Left(HTTP_USER_AGENT,300);
            l.Https = u.Left(HTTPS,10);
            l.ResponseCode = responseCode;
            l.IsNotFound = isNotFound;
            
            //why is this here? 
            if (page != string.Empty)
            {
                l.Page = page;
            }

            l.Save();
        }

    }
}