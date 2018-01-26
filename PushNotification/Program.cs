using FCM.Net;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PushNotification
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync();
        }
        static async Task MainAsync()
        {
            var registrationId = " cEj3FWibEaE:APA91bEy0xZZM_O7ly2cVMes_bi6vkYg9YdLhRuS6tjUHNa7M5Xhe_G2e1x3d_ZJDkDYzXXUUCs-G8qNs_qsXpYFuvP7tKjoq_sX_llqKp73oM4B5-LbYSFZGqhIKw2YDLT45MoV0LHL";

            using (var sender = new Sender("AAAAoBuDsuI:APA91bEavogCZlE5MBsIJC5LgJUQ8DPgQMbBVc01-YMwTe_rQxA-zCb3dMC2mgQe2zNMUp6S69ITlOZ1vsKhkGLB0WS1gNHJAuITb0fzFzab1SyJOkN0qitsM67jY6ngDZMscEUE15Np"))
            {
                try
                {
                    var message = new Message
                    {
                        RegistrationIds = new List<string> { registrationId },
                        Notification = new Notification
                        {
                            Title = "Mensaje de Título",
                            Body = "Mensaje de Cuerpo",
                            Icon = "",
                            Sound = ""

                        }
                    };
                    var result = sender.SendAsync(message);
                    //Console.WriteLine($"Success: {result.MessageResponse.Success}");

                    Console.ReadKey();
                    //var json = "{\"notification\":{\"title\":\"json message\",\"body\":\"works like a charm!\"},\"to\":\"" + registrationId + "\"}";
                    //result = sender.SendAsync(json);
                    Console.WriteLine($"Success: {result.IsCompleted}");

                    Console.ReadKey();
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }
    }
}
