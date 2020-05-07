namespace ModernWebStores.SharedKernel.Helpers
{
    public class StringHelper
    {
        public static string Encrypt(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            value += "|54be1d80-b6d0-45c0-b8d7-13b3c7898729d";
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] data = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(value));
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("X2"));
            }

            return stringBuilder.ToString();

        }
    }
}
