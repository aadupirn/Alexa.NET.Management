﻿using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using VoicifyAlexa.NET.Management.Nlu.AnnotationSet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace VoicifyAlexa.NET.Management.Tests
{
    public class NluAnnotationSetTests
    {
        [Fact]
        public async Task CreateGeneratesCorrectRequestAndResponse()
        {
            var locale = "en-GB";
            var name = "testSet";

            var management = new ManagementApi("xxx", new ActionHandler(async req =>
            {
                Assert.Equal(HttpMethod.Post, req.Method);
                Assert.Equal("/v1/skills/skillId/nluAnnotationSets", req.RequestUri.PathAndQuery);
                var requestcontent = await req.Content.ReadAsStringAsync();
                var request = JsonConvert.DeserializeObject<CreateAnnotationSetRequest>(requestcontent);
                Assert.Equal(locale, request.Locale);
                Assert.Equal(name, request.Name);

                var json = new JObject(new JProperty("id", "abcdef")).ToString();
                var response = new HttpResponseMessage(HttpStatusCode.Created)
                {
                    Content = new StringContent(json)
                };
                response.Headers.Location = new Uri("http://test.com/example", UriKind.Absolute);
                return response;
            }));

            var setresponse = await management.Nlu.AnnotationSets.Create("skillId", locale, name);
            Assert.Equal("http://test.com/example", setresponse.Location.ToString());
            Assert.Equal("abcdef", setresponse.Id);
        }

        [Fact]
        public async Task ListCreatesCorrectRequestAndResponse()
        {
            var management = new ManagementApi("xxx", new ActionHandler( req =>
            {
                Assert.Equal(HttpMethod.Get, req.Method);
                Assert.Equal("/v1/skills/skillId/nluAnnotationSets?locale=en-GB&maxResults=2", req.RequestUri.PathAndQuery);
            }, Utility.ExampleFileContent<ListAnnotationSetResponse>("AnnotationSetResponse.json")));

            var response = await management.Nlu.AnnotationSets.List("skillId", "en-GB", 2);
            var set = Assert.Single(response.AnnotationSets);
            Assert.Equal("fromjson", set.Name);
            Assert.Equal(0, set.NumberOfEntries);
            Assert.Equal("en-GB", set.Locale);
        }

        [Fact]
        public async Task UpdateCreatesCorrectRequestAndResponse()
        {
            var management = new ManagementApi("xxx", new ActionHandler(async req =>
            {
                Assert.Equal(HttpMethod.Post, req.Method);
                Assert.Equal("/v1/skills/skillId/nluAnnotationSets/fromjson/annotations", req.RequestUri.PathAndQuery);
                var content = await req.Content.ReadAsStringAsync();
                var response = JsonConvert.DeserializeObject<AnnotationSet>(content);
                Assert.True(Utility.CompareJson(response,"AnnotationSet.json", "referenceTimestamp"));
            }));

            await management.Nlu.AnnotationSets.Update("skillId", "fromjson",
                Utility.ExampleFileContent<AnnotationSet>("AnnotationSet.json"));
        }

        [Fact]
        public async Task GetCreatesCorrectRequestAndResponse()
        {
            var management = new ManagementApi("xxx", new ActionHandler(req =>
            {
                Assert.Equal(HttpMethod.Get, req.Method);
                Assert.Equal("application/json",req.Headers.Accept.First().MediaType);
                Assert.Equal("/v1/skills/skillId/nluAnnotationSets/fromjson/annotations", req.RequestUri.PathAndQuery);
            }, Utility.ExampleFileContent<AnnotationSet>("AnnotationSet.json")));

            var result = await management.Nlu.AnnotationSets.Get("skillId", "fromjson");
            Assert.Equal(5, result.Data.Length);
            var annotation = result.Data.First();
        }

        [Fact]
        public async Task RenameCreatesCorrectRequestAndResponse()
        {
            var management = new ManagementApi("xxx", new ActionHandler(async req =>
            {
                Assert.Equal(HttpMethod.Put, req.Method);
                Assert.Equal("/v1/skills/skillId/nluAnnotationSets/abcdef/properties", req.RequestUri.PathAndQuery);

                var content = await req.Content.ReadAsStringAsync();
                var contentjson = JObject.Parse(content);
                Assert.Equal("newjson", contentjson.Value<string>("name"));

            },HttpStatusCode.Created));

            await management.Nlu.AnnotationSets.Rename("skillId", "abcdef","newjson");
        }

        [Fact]
        public async Task GetPropertiesCreatesCorrectRequestAndResponse()
        {
            var management = new ManagementApi("xxx", new ActionHandler(req =>
            {
                Assert.Equal(HttpMethod.Get, req.Method);
                Assert.Equal("/v1/skills/skillId/nluAnnotationSets/abcdef/properties", req.RequestUri.PathAndQuery);
            }, Utility.ExampleFileContent<AnnotationSetProperties>("AnnotationSetProperties.json")));

            var result = await management.Nlu.AnnotationSets.GetProperties("skillId", "abcdef");
            Assert.Equal("abcdef", result.AnnotationId);
            Assert.Equal("fromjson",result.Name);
            Assert.Equal(0,result.NumberOfEntries);
            Assert.Equal("en-GB", result.Locale);
        }

        [Fact]
        public async Task DeleteCreatesCorrectRequestAndResponse()
        {
            var management = new ManagementApi("xxx", new ActionHandler(req =>
            {
                Assert.Equal(HttpMethod.Delete, req.Method);
                Assert.Equal("/v1/skills/skillId/nluAnnotationSets/abcdef", req.RequestUri.PathAndQuery);
            }, HttpStatusCode.NoContent));

            await management.Nlu.AnnotationSets.Delete("skillId", "abcdef");
        }

    }
}
