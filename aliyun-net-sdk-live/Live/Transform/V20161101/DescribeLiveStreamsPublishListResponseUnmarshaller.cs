/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Live.Transform.V20161101
{
    public class DescribeLiveStreamsPublishListResponseUnmarshaller
    {
        public static DescribeLiveStreamsPublishListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamsPublishListResponse describeLiveStreamsPublishListResponse = new DescribeLiveStreamsPublishListResponse();

			describeLiveStreamsPublishListResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamsPublishListResponse.RequestId = context.StringValue("DescribeLiveStreamsPublishList.RequestId");

			List<DescribeLiveStreamsPublishListResponse.LiveStreamPublishInfo> publishInfo = new List<DescribeLiveStreamsPublishListResponse.LiveStreamPublishInfo>();
			for (int i = 0; i < context.Length("DescribeLiveStreamsPublishList.PublishInfo.Length"); i++) {
				DescribeLiveStreamsPublishListResponse.LiveStreamPublishInfo liveStreamPublishInfo = new DescribeLiveStreamsPublishListResponse.LiveStreamPublishInfo();
				liveStreamPublishInfo.DomainName = context.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].DomainName");
				liveStreamPublishInfo.AppName = context.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].AppName");
				liveStreamPublishInfo.StreamName = context.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].StreamName");
				liveStreamPublishInfo.StreamUrl = context.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].StreamUrl");
				liveStreamPublishInfo.PublishTime = context.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].PublishTime");
				liveStreamPublishInfo.StopTime = context.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].StopTime");
				liveStreamPublishInfo.PublishUrl = context.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].PublishUrl");
				liveStreamPublishInfo.ClientAddr = context.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].ClientAddr");
				liveStreamPublishInfo.EdgeNodeAddr = context.StringValue("DescribeLiveStreamsPublishList.PublishInfo["+ i +"].EdgeNodeAddr");

				publishInfo.Add(liveStreamPublishInfo);
			}
			describeLiveStreamsPublishListResponse.PublishInfo = publishInfo;
        
			return describeLiveStreamsPublishListResponse;
        }
    }
}