//=======================================================================================
/****************************************************************************************
 * 
 * 文件说明：
 * 作者：$陈建刚$
 * 创始时间：2017/4/13 10:45:15
 * 创建说明：
*****************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveVedioDemo
{

    public class LiveVedioFactory
    {
        public static ILiveVedio CreateLiveVedio()
        {
            ILiveVedio liveVedio = new AliyunLiveVedio(ConfigSetting.RegionId, ConfigSetting.AccessKeyId, ConfigSetting.Secret);
            return liveVedio;
        }
    }
}
