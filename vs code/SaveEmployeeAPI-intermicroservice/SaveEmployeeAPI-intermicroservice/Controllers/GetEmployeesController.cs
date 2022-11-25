using FirstAPIProj.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace SaveEmployeeAPI_intermicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetEmployeesController : ControllerBase
    {

        [HttpGet("Employee")]
        public async Task<List<EmployeeTable>> GetEmployee()
        {

            string Baseurl = "https://localhost:7212/";
            List<EmployeeTable> EmployeeInfo = new List<EmployeeTable>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllEmployees using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/Companies");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmployeeResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    EmployeeInfo = JsonConvert.DeserializeObject<List<EmployeeTable>>(EmployeeResponse);
                    return EmployeeInfo;
                }
                else
                {
                    return null;
                }

            }
        }
    }
}
