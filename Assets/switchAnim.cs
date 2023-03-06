using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class switchAnim : MonoBehaviour
{
    [SerializeField] GameObject Button_Image;
    private PlayableDirector director;
    private bool isenter = false;
    private bool actived = false;
    // Start is called before the first frame update
    void Awake()
    {
        Button_Image.SetActive(false);
        director = this.GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isenter && !actived)
        {
            if (Input.GetButtonDown("execute"))
            {
                actived = true;
                Button_Image.SetActive(false);
                director.Play();
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && !actived)
        {
            isenter = true;
            Button_Image.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isenter = false;
            Button_Image.SetActive(false);
        }
    }
}
