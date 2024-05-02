using System;
using UnityEngine;

namespace MovementImpulse
{
    public class impulse : MonoBehaviour
    {
        public Movement movement;
        private bool isKeyPressed = false;

        private void Start()
        {
            movement = GetComponent<Movement>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                isKeyPressed = true;
            }
        }

        private void FixedUpdate()
        {
            if (isKeyPressed)
            {
                Vector2 direction = movement.rb.velocity.normalized;
                if (direction != Vector2.zero) 
                {
                    movement.rb.AddForce(direction * 100, ForceMode2D.Impulse); 
                    Debug.Log("Impulse");
                }
                isKeyPressed = false;
            }
        }
    }
}