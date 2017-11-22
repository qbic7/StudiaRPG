using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenFaded : MonoBehaviour {

    Animator anim;
    bool isFading = false;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

    public IEnumerator FadeToClear()
    {
        isFading = true;
        anim.SetTrigger("Fade_In");

        while (isFading)
        {
            yield return null;
        }
    }

    public IEnumerator FadeToBlack()
    {
        isFading = false;
        anim.SetTrigger("Fade_Out");

        while (isFading)
        {
            yield return null;
        }
    }

    void AnimationComplete()
    {
        isFading = false;
    }
}
