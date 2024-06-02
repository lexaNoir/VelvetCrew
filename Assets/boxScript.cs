
using UnityEngine;

public class boxScript : MonoBehaviour
{

    [SerializeField] private Collision2D _collision2D;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (_collision2D.collider)
        {
            Destroy(this.gameObject); 
        }
        
    }
}
