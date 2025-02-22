using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableCard", menuName = "ScriptableCard")] 

public class ScriptableCards : ScriptableObject
{
    public int idCard;
    public string cardName;
    public string cardDescription;
    public Sprite cardImage;
    public GameObject obj3D;
}
