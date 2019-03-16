using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoMod;
using UnityEngine;

namespace LaMulana2Randomizer.Core.MonoModPatches
{
    public class patch_TreasureBoxScript : TreasureBoxScript
    {
        public extern void orig_openBox();
        string itemToReplaceName;
        string itemToInsertName;
        public void openBox()
        {
            if(this.itemObj != null)
            {
                AbstractItemBase component = this.itemObj.GetComponent<AbstractItemBase>();
                if (component.name.Contains(itemToReplaceName) && Enum.IsDefined(typeof(ItemDatabaseSystem.ItemNames), itemToInsertName))
                {
                    component.setItemParameter(itemToInsertName, 1);
                    Sprite mapIconSprite = L2SystemCore.getMapIconSprite(L2SystemCore.getItemData((ItemDatabaseSystem.ItemNames)Enum.Parse(typeof(ItemDatabaseSystem.ItemNames), itemToInsertName)));
                    this.itemObj.GetComponent<SpriteRenderer>().sprite = mapIconSprite;
                }
            }
            base.openBox();
        }
    }
}
