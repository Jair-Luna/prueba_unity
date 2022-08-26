using System;
using UnityEngine;

public class DataBaseManager : MonoBehaviour
{

    public static DataBaseManager instance;
    private DataBase dataBase;
    public ControladorNecesidades controladorNecesidades;

    private void Awake()
    {
        dataBase = new DataBase();
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogWarning("Mas de un controlador en escena");
        }
    }

    private void Update()
    {
        if(ManagerTiempo.horaJuego < 0)
        {
            Mascota mascota = new Mascota(
                controladorNecesidades.ultimaHambre.ToString(),
                controladorNecesidades.ultimaEnergia.ToString(),
                controladorNecesidades.ultimaSalud.ToString(),
                controladorNecesidades.ultimaAseo.ToString(),
                controladorNecesidades.hambre,
                controladorNecesidades.energia,
                controladorNecesidades.salud,
                controladorNecesidades.aseo
                );

            GuardarMascota(mascota);
        }
    }


    private void Start()
    {
        Mascota mascota = CargarMascota();
        if(mascota != null)
        {
            controladorNecesidades.Initialize(
                mascota.hambre, mascota.energia, mascota.salud, mascota.aseo, 
                10, 10, 10, 10,
                DateTime.Parse(mascota.ultimaHambre), DateTime.Parse(mascota.ultimaEnergia), DateTime.Parse(mascota.ultimaSalud), DateTime.Parse(mascota.ultimaAseo));

        }
    }

    public void GuardarMascota(Mascota mascota)
    {
        dataBase.GuardarData<Mascota>("MascotaActual", mascota);
    }

    public Mascota CargarMascota()
    {
        Mascota returnValue = null;

        dataBase.CargarData<Mascota>("MascotaActual", (mascota) =>
        {
            returnValue = mascota;
        });

        return returnValue;
    }

}
