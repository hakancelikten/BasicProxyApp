public class TokenManager
{
    private readonly Dictionary<string, string> _tokens = new Dictionary<string, string>();

    // Token ekleme metodu
    public void AddToken(string userId, string token)
    {
        if (_tokens.ContainsKey(userId))
        {
            _tokens[userId] = token;
        }
        else
        {
            _tokens.Add(userId, token);
        }
    }

    // Token alma metodu
    public string GetToken(string userId)
    {
        return _tokens.ContainsKey(userId) ? _tokens[userId] : null;
    }

    // Token silme metodu
    public void RemoveToken(string userId)
    {
        if (_tokens.ContainsKey(userId))
        {
            _tokens.Remove(userId);
        }
    }
}

