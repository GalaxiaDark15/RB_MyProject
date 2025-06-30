using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTriggerEnterExample : MonoBehaviour
{
    public bool disappear = false;
    public bool changeColor = false;
    public bool changeScene = false;
    public GameObject ourCube;
    public Material DefaultCubeMaterial;
    public Material ChangeColorMaterial;

    private Renderer cubeRenderer;

    // Start is called before the first frame update
    void Start()
        {
            if (ourCube != null)
            {
                cubeRenderer = ourCube.GetComponent<Renderer>();
                if (cubeRenderer != null && DefaultCubeMaterial != null)
                {
                    cubeRenderer.material = DefaultCubeMaterial;
                }
            }
        }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (disappear == true)
        {
            ourCube.SetActive(false);
        }
        else if (changeColor == true)
        {
            if (cubeRenderer != null && ChangeColorMaterial != null)
            {
                cubeRenderer.material = ChangeColorMaterial;
            }
        }
        else if (changeScene == true)
        {
            SceneManager.LoadScene("UIScene");
        }
    }

    private void OnTriggerStay(Collider other)
    {

    }

    private void OnTriggerExit(Collider other)
    {
        if (disappear == true)
        {
            ourCube.SetActive(true);
        }
        else if (changeColor == true)
        { 
            if (cubeRenderer != null && DefaultCubeMaterial != null)
            {
                cubeRenderer.material = DefaultCubeMaterial;
            }
        }
    }
}
