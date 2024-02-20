using	System.Collections;
 using	System.Collections.Generic;
 using	UnityEngine;
using UnityEngine.UI;

 public	class	Lives	:	MonoBehaviour	{

    void OnCollisionEnter(Collision coll){	//	a
 //	Find	out	what	hit	this	basket
    GameObject	collidedWith	=	coll.gameObject;	//	b
        if	(collidedWith.tag == "Bomb")	{	//	c
            Destroy(collidedWith);
        }
    }
 }