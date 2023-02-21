using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace InventoryManagement
{
    public class Fetchinventory
    {
        public InventoryDetails Read(string path)
        {
            using (StreamReader file=new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryDetails>(json);
                }catch(Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
