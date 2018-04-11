using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insta2Telegram
{
    class Telegrambot
    {
        public bool ok { get; set; }
        public Result result { get; set; }
        public int error_code { get; set; }
        public string description { get; set; }
    }
    public class Result
    {
        public int id { get; set; }
        public bool is_bot { get; set; }
        public string first_name { get; set; }
        public string username { get; set; }
    }
    
}
