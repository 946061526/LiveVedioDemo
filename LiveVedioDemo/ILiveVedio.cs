
//=======================================================================================
/****************************************************************************************
 * 
 * 文件说明：
 * 作者：$陈建刚$
 * 创始时间：2017/4/13 10:41:31
 * 创建说明：
****************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiveVedioDemo
{
    public interface ILiveVedio
    {
        /// <summary>
        /// 禁止某条流的推送，可以预设某个时刻将流恢复
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="minutes"></param>
        string Forbid(string userID, int minutes);

        /// <summary>
        /// 恢复某条流的推送
        /// </summary>
        /// <param name="userID"></param>
        string Resume(string userID);

          /// <summary>
        /// 查看指定域名下（或者指定域名下某个应用）的所有正在推的流的信息
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        string GetOnlineList();

        /// <summary>
        /// 获取某一时间段内某个域名(或域名下某应用或某个流)的推流记录
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        string GetPublishList(string userID, DateTime startTime, DateTime endTime);

           /// <summary>
        /// 获取在线直播流的在线人数，支持实时查询和基于时间范围的查询
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        long GetTotalUserNumber(string userID);
    }
}
