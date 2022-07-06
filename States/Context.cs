namespace UserNamespace;

public class Context
{
    private State _state = null;

    public Context(State state)
    {
        this.TransitionTo(state);
    }

    public void TransitionTo(State state)
    {
        this._state = state;
        this._state.SetContext(this);
    }

    
}