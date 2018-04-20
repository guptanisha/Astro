using Astrowebapp.Models;
using Astrowebapp.Persistence;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using static Astrowebapp.Models.FromAstroDescription;
using static Astrowebapp.Models.ChannelDescription;

namespace Astrowebapp.Controllers
{
    public class HomeController : Controller
    {
       

        //Hosted web API REST Service base url  
        string Baseurl = "http://ams-api.astro.com.my/";
        public async Task<ActionResult> Index()
        {

            List<Description> EmpInfo = new List<Description>();
            FromAstroDescription EmpInfo2 = new FromAstroDescription();
            FromAstroImages Images = new FromAstroImages();
            using (var client = new HttpClient())
            {
                //Passing service base url  s
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllChannels using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("/ams/v3/getChannels");



                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Channel list  
                    JavaScriptSerializer ser = new JavaScriptSerializer();

                    var r = ser.Deserialize<List<Description>>(EmpResponse);
                    //EmpInfo = JsonConvert.DeserializeObject<List<Channellist>>(EmpResponse);


                    EmpInfo2 = ser.Deserialize<FromAstroDescription>(EmpResponse);//str is JSON string.
                    Images = ser.Deserialize<FromAstroImages>(EmpResponse);//str is JSON string.
                }
                //returning the Channel list to view  
                return View(EmpInfo2);
            }
        }
        public async Task<ActionResult> About()
        {
            //List<Description> EmpInfo = new List<Description>();
            FromAstroDescription EmpInfo2 = new FromAstroDescription();
            FromAstroImages Images = new FromAstroImages();
            using (var client = new HttpClient())
            {
                //Passing service base url  s
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllChannels using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("/ams/v3/getChannels");



                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Channel list  
                    JavaScriptSerializer ser = new JavaScriptSerializer();

                    var r = ser.Deserialize<List<Description>>(EmpResponse);
                    //EmpInfo = JsonConvert.DeserializeObject<List<Channellist>>(EmpResponse);


                    EmpInfo2 = ser.Deserialize<FromAstroDescription>(EmpResponse);//str is JSON string.
                    Images = ser.Deserialize<FromAstroImages>(EmpResponse);//str is JSON string.
                }
                //returning the Channel list to view  
                return View(EmpInfo2);
            }
        }
        public async Task<ActionResult> Description() //description
        {
            //var channeldescription = description.channelDescription;
            //var channelId = channelid;
            Description EmpInfo3 = new Description();
            FromAstroImages Images = new FromAstroImages();
            List<Description> des = new List<Description>();
            FromAstroDescription EmpInfo2 = new FromAstroDescription();

            //List<Description> descr = EmpInfo3.channelDescription.Where(emp => emp.channelId == channelid).ToList();

            
          
          

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllChannels using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("/ams/v3/getChannels");



                //Checking the response is successful or not which is sent using HttpClient
                if (Res.IsSuccessStatusCode)
                    {
                        //Storing the response details recieved from web api   
                        var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                        //Deserializing the response recieved from web api and storing into the Channel list  
                        JavaScriptSerializer ser = new JavaScriptSerializer();

                        var r = ser.Deserialize<List<Description>>(EmpResponse);
                        //EmpInfo = JsonConvert.DeserializeObject<List<Channellist>>(EmpResponse);


                        EmpInfo2 = ser.Deserialize<FromAstroDescription>(EmpResponse);//str is JSON string.
                       
                        Images = ser.Deserialize<FromAstroImages>(EmpResponse);//str is JSON string.
                    }
                //returning the Channel list to view
                return View(EmpInfo2);
            }
        }
        public async Task<ActionResult> channels(GetChanneltitles description,string channelname,string sortOrder)
        {
            FromAstroDescription EmpInfo2 = new FromAstroDescription();
            FromAstroImages Images = new FromAstroImages();
            using (var client = new HttpClient())
            {
                //Passing service base url  s
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetAllChannels using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("/ams/v3/getChannels");



                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var EmpResponse = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Channel list  
                    JavaScriptSerializer ser = new JavaScriptSerializer();

                    var r = ser.Deserialize<List<Description>>(EmpResponse);
                    //EmpInfo = JsonConvert.DeserializeObject<List<Channellist>>(EmpResponse);


                    EmpInfo2 = ser.Deserialize<FromAstroDescription>(EmpResponse);//str is JSON string.
                    Images = ser.Deserialize<FromAstroImages>(EmpResponse);//str is JSON string.

                    // Convert sort order
                    ViewBag.NameSort = sortOrder == "Name" ? "Name_desc" : "Name";



                    //switch (sortOrder)
                    //{
                    //    case "Name_desc":
                    //        model = model.OrderByDescending(t => t.d);
                    //        break;
                    //    case "Name":
                    //        model = modelOrderBy(t => t.UserName);
                    //        break;
                    //}
                }
                //returning the Channel list to view  
                return View(EmpInfo2);
            }
        }
    }
}