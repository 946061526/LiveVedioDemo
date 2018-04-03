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
    public class StartMixStreamsServiceResponseUnmarshaller
    {
        public static StartMixStreamsServiceResponse Unmarshall(UnmarshallerContext context)
        {
			StartMixStreamsServiceResponse startMixStreamsServiceResponse = new StartMixStreamsServiceResponse();

			startMixStreamsServiceResponse.HttpResponse = context.HttpResponse;
			startMixStreamsServiceResponse.RequestId = context.StringValue("StartMixStreamsService.RequestId");

			List<StartMixStreamsServiceResponse.MixStreamsInfo> mixStreamsInfoList = new List<StartMixStreamsServiceResponse.MixStreamsInfo>();
			for (int i = 0; i < context.Length("StartMixStreamsService.MixStreamsInfoList.Length"); i++) {
				StartMixStreamsServiceResponse.MixStreamsInfo mixStreamsInfo = new StartMixStreamsServiceResponse.MixStreamsInfo();
				mixStreamsInfo.DomainName = context.StringValue("StartMixStreamsService.MixStreamsInfoList["+ i +"].DomainName");
				mixStreamsInfo.AppName = context.StringValue("StartMixStreamsService.MixStreamsInfoList["+ i +"].AppName");
				mixStreamsInfo.StreamName = context.StringValue("StartMixStreamsService.MixStreamsInfoList["+ i +"].StreamName");

				mixStreamsInfoList.Add(mixStreamsInfo);
			}
			startMixStreamsServiceResponse.MixStreamsInfoList = mixStreamsInfoList;
        
			return startMixStreamsServiceResponse;
        }
    }
}