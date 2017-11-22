using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

    public Transform warpTarget;

    IEnumerator OnTriggerEnter2D(Collider2D other) {
        ScreenFaded sf = GameObject.FindGameObjectWithTag("Fader").GetComponent<ScreenFaded>();

        yield return StartCoroutine(sf.FadeToBlack());

        Debug.Log("An object collided!");
        other.gameObject.transform.position = warpTarget.position;
        Camera.main.transform.position = warpTarget.position;

        yield return StartCoroutine(sf.FadeToClear());
    }
}
