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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class SearchWaterMarkTemplateResponseUnmarshaller
    {
        public static SearchWaterMarkTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			SearchWaterMarkTemplateResponse searchWaterMarkTemplateResponse = new SearchWaterMarkTemplateResponse();

			searchWaterMarkTemplateResponse.HttpResponse = context.HttpResponse;
			searchWaterMarkTemplateResponse.RequestId = context.StringValue("SearchWaterMarkTemplate.RequestId");
			searchWaterMarkTemplateResponse.TotalCount = context.LongValue("SearchWaterMarkTemplate.TotalCount");
			searchWaterMarkTemplateResponse.PageNumber = context.LongValue("SearchWaterMarkTemplate.PageNumber");
			searchWaterMarkTemplateResponse.PageSize = context.LongValue("SearchWaterMarkTemplate.PageSize");

			List<SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate> searchWaterMarkTemplateResponse_waterMarkTemplateList = new List<SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate>();
			for (int i = 0; i < context.Length("SearchWaterMarkTemplate.WaterMarkTemplateList.Length"); i++) {
				SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate waterMarkTemplate = new SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate();
				waterMarkTemplate.Id = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Id");
				waterMarkTemplate.Name = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Name");
				waterMarkTemplate.Width = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Width");
				waterMarkTemplate.Height = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Height");
				waterMarkTemplate.Dx = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Dx");
				waterMarkTemplate.Dy = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Dy");
				waterMarkTemplate.ReferPos = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].ReferPos");
				waterMarkTemplate.Type = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Type");
				waterMarkTemplate.State = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].State");

				SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate.SearchWaterMarkTemplate_Timeline timeline = new SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate.SearchWaterMarkTemplate_Timeline();
				timeline.Start = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Timeline.Start");
				timeline.Duration = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].Timeline.Duration");
				waterMarkTemplate.Timeline = timeline;

				SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate.SearchWaterMarkTemplate_RatioRefer ratioRefer = new SearchWaterMarkTemplateResponse.SearchWaterMarkTemplate_WaterMarkTemplate.SearchWaterMarkTemplate_RatioRefer();
				ratioRefer.Dx = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].RatioRefer.Dx");
				ratioRefer.Dy = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].RatioRefer.Dy");
				ratioRefer.Width = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].RatioRefer.Width");
				ratioRefer.Height = context.StringValue("SearchWaterMarkTemplate.WaterMarkTemplateList["+ i +"].RatioRefer.Height");
				waterMarkTemplate.RatioRefer = ratioRefer;

				searchWaterMarkTemplateResponse_waterMarkTemplateList.Add(waterMarkTemplate);
			}
			searchWaterMarkTemplateResponse.WaterMarkTemplateList = searchWaterMarkTemplateResponse_waterMarkTemplateList;
        
			return searchWaterMarkTemplateResponse;
        }
    }
}
