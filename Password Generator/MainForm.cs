using System.Diagnostics;
using System.Net;
using System.Text.Json;

namespace Password_Generator
{
    public partial class MainForm : Form
    {
        public static int PasswordLength = 15;
        public static bool IncludeSymbols = true;
        public static bool IncludeNumbers = true;
        public static bool Upload = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SettingsBtn_Click(object sender, EventArgs e)
        {
            var openForm = new Settings();
            openForm.Show();
        }
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("GENERATING: Password Length = " + PasswordLength + " | Include Symbols = " + IncludeSymbols + " | Include Numbers = " + IncludeNumbers + " | Upload Password = " + MainForm.Upload);
            var random = new Random();
            var stringChars = new char[PasswordLength];
            var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            if (IncludeNumbers) characters += "0123456789";
            if (IncludeSymbols) characters += "!@#$^*_+-=~`|()/{}[]!@#$^*_+-=~`|()/{}[]";
            
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = characters[random.Next(characters.Length)];
            }

            PasswordBox.Text = new String(stringChars);
            if (Upload) UploadPassword();
        }

        private void UploadPassword()
        {
            string url = "https://onetimesecret.com/api/v1/share";
            string secret = PasswordBox.Text;
            int ttl = 300;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            string authInfo = "username:apikey";//redacted
            authInfo = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authInfo));
            request.Headers["Authorization"] = "Basic " + authInfo;
            string requestBody = $"secret={secret}&ttl={ttl}";
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(requestBody);
            request.ContentLength = bytes.Length;

            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Length);
            }

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
                    string responseText = reader.ReadToEnd();
                    Debug.WriteLine(responseText);

                    JsonDocument jsonResponse = JsonDocument.Parse(responseText);
                    string secretKey = jsonResponse.RootElement.GetProperty("metadata_key").GetString();

                    System.Diagnostics.Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://onetimesecret.com/private/" + secretKey,
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to upload password");
            }
        }
    }
}