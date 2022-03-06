using System.Text.Json.Serialization;
namespace BlazorApp.Shared
{
    public class Greeting
    {
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public string Message { get; set; }
        public Guid Id { get; set; } = Guid.NewGuid();
        public int? InvoiceId { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string? Preview { get; set; }

        public Greeting()
        {

        }

        /// <summary>
        /// Makes a greeting with current date and time and a new guid
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="message"></param>
        public Greeting(string from, string to, string message)
        {
            From = from;
            To = to;
            Message = message;
        }


        /// <summary>
        /// Makes a greeting with specified guid and current date and time
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="message"></param>
        /// <param name="id"></param>
        public Greeting(string from, string to, string message, Guid id)
        {
            From = from;
            To = to;
            Message = message;
            Id = id;
        }
        /// <summary>
        /// Makes a greeting with a new guid.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="message"></param>
        /// <param name="timestamp"></param>
        public Greeting(string from, string to, string message, DateTime timestamp)
        {
            From = from;
            To = to;
            Message = message;
            Timestamp = timestamp;
        }

        /// <summary>
        /// Makes a greeting with all properties specified.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="message"></param>
        /// <param name="id"></param>
        /// <param name="timestamp"></param>
        [JsonConstructorAttribute]
        public Greeting(string from, string to, string message, Guid id, DateTime timestamp)
        {
            Timestamp = timestamp;
            From = from;
            To = to;
            Message = message;
            Id = id;
        }
    }


    public class GreetingNewest : IComparer<Greeting>
    {
        public int Compare(Greeting? x, Greeting? y)
        {
            return -(x.Timestamp.CompareTo(y.Timestamp));
        }
    }
}