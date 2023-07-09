namespace Application.Common.Models.Auth
{
    public class TwoFactorGeneratedDto
    {
        public byte[] OrCodeImage { get; set; }
        public string Key { get; set; }
    }
}
