using System;

class MyClass : IDisposable
{
    // Egy példa tartalom, amelyet fel kell szabadítani
    private bool _isDisposed = false;

    // Ezt a metódust hívják meg, amikor fel kell szabadítani az erőforrásokat
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // Ez a metódus végzi a tényleges felszabadítást
    protected virtual void Dispose(bool disposing)
    {
        if (!_isDisposed)
        {
            if (disposing)
            {
                // Ide jön az erőforrások felszabadítása
                // Például: zárási műveletek, fájlok lezárása, stb.
            }

            _isDisposed = true;
        }
    }

    // Ha a hivatkozások és a finalizálók nélkül is felszabadulni kellene,
    // akkor implementálhatunk egy finalizátort is.
    // ~MyClass()
    // {
    //     Dispose(false);
    // }
}
