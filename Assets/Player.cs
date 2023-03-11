using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    AudioSource _audioSource;
    // Start is called before the first frame update
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] public UIManager _uIManager;
    
    
    public void Start() {
        _audioSource = GetComponent<AudioSource>();

        if(_audioSource == null){
            Debug.LogError("The Audio is null");
        }
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Fruit"){
            _uIManager.AddScore(1);
            _audioSource.Play();
            Destroy(other.gameObject);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        float moveAmount = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(moveAmount, 0, 0);
    }
}
