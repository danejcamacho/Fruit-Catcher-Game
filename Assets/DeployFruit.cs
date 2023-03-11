using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployFruit : MonoBehaviour
{
    public GameObject fruitPrefab;
    [SerializeField] public float respawnTime = 1.0f;

    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(fruitWave());
    }

    private void spawnFruit(){
        GameObject a = Instantiate(fruitPrefab) as GameObject;
        //a.transform.position = new Vector2(screenBounds.y * -2, Random.Range(-screenBounds.x, screenBounds.x));
        a.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x),screenBounds.y  );
    }   
    IEnumerator fruitWave(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            spawnFruit();
        }
    }

}
