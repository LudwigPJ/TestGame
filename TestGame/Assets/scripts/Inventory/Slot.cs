using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Slot : MonoBehaviour
{
    [SerializeField] private Image item;
    [SerializeField] private TMP_Text countText;
    

    public void SetItem(string id, int count)
    {
        item.sprite = Resources.Load<Sprite>("Icons/" + id);
        countText.text = count.ToString();

    }

   
}
