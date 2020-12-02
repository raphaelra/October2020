using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage : MonoBehaviour
{
    public GameObject RightPanel;
    public Texture RawImage;
    private SpriteRenderer spriteRenderer;
     public void Start()
     {
         spriteRenderer = GetComponent<SpriteRenderer>();
         if (spriteRenderer.sprite == null)
         spriteRenderer.sprite = Resources.Load<Sprite>("rightimage"+Random.Range(0,1));
     }


     public void Update()
     {

     }
     
    // /RandomImage()
    // {
    //    RightPanel =GetComponent<Sprite>("rightimage"+Random.Range(0,1)).texture = texture;
     //   spriteRenderer.sprite = Resources.Load<RawImage>("rightimage"+Random.Range(0,1));
    //}
 }