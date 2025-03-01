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
        
    }

    // Update is called once per frame

    public void LoadCard() {
        nameCard.text = formCard.name;
        iconCard.sprite = formCard.cardImage;
    }
    void Update()
    {
        
    }
}
