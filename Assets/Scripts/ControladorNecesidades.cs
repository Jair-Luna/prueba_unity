using System;
using UnityEngine;

public class ControladorNecesidades : MonoBehaviour
{
    
    public int hambre;
    public int energia;
    public int salud;
    public int aseo;

    public int hambreTickRate;
    public int energiaTickRate;
    public int saludTickRate;
    public int aseoTickRate;

    public DateTime ultimaHambre, ultimaEnergia, ultimaSalud, ultimaAseo;

    //private void Awake()
    //{
    //    Initialize(100, 100, 100, 100, 5, 4, 2, 1);
    //}

    public void Initialize(int hambre, int energia, int salud, int aseo, int hambreTickRate, int energiaTickRate, int saludTickRate, int aseoTickRate)
    {
        ultimaHambre = DateTime.Now;
        ultimaEnergia = DateTime.Now;
        ultimaSalud = DateTime.Now;
        ultimaAseo = DateTime.Now;
        this.hambre = hambre;
        this.energia = energia;
        this.salud = salud;
        this.aseo = aseo;
        this.hambreTickRate = hambreTickRate;
        this.energiaTickRate = energiaTickRate;
        this.saludTickRate = saludTickRate;
        this.aseoTickRate = aseoTickRate;
        ControladorUI.instance.updateImages(hambre, energia, salud, aseo);
    }

    public void Initialize(int hambre, int energia, int salud, int aseo, 
        int hambreTickRate, int energiaTickRate, int saludTickRate, int aseoTickRate,
        DateTime ultimaHambre, DateTime ultimaEnergia, DateTime ultimaSalud, DateTime ultimaAseo
        )
    {
        this.ultimaHambre = ultimaHambre;
        this. ultimaEnergia = ultimaEnergia;
        this.ultimaSalud = ultimaSalud;
        this.ultimaAseo = ultimaAseo;
        this.hambre = hambre;
        this.energia = energia;
        this.salud = salud;
        this.aseo = aseo;
        this.hambreTickRate = hambreTickRate;
        this.energiaTickRate = energiaTickRate;
        this.saludTickRate = saludTickRate;
        this.aseoTickRate = aseoTickRate;
        ControladorUI.instance.updateImages(hambre, energia, salud, aseo);
    }

    private void Update()
    {
        
        if(ManagerTiempo.horaJuego < 0)
        {
            ActualizarHambre(-hambreTickRate);
            ActualizarEnergia(-energiaTickRate);
            Actualizarsalud(-saludTickRate);
            ActualizarAseo(-aseoTickRate);
            ControladorUI.instance.updateImages(hambre, energia, salud, aseo);
        }

    }

    public void ActualizarHambre(int amount)
    {
        hambre += amount;
        if(amount > 0) ultimaHambre = DateTime.Now; 

        if(hambre > 100) hambre = 100;
        
    }

    public void ActualizarEnergia(int amount)
    {
        energia += amount;
        if(amount > 0) ultimaEnergia = DateTime.Now; 
        if(energia > 100) energia = 100;
    }

    public void Actualizarsalud(int amount)
    {
        salud += amount;
        if(amount > 0) ultimaSalud = DateTime.Now;
        if(salud > 100) salud = 100;
    }

    public void ActualizarAseo(int amount)
    {
        aseo += amount;
        if(amount > 0) ultimaAseo = DateTime.Now; ;
        if(aseo > 100) aseo = 100;
    }
    
}
