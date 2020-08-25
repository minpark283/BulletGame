using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title_Scripts : MonoBehaviour {
    Animator anim;
    public GameObject NewGame;
    public GameObject Continue;
    public GameObject Options;
    public GameObject EnterBt;
    public GameObject TitleSign;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        anim.SetBool("PressedEnter", false);
        NewGame.SetActive(false);
        Continue.SetActive(false);
        Options.SetActive(false);
        EnterBt.SetActive(true);
        TitleSign.SetActive(false);
}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("enter") || Input.GetKeyDown("return"))
        {
            anim.SetBool("PressedEnter", true);
            NewGame.SetActive(true);
            Continue.SetActive(true);
            Options.SetActive(true);
            EnterBt.SetActive(false);
            TitleSign.SetActive(true);
        }
    }
   
}
