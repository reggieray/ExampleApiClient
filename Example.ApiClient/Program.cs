using System;
using System.Threading;
using System.Threading.Tasks;

namespace Example.ApiClient
{
    class Program
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static async Task Main(string[] args)
        {
            try
            {
                using (var cancelSrc = new CancellationTokenSource())
                {
                    var response = await ApiClient.GetAsync<Todo>($"https://jsonplaceholder.typicode.com/todos/3", cancelSrc.Token);
                    Console.WriteLine($"response: {response}");
                }
            }
            catch (ApiException apiEx)
            {
                Console.WriteLine(apiEx.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
