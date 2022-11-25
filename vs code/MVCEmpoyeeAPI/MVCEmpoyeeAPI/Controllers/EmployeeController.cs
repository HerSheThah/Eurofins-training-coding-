using FirstAPIProj.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MVCEmpoyeeAPI.Controllers
{
    public class EmployeeController: Controller
    {
       

        string Baseurl = "https://localhost:7212/";
        public async Task<ActionResult> Index()
        {
            List<EmployeeTable> EmpInfo = new List<EmployeeTable>();

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
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    EmpInfo = JsonConvert.DeserializeObject<List<EmployeeTable>>(EmpResponse);

                }
                //returning the employee list to view  
                return View(EmpInfo);
            }
        }

        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AddEmployee(EmployeeTable e)
        {
            EmployeeTable Emplobj = new EmployeeTable();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(e), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync(Baseurl+"api/Companies", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Emplobj = JsonConvert.DeserializeObject<EmployeeTable>(apiResponse);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> UpdateEmployee(int id)
        {
            EmployeeTable emp = new EmployeeTable();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(Baseurl+"api/Companies/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    emp = JsonConvert.DeserializeObject<EmployeeTable>(apiResponse);
                }
            }
            return View(emp);
        }

        [HttpPost]
        public async Task<ActionResult> UpdateEmployee(EmployeeTable e)
        {
            EmployeeTable receivedemp = new EmployeeTable();

            using (var httpClient = new HttpClient())
            {
                #region
                //var content = new MultipartFormDataContent();
                //content.Add(new StringContent(reservation.Empid.ToString()), "Empid");
                //content.Add(new StringContent(reservation.Name), "Name");
                //content.Add(new StringContent(reservation.Gender), "Gender");
                //content.Add(new StringContent(reservation.Newcity), "Newcity");
                //content.Add(new StringContent(reservation.Deptid.ToString()), "Deptid");
                #endregion
                int id = e.Empid;
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(e), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PutAsync(Baseurl + "api/Companies/" + id, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ViewBag.Result = "Success";
                    receivedemp = JsonConvert.DeserializeObject<EmployeeTable>(apiResponse);
                }
            }
            return RedirectToAction("index");
        }




        [HttpGet]
        public async Task<ActionResult> DeleteEmployee(int id)
        {
            TempData["empid"] = id;
            EmployeeTable e = new EmployeeTable();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(Baseurl + "api/Companies/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    e = JsonConvert.DeserializeObject<EmployeeTable>(apiResponse);
                }
            }
            return View(e);
        }


        [HttpPost]
        [ActionName("DeleteEmployee")]
        public async Task<ActionResult> DeleteEmployeeConfirmed(int id)
        {
            int empid = Convert.ToInt32(TempData["empid"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync(Baseurl + "api/Companies/" + empid))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("Index");
        }






    }
}
