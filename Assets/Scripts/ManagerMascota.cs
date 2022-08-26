using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerMascota : MonoBehaviour
{

    public ControladorNecesidades controladorNecesidades;

    public static ManagerMascota instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("Mas de un controlador en escena");
        }
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
