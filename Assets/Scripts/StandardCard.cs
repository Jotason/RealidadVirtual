using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class StandardCard : MonoBehaviour
{
    public TextMeshProUGUI nameCard;
    public Image iconCard;
    public ScriptableCards formCard;
    



    // Update is called once per frame

    public void LoadCard() {
        nameCard.text = formCard.name;
        iconCard.sprite = formCard.cardImage;
    }
    public void CreateObject() {
        //GameObject objeto = Instantiate(formCard.obj3D);
        //objeto.transform.position = new Vector3(0,0,2);


        GameObject _objeto = Instantiate(formCard.obj3D);
        _objeto.transform.position = _objeto.transform.forward * 2.0f;


        GameManager _gamemanager = GameObject.FindObjectOfType<GameManager>();
        _gamemanager.DestroyCurrObject();
        _gamemanager.curr3DObject = _objeto;
        _gamemanager.currScriptable = formCard;
    }
}
