using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField] float speed = 10.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    
    

    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(3.5f,10f);
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,-speed);
        
        //apparently this sets the bounds of the screen
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    

    

    // Update is called once per frame
    void Update()
    {
        /*if(transform.position.y < screenBounds.y + Screen.height){
            Destroy(this.gameObject);
        }*/

    }
}
