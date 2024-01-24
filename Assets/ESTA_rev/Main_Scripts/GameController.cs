using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{

    public static GameController Instance;
    public List<TextMeshProUGUI> itemList = new List<TextMeshProUGUI>();
    [SerializeField] public int itemCount = 0;


    public void Awake()
    {

        if(Instance!=null)
        {
            Destroy(this.gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    private void CheckForGameWin()
    {

    }
}
