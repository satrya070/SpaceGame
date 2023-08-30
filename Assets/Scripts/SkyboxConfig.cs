using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Skybox))] 
public class SkyboxConfig : MonoBehaviour
{
    [SerializeField] List<Material> skyboxMaterials;
    Skybox skybox;


    // Update is called once per frame
    void Awake()
    {
        skybox = GetComponent<Skybox>();
    }

    private void OnEnable()
    {
        ChangeSkybox(0);
    }

    void ChangeSkybox(int skyboxId)
    {
        if (skyboxId >= 0 && skyboxId <= skyboxMaterials.Count)
        {
            skybox.material = skyboxMaterials[skyboxId];
        }
    }
}
