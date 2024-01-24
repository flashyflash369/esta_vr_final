using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportTo : MonoBehaviour
{
    public GameObject destinationArea;

    public void TeleportationTo()
    {
        this.transform.position = destinationArea.transform.position;
    }

}
