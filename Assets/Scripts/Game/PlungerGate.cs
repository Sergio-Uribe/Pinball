using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlungerGate : MonoBehaviour
{
    [SerializeField] private Animator anim = null;
    [SerializeField] private Live ballLive = null;

    private void Start()
    {
        ballLive.OnLivesRemoved += Open;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Ball>() == null) return;
        Close();
    }


    private void Open()
    {
        anim.ResetTrigger("Close");
        anim.SetTrigger("Open");
    }

    public void Close()
    {
        anim.ResetTrigger("Close");
        anim.SetTrigger("Close");
    }
}
