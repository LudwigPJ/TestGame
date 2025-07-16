using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using static UnityEditor.Progress;

namespace Assets.scripts.Inventory
{
    class UIInventory : MonoBehaviour
    {
        [SerializeField] private GameObject SlotCountener;
        [SerializeField] private Slot SlotPrefab;
        [SerializeField] private InventModel inventory;




        public void RedDraw()
        {


            foreach (Transform child in SlotCountener.transform)
            {
                Destroy(child.gameObject);
            }
            
            foreach (var item in inventory.GetItems())
            {
                Slot slot = Instantiate(SlotPrefab, SlotCountener.transform);
                slot.SetItem(item.Key, item.Value);
            }
            

        }

        void OnDestroy()
        {
            inventory.OnInventoryChanged -= RedDraw;
        }
        public void Start()
        {
            inventory.OnInventoryChanged += RedDraw;
            RedDraw();
        }

    }



}
