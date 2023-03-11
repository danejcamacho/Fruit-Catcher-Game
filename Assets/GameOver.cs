using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    [SerializeField] public UIManager _uIManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Fruit"){
            
            _uIManager.Start();
            Destroy(other.gameObject);
            
        }
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
