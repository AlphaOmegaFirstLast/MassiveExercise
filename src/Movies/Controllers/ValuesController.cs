using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Movies.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<string> Get(int id)
        {
            var massiveUserServiceClient = new MassiveUserService.UserServiceClient();
            var user = new MassiveUserService.User() { FirstName = "Suzette", LastName = "Antony", Password = "xxx123YYY", EmailAddress = "santony106@yahoo.com" };
            await massiveUserServiceClient.RegisterAsync(user);
            await massiveUserServiceClient.CloseAsync();
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<string> Post([FromBody]string value)
        {
            var massiveAuthClient = new MassiveAuthService.AuthenticationServiceClient();
            var accessToken = await massiveAuthClient.AuthenticateAsync(userName: "Suzette", password: "xxx123YYY");
            await massiveAuthClient.CloseAsync();
            return accessToken.Token;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<List<MassiveItemService.Item>> Put(int id, [FromBody]string value)
        {
            var massiveItemServiceClient = new MassiveItemService.ItemServiceClient()            
            var items = await massiveItemServiceClient.ListItemsAsync();
            await massiveItemServiceClient.CloseAsync();
            return items;
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            var massiveImageServiceClient = new MassiveImageService.ImageServiceClient();
            byte[] imageInBytes = new byte[5];
            var result = await massiveImageServiceClient.UploadImageAsync(imageInBytes);
            await massiveImageServiceClient.CloseAsync();
        }
    }
}
