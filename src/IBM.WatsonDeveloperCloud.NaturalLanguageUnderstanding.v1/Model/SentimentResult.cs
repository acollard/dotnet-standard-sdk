/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Collections.Generic;
using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.NaturalLanguageUnderstanding.v1.Model
{
    /// <summary>
    /// The sentiment of the content.
    /// </summary>
    public class SentimentResult : BaseModel
    {
        /// <summary>
        /// The document level sentiment.
        /// </summary>
        /// <value>The document level sentiment.</value>
        [JsonProperty("document", NullValueHandling = NullValueHandling.Ignore)]
        public DocumentSentimentResults Document { get; set; }
        /// <summary>
        /// The targeted sentiment to analyze.
        /// </summary>
        /// <value>The targeted sentiment to analyze.</value>
        [JsonProperty("targets", NullValueHandling = NullValueHandling.Ignore)]
        public List<TargetedSentimentResults> Targets { get; set; }
    }

}
