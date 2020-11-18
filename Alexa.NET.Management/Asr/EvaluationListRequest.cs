using System;
using System.Collections.Generic;
using System.Text;
using VoicifyAlexa.NET.Management.Api;
using Refit;

namespace VoicifyAlexa.NET.Management.Asr.Evaluations
{
    public class EvaluationListRequest
    {
        [AliasAs("annotationSetId")]
        public string AnnotationSetId { get; set; }

        [AliasAs("locale")]
        public string Locale { get; set; }

        [AliasAs("maxResults")]
        public int MaxResults { get; set; }

        [AliasAs("stage")]
        public SkillStage? Stage { get; set; }

        [AliasAs("nextToken")]
        public string NextToken { get; set; }
    }
}
