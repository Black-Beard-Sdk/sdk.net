using Bb.Curl.Commands;
using Flurl;
using System;

namespace Curl
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestUrlCombine()
        {
            Assert.AreEqual( Url.Combine("host", "segment1"), "host/segment1");
        }


        [TestMethod]
        public async Task ArgumentLineParser()
        {
            var payload = @"
curl -X 'POST' 'https://localhost:7033/Manager/mock/parcel/upload' \
-H 'accept: */*' \
-H 'Content-Type: multipart/form-data' \
-F 'upfile=@C:\Users\g.beard\Desktop\swagger.json;type=application/json'
";
            
            var args = payload.ParseCurlLine();
            var ctx = args.CallAsync();
            ctx.Wait();
            var result = ctx.Result;

            

        }

        //(https?|ftp|ssh|mailto):\/\/([a-z]+[a-z0-9.-]+|(\d{1,3}\.){3,3}\d{1,3})
        // (:\d{0,5})?
        // (\/[a-z]+[a-z0-9.-]+)*
    }
}