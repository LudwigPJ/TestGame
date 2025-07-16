using Assets.scripts.input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using static UnityEditor.Progress;

namespace Assets.scripts.Inventory
{
    public class SpawnItem : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer itemSpriteRenderer;
        [SerializeField] private String itemId;
        [SerializeField] private int count = 1;



        public void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.TryGetComponent(out IntemCollecter itemcollctor))
            {
                itemcollctor.CollectItem(itemId, count);

                Destroy(gameObject);
            }

        }

        private void Start()
        {
            itemSpriteRenderer.sprite = Resources.Load<Sprite>("Icons/" + itemId);

        }

    }
}
