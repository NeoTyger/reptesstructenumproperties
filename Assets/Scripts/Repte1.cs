using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Repte1 : MonoBehaviour
{

    public Item itemC;
    
    // Start is called before the first frame update
    void Start()
    {
        itemC = new Item("Uno", 1, "Joc de cartes");
        ItemS.itemName = "Monopoly";
        ItemS.itemId = 2;
        
        ChangeNameItem(itemC, "Virus");
        ChangeNameItem(iS:Item, "Virus" );
    }

    public struct ItemS
    {
        public string itemName;
        public int itemId;
    }

    public void ChangeNameItem(ItemS iS, string s)
    {
        iS.itemName = s;
    }
    
    public void ChangeNameItem(Item itemC, string s)
    {
        itemC.itemName = s;
    }
}
