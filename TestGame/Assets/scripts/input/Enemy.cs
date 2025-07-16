using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.scripts.input
{
    public class Enemy: MonoBehaviour
    {
        [SerializeField] private HealPoints healPoints;
        [SerializeField] private Transform PlayerTransform;
        [SerializeField] private int speed = 2;
        [SerializeField] private int attackRange = 1;
        [SerializeField] private Rigidbody2D body;
        public HealPoints HealPoints { get => healPoints;}

        private void OnEnable()
        {
            healPoints.onDeath.AddListener(() => 
            {
                Destroy(gameObject);
            });
        }

        private void OnDisable()
        {
            healPoints.onDeath.RemoveAllListeners();
        }

        public void Update()
        {
            if(PlayerTransform == null)
            {
                return;
            }
            if(Vector2.Distance(PlayerTransform.position, transform.position) < attackRange)
            {
                
                Vector2 Currentposition = (PlayerTransform.position - transform.position).normalized;
                body.MovePosition((Vector3)Currentposition * speed * Time.deltaTime + transform.position);
            }
        }

        public void Init(Transform playertransform) 
        {
            PlayerTransform = playertransform;

        }

    }
}
