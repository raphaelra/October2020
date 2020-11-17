using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorScript : MonoBehaviour
{
    //Needs sprites = to amount of public enum CharacterEmotion amount
    public Sprite[] emotionSprites;
    SpriteRenderer SpriteRenderer;
    public enum CharacterEmotion{
        happy,sad,neutral,angry
    }
    CharacterEmotion myState;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
