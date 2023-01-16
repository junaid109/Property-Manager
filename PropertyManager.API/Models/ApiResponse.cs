using System.Net;

namespace PropertyManager.API.Models
{
	public class ApiResponse
	{
		public HttpStatusCode StatusCode { get; set; }
		public bool isSuccess
		{
			get; set;
		}
		
		public List<string> Messages { get; set; }

		public object Result { get; set; }


	}
}
