namespace IO.Swagger.Services
{
    /// <summary>
    ///IJwtTokenService
    /// </summary>
    public interface IJwtTokenService
    {
        /// <summary>
        //GenerateToken
        /// </summary>
        string GenerateToken(string username);
    }
}
