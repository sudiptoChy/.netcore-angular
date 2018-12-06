namespace myApp.API.Helpers
{
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int p = 10;
        public int PageSize
        {
            get { return p;}
            set { p = (value > MaxPageSize) ? MaxPageSize : value;}
        }
    }
} 