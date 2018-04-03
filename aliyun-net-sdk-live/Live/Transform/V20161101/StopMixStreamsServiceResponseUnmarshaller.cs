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
    public class StopMixStreamsServiceResponseUnmarshaller
    {
        public static StopMixStreamsServiceResponse Unmarshall(UnmarshallerContext context)
        {
			StopMixStreamsServiceResponse stopMixStreamsServiceResponse = new StopMixStreamsServiceResponse();

			stopMixStreamsServiceResponse.HttpResponse = context.HttpResponse;
			stopMixStreamsServiceResponse.RequestId = context.StringValue("StopMixStreamsService.RequestId");

			List<StopMixStreamsServiceResponse.MixStreamsInfo> mixStreamsInfoList = new List<StopMixStreamsServiceResponse.MixStreamsInfo>();
			for (int i = 0; i < context.Length("StopMixStreamsService.MixStreamsInfoList.Length"); i++) {
				StopMixStreamsServiceResponse.MixStreamsInfo mixStreamsInfo = new StopMixStreamsServiceResponse.MixStreamsInfo();
				mixStreamsInfo.DomainName = context.StringValue("StopMixStreamsService.MixStreamsInfoList["+ i +"].DomainName");
				mixStreamsInfo.AppName = context.StringValue("StopMixStreamsService.MixStreamsInfoList["+ i +"].AppName");
				mixStreamsInfo.StreamName = context.StringValue("StopMixStreamsService.MixStreamsInfoList["+ i +"].StreamName");

				mixStreamsInfoList.Add(mixStreamsInfo);
			}
			stopMixStreamsServiceResponse.MixStreamsInfoList = mixStreamsInfoList;
        
			return stopMixStreamsServiceResponse;
        }
    }
}