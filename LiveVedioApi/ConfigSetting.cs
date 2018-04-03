//=======================================================================================
/****************************************************************************************
 * 
 * 文件说明：
 * 作者：$陈建刚$
 * 创始时间：2017/4/13 10:50:19
 * 创建说明：
*****************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace LiveVedioApi
{
    public class ConfigSetting
    {
        private static string _RegionId = null;
        public static string RegionId
        {
            get
            {
                if (_RegionId == null)
                {
                    _RegionId = ConfigurationManager.AppSettings["regionId"];
                }
                return _RegionId;
            }
        }

        private static string _AccessKeyId = null;
        public static string AccessKeyId
        {
            get
            {
                if (_AccessKeyId == null)
                {
                    _AccessKeyId = ConfigurationManager.AppSettings["accessKeyId"];
                }
                return _AccessKeyId;
            }
        }


        private static string _Secret = null;
        public static string Secret
        {
            get
            {
                if (_Secret == null)
                {
                    _Secret = ConfigurationManager.AppSettings["secret"];
                }
                return _Secret;
            }
        }


        private static string _AppName = null;
        public static string AppName
        {
            get
            {
                if (_AppName == null)
                {
                    _AppName = ConfigurationManager.AppSettings["appName"];
                }
                return _AppName;
            }
        }

        private static string _DomainName = null;
        public static string DomainName
        {
            get
            {
                if (_DomainName == null)
                {
                    _DomainName = ConfigurationManager.AppSettings["domainName"];
                }
                return _DomainName;
            }
        }

        private static string _LiveSecret = null;
        public static string LiveSecret
        {
            get
            {
                if ( _LiveSecret == null )
                {
                    _LiveSecret = ConfigurationManager.AppSettings["liveSecret"];
                }
                return _LiveSecret;
            }
        }

        
    }
}
