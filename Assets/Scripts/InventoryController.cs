using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
   
    public GameObject standardCardPrefab;
    public GameObject contentCard;

    public List<ScriptableCards> cardScriptable;

    //public ScriptableCards cardScriptable;
    void Start()
    {
       

        foreach (var card in cardScriptable)
        {
            GameObject _objTemp = Instantiate(standardCardPrefab, contentCard.transform);
            _objTemp.GetComponent<StandardCard>().formCard = card;
            _objTemp.GetComponent<StandardCard>().LoadCard();
        }

        

        

        //_objTemp.transform.parent = contentCard.transform;


        
    }

    
    void Update()
    {
        
    }
}
