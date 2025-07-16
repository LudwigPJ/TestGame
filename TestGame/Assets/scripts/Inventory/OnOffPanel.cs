using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.UI;

public class OnOffPanel : MonoBehaviour
{
    [SerializeField] private Button inventoryButton;
    [SerializeField] private GameObject inventoryPanel;
    

   
    public void Panel()
    {
        if(inventoryPanel != null)
        {
            bool isAvtive = inventoryPanel.activeSelf;
            inventoryPanel.SetActive(!isAvtive);
        }

    }
}
