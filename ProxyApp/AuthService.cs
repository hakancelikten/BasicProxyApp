public class AuthService
{
    private readonly TokenManager _tokenManager;

    public AuthService(TokenManager tokenManager)
    {
        _tokenManager = tokenManager;
    }

    public void Login(string userId, string password)
    {
        // Örneğin API'den token alınıyor
        string token = AuthenticateWithExternalApi(userId, password);

        // Token'ı bellek üzerinde saklıyoruz
        _tokenManager.AddToken(userId, token);
    }

    private string AuthenticateWithExternalApi(string userId, string password)
    {
        // API'ye istekte bulunup token alındığını varsayalım
        // Bu örnek için sahte bir token döndürüyoruz
        return "sample-jwt-token";
    }
}

