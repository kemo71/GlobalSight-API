namespace GlobalSightLib
{
	public class GlobalSightAPI
	{

        GS_API.AmbassadorService client;

        // E.g. https://myglobalsight.com/globalsight/services/AmbassadorWebService

        protected string GlobalSightApiUrl = "ENTER GLOBALSIGHT WEB SERVICE URL HERE";

        /// <summary>
        /// Constructor
        /// </summary>
        public GlobalSightAPI()
        {
            client = new GS_API.AmbassadorService();
            client.Url = GlobalSightApiUrl;
            client.Timeout = 300000;
        }


        /// <summary>
        /// Login to GlobalSight to authenticate further API calls
        /// This function must be called first
        /// </summary>
        /// <param name="username">GlobalSight username</param>
        /// <param name="password">GlobalSight password</param>
        /// <returns>An authentication code if successful, an empty string otherwise</returns>
        public string Login(string username, string password)
		{
			string authCode = string.Empty;
			if (! string.IsNullOrEmpty(username) && ! string.IsNullOrEmpty(password))
			{
                authCode = client.login(username, password);
            }
			return authCode;
		}


		/// <summary>
		/// This method is used for getting the GlobalSight server version
		/// </summary>
		/// <param name="AuthenticationToken">The authentication token returned from Login()</param>
		/// <returns>The GlobalSight server version</returns>
		public string GetServerVersion(string AuthenticationToken)
		{
			return client.getServerVersion(AuthenticationToken);
		}


        // Add other functions here based on the Web Service Documentation
        // ...
        // http://www.globalsight.com/wiki/index.php/GlobalSight_Web_Services_API

	}
}