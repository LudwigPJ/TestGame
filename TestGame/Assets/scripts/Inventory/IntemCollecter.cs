using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.scripts.Inventory
{
    public class IntemCollecter : MonoBehaviour
    {
        [SerializeField] private InventModel InventModel;
        

        public void CollectItem(string Item, int count)
        {
            InventModel.AddItem(Item, count);

        }




    }
}
