namespace myApp.API.Helpers
{
    public class MessageParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int p = 10;
        public int PageSize
        {
            get { return p;}
            set { p = (value > MaxPageSize) ? MaxPageSize : value;}
        }
        public int UserId { get; set; }
        public string MessageContainer { get; set; } = "Unread";
    }
}