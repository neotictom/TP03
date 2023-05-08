class Cliente{
    public string DNI{get; private set;}
    public string Apellido{get; private set;}
    public string Nombre{get; private set;}
    public DateTime FechaInscripcion{get; private set;}
    public int TipoEntrada{get; private set;}
    public double TotalAbonado {get; private set;}
    public Cliente(string dni, string ape, string nom, int tipoEnt,double totAbon){
        DNI = dni;
        Apellido = ape;
        Nombre = nom;
        TipoEntrada = tipoEnt;
        TotalAbonado = totAbon;
    }
     public bool CambiarEntrada(string nuevoTipoEntrada, int nuevoValorAbonado, DateTime nuevaFecha)
    {
        
        if (nuevoValorAbonado >= ValorAbonado)
        {
            TipoEntrada = nuevoTipoEntrada;
            ValorAbonado = nuevoValorAbonado;
            Fecha = nuevaFecha;
            return true;
        }
        else
        {
            return false;
        }
    }

}