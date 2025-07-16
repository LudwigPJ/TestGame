using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlOld : MonoBehaviour
{
    [SerializeField]private float movement; 
    private Vector2 movementDirection;
    private Rigidbody2D rb;
    [SerializeField] private HealPoints healPoints;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        
    }

    public void setMovement(Vector2 moveVector)
    {
        movementDirection = moveVector;
    }

    // Start is called before the first frame update
    void Start()
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

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (movementDirection != Vector2.zero)
        {
            rb.MovePosition(rb.position + movementDirection * movement * Time.fixedDeltaTime);
        }
    }
}
