using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_store
{
    public class Message
    {
        public int Number { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }

        public Message(int number, string text, DateTime dateTime)
        {
            Number = number;
            Text = text;
            DateTime = dateTime;
        }

        public override string ToString()
        {
            return $"#{Number} | {DateTime:dd.MM.yyyy} | {DateTime:HH:mm:ss}{Environment.NewLine}{Text}";
        }
    }

}
