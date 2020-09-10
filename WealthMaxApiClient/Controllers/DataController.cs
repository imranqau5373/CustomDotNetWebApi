using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace WealthMaxApiClient.Controllers
{
    [AllowAnonymous]
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowOrigin")]
    public class DataController : ControllerBase
    {

        [HttpPost]
        public ReponseObject Post([FromBody]Command commandObj)

        {

            var client = new RestClient("https://crm.wealthmax.co.uk/api/api/values?title="+commandObj.title +
                "&firstname="+commandObj.firstname+
                "&middlename=" + commandObj.middlename +
                "&lastname=" + commandObj.lastname +
                "&nexIBO=" + commandObj.nexIBO +
                "&martial_status=" + commandObj.martial_status +
                "&email=" + commandObj.email +
                "&phone=" + commandObj.phone +
                "&lead_source_id=" + commandObj.lead_source_id +
                "&gender=Male" + commandObj.gender +
                "&mortgage=" + commandObj.mortgage +
                "&customer_isSmoker=" + commandObj.customer_isSmoker +
                "&annual_income=" + commandObj.annual_income +
                "&address1=Flat%201" + commandObj.address1 +
                "&address2=153%20Sutton%20Lane" + commandObj.address2 +
                "&city=Hounslow" + commandObj.city +
                "&county=Middlesex" + commandObj.county +
                "&country=United%20Kingdom" + commandObj.country +
                "&postcode=TW3%204JW" + commandObj.postcode +
                "&username=leads@nex-protect.co.uk" +
                "&password=joshi123" +
                "&apiKey=EuMysjk9YrW2rMYB4e5tt2Wxgs4NgkZV" +
                "&selected_products=" + commandObj.selected_products +
                "&date_of_birth=1991-12-13"+ commandObj.date_of_birth
                );
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "84dd05c8-8e34-40f7-b2aa-3cf7e7f16d2f");
            request.AddHeader("cache-control", "no-cache");
            IRestResponse response = client.Execute(request);
            var result = response.Content;
            var result = new ReponseObject() { }.ToString();
            return JsonConvert.DeserializeObject<ReponseObject>(result);
        }
    }
}
