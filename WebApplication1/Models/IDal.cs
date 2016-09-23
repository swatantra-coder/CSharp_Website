using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public interface IDal : IDisposable
    {
        List<Metier> ObtientTousLesMetiers();
        void CreerMetier(string title);
        void ModifierMetier(int id, string title);
    }
}
