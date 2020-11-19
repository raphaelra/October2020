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
    [SerializeField]
    CharacterEmotion myState;
    // Start is called before the first frame update
    void Start()
    {
        myState = CharacterEmotion.neutral;
        SpriteRenderer =GetComponent<SpriteRenderer>();
    }
    public void ChangeState(string emotionName)
    {
        StartCoroutine(emotionName + "State");
    }

    IEnumerator NeutralState()
    {
        SpriteRenderer.sprite = emotionSprites[0];
        yield return null;

    }
        IEnumerator HappyState()
    {
        SpriteRenderer.sprite = emotionSprites[1];
        yield return null;

    }
        IEnumerator SadState()
    {
        SpriteRenderer.sprite = emotionSprites[2];
        yield return null;

    }
        IEnumerator AngryState()
    {
        SpriteRenderer.sprite = emotionSprites[3];
        yield return null;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
