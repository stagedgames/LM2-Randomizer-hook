using LaMulana2Randomizer.Core.ItemEnums;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaMulana2Randomizer.Core
{

    public class ItemLocationHelper
    {
        private Dictionary<ItemEnum, ItemEnum> itemLocationDictionary;
        public ItemLocationHelper()
        {
            // format = LOCATION, ITEM
            this.itemLocationDictionary = new Dictionary<ItemEnum, ItemEnum>();
            foreach (ItemEnum item in Enum.GetValues(typeof (ItemEnum))){
                itemLocationDictionary.Add(item, item);
            }
            
        }
        public string getItemForLocation(string location)
        {
            var locationEnum = this.itemLocationDictionary.Single(x => x.Key.ToString() == location).Value;
            return locationEnum.GetAttributeOfType<DescriptionAttribute>().ToString();
        }
    }
}
