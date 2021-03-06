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
using Aliyun.Acs.Actiontrail.Model.V20171204;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Actiontrail.Transform.V20171204
{
    public class LookupEventsResponseUnmarshaller
    {
        public static LookupEventsResponse Unmarshall(UnmarshallerContext context)
        {
			LookupEventsResponse lookupEventsResponse = new LookupEventsResponse();

			lookupEventsResponse.HttpResponse = context.HttpResponse;
			lookupEventsResponse.RequestId = context.StringValue("LookupEvents.RequestId");
			lookupEventsResponse.NextToken = context.StringValue("LookupEvents.NextToken");
			lookupEventsResponse.StartTime = context.StringValue("LookupEvents.StartTime");
			lookupEventsResponse.EndTime = context.StringValue("LookupEvents.EndTime");

			List<string> lookupEventsResponse_events = new List<string>();
			for (int i = 0; i < context.Length("LookupEvents.Events.Length"); i++) {
				lookupEventsResponse_events.Add(context.StringValue("LookupEvents.Events["+ i +"]"));
			}
			lookupEventsResponse.Events = lookupEventsResponse_events;
        
			return lookupEventsResponse;
        }
    }
}