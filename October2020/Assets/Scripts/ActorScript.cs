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
        myState = CharacterEmotion.neutral;
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void ChangeState(string emotionName){
        startCoroutine(emotionName +"State");

    }
    IEnumerator NeutralState()
    {
        SpriteRenderer = emotionSprites[0];
        yield return null;

    }
      IEnumerator HappyState()
    {
        SpriteRenderer = emotionSprites[1];
        yield return null;

    }
      IEnumerator SadState()
    {
        SpriteRenderer = emotionSprites[2];
        yield return null;

    }
      IEnumerator AngryState()
    {
        SpriteRenderer = emotionSprites[3];
        yield return null;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
