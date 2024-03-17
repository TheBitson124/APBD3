using System;

namespace cwiczenia3.interfaces
{
    public interface IHazardNotifier
    {
        void Notify(int containerNumber, string message);
    }
}