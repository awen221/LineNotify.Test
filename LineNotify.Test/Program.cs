namespace LineNotify.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Msg = "Test OK";
            try
            {
                {
                    var token = "";
                    var message = "測試訊息";
					
                    var api = new api();
                    var Result = api.notify(token, "GetResult" + message);
                    if (Result is null) throw new Exception("result is null");

                    Console.WriteLine($"GetResult：status={Result.status};message={Result.message}");
                }
            }
            catch (Exception ex)
            {
                Msg = $"FAIL：{ex.Message}";
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine(Msg);
                Console.WriteLine();
                Console.WriteLine("press any key to exit......");
                Console.ReadKey();
            }
        }
    }
}