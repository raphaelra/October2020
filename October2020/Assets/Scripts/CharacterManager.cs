using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public GameObject[] characters;
    public List<GameObject> actorslist = new List<GameObject>();
    [SerializeField]
    Vector3 leftActorPosition,rightActorPosition;
    List<ActorScript> activeActors = new List<ActorScript>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i< characters.Length; i++)
        {
            GameObject NewActor = Instantiate(characters[i]);
            //newActor.SetActive(false);
            NewActor.name = characters[i].name;
            actorslist.Add(NewActor);
        }     
    }

public void PlaceActors(string leftActorName, string rightActorName)
    // Update is called once per frame
    {
        foreach (GameObject g0 in actorslist)
        {
            if (g0.name == leftActorName)
            {
                g0.SetActive(true);
                g0.GetComponent<ActorScript>().ID = 0;
                activeActors.Add(g0.GetComponent<ActorScript>());
                g0.transform.position = leftActorPosition;
            }
            else if (g0.name == rightActorName)
             {
                g0.SetActive(true);
                g0.GetComponent<ActorScript>().ID = 1;
                activeActors.Add(g0.GetComponent<ActorScript>());
                g0.transform.position = rightActorPosition;
             }
            
        }
    }

}

 // public void Update()
  //ChangeActorEmotion(string emotion, int ID)
   // {
       // foreach (ActorScript actor in activeActors)
       // {
            //if (actor.GameObject.activeInHierarchy)
           // {
              //  if (actor.ID == ID)
               // {
               //     actor.ChangeState(emotion);
              //  }
          //  }
      //  }

    //}
