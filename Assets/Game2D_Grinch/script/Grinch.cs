using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grinch : MonoBehaviour
{
    
private Animator anim;
private Rigidbody2D rb2D;

//--------------------------------------------------------------------------//
[Header("position deplacement")]
[SerializeField] private Vector2[] position = new Vector2[4];
[SerializeField] private Vector2 position1 = new Vector2 (-4f,-3.7f);
[SerializeField] private Vector2 position2 = new Vector2 (-0.75f,-3.7f);
[SerializeField] private Vector2 position3 = new Vector2 (2.5f,-3.7f);
[SerializeField] private Vector2 position4 = new Vector2 (5.25f,-3.7f);
[SerializeField] private int indexPosition = 1;

//--------------------------------------------------------------------------//
public GameObject GiftCatched;


private void Start() 
{
    anim = GetComponent<Animator>();
    rb2D = GetComponent<Rigidbody2D>();
}

private void Update() 
{
    Deplacement();
}


 private void Deplacement() // input de déplacement des 4 différents positions (il en manque un vers le coffre)
 {

     indexPosition = Mathf.Clamp(indexPosition,0,3);
     position[0] = position1;
     position[1] = position2;
     position[2] = position3;
     position[3] = position4;

    

    if(Input.GetKeyDown(KeyCode.RightArrow) && indexPosition<position.Length-1)
     {
        indexPosition +=1;
        transform.position = position[indexPosition];
     }

    if(Input.GetKeyDown(KeyCode.LeftArrow)&& indexPosition>0)
     {
        indexPosition -=1;
        transform.position = position[indexPosition];
     }
 }


private void OnCollisionEnter2D(Collision2D other) 
{
    if(other.gameObject.CompareTag("gift"))
    {
        print("je m'anime");
        anim.SetTrigger("catchTrigger");
        GiftCatched.SetActive(true); //Amelioration a faire : apparaitre le cadeau une fois l'animation fini
    }    
}



































    //machine à etat :
    // -je me deplace 
    // -j'attrape un cadeau
    // -je dépose un cadeau 


    //event du shape 

    //gestion de niveau
    //ecoute le cadeau et marque des points 
    // timer 
    //commencer la partie
    //pause
    //gagner et defaite 
    //point de vie 
}
