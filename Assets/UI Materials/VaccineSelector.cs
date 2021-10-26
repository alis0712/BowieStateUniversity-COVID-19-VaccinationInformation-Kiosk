using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaccineSelector : MonoBehaviour
{
    public AudioSource pfizer;
    public AudioSource moderna;
    public AudioSource jj;

    public GameObject pfizerWindow;
    public GameObject modernaWindow;
    public GameObject jjWindow;

    Animation pfizerWindowAnimation;
    Animation modernaWindowAnimation;
    Animation jjWindowAnimation;

    void Start()
    {
        pfizerWindowAnimation = pfizerWindow.GetComponent<Animation>();
        modernaWindowAnimation = modernaWindow.GetComponent<Animation>();
        jjWindowAnimation = jjWindow.GetComponent<Animation>();
    }
    
    public void pfizerClicked()
    {
        // Play Pfizer Audio
       
        pfizer.Play();
        moderna.Stop();
        jj.Stop();


        // Animate Pfizer Window
        pfizerWindowAnimation["Pfizer"].speed = 1;
        pfizerWindowAnimation.Play();

    }

    public void modernaClicked()
    {
        pfizer.Stop();
        moderna.Play();
        jj.Stop();

        modernaWindowAnimation["Moderna"].speed = 1;
        modernaWindowAnimation.Play();
    }

    public void jjClicked()
    {
        pfizer.Stop();
        moderna.Stop();
        jj.Play();

        jjWindowAnimation["J&J"].speed = 1;
        jjWindowAnimation.Play();
    }

    public void pfizerCloseButtonClicked()
    {
        pfizerWindowAnimation["Pfizer"].speed = -1;
        pfizerWindowAnimation["Pfizer"].time = pfizerWindowAnimation["Pfizer"].length;
        pfizerWindowAnimation.Play();


    }

    public void modernaCloseButtonClicked()
    {
        modernaWindowAnimation["Moderna"].speed = -1;
        modernaWindowAnimation["Moderna"].time = modernaWindowAnimation["Moderna"].length;
        modernaWindowAnimation.Play();


    }

    public void jjCloseButtonClicked()
    {
        jjWindowAnimation["J&J"].speed = -1;
        jjWindowAnimation["J&J"].time = jjWindowAnimation["J&J"].length;
        jjWindowAnimation.Play();

    }
}
