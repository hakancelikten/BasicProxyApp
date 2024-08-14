public class SomeApiService
{
    private readonly TokenManager _tokenManager;

    public SomeApiService(TokenManager tokenManager)
    {
        _tokenManager = tokenManager;
    }

    public void CallApi(string userId)
    {
        // Bellekten token'ı alıyoruz
        string token = _tokenManager.GetToken(userId);

        if (token == null)
        {
            Console.WriteLine("Token bulunamadı. Kullanıcı önce giriş yapmalı.");
            return;
        }

        // Token'ı kullanarak API'ye istek atıyoruz.
        Console.WriteLine($"API isteği yapılıyor. Kullanılan token: {token}");
    }
}

