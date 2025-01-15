using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using DotNetEnv;

namespace AndGate
{
    public class And_Gate
    {
        private bool input1;
        private bool input2;
        private string envImageUrl;
        private string saveFolderPath;  // Add a field to store the folder path

        // Public constructor to allow instantiation from outside
        public And_Gate(bool input1, bool input2, private string envImageUrl, private string saveFolderPath = "Images")
        {
            this.input1 = input1;
            this.input2 = input2;
            this.envImageUrl = envImageUrl;
            this.saveFolderPath = saveFolderPath;

            // Load environment variables from the .env file
            Env.Load();
            
            // Conditionally create the folder if it doesn't exist
            if (!Directory.Exists(saveFolderPath))
            {
                Directory.CreateDirectory(saveFolderPath);
                Console.WriteLine($"Directory '{saveFolderPath}' created.");
            }
            else
            {
                Console.WriteLine($"Directory '{saveFolderPath}' already exists.");
            }
        }

        // Public method to download the image bytes asynchronously
        public async Task DownloadImageBytesAsync()
        {
            // Get the GitHub token from the .env file
            string githubToken = Env.GetString("GITHUB_TOKEN");

            // Download the raw image bytes from the URL in the env variable
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Add the Authorization header with the GitHub token
                    client.DefaultRequestHeaders.Authorization = new Http.Headers.AuthenticationHeaderValue("Bearer", githubToken);

                    // Get the raw byte array from the image URL
                    byte[] imageBytes = await client.GetByteArrayAsync(envImageUrl);

                    // Extract the file name from the URL
                    string fileName = Path.GetFileName(new Uri(envImageUrl).AbsolutePath);

                    // Combine the folder path and the file name to get the full path
                    string filePath = Path.Combine(saveFolderPath, fileName);

                    // Save the image to the specified folder
                    await File.WriteAllBytesAsync(filePath, imageBytes);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error downloading the image: {ex.Message}");
                }
            }
        }
    }
}




