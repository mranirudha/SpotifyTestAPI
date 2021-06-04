using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SpotifyAPI.Spotify
{
    [TestClass]
    public class SpotifyAPITest
    {

        public string baseURL = "https://api.spotify.com/v1/users/w33b16ku5vfwikezvisjp41fc/playlists";

        public string accessToken = "Bearer BQCVtSTY8jTTx9ifmijAG0rAF4ehSM1xBSQ7H7sOaqyaxtqyc3yQCGbFWMpuo5TTg4cR_6zdR9oG9h9VcXi5w6e1FcTa1dd1Aqu1tKRj4i_1bpwFsmXjsCrLSZ7yao_5pFj00CDjiLjFdhmmeYfstxkPEdGzkXEHLM4gNCM35G-_J9q9z76vB4VtCGmeea-BjGguyA25FFpAYPnmH3IKikj9U9ljA-CLSBf5JMJ0BCIe";

        // public int portNumber = 3030;

        // public string endPoint = "/playlists";

        //public string requesturl;

        IRestClient restclient;

        [TestInitialize]

        public void testSetup()
        {

            restclient = new RestClient();
        }

        [TestMethod]
        public void createPlayList()
        {
            IRestRequest request = new RestRequest(baseURL);
            request.AddHeader("Authorization", accessToken);
            //request.AddJsonBody("{\"name\":\"MyPlayList\"}");
            request.AddJsonBody("{\"name\":\"Anirudha_Sahoo1\"}");
            IRestResponse response = restclient.Post(request);
            //Console.WriteLine(response.Content);
            Assert.AreEqual(HttpStatusCode.Created, response.StatusCode);

        }


     }
}
