using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
   public interface IActivoServices: IServices<Activo>
    {
        Activo GetById(int id);
        void Update(Activo activo);
        List<Activo> FindSpecific(Expression<Func<Activo, bool>> where);
    }
}
