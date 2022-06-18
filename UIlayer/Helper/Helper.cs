namespace UIlayer.Helper
{
    public class UserApi{
        public HttpClient Initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:44398");
            return client;
        }
      }
}
