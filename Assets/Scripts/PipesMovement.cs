using UnityEngine;

public class PipesMovement : MonoBehaviour
{
    public float speed= 2f;
    private void Update() 
    {
        if(transform.position.x < -11 )
        {
            Destroy(gameObject);
        }

        transform.position += Vector3.left * speed * Time.deltaTime;
    }
    
}
