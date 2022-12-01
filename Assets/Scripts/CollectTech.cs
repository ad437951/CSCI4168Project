using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectTech : MonoBehaviour {
    public Image[] displayImage;
    public Texture2D[] techImages;

    private int techCollected;
    
    // Start is called before the first frame update
    void Start() {
        techCollected = 0;    
    }

    // Update is called once per frame
    void Update() {

    }
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Collectable")) {
            displayImage[techCollected].gameObject.SetActive(true);
            displayImage[techCollected].sprite = collision.GetComponent<SpriteRenderer>().sprite;
            Destroy(collision.gameObject);

            techCollected++;
        }
    }
}
