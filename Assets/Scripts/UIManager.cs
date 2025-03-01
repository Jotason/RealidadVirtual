using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject inventoryMenuPanel;

    public Action onMainMenu;
    public Action onInventoryMenu;

    void Start()
    {
        onMainMenu += OnMainMenu;
        onMainMenu += OnInventoryMenu;
    }

    public void OnMainMenu() {
        mainMenuPanel.SetActive(true);
        inventoryMenuPanel.SetActive(false);
    }
    public void OnInventoryMenu()
    {
        mainMenuPanel.SetActive(false);
        inventoryMenuPanel.SetActive(true);
        Debug.Log("vales monda");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
