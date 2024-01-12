using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


[CreateAssetMenu(menuName="ScriptableObjects/Teleport")]
public class ScriptableTeleport : ScriptableObject
{
    public string name;
    public int teleportationAreaId;
    public TextMeshProUGUI teleportationAreaText;
}
