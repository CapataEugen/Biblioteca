namespace UserNamespace;

public abstract class State
{
    protected Context _context;

    public void SetContext(Context contex)
    {
        this._context = contex;
    }
}