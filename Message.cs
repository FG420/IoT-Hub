using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_IoT
{
    internal class Message
    {
        public Int32 id {  get; set; }
        public String textMessage { get; set; }
        public DateTime date {  get; set; }
        public String receiverId { get; set; }
        public Boolean received { get; set; }

    }
}
