using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.scripts.input
{
    public class AttackEnemy : MonoBehaviour
    {
        [SerializeField] private float AttackRange;
        [SerializeField] private LayerMask enemylayer;
        [SerializeField] private float damageAmount = 10f;
        [SerializeField] private float CoolDown;
        private float lastAttackTime;



        public void Update()
        {
            
            if (Time.time - lastAttackTime >= CoolDown)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, AttackRange, enemylayer);
                if (colliders.Length > 0)
                {
                    colliders[0].GetComponent<HealPoints>().TakeDamage(damageAmount);
                    lastAttackTime = Time.time;
                }
            }
        }




    }
}
