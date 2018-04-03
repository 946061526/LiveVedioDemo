//=======================================================================================
/****************************************************************************************
 * 
 * 文件说明：
 * 作者：$陈建刚$
 * 创始时间：2017/4/13 10:41:58
 * 创建说明：
*****************************************************************************************/
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Profile;
using Aliyun.Acs.Live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace LiveVedioApi
{
    /// <summary>
    /// 对阿里云直播API进行封装
    /// </summary>
    public class AliyunLiveVedio : ILiveVedio
    {
        private IAcsClient _AcsClient;
        private const string _ProductName = "live";
        private const string _LiveStreamType = "publisher";
        private const string _UtcFormat = "yyyy-MM-ddTHH:mm:ssZ";

        public AliyunLiveVedio(string regionId, string accessKeyId, string secret)
        {
            IClientProfile clientProfile = DefaultProfile.GetProfile(regionId, accessKeyId, secret);
            _AcsClient = new DefaultAcsClient(clientProfile);
        }

        /// <summary>
        /// 获取执行API返回的内容
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        private string GetString(AcsResponse response)
        {
            byte[] bytes = response.HttpResponse.Content;
            return System.Text.Encoding.ASCII.GetString(bytes);
        }

        /// <summary>
        /// 禁止某条流的推送，可以预设某个时刻将流恢复
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="minutes"></param>
        public string Forbid(string userID, int minutes)
        {
            ForbidLiveStreamRequest request = new ForbidLiveStreamRequest();
            request.AppName = ConfigSetting.AppName;
            request.Product = _ProductName;
            request.DomainName = ConfigSetting.DomainName;
            request.AcceptFormat = Aliyun.Acs.Core.Http.FormatType.JSON;
            request.LiveStreamType = _LiveStreamType;
            request.StreamName = userID;
            request.ResumeTime = DateTime.UtcNow.AddMinutes(minutes).ToString(_UtcFormat);
            ForbidLiveStreamResponse response = _AcsClient.GetAcsResponse(request);
            return GetString(response);
        }

        /// <summary>
        /// 恢复某条流的推送
        /// </summary>
        /// <param name="userID"></param>
        public string Resume(string userID)
        {
            ResumeLiveStreamRequest request = new ResumeLiveStreamRequest();
            request.AppName = ConfigSetting.AppName;
            request.Product = _ProductName;
            request.DomainName = ConfigSetting.DomainName;
            request.AcceptFormat = Aliyun.Acs.Core.Http.FormatType.JSON;
            request.LiveStreamType = _LiveStreamType;
            request.StreamName = userID;
            ResumeLiveStreamResponse response = _AcsClient.GetAcsResponse(request);
            return GetString(response);
        }

        /// <summary>
        /// 获取某一时间段内某个域名(或域名下某应用或某个流)的推流记录
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public string GetPublishList(string userID, DateTime startTime, DateTime endTime)
        {
            DescribeLiveStreamsPublishListRequest request = new DescribeLiveStreamsPublishListRequest();
            request.AppName = ConfigSetting.AppName;
            request.Product = _ProductName;
            request.DomainName = ConfigSetting.DomainName;
            request.AcceptFormat = Aliyun.Acs.Core.Http.FormatType.JSON;
            request.StreamName = userID;
            request.StartTime = startTime.ToUniversalTime().ToString(_UtcFormat);
            request.EndTime = endTime.ToUniversalTime().ToString(_UtcFormat);

            DescribeLiveStreamsPublishListResponse response = _AcsClient.GetAcsResponse(request);
            return GetString(response);
        }

        /// <summary>
        /// 查看指定域名下（或者指定域名下某个应用）的所有正在推的流的信息
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public List<DescribeLiveStreamsOnlineListResponse.LiveStreamOnlineInfo> GetOnlineList()
        {
            DescribeLiveStreamsOnlineListRequest request = new DescribeLiveStreamsOnlineListRequest();
            request.AppName = ConfigSetting.AppName;
            request.Product = _ProductName;
            request.DomainName = ConfigSetting.DomainName;
            request.AcceptFormat = Aliyun.Acs.Core.Http.FormatType.JSON;
            DescribeLiveStreamsOnlineListResponse response = _AcsClient.GetAcsResponse(request);
            return response.OnlineInfo;
        }

        /// <summary>
        /// 获取在线直播流的在线人数，支持实时查询和基于时间范围的查询
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public long GetTotalUserNumber(string userID)
        {
            DescribeLiveStreamOnlineUserNumRequest request = new DescribeLiveStreamOnlineUserNumRequest();
            request.AppName = ConfigSetting.AppName;
            request.Product = _ProductName;
            request.DomainName = ConfigSetting.DomainName;
            request.AcceptFormat = Aliyun.Acs.Core.Http.FormatType.JSON;
            request.StreamName = userID;
            DescribeLiveStreamOnlineUserNumResponse response = _AcsClient.GetAcsResponse(request);
            return response.TotalUserNumber.Value;
        }

        /// <summary>
        /// 针对直播流下的AppName配置截图信息，输出内容保存到OSS中，重新推流生效。
        /// </summary>
        /// <param name="ossEndpoint"></param>
        /// <param name="ossBucket"></param>
        /// <param name="timeInterval"></param>
        /// <returns></returns>
        public string AddSnapshotConfig(string ossEndpoint, string ossBucket, int timeInterval)
        {
            AddLiveAppSnapshotConfigRequest request = new AddLiveAppSnapshotConfigRequest();
            request.AppName = ConfigSetting.AppName;
            request.Product = _ProductName;
            request.DomainName = ConfigSetting.DomainName;
            request.AcceptFormat = Aliyun.Acs.Core.Http.FormatType.JSON;
            request.TimeInterval = timeInterval;
            request.OssEndpoint = ossEndpoint;
            request.OssBucket = ossBucket;
            AddLiveAppSnapshotConfigResponse response = _AcsClient.GetAcsResponse(request);
            return GetString(response);
        }

        /// <summary>
        /// 查询一段时间内截图内容
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        public string GetSnapshotInfo(string userID, DateTime startTime, DateTime endTime, int limit)
        {
            DescribeLiveStreamSnapshotInfoRequest request = new DescribeLiveStreamSnapshotInfoRequest();
            request.AppName = ConfigSetting.AppName;
            request.Product = _ProductName;
            request.DomainName = ConfigSetting.DomainName;
            request.AcceptFormat = Aliyun.Acs.Core.Http.FormatType.JSON;
            request.StreamName = userID;
            request.StartTime = startTime.ToUniversalTime().ToString(_UtcFormat);
            request.EndTime = endTime.ToUniversalTime().ToString(_UtcFormat);
            request.Limit = limit;
            DescribeLiveStreamSnapshotInfoResponse response = _AcsClient.GetAcsResponse(request);
            return GetString(response);
        }

        /// <summary>
        /// 配置APP录制，输出内容保存到OSS中
        /// </summary>
        /// <param name="ossEndpoint"></param>
        /// <param name="ossBucket"></param>
        /// <returns></returns>
        public string AddRecordConfig(string ossEndpoint, string ossBucket)
        {
            AddLiveAppRecordConfigRequest request = new AddLiveAppRecordConfigRequest();
            request.AppName = ConfigSetting.AppName;
            request.Product = _ProductName;
            request.DomainName = ConfigSetting.DomainName;
            request.AcceptFormat = Aliyun.Acs.Core.Http.FormatType.JSON;
            request.OssEndpoint = ossEndpoint;
            request.OssBucket = ossBucket;
            AddLiveAppRecordConfigResponse response = _AcsClient.GetAcsResponse(request);
            return GetString(response);
        }
    }
}
