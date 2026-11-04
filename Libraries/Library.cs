using System;
using System.Collections.Generic;
using System.Text;

class Library
{
    public delegate void Visit(string name);

    private event Visit VisitDelegate;
    private event Visit VisitOnceDelegate;


    public void Subscribe(Visit delFn)
    {
        VisitDelegate += delFn;
    }

    public void UnSubscribe(Visit delFn)
    {
        VisitDelegate -= delFn;
    }

    public void SubscribeOnce(Visit delFn)
    {
        VisitOnceDelegate += delFn;
    }

    public void Enter(string name)
    {
        VisitDelegate?.Invoke(name);
        VisitOnceDelegate?.Invoke(name);
        VisitOnceDelegate = null;
    }

}
