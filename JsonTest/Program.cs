using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Serialization;

namespace JsonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //PutIn put=new PutIn();
            var User = new {UserName = "张三", Userage = 22};
            var serializerSettings = new JsonSerializerSettings
            {
                // 设置为驼峰命名
                ContractResolver = new CamelCasePropertyNamesContractResolver()
                ////设置为默认命名
                //ContractResolver = new DefaultContractResolver()
            };
            var userStr = JsonConvert.SerializeObject(User, Formatting.None, serializerSettings);
            Console.WriteLine(JsonConvert.DeserializeObject(userStr));
            Console.ReadLine();
        }
    }
}
