using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    
    public ScriptableCards currScriptable = null;
    
    public GameObject curr3DObject = null;

    private void Start()
    {
        if (instance == null || instance != this)
        {
            instance = this;
        }
        else { 
            Destroy(gameObject);
        }
    }

    public void DestroyCurrObject() { 
    
    Destroy(curr3DObject);
        currScriptable = null;
        curr3DObject=null;
    }


    public void TakeScreenShot() {
        ScreenCapture.CaptureScreenshot("Capture.png");
    }
}
