﻿using mf_imports.DAL.Interfaces;
using mf_imports.Model;

namespace mf_imports.DAL;

public class UnidadeMedidaRepository : Repository<UnidadeMedida>
{
    public UnidadeMedidaRepository(ConnectionContext context) :base(context) { }

    public override IList<UnidadeMedida> GetByName(string name)
    {
        return _context.Set<UnidadeMedida>().Where(um => um.Nome.ToLower().Contains(name.ToLower())).ToList();
    }

}