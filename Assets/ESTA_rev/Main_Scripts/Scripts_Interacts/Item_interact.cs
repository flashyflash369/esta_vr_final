using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item_interact : MonoBehaviour
{
    public string name;
    public bool isItemCheck;
    public TextMeshProUGUI itemText;

    public GameController gameController;

    public void CheckIfItem()
    { 
        foreach(TextMeshProUGUI itemName in gameController.itemList)
        {
            if(name == itemName.text)
            {
                itemName.color = Color.green;
            }
        }

    }
}
