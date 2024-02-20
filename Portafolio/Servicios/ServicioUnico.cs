namespace Portafolio.Servicios
{
    public class ServicioUnico
    {
        public ServicioUnico()
        {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; set; }
    }

    public class ServicioDelimitado
    {
        public ServicioDelimitado()
        {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; set; }
    }

    public class ServicioTransitorio
    {
        public ServicioTransitorio()
        {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; set; }
    }
}
