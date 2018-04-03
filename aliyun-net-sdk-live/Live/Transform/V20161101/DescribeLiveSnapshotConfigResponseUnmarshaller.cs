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
    public class DescribeLiveSnapshotConfigResponseUnmarshaller
    {
        public static DescribeLiveSnapshotConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveSnapshotConfigResponse describeLiveSnapshotConfigResponse = new DescribeLiveSnapshotConfigResponse();

			describeLiveSnapshotConfigResponse.HttpResponse = context.HttpResponse;
			describeLiveSnapshotConfigResponse.RequestId = context.StringValue("DescribeLiveSnapshotConfig.RequestId");
			describeLiveSnapshotConfigResponse.PageNum = context.IntegerValue("DescribeLiveSnapshotConfig.PageNum");
			describeLiveSnapshotConfigResponse.PageSize = context.IntegerValue("DescribeLiveSnapshotConfig.PageSize");
			describeLiveSnapshotConfigResponse.Order = context.StringValue("DescribeLiveSnapshotConfig.Order");
			describeLiveSnapshotConfigResponse.TotalNum = context.IntegerValue("DescribeLiveSnapshotConfig.TotalNum");
			describeLiveSnapshotConfigResponse.TotalPage = context.IntegerValue("DescribeLiveSnapshotConfig.TotalPage");

			List<DescribeLiveSnapshotConfigResponse.LiveStreamSnapshotConfig> liveStreamSnapshotConfigList = new List<DescribeLiveSnapshotConfigResponse.LiveStreamSnapshotConfig>();
			for (int i = 0; i < context.Length("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList.Length"); i++) {
				DescribeLiveSnapshotConfigResponse.LiveStreamSnapshotConfig liveStreamSnapshotConfig = new DescribeLiveSnapshotConfigResponse.LiveStreamSnapshotConfig();
				liveStreamSnapshotConfig.DomainName = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].DomainName");
				liveStreamSnapshotConfig.AppName = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].AppName");
				liveStreamSnapshotConfig.TimeInterval = context.IntegerValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].TimeInterval");
				liveStreamSnapshotConfig.OssEndpoint = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].OssEndpoint");
				liveStreamSnapshotConfig.OssBucket = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].OssBucket");
				liveStreamSnapshotConfig.OverwriteOssObject = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].OverwriteOssObject");
				liveStreamSnapshotConfig.SequenceOssObject = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].SequenceOssObject");
				liveStreamSnapshotConfig.CreateTime = context.StringValue("DescribeLiveSnapshotConfig.LiveStreamSnapshotConfigList["+ i +"].CreateTime");

				liveStreamSnapshotConfigList.Add(liveStreamSnapshotConfig);
			}
			describeLiveSnapshotConfigResponse.LiveStreamSnapshotConfigList = liveStreamSnapshotConfigList;
        
			return describeLiveSnapshotConfigResponse;
        }
    }
}