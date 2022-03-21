using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace test_321
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //封裝
            //Car car123 = new Car();
            //car123.ShowInfo();

            //繼承
            //Car car123 = new CarA();
            //car123.ShowInfo();

            //練習使用 HttpClient 物件
            //await MyHttpClientAsync();

            /*猜數字遊戲
            int input;
            int x;
            Random xx = new Random();
            x = xx.Next(1, 100);
            int i = 1;
            while (i < 2)
            {
                Console.WriteLine("猜數字遊戲(請輸入數字1-100)");
                input = int.Parse(Console.ReadLine());
                if (input == x)
                {
                    Console.WriteLine("猜對了!!!");
                    i++;
                }
                else
                {
                    if(input > x)
                    {
                        Console.WriteLine("猜錯了，再小一點");
                    }
                    else
                    {
                        Console.WriteLine("猜錯了，再大一點");
                    }
                    
                }
            }
            */
            

        }

        /*練習使用 HttpClient 物件
        static private async Task MyHttpClientAsync()
        {

            HttpClient client = new HttpClient();
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        */
    }
}
