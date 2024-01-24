using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item_interact : MonoBehaviour
{
    public string name;
    public ParticleSystem explosionEffect;
    
    public GameController gameController;

    public void CheckIfItem()
    { 
        foreach(TextMeshProUGUI itemName in gameController.itemList)
        {
            if(name == itemName.text)
            {
                gameController.itemCount++;
                itemName.color = Color.green;
                this.gameObject.SetActive(false);
                Instantiate(explosionEffect, this.transform.position, explosionEffect.transform.rotation);

            }
        }

        if(gameController.itemCount == gameController.itemList.Count)
        {
            Debug.Log("Yeaah");
        }

    }
}
