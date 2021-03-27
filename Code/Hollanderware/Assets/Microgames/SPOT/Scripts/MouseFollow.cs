using UnityEngine;

public class MouseFollow : MonoBehaviour
{
   // Create the variables for the mouse movement
   Vector3 mousePosition;
   public float moveSpeed = 1f;
   Rigidbody2D rb;
   Vector2 position = new Vector2(0f,0f);
    
   // Get the rigidbody of the mouse finger
   private void Start()
   {
       rb = GetComponent<Rigidbody2D>();
   }
   
   // Make the mouse finger follow the position of the player's mouse
   private void Update()
   {
       mousePosition = Input.mousePosition;
       mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
       position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
   }

   // Update the position of the finger as the game goes on 
   private void FixedUpdate()
   {
       rb.MovePosition(position);
   }

}
