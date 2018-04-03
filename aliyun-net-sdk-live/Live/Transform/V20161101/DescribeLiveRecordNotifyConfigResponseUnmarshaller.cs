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
    public class DescribeLiveRecordNotifyConfigResponseUnmarshaller
    {
        public static DescribeLiveRecordNotifyConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveRecordNotifyConfigResponse describeLiveRecordNotifyConfigResponse = new DescribeLiveRecordNotifyConfigResponse();

			describeLiveRecordNotifyConfigResponse.HttpResponse = context.HttpResponse;
			describeLiveRecordNotifyConfigResponse.RequestId = context.StringValue("DescribeLiveRecordNotifyConfig.RequestId");

			DescribeLiveRecordNotifyConfigResponse.LiveRecordNotifyConfig_ liveRecordNotifyConfig = new DescribeLiveRecordNotifyConfigResponse.LiveRecordNotifyConfig_();
			liveRecordNotifyConfig.DomainName = context.StringValue("DescribeLiveRecordNotifyConfig.LiveRecordNotifyConfig.DomainName");
			liveRecordNotifyConfig.NotifyUrl = context.StringValue("DescribeLiveRecordNotifyConfig.LiveRecordNotifyConfig.NotifyUrl");
			liveRecordNotifyConfig.NeedStatusNotify = context.BooleanValue("DescribeLiveRecordNotifyConfig.LiveRecordNotifyConfig.NeedStatusNotify");
			describeLiveRecordNotifyConfigResponse.LiveRecordNotifyConfig = liveRecordNotifyConfig;
        
			return describeLiveRecordNotifyConfigResponse;
        }
    }
}