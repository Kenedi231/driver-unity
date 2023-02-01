using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject firstViewCamera;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera.SetActive(true);
        firstViewCamera.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp("v"))
        {
            mainCamera.SetActive(!mainCamera.activeSelf);
            firstViewCamera.SetActive(!firstViewCamera.activeSelf);
        }
    }
}
