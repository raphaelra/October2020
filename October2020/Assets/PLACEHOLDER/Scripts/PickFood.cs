using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PickFood : MonoBehaviour
{
    public TextMeshProUGUI PointsText;
    public GameObject Portal;
    public AudioSource Collect;

    public List<GameObject> Foods;
    private int Points;

    void Start()
    {
        Points = 0;
        Portal.SetActive(false);
        PointsText.text = "Points: 0";
    }

    
    void Update()
    {
        if(Points == Foods.Count) {
            Portal.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Food")) {
            Points++;
            PointsText.text = "Points: " + Points;
            Collect.Play();
            Destroy(other.gameObject);
        }
    }
}
