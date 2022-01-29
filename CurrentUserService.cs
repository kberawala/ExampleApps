namespace ExampleApps
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string MyVariable
        {
            get
            {
                // get data as you need, e.g. from header or request object.
                return _httpContextAccessor.HttpContext.Request.Headers["MyVariable"].ToString();
            }
        }

        public string RemoteIpAddress
        {
            get
            {
                return _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
            }
        }
    }
}
