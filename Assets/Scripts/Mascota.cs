using System;

public class Mascota 
{

    public string ultimaHambre, ultimaEnergia, ultimaSalud, ultimaAseo;

    public int hambre, energia, salud, aseo;

    public Mascota(string ultimaHambre, string ultimaEnergia, string ultimaSalud, string ultimaAseo, int hambre, int energia, int salud, int aseo)
    {
        this.ultimaHambre = ultimaHambre;
        this.ultimaEnergia = ultimaEnergia;
        this.ultimaSalud = ultimaSalud;
        this.ultimaAseo = ultimaAseo;
        this.hambre = hambre;
        this.energia = energia;
        this.salud = salud;
        this.aseo = aseo;
    }
}
