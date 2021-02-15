using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DPLT10.Pages
{
    public class ScheduleModel : PageModel
    {
        public class InputModel
        {
            public string Date { get; set; }
            public string Time { get; set; }
            public string Match { get; set; }
            public string Team1 { get; set; }
            public string vs { get; set; }
            public string Team2 { get; set; }
        }

        public List<InputModel> Schedules { get; set; }
        public void OnGet()
        {

            
            using (StreamReader r = new StreamReader("Schedule.json"))
            {
                string json = r.ReadToEnd();
                Schedules = Newtonsoft.Json.JsonConvert.DeserializeObject<List<InputModel>>(json);
            }
        }
        public void OnPost()
        {
     
           
        }
    }
}