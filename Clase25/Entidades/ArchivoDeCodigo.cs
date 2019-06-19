public delegate void DelegadoSueldo(Entidades.Empleado e, float a);
public delegate void DelSueldo(Entidades.EmpleadoMejorado e, Entidades.EmpleadoSueldoArgs a);

public enum ETipoManejador
{
    LimiteSueldo,
    Log,
    Ambos
}