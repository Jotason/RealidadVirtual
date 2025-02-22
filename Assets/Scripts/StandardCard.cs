using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.UI;
using UnityEngine.UI;

public class StandardCard : MonoBehaviour
{
    public TextMeshProUGUI nameCard;
    public Image iconCard;
    public ScriptableCards formCard;
    // Start is called before the first frame update
    void Start()
    {
        nameCard.text = formCard.name;
        iconCard.sprite = formCard.cardImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
