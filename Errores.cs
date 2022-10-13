using System;

class Errores : Exception
{
    Exception _error;
    public Errores(Exception e)
    {
        _error = e;
    }

    public override string Message { get; }
}
