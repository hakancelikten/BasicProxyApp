public class Program
{
    public static void Main(string[] args)
    {
        var tokenManager = new TokenManager();
        var authService = new AuthService(tokenManager);
        var apiService = new SomeApiService(tokenManager);

        // Kullanıcı girişi
        authService.Login("user123", "password");

        // API'ye token ile istek yapılıyor
        apiService.CallApi("user123");

        // Token'ı bellekten silebilirsiniz
        tokenManager.RemoveToken("user123");
    }
}