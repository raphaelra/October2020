using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public List<Sprite> sprites;

    private SpriteRenderer renderer;
    private void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
         if (renderer.sprite == null)
         renderer.sprite = sprites[Random.Range(0,sprites.Count)];

    }
    
    public void RandomSprite()
    {
        Sprite newSprite = sprites[Random.Range(0,sprites.Count)];
        renderer.sprite = newSprite;
    }


    //public GameObject RightPanel;
    //public Texture RawImage;
    //private SpriteRenderer spriteRenderer;
     //public void Start()
     //{
     //    spriteRenderer = GetComponent<SpriteRenderer>();
     //    if (spriteRenderer.sprite == null)
     //  //  spriteRenderer.sprite = Resources.Load<Sprite>("rightimage"+Random.Range(0,1));
     //}


    // public void Update()
    // {
     //}
     
    // /RandomImage()
    // {
    //    RightPanel =GetComponent<Sprite>("rightimage"+Random.Range(0,1)).texture = texture;
     //   spriteRenderer.sprite = Resources.Load<RawImage>("rightimage"+Random.Range(0,1));
    //}
 }