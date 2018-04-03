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
    public class DescribeLiveStreamsBlockListResponseUnmarshaller
    {
        public static DescribeLiveStreamsBlockListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLiveStreamsBlockListResponse describeLiveStreamsBlockListResponse = new DescribeLiveStreamsBlockListResponse();

			describeLiveStreamsBlockListResponse.HttpResponse = context.HttpResponse;
			describeLiveStreamsBlockListResponse.RequestId = context.StringValue("DescribeLiveStreamsBlockList.RequestId");
			describeLiveStreamsBlockListResponse.DomainName = context.StringValue("DescribeLiveStreamsBlockList.DomainName");

			List<string> streamUrls = new List<string>();
			for (int i = 0; i < context.Length("DescribeLiveStreamsBlockList.StreamUrls.Length"); i++) {
				streamUrls.Add(context.StringValue("DescribeLiveStreamsBlockList.StreamUrls["+ i +"]"));
			}
			describeLiveStreamsBlockListResponse.StreamUrls = streamUrls;
        
			return describeLiveStreamsBlockListResponse;
        }
    }
}