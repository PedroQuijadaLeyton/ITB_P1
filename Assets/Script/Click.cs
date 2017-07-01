using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{

    Manager m;
    Color transparent;

	// Use this for initialization
	void Start ()
    {
        m = FindObjectOfType<Manager>();
        transparent = new Color(1, 1, 1, 0.3f);

    }

    public void correct()
    {
        m.good.Play();
        GetComponent<Image>().color = transparent;
        transform.GetChild(0).gameObject.SetActive(true);
        GetComponent<CanvasGroup>().interactable = false;
        GetComponent<CanvasGroup>().blocksRaycasts = false;

    }

    public void incorrect()
    {
        m.bad.Play();
        GetComponent<Animator>().SetBool("start", true);
        StartCoroutine(waitforsec());
    }

    IEnumerator waitforsec()
    {
        yield return new WaitForSeconds(0.3f);
        GetComponent<Animator>().SetBool("start", false);
    }

}
