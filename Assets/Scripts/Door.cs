using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

    private Animator myAnimator;

    void Awake()
    {
        myAnimator = GetComponent<Animator>();
    }

    public void Open()
    {
        myAnimator.SetTrigger("Open");
    }

    public void Close()
    {
        myAnimator.SetTrigger("Close");
    }

}
