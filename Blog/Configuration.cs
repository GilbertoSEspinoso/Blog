namespace Blog;

public static class Configuration
{
    public static string JwtKey = "NmYwYzA0ZDItMjE4Ny00YTA1LWI4YmItNzg2Yzc2ODI0OWM1=";
    public static string ApiKeyName = "api_key";
    public static string Apikey = "curso_api_IlTevUM/z0ey3NwCV/unWg==";
    public static SmtpConfiguration Smtp = new();

    //envio de email
    public class SmtpConfiguration
    {
        public string Host { get; set; } = string.Empty;
        public int Port { get; set; } = 25;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}