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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Live.Transform;
using Aliyun.Acs.Live.Transform.V20161101;
using System.Collections.Generic;

namespace Aliyun.Acs.Live.Model.V20161101
{
    public class AddLiveAppRecordConfigRequest : RpcAcsRequest<AddLiveAppRecordConfigResponse>
    {
        public AddLiveAppRecordConfigRequest()
            : base("Live", "2016-11-01", "AddLiveAppRecordConfig")
        {
        }

		private string securityToken;

		private long? ownerId;

		private string domainName;

		private string appName;

		private string ossEndpoint;

		private string ossBucket;

		private List<RecordFormat> recordFormats;

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public string OssEndpoint
		{
			get
			{
				return ossEndpoint;
			}
			set	
			{
				ossEndpoint = value;
				DictionaryUtil.Add(QueryParameters, "OssEndpoint", value);
			}
		}

		public string OssBucket
		{
			get
			{
				return ossBucket;
			}
			set	
			{
				ossBucket = value;
				DictionaryUtil.Add(QueryParameters, "OssBucket", value);
			}
		}

		public List<RecordFormat> RecordFormats
		{
			get
			{
				return recordFormats;
			}

			set
			{
				recordFormats = value;
				for (int i = 0; i < recordFormats.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RecordFormat." + (i + 1) + ".Format", recordFormats[i].Format);
					DictionaryUtil.Add(QueryParameters,"RecordFormat." + (i + 1) + ".OssObjectPrefix", recordFormats[i].OssObjectPrefix);
					DictionaryUtil.Add(QueryParameters,"RecordFormat." + (i + 1) + ".SliceOssObjectPrefix", recordFormats[i].SliceOssObjectPrefix);
				}
			}
		}

		public class RecordFormat
		{

			private string format;

			private string ossObjectPrefix;

			private string sliceOssObjectPrefix;

			public string Format
			{
				get
				{
					return format;
				}
				set	
				{
					format = value;
				}
			}

			public string OssObjectPrefix
			{
				get
				{
					return ossObjectPrefix;
				}
				set	
				{
					ossObjectPrefix = value;
				}
			}

			public string SliceOssObjectPrefix
			{
				get
				{
					return sliceOssObjectPrefix;
				}
				set	
				{
					sliceOssObjectPrefix = value;
				}
			}
		}

        public override AddLiveAppRecordConfigResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AddLiveAppRecordConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}