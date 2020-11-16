using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public GameObject[] characters;
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i< characters.Length; i++)
        {
            GameObject NewActor = Instantiate(characters[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeState()
    {

    }

}
