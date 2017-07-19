namespace GlobalSightLib
{
	public class GlobalSightAPI
	{

        GS_API.AmbassadorService client;

        // E.g. https://myglobalsight.com/globalsight/services/AmbassadorWebService

        protected string GlobalSightApiUrl = "http://10.41.16.180:9069/globalsight/services/AmbassadorWebService?wsdl";//ENTER GLOBALSIGHT WEB SERVICE URL HERE

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
			var x = client.getServerVersion(AuthenticationToken);
            return x;
        }

        public string tmFullTextSearch(string AuthenticationToken,string searchString,string translationMemoryName, string sourceLocale, string targetLocale, string dateType,string startDate, string finishDate,string companyName)
        {
            string result = client.tmFullTextSearch(AuthenticationToken, searchString, translationMemoryName, sourceLocale, targetLocale, dateType, startDate, finishDate, companyName);
            return result;
        }

        public string searchEntries(string AuthenticationToken, string tmProfileName, string searchText, string sourceLocale)
        {
            string result = client.searchEntries(AuthenticationToken, tmProfileName, searchText, sourceLocale);
            return result;
        }
        public void searchEntriesAsync(string AuthenticationToken, string tmProfileName, string searchText, string sourceLocale)
        {
            client.searchEntriesAsync(AuthenticationToken, tmProfileName, searchText, sourceLocale);
        }

        //public string searchEntriesOperationCompleted()
        //{
        //    client.searchEntriesCompleted();
        //}

        public string getAllTMProfiles(string AuthenticationToken)
        {
            string result = client.getAllTMProfiles(AuthenticationToken);
            return result;
        }

        public string uploadTmxFile(string AuthenticationToken, string fileName, string tmName, byte [] tmxAsBytes)
        {
            string result = client.uploadTmxFile(AuthenticationToken, fileName, tmName, tmxAsBytes);
            return result;
        }
        public void importTmxFile(string AuthenticationToken, string tmName, string syncMode)
        {
             client.importTmxFile(AuthenticationToken, tmName, syncMode);
        }
        

        // Add other functions here based on the Web Service Documentation
        // ...
        // http://www.globalsight.com/wiki/index.php/GlobalSight_Web_Services_API

    }
}